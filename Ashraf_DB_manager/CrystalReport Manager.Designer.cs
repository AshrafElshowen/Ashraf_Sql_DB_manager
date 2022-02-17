namespace Ashraf_DB_manager
{
    partial class CrystalReport_Manager
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
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonChangePath = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxPath2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonChangePath2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog2 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.textBoxPath.Location = new System.Drawing.Point(94, 59);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(640, 35);
            this.textBoxPath.TabIndex = 21;
            this.textBoxPath.Text = "C:\\Program Files (x86)\\SAP BusinessObjects\\Crystal Reports for .NET Framework 4.0" +
    "\\Common\\SAP BusinessObjects Enterprise XI 4.0\\win32_x86\\dotnet";
            this.textBoxPath.TextChanged += new System.EventHandler(this.textBoxPath_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(301, 28);
            this.label3.TabIndex = 24;
            this.label3.Text = "Crystal Reports (DDLs) path :";
            // 
            // buttonChangePath
            // 
            this.buttonChangePath.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePath.Location = new System.Drawing.Point(740, 57);
            this.buttonChangePath.Name = "buttonChangePath";
            this.buttonChangePath.Size = new System.Drawing.Size(133, 37);
            this.buttonChangePath.TabIndex = 22;
            this.buttonChangePath.Text = "Change";
            this.buttonChangePath.UseVisualStyleBackColor = true;
            this.buttonChangePath.Click += new System.EventHandler(this.buttonChangePath_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonUpdate.Location = new System.Drawing.Point(740, 193);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(133, 37);
            this.buttonUpdate.TabIndex = 23;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "choose were backup file will be stored";
            // 
            // textBoxPath2
            // 
            this.textBoxPath2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F);
            this.textBoxPath2.Location = new System.Drawing.Point(94, 145);
            this.textBoxPath2.Name = "textBoxPath2";
            this.textBoxPath2.Size = new System.Drawing.Size(640, 35);
            this.textBoxPath2.TabIndex = 25;
            this.textBoxPath2.TextChanged += new System.EventHandler(this.textBoxPath2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 28);
            this.label1.TabIndex = 27;
            this.label1.Text = "Project (Debug) path :";
            // 
            // buttonChangePath2
            // 
            this.buttonChangePath2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonChangePath2.Location = new System.Drawing.Point(740, 143);
            this.buttonChangePath2.Name = "buttonChangePath2";
            this.buttonChangePath2.Size = new System.Drawing.Size(133, 37);
            this.buttonChangePath2.TabIndex = 26;
            this.buttonChangePath2.Text = "Change";
            this.buttonChangePath2.UseVisualStyleBackColor = true;
            this.buttonChangePath2.Click += new System.EventHandler(this.buttonChangePath2_Click);
            // 
            // folderBrowserDialog2
            // 
            this.folderBrowserDialog2.Description = "choose were backup file will be stored";
            // 
            // CrystalReport_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 243);
            this.Controls.Add(this.textBoxPath2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonChangePath2);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonChangePath);
            this.Controls.Add(this.buttonUpdate);
            this.Name = "CrystalReport_Manager";
            this.Text = "CrystalReport_Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonChangePath;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.TextBox textBoxPath2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonChangePath2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog2;
    }
}