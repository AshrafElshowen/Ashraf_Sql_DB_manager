using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.ServiceProcess;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Ashraf_DB_manager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ValidateBackupPath();
            _ = ValidateDBName();
        }

        private void GetSqlServersList()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            DataTable table = instance.GetDataSources();
            string ServerName = Environment.MachineName;
            ServersList.Items.Clear();
            foreach (DataRow row in table.Rows)
            {
                _ = ServersList.Items.Add(ServerName + @"\" + row["InstanceName"].ToString());
            }
        }
        private void ValidateBackupPath()
        {
            if (Directory.Exists(textBoxBackupPath.Text) == true)
            { textBoxBackupPath.ForeColor = Color.Green; }
            else { textBoxBackupPath.ForeColor = Color.Red; }
        }

        private void ServersList_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabasesList.Items.Clear();
            string connectionString = "Data Source=" + ServersList.SelectedItem + "; Integrated Security=True;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                //load Databases list & Collation List
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT name from sys.databases ;" +
                    "Select name from fn_helpcollations() ", con);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    string name = row["name"].ToString();
                    if (!name.Equals("master")
                        && !name.Equals("tempdb")
                        && !name.Equals("model")
                        && !name.Equals("msdb"))
                    {
                        DatabasesList.Items.Add(name);
                    }
                }
                foreach (DataRow row in ds.Tables[1].Rows)
                {
                    string name = row["name"].ToString();
                    CollationList.Items.Add(name);
                }

            }
            AutoComplete(ref CollationList);
            AutoComplete(ref DatabasesList);
        }

        private void AutoComplete(ref ComboBox list)
        {
            list.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            list.AutoCompleteSource = AutoCompleteSource.ListItems;
            CollationList.MaxDropDownItems = 10;
            CollationList.IntegralHeight = false;
        }

        private void BackUpButton_Click(object sender, EventArgs e)
        {
            string db_name = string.Empty;
            if (DatabasesList.SelectedItem == null)
            {
                MessageBox.Show("Database was not set", "Invalid options");
            }
            else
            {
                db_name = DatabasesList.SelectedItem.ToString();
            }
            string backup_path = string.Empty;
            if (Directory.Exists(textBoxBackupPath.Text))
            {
                backup_path = textBoxBackupPath.Text + @"\";
            }
            else
            {
                MessageBox.Show("Backup path is not valid", "Invalid options");
            }
            if (string.IsNullOrEmpty(db_name) == false && string.IsNullOrEmpty(backup_path) == false)
            {
                string file_name = db_name + "_" + DateTime.Now.ToShortDateString().Replace(@"/", "_") + ".bak";
                using (SqlConnection con = new SqlConnection("Data Source=" + ServersList.SelectedItem + "; Integrated Security=True;"))
                {
                    SqlCommand backup = new SqlCommand("BACKUP DATABASE [" + db_name + "] TO  DISK = '" + backup_path + file_name + "'", con);
                    try
                    {
                        con.Open();
                        backup.ExecuteNonQuery();
                        MessageBox.Show("Database was backed up successfully", "Backup succeeded");
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Connection Faild");
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 3201)
                        {
                            MessageBox.Show("Access denied , click 'GetAccess' ,then try again", "Backup Faild");
                        }
                        else
                        {
                            MessageBox.Show(ex.Message, "Backup Faild");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Backup Faild");
                    }
                }
            }
        }

        private void buttonChangePath_Click(object sender, EventArgs e)
        {
            DialogResult relult = folderBrowserDialogBackup.ShowDialog();
            if (relult == DialogResult.OK)
            {
                textBoxBackupPath.Text = folderBrowserDialogBackup.SelectedPath;
            }
        }

        private void textBoxBackupPath_TextChanged(object sender, EventArgs e)
        {
            ValidateBackupPath();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            GetSqlServersList();
        }

        private string FindServiceNameByDescription(string ServiceDescription = "Provides storage, processing and controlled access of data, and rapid transaction processing.")
        {
            ServiceController[] services = ServiceController.GetServices();
            foreach (ServiceController serviceController in services)
            {
                string serviceName = serviceController.ServiceName;
                using (ManagementObject service = new ManagementObject(new ManagementPath(string.Format("Win32_Service.Name='{0}'", serviceName))))
                {
                    object Description = service["Description"];
                    if (Description != null)
                    {
                        if (service["Description"].ToString() == ServiceDescription)
                        {
                            return service["Name"].ToString();
                        }
                    }
                }
            }
            return string.Empty;
        }

        private void GetAccessButton_Click(object sender, EventArgs e)
        {
            string ServiceName = FindServiceNameByDescription();
            ChangeSqlServerServiceLonginAccount(ServiceName);
        }

        private void ChangeSqlServerServiceLonginAccount(string ServiceName)
        {
            string command = "sc config \"ServiceName\" obj= LocalSystem password= LocalSystem";
            command = command.Replace("ServiceName", ServiceName);
            command += Environment.NewLine + "pause";
            string fileName = "ChangeSqlServerServiceLonginAccount.bat";
            string fullpath = Application.StartupPath + @"\commands\" + fileName;
            //delete old file if found
            if (File.Exists(fullpath))
            {
                File.Delete(fullpath);
            }
            // Create new file.
            using (FileStream fs = File.Create(fullpath))
            {
                Byte[] info = new UTF8Encoding(true).GetBytes(command);
                // Add commands to the file
                fs.Write(info, 0, info.Length);
            }
            // execute command
            Process.Start(fullpath);
        }

        private void textBoxRestore_TextChanged(object sender, EventArgs e)
        {
            ValidateFile(ref textBoxRestore);
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            openFileDialogRestore.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult relult = openFileDialogRestore.ShowDialog();
            if (relult == DialogResult.OK)
            {
                textBoxRestore.Text = openFileDialogRestore.FileName;
            }
        }

        private void buttonRestore_Click(object sender, EventArgs e)
        {
            string db_name = string.Empty;
            if (DatabasesList.SelectedItem == null)
            {
                if (string.IsNullOrEmpty(textBoxNewDB.Text) == false)
                {
                    db_name = textBoxNewDB.Text.Trim();
                }
                else
                {
                    _ = MessageBox.Show("Database was not set", "Invalid options");
                }
            }
            else
            {
                db_name = DatabasesList.SelectedItem.ToString();
            }
            string Restore_File = string.Empty;
            if (File.Exists(textBoxRestore.Text))
            {
                Restore_File = textBoxRestore.Text;
            }
            else
            {
                MessageBox.Show("Restore File was not found", "Invalid options");
            }
            if (string.IsNullOrEmpty(db_name) == false && string.IsNullOrEmpty(Restore_File) == false)
            {
                using (SqlConnection con = new SqlConnection("Data Source=" + ServersList.SelectedItem + "; Integrated Security=True;"))
                {
                    SqlCommand restore = new SqlCommand("use master; " +
                        "Alter Database " + db_name +" Set Single_user with Rollback Immediate; " +
                        "RESTORE DATABASE " + db_name +
                        " FROM DISK = '" + Restore_File +
                        "' WITH REPLACE ;  " +
                        "Alter Database " + db_name + " Set Multi_user with Rollback Immediate;", con);
                    try
                    {
                        con.Open();
                        restore.ExecuteNonQuery();
                        MessageBox.Show("Database was Restored successfully", "Restoring succeeded");
                    }
                    catch (InvalidOperationException ex)
                    {
                        MessageBox.Show(ex.Message, "Connection Faild");
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 3201)
                        {
                            _ = MessageBox.Show("Access denied , click 'GetAccess' ,then try again", "Restoring Faild");
                        }
                        else if(ex.Number == 1834)
                        {
                            _ = MessageBox.Show("Wrong Backup file , Backup file points to data base files that used by another data base", "Restoring Faild");
                        }
                        else
                        {
                            _ = MessageBox.Show(ex.Message, "Restore Faild");
                        }
                    }
                    catch (Exception ex)
                    {
                        _ = MessageBox.Show(ex.Message, "Restore Faild");
                    }
                }
            }
        }

        private void buttonNewDB_Click(object sender, EventArgs e)
        {
            if (ValidateDBName())
            {
                int index = DatabasesList.Items.IndexOf(textBoxNewDB.Text.Trim());
                DatabasesList.SelectedIndex = index;
                if (index == -1)
                {
                    if (CollationList.SelectedIndex != -1)
                    {
                        string dbName = textBoxNewDB.Text;
                        string CollationName = CollationList.SelectedItem.ToString();
                        CreateDB(dbName, CollationName);
                    }
                    else
                    {
                        MessageBox.Show("Database Collation is not valid", "Invalid Database Collation");
                    }
                }
            }
            else
            {
                MessageBox.Show("Database name is not valid", "Invalid Data base name");
            }
        }

        private void textBoxNewDB_TextChanged(object sender, EventArgs e)
        {
            ValidateDBName();
        }

        private void CreateDB(string db_name, string CollationName)
        {
            string CreateDbQuery = @"Use master ;
        Create Database mydb CONTAINMENT = NONE ;
        IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
        begin
        EXEC [mydb].[dbo].[sp_fulltext_database] @action = 'enable'
        end;
        ALTER DATABASE [mydb] SET COMPATIBILITY_LEVEL = 120;
        Alter Database [mydb] Set Single_User;
        ALTER DATABASE [mydb] Collate CollationName ;
        ALTER Database [mydb] Set MULTI_USER ;
        ALTER DATABASE [mydb] SET ANSI_NULL_DEFAULT OFF ;
        ALTER DATABASE [mydb] SET ANSI_NULLS OFF ;
        ALTER DATABASE [mydb] SET ANSI_PADDING OFF ;
        ALTER DATABASE [mydb] SET ANSI_WARNINGS OFF ;
        ALTER DATABASE [mydb] SET ARITHABORT OFF ;
        ALTER DATABASE [mydb] SET AUTO_CLOSE OFF ;
        ALTER DATABASE [mydb] SET AUTO_SHRINK OFF ;
        ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS ON ;
        ALTER DATABASE [mydb] SET CURSOR_CLOSE_ON_COMMIT OFF ;
        ALTER DATABASE [mydb] SET CURSOR_DEFAULT  GLOBAL ;
        ALTER DATABASE [mydb] SET CONCAT_NULL_YIELDS_NULL OFF ;
        ALTER DATABASE [mydb] SET NUMERIC_ROUNDABORT OFF ;
        ALTER DATABASE [mydb] SET QUOTED_IDENTIFIER OFF ;
        ALTER DATABASE [mydb] SET RECURSIVE_TRIGGERS OFF ;
        ALTER DATABASE [mydb] SET  DISABLE_BROKER ;
        ALTER DATABASE [mydb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF ;
        ALTER DATABASE [mydb] SET DATE_CORRELATION_OPTIMIZATION OFF ;
        ALTER DATABASE [mydb] SET TRUSTWORTHY OFF ;
        ALTER DATABASE [mydb] SET ALLOW_SNAPSHOT_ISOLATION OFF ;
        ALTER DATABASE [mydb] SET PARAMETERIZATION SIMPLE ;
        ALTER DATABASE [mydb] SET READ_COMMITTED_SNAPSHOT OFF ;
        ALTER DATABASE [mydb] SET HONOR_BROKER_PRIORITY OFF ;
        ALTER DATABASE [mydb] SET RECOVERY SIMPLE ;
        ALTER DATABASE [mydb] SET PAGE_VERIFY CHECKSUM  ;
        ALTER DATABASE [mydb] SET DB_CHAINING OFF ;
        ALTER DATABASE [mydb] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) ;
        ALTER DATABASE [mydb] SET TARGET_RECOVERY_TIME = 0 SECONDS ;
        ALTER DATABASE [mydb] SET DELAYED_DURABILITY = DISABLED ;
        ALTER DATABASE [mydb] SET  READ_WRITE ;";
            CreateDbQuery = CreateDbQuery.Replace("mydb", db_name);
            CreateDbQuery = CreateDbQuery.Replace("CollationName", CollationName);
            using (SqlConnection con = new SqlConnection("Data Source=" + ServersList.SelectedItem + "; Integrated Security=True;"))
            {
                SqlCommand cmd = new SqlCommand(CreateDbQuery, con);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    _ = DatabasesList.Items.Add(db_name);
                    DatabasesList.SelectedIndex = DatabasesList.Items.Count - 1;
                    textBoxNewDB.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Failed");
                }
            }
        }

        private bool ValidateDBName()
        {
            string name = textBoxNewDB.Text.Trim().ToLower();
            // system dbs : master tempdb model msdb
            if (string.IsNullOrEmpty(name) ||
                name.Equals("master") ||
                name == "tempdb" ||
                name == "model" ||
                name == "msdb" ||
                name.Contains(" "))
            {
                textBoxNewDB.ForeColor = Color.Red;
                CollationList.Enabled = false;
                return false;
            }
            else
            {
                textBoxNewDB.ForeColor = Color.Green;
                CollationList.Enabled = true;
                return true;
            }
        }

        private void DatabasesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load table list
            //Load cs
            try
            {
                using (SqlConnection con = new SqlConnection(GetCS()))
                {
                    SqlDataAdapter da = new SqlDataAdapter(
                            "SELECT TABLE_NAME FROM information_schema.tables; ", con);
                    DataTable dt = new DataTable();
                    _ = da.Fill(dt);
                    textBoxCS.Text = con.ConnectionString;
                    //Clipboard.SetText(textBoxCS.Text);
                    TablesList.Items.Clear();
                    TablesList.Text = "Choose Table";
                    foreach (DataRow row in dt.Rows)
                    {
                        _ = TablesList.Items.Add(row["TABLE_NAME"].ToString());
                    }
                }
            }
            catch (InvalidOperationException)
            {
                textBoxCS.Clear();
                TablesList.Items.Clear();
            }
            //Clear Restore path file box :
            textBoxRestore.Clear();
        }

        private string GetCS()
        {
            if (DatabasesList.SelectedItem == null)
            {
                MessageBox.Show("Database was not set", "Invalid options");
                return string.Empty;
            }
            else
            {
                string db_name = DatabasesList.SelectedItem.ToString();
                try
                {
                    using (SqlConnection con = new SqlConnection("Data Source=" + ServersList.SelectedItem + ";Initial Catalog=" + db_name + "; Integrated Security=True;"))
                    {
                        con.Open();
                        con.Close();
                        return con.ConnectionString;
                    }
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message, "Connection faild");
                    return string.Empty;
                }
            }
        }

        private void buttonCopyCS_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBoxCS.Text);
            _ = MessageBox.Show("Connection string copied to clipboard", "Done");
        }

        private void buttonViewData_Click(object sender, EventArgs e)
        {
            if (TablesList.SelectedIndex != -1)
            {
                string TableName = TablesList.SelectedItem.ToString();
                using (SqlDataAdapter da = new SqlDataAdapter("Select * from " + TableName, GetCS()))
                {
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dt.TableName = TableName;
                    ViewTableData form = new ViewTableData
                    {
                        Table = dt
                    };
                    form.ShowDialog();
                }
            }
            else
            {
                _ = MessageBox.Show("Choose Data Table first !", "Operation Faild");
            }
        }

        private void buttonChooseConfigurationFile_Click(object sender, EventArgs e)
        {
            openFileDialogConfigurationFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            DialogResult relult = openFileDialogConfigurationFile.ShowDialog();
            if (relult == DialogResult.OK)
            {
                textBoxConfigurationFile.Text = openFileDialogConfigurationFile.FileName;
                LoadConnectionStrings(textBoxConfigurationFile.Text);
                csList.DataSource = FileConnectionStrings.Keys.ToList();
                csList.SelectedIndex = -1;
            }
        }
        private Dictionary<string, string> FileConnectionStrings = new Dictionary<string, string>();
        private  void LoadConnectionStrings(string fullFilePath, string LocalConnectionStringToRemove = "LocalSqlServer")
        {
            ExeConfigurationFileMap ConfigFileMap = new ExeConfigurationFileMap
            {
                ExeConfigFilename = fullFilePath
            };
            Configuration config = ConfigurationManager.OpenMappedExeConfiguration(ConfigFileMap, ConfigurationUserLevel.None);
            ConnectionStringsSection conSection = config.ConnectionStrings;
            FileConnectionStrings.Clear();
            foreach (ConnectionStringSettings item in conSection.ConnectionStrings)
            {
                FileConnectionStrings.Add(item.Name, item.ConnectionString);
            }
            FileConnectionStrings.Remove(LocalConnectionStringToRemove);
        }

        private void UpdateConnectionString(string key,string connectionString)
        {
            FileConnectionStrings[key] = connectionString;
        }
        
        private void SaveConnectionStrings(string fullFilePath)
        {
            if (File.Exists(fullFilePath))
            {
                try
                {
                    ExeConfigurationFileMap ConfigFileMap = new ExeConfigurationFileMap
                    {
                        ExeConfigFilename = fullFilePath
                    };
                    Configuration config = ConfigurationManager.OpenMappedExeConfiguration(ConfigFileMap, ConfigurationUserLevel.None);
                    ConnectionStringsSection conSection = config.ConnectionStrings;

                    foreach (string key in FileConnectionStrings.Keys)
                    {
                        conSection.ConnectionStrings[key].ConnectionString = FileConnectionStrings[key];
                    }
                    config.Save();
                    _ = MessageBox.Show("All Done", "Saved");
                csList.SelectedIndex = -1;
                textBoxConfigurationFile.Clear();
                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message, "Saving Failed !");
                }
            }
            
        }

        private void textBoxConfigurationFile_TextChanged(object sender, EventArgs e)
        {
            ValidateFile(ref textBoxConfigurationFile);
        }

        private void ValidateFile(ref TextBox textbox)
        {
            if (File.Exists(textbox.Text) == true)
            { textbox.ForeColor = Color.Green; }
            else { textbox.ForeColor = Color.Red; }
        }

        private void buttonUpdateConfigurationFile_Click(object sender, EventArgs e)
        {
            if (csList.SelectedItem != null)
            {
                string name = csList.SelectedItem.ToString();
                try
                {
                    UpdateConnectionString(name, textBoxCS.Text);
                    //csList.Refresh();
                    textBoxViewCS.Text = textBoxCS.Text;
                    _ = MessageBox.Show("do not forget to hit save when you are Done", "Updated");

                }
                catch (Exception ex)
                {
                    _ = MessageBox.Show(ex.Message, "Update Faild");
                }
            }
            else
            {
                textBoxViewCS.Clear();
            }
        }

        private void csList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (csList.SelectedIndex != -1)
            {
                string name = csList.SelectedItem.ToString();
                LoadConnectionStrings(textBoxConfigurationFile.Text);
                textBoxViewCS.Text = FileConnectionStrings[name];
            }
            else
            {
                textBoxViewCS.Clear();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveConnectionStrings(textBoxConfigurationFile.Text);
        }

        private void csList_DataSourceChanged(object sender, EventArgs e)
        {
            csList.Text = "Choose Connection String";
        }

    }
}
