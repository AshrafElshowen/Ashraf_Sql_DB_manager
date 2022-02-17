using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Ashraf_DB_manager
{
    public partial class CrystalReport_Manager : Form
    {
        public CrystalReport_Manager()
        {
            InitializeComponent();
        }

        private void textBoxPath_TextChanged(object sender, EventArgs e)
        {
            ValidatePath();
        }

        private void ValidatePath()
        {
            if (Directory.Exists(textBoxPath.Text) == true)
            { textBoxPath.ForeColor = Color.Green; }
            else { textBoxPath.ForeColor = Color.Red; }
        }

        private void buttonChangePath_Click(object sender, EventArgs e)
        {
            DialogResult relult = folderBrowserDialog.ShowDialog();
            if (relult == DialogResult.OK)
            {
                textBoxPath.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(textBoxPath.Text))
            {         
                if (Directory.Exists(textBoxPath2.Text))
                {
                    string[] files = {
                    "CrystalDecisions.CrystalReports.Engine.dll",
                        "CrystalDecisions.ReportAppServer.ClientDoc.dll",
                        "CrystalDecisions.ReportAppServer.CommLayer.dll",
                        "CrystalDecisions.ReportAppServer.CommonControls.dll",
                    "CrystalDecisions.ReportAppServer.CommonObjectModel.dll",
                        "CrystalDecisions.ReportAppServer.Controllers.dll",
                        "CrystalDecisions.ReportAppServer.CubeDefModel.dll",
                        "CrystalDecisions.ReportAppServer.DataDefModel.dll",
                    "CrystalDecisions.ReportAppServer.DataSetConversion.dll",
                        "CrystalDecisions.ReportAppServer.ObjectFactory.dll",
                        "CrystalDecisions.ReportAppServer.Prompting.dll",
                        "CrystalDecisions.ReportAppServer.ReportDefModel.dll",
                    "CrystalDecisions.ReportAppServer.XmlSerialize.dll",
                        "CrystalDecisions.ReportSource.dll",
                        "CrystalDecisions.Shared.dll",
                        "CrystalDecisions.Windows.Forms.dll",
                    };
                    string path = textBoxPath.Text + @"\"; 
                    string path2 = textBoxPath2.Text + @"\";
                    
                    foreach (string fileName in files)
                    {
                        try
                        {
                        File.Copy(path + fileName, path2 + fileName, true);

                        }
                        catch (Exception ex)
                        {
                            _ = MessageBox.Show(ex.Message, "Faild");
                            _ = MessageBox.Show(fileName, "Error Details");
                        }
                    }
                    _ = MessageBox.Show("Update Completed", "Done");
                }
                else
                {
                    MessageBox.Show("Project Debug path is not valid", "Invalid options");
                }
            }
            else
            {
                MessageBox.Show("Crystal Reports DLLs path is not valid", "Invalid options");
            }
        }

        private void textBoxPath2_TextChanged(object sender, EventArgs e)
        {
            ValidatePath();
        }

        private void buttonChangePath2_Click(object sender, EventArgs e)
        {
            DialogResult relult = folderBrowserDialog2.ShowDialog();
            if (relult == DialogResult.OK)
            {
                textBoxPath2.Text = folderBrowserDialog2.SelectedPath;
            }
        }
    }
}
