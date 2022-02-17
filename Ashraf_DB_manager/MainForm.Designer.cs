namespace Ashraf_DB_manager
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ServersList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BackUpButton = new System.Windows.Forms.Button();
            this.DatabasesList = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialogBackup = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxBackupPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChangePath = new System.Windows.Forms.Button();
            this.GetAccessButton = new System.Windows.Forms.Button();
            this.openFileDialogRestore = new System.Windows.Forms.OpenFileDialog();
            this.textBoxRestore = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonChoose = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxViewCS = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.csList = new System.Windows.Forms.ComboBox();
            this.textBoxConfigurationFile = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonChooseConfigurationFile = new System.Windows.Forms.Button();
            this.buttonUpdateConfigurationFile = new System.Windows.Forms.Button();
            this.buttonCopyCS = new System.Windows.Forms.Button();
            this.textBoxCS = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.buttonViewData = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.TablesList = new System.Windows.Forms.ComboBox();
            this.buttonNewDB = new System.Windows.Forms.Button();
            this.textBoxNewDB = new System.Windows.Forms.TextBox();
            this.openFileDialogConfigurationFile = new System.Windows.Forms.OpenFileDialog();
            this.CollationList = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // ServersList
            // 
            this.ServersList.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServersList.FormattingEnabled = true;
            this.ServersList.Location = new System.Drawing.Point(137, 12);
            this.ServersList.Name = "ServersList";
            this.ServersList.Size = new System.Drawing.Size(404, 36);
            this.ServersList.TabIndex = 0;
            this.ServersList.Text = "Select Sql Server instance";
            this.ServersList.SelectedIndexChanged += new System.EventHandler(this.ServersList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "SQL Server";
            // 
            // BackUpButton
            // 
            this.BackUpButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackUpButton.Location = new System.Drawing.Point(648, 58);
            this.BackUpButton.Name = "BackUpButton";
            this.BackUpButton.Size = new System.Drawing.Size(133, 37);
            this.BackUpButton.TabIndex = 5;
            this.BackUpButton.Text = "Backup";
            this.BackUpButton.UseVisualStyleBackColor = true;
            this.BackUpButton.Click += new System.EventHandler(this.BackUpButton_Click);
            // 
            // DatabasesList
            // 
            this.DatabasesList.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatabasesList.FormattingEnabled = true;
            this.DatabasesList.Location = new System.Drawing.Point(125, 54);
            this.DatabasesList.Name = "DatabasesList";
            this.DatabasesList.Size = new System.Drawing.Size(277, 36);
            this.DatabasesList.TabIndex = 1;
            this.DatabasesList.Text = "Choose Database";
            this.DatabasesList.SelectedIndexChanged += new System.EventHandler(this.DatabasesList_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Database";
            // 
            // folderBrowserDialogBackup
            // 
            this.folderBrowserDialogBackup.Description = "choose were backup file will be stored";
            // 
            // textBoxBackupPath
            // 
            this.textBoxBackupPath.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.textBoxBackupPath.Location = new System.Drawing.Point(154, 15);
            this.textBoxBackupPath.Name = "textBoxBackupPath";
            this.textBoxBackupPath.Size = new System.Drawing.Size(480, 35);
            this.textBoxBackupPath.TabIndex = 3;
            this.textBoxBackupPath.TextChanged += new System.EventHandler(this.textBoxBackupPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "Backup Path";
            // 
            // buttonChangePath
            // 
            this.buttonChangePath.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePath.Location = new System.Drawing.Point(648, 15);
            this.buttonChangePath.Name = "buttonChangePath";
            this.buttonChangePath.Size = new System.Drawing.Size(133, 37);
            this.buttonChangePath.TabIndex = 4;
            this.buttonChangePath.Text = "Change";
            this.buttonChangePath.UseVisualStyleBackColor = true;
            this.buttonChangePath.Click += new System.EventHandler(this.buttonChangePath_Click);
            // 
            // GetAccessButton
            // 
            this.GetAccessButton.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetAccessButton.Location = new System.Drawing.Point(408, 54);
            this.GetAccessButton.Name = "GetAccessButton";
            this.GetAccessButton.Size = new System.Drawing.Size(133, 37);
            this.GetAccessButton.TabIndex = 2;
            this.GetAccessButton.Text = "Get Access";
            this.GetAccessButton.UseVisualStyleBackColor = true;
            this.GetAccessButton.Click += new System.EventHandler(this.GetAccessButton_Click);
            // 
            // openFileDialogRestore
            // 
            this.openFileDialogRestore.DefaultExt = "bak";
            this.openFileDialogRestore.Filter = "Database Backup file|*.bak;";
            this.openFileDialogRestore.RestoreDirectory = true;
            this.openFileDialogRestore.Title = "Choose Database back up file to restore";
            // 
            // textBoxRestore
            // 
            this.textBoxRestore.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.textBoxRestore.Location = new System.Drawing.Point(154, 15);
            this.textBoxRestore.Name = "textBoxRestore";
            this.textBoxRestore.Size = new System.Drawing.Size(480, 35);
            this.textBoxRestore.TabIndex = 6;
            this.textBoxRestore.TextChanged += new System.EventHandler(this.textBoxRestore_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 28);
            this.label4.TabIndex = 10;
            this.label4.Text = "Restore Path";
            // 
            // buttonChoose
            // 
            this.buttonChoose.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChoose.Location = new System.Drawing.Point(648, 15);
            this.buttonChoose.Name = "buttonChoose";
            this.buttonChoose.Size = new System.Drawing.Size(133, 37);
            this.buttonChoose.TabIndex = 7;
            this.buttonChoose.Text = "Choose";
            this.buttonChoose.UseVisualStyleBackColor = true;
            this.buttonChoose.Click += new System.EventHandler(this.buttonChoose_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestore.Location = new System.Drawing.Point(648, 58);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(133, 37);
            this.buttonRestore.TabIndex = 8;
            this.buttonRestore.Text = "Restore";
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(17, 187);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 298);
            this.tabControl1.TabIndex = 13;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxBackupPath);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.buttonChangePath);
            this.tabPage1.Controls.Add(this.BackUpButton);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 261);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Backup";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxRestore);
            this.tabPage2.Controls.Add(this.buttonRestore);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.buttonChoose);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 261);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Restore";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonSave);
            this.tabPage3.Controls.Add(this.textBoxViewCS);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.csList);
            this.tabPage3.Controls.Add(this.textBoxConfigurationFile);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.buttonChooseConfigurationFile);
            this.tabPage3.Controls.Add(this.buttonUpdateConfigurationFile);
            this.tabPage3.Controls.Add(this.buttonCopyCS);
            this.tabPage3.Controls.Add(this.textBoxCS);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(799, 261);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Connection String";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(646, 155);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(133, 37);
            this.buttonSave.TabIndex = 24;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxViewCS
            // 
            this.textBoxViewCS.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.textBoxViewCS.Location = new System.Drawing.Point(60, 209);
            this.textBoxViewCS.Name = "textBoxViewCS";
            this.textBoxViewCS.ReadOnly = true;
            this.textBoxViewCS.Size = new System.Drawing.Size(719, 35);
            this.textBoxViewCS.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(16, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 28);
            this.label8.TabIndex = 22;
            this.label8.Text = "Connection String";
            // 
            // csList
            // 
            this.csList.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.csList.FormattingEnabled = true;
            this.csList.Location = new System.Drawing.Point(216, 156);
            this.csList.Name = "csList";
            this.csList.Size = new System.Drawing.Size(290, 36);
            this.csList.TabIndex = 21;
            this.csList.Text = "Choose Connection String";
            this.csList.SelectedIndexChanged += new System.EventHandler(this.csList_SelectedIndexChanged);
            this.csList.DataSourceChanged += new System.EventHandler(this.csList_DataSourceChanged);
            // 
            // textBoxConfigurationFile
            // 
            this.textBoxConfigurationFile.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.textBoxConfigurationFile.Location = new System.Drawing.Point(152, 113);
            this.textBoxConfigurationFile.Name = "textBoxConfigurationFile";
            this.textBoxConfigurationFile.Size = new System.Drawing.Size(480, 35);
            this.textBoxConfigurationFile.TabIndex = 16;
            this.textBoxConfigurationFile.TextChanged += new System.EventHandler(this.textBoxConfigurationFile_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(192, 28);
            this.label7.TabIndex = 19;
            this.label7.Text = "Configuration File";
            // 
            // buttonChooseConfigurationFile
            // 
            this.buttonChooseConfigurationFile.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChooseConfigurationFile.Location = new System.Drawing.Point(646, 113);
            this.buttonChooseConfigurationFile.Name = "buttonChooseConfigurationFile";
            this.buttonChooseConfigurationFile.Size = new System.Drawing.Size(133, 37);
            this.buttonChooseConfigurationFile.TabIndex = 17;
            this.buttonChooseConfigurationFile.Text = "Choose";
            this.buttonChooseConfigurationFile.UseVisualStyleBackColor = true;
            this.buttonChooseConfigurationFile.Click += new System.EventHandler(this.buttonChooseConfigurationFile_Click);
            // 
            // buttonUpdateConfigurationFile
            // 
            this.buttonUpdateConfigurationFile.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdateConfigurationFile.Location = new System.Drawing.Point(512, 155);
            this.buttonUpdateConfigurationFile.Name = "buttonUpdateConfigurationFile";
            this.buttonUpdateConfigurationFile.Size = new System.Drawing.Size(120, 37);
            this.buttonUpdateConfigurationFile.TabIndex = 18;
            this.buttonUpdateConfigurationFile.Text = "Update";
            this.buttonUpdateConfigurationFile.UseVisualStyleBackColor = true;
            this.buttonUpdateConfigurationFile.Click += new System.EventHandler(this.buttonUpdateConfigurationFile_Click);
            // 
            // buttonCopyCS
            // 
            this.buttonCopyCS.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCopyCS.Location = new System.Drawing.Point(646, 69);
            this.buttonCopyCS.Name = "buttonCopyCS";
            this.buttonCopyCS.Size = new System.Drawing.Size(133, 37);
            this.buttonCopyCS.TabIndex = 15;
            this.buttonCopyCS.Text = "Copy CS";
            this.buttonCopyCS.UseVisualStyleBackColor = true;
            this.buttonCopyCS.Click += new System.EventHandler(this.buttonCopyCS_Click);
            // 
            // textBoxCS
            // 
            this.textBoxCS.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.textBoxCS.Location = new System.Drawing.Point(60, 28);
            this.textBoxCS.Name = "textBoxCS";
            this.textBoxCS.ReadOnly = true;
            this.textBoxCS.Size = new System.Drawing.Size(719, 35);
            this.textBoxCS.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 28);
            this.label5.TabIndex = 12;
            this.label5.Text = "CS";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.buttonViewData);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.TablesList);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(799, 261);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Show Table contents";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // buttonViewData
            // 
            this.buttonViewData.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonViewData.Location = new System.Drawing.Point(470, 27);
            this.buttonViewData.Name = "buttonViewData";
            this.buttonViewData.Size = new System.Drawing.Size(133, 37);
            this.buttonViewData.TabIndex = 6;
            this.buttonViewData.Text = "View Data";
            this.buttonViewData.UseVisualStyleBackColor = true;
            this.buttonViewData.Click += new System.EventHandler(this.buttonViewData_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 28);
            this.label6.TabIndex = 7;
            this.label6.Text = "Table Name";
            // 
            // TablesList
            // 
            this.TablesList.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TablesList.FormattingEnabled = true;
            this.TablesList.Location = new System.Drawing.Point(166, 28);
            this.TablesList.Name = "TablesList";
            this.TablesList.Size = new System.Drawing.Size(298, 36);
            this.TablesList.TabIndex = 5;
            this.TablesList.Text = "Choose Table";
            // 
            // buttonNewDB
            // 
            this.buttonNewDB.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNewDB.Location = new System.Drawing.Point(408, 97);
            this.buttonNewDB.Name = "buttonNewDB";
            this.buttonNewDB.Size = new System.Drawing.Size(133, 37);
            this.buttonNewDB.TabIndex = 14;
            this.buttonNewDB.Text = "New DB";
            this.buttonNewDB.UseVisualStyleBackColor = true;
            this.buttonNewDB.Click += new System.EventHandler(this.buttonNewDB_Click);
            // 
            // textBoxNewDB
            // 
            this.textBoxNewDB.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.textBoxNewDB.Location = new System.Drawing.Point(125, 97);
            this.textBoxNewDB.Name = "textBoxNewDB";
            this.textBoxNewDB.Size = new System.Drawing.Size(277, 35);
            this.textBoxNewDB.TabIndex = 15;
            this.textBoxNewDB.TextChanged += new System.EventHandler(this.textBoxNewDB_TextChanged);
            // 
            // openFileDialogConfigurationFile
            // 
            this.openFileDialogConfigurationFile.DefaultExt = "bak";
            this.openFileDialogConfigurationFile.Filter = "App Configuration File |*.config;";
            this.openFileDialogConfigurationFile.RestoreDirectory = true;
            this.openFileDialogConfigurationFile.Title = "Choose App Configuration file to update";
            // 
            // CollationList
            // 
            this.CollationList.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CollationList.FormattingEnabled = true;
            this.CollationList.Location = new System.Drawing.Point(125, 138);
            this.CollationList.Name = "CollationList";
            this.CollationList.Size = new System.Drawing.Size(277, 36);
            this.CollationList.TabIndex = 17;
            this.CollationList.Text = "Choose Collation";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 494);
            this.Controls.Add(this.CollationList);
            this.Controls.Add(this.textBoxNewDB);
            this.Controls.Add(this.buttonNewDB);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.GetAccessButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DatabasesList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ServersList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Ashraf_DB_Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ServersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BackUpButton;
        private System.Windows.Forms.ComboBox DatabasesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogBackup;
        private System.Windows.Forms.TextBox textBoxBackupPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChangePath;
        private System.Windows.Forms.Button GetAccessButton;
        private System.Windows.Forms.OpenFileDialog openFileDialogRestore;
        private System.Windows.Forms.TextBox textBoxRestore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonChoose;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonNewDB;
        private System.Windows.Forms.TextBox textBoxNewDB;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBoxCS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button buttonViewData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TablesList;
        private System.Windows.Forms.Button buttonCopyCS;
        private System.Windows.Forms.TextBox textBoxConfigurationFile;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonChooseConfigurationFile;
        private System.Windows.Forms.Button buttonUpdateConfigurationFile;
        private System.Windows.Forms.OpenFileDialog openFileDialogConfigurationFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox csList;
        private System.Windows.Forms.TextBox textBoxViewCS;
        private System.Windows.Forms.ComboBox CollationList;
        private System.Windows.Forms.Button buttonSave;
    }
}

