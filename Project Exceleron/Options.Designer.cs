namespace Project_Exceleron
{
    partial class Options
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
            this.AstronLocate = new System.Windows.Forms.Button();
            this.AstronPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Save = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MongoPath = new System.Windows.Forms.TextBox();
            this.MongoLocate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dbPath = new System.Windows.Forms.TextBox();
            this.mongoDbLocate = new System.Windows.Forms.Button();
            this.SrcFolderLocate = new System.Windows.Forms.Button();
            this.srcPath = new System.Windows.Forms.TextBox();
            this.srcCheckBox = new System.Windows.Forms.CheckBox();
            this.clusterLocate = new System.Windows.Forms.Button();
            this.clusterPath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ppythonLocate = new System.Windows.Forms.Button();
            this.ppythonPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AstronLocate
            // 
            this.AstronLocate.Location = new System.Drawing.Point(300, 41);
            this.AstronLocate.Name = "AstronLocate";
            this.AstronLocate.Size = new System.Drawing.Size(27, 23);
            this.AstronLocate.TabIndex = 5;
            this.AstronLocate.Text = "...";
            this.AstronLocate.UseVisualStyleBackColor = true;
            this.AstronLocate.Click += new System.EventHandler(this.AstronLocate_Click);
            // 
            // AstronPath
            // 
            this.AstronPath.Location = new System.Drawing.Point(81, 43);
            this.AstronPath.Name = "AstronPath";
            this.AstronPath.Size = new System.Drawing.Size(213, 20);
            this.AstronPath.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Astrond.exe";
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(125, 413);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "mongod.exe";
            // 
            // MongoPath
            // 
            this.MongoPath.Location = new System.Drawing.Point(81, 95);
            this.MongoPath.Name = "MongoPath";
            this.MongoPath.Size = new System.Drawing.Size(213, 20);
            this.MongoPath.TabIndex = 8;
            // 
            // MongoLocate
            // 
            this.MongoLocate.Location = new System.Drawing.Point(300, 92);
            this.MongoLocate.Name = "MongoLocate";
            this.MongoLocate.Size = new System.Drawing.Size(27, 23);
            this.MongoLocate.TabIndex = 9;
            this.MongoLocate.Text = "...";
            this.MongoLocate.UseVisualStyleBackColor = true;
            this.MongoLocate.Click += new System.EventHandler(this.MongoLocate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "DB path";
            // 
            // dbPath
            // 
            this.dbPath.Location = new System.Drawing.Point(81, 124);
            this.dbPath.Name = "dbPath";
            this.dbPath.Size = new System.Drawing.Size(213, 20);
            this.dbPath.TabIndex = 11;
            // 
            // mongoDbLocate
            // 
            this.mongoDbLocate.Location = new System.Drawing.Point(300, 122);
            this.mongoDbLocate.Name = "mongoDbLocate";
            this.mongoDbLocate.Size = new System.Drawing.Size(27, 23);
            this.mongoDbLocate.TabIndex = 12;
            this.mongoDbLocate.Text = "...";
            this.mongoDbLocate.UseVisualStyleBackColor = true;
            this.mongoDbLocate.Click += new System.EventHandler(this.mongoDbLocate_Click);
            // 
            // SrcFolderLocate
            // 
            this.SrcFolderLocate.Location = new System.Drawing.Point(300, 10);
            this.SrcFolderLocate.Name = "SrcFolderLocate";
            this.SrcFolderLocate.Size = new System.Drawing.Size(27, 23);
            this.SrcFolderLocate.TabIndex = 15;
            this.SrcFolderLocate.Text = "...";
            this.SrcFolderLocate.UseVisualStyleBackColor = true;
            this.SrcFolderLocate.Click += new System.EventHandler(this.SrcFolderLocate_Click);
            // 
            // srcPath
            // 
            this.srcPath.Location = new System.Drawing.Point(145, 12);
            this.srcPath.Name = "srcPath";
            this.srcPath.Size = new System.Drawing.Size(149, 20);
            this.srcPath.TabIndex = 14;
            // 
            // srcCheckBox
            // 
            this.srcCheckBox.AutoSize = true;
            this.srcCheckBox.Location = new System.Drawing.Point(13, 13);
            this.srcCheckBox.Name = "srcCheckBox";
            this.srcCheckBox.Size = new System.Drawing.Size(126, 17);
            this.srcCheckBox.TabIndex = 16;
            this.srcCheckBox.Text = "Inherit from Src folder";
            this.srcCheckBox.UseVisualStyleBackColor = true;
            this.srcCheckBox.CheckStateChanged += new System.EventHandler(this.srcCheckBox_CheckStateChanged);
            // 
            // clusterLocate
            // 
            this.clusterLocate.Location = new System.Drawing.Point(300, 67);
            this.clusterLocate.Name = "clusterLocate";
            this.clusterLocate.Size = new System.Drawing.Size(27, 23);
            this.clusterLocate.TabIndex = 19;
            this.clusterLocate.Text = "...";
            this.clusterLocate.UseVisualStyleBackColor = true;
            this.clusterLocate.Click += new System.EventHandler(this.clusterLocate_Click);
            // 
            // clusterPath
            // 
            this.clusterPath.Location = new System.Drawing.Point(81, 69);
            this.clusterPath.Name = "clusterPath";
            this.clusterPath.Size = new System.Drawing.Size(213, 20);
            this.clusterPath.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Cluster.yml";
            // 
            // ppythonLocate
            // 
            this.ppythonLocate.Location = new System.Drawing.Point(300, 149);
            this.ppythonLocate.Name = "ppythonLocate";
            this.ppythonLocate.Size = new System.Drawing.Size(27, 23);
            this.ppythonLocate.TabIndex = 22;
            this.ppythonLocate.Text = "...";
            this.ppythonLocate.UseVisualStyleBackColor = true;
            this.ppythonLocate.Click += new System.EventHandler(this.ppythonLocate_Click);
            // 
            // ppythonPath
            // 
            this.ppythonPath.Location = new System.Drawing.Point(81, 151);
            this.ppythonPath.Name = "ppythonPath";
            this.ppythonPath.Size = new System.Drawing.Size(213, 20);
            this.ppythonPath.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "ppython.exe";
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(81, 177);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(246, 20);
            this.usernameField.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Username";
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(81, 203);
            this.passwordField.Name = "passwordField";
            this.passwordField.PasswordChar = '*';
            this.passwordField.Size = new System.Drawing.Size(246, 20);
            this.passwordField.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Password";
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 448);
            this.Controls.Add(this.passwordField);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ppythonLocate);
            this.Controls.Add(this.ppythonPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clusterLocate);
            this.Controls.Add(this.clusterPath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.srcCheckBox);
            this.Controls.Add(this.SrcFolderLocate);
            this.Controls.Add(this.srcPath);
            this.Controls.Add(this.mongoDbLocate);
            this.Controls.Add(this.dbPath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MongoLocate);
            this.Controls.Add(this.MongoPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.AstronLocate);
            this.Controls.Add(this.AstronPath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AstronLocate;
        private System.Windows.Forms.TextBox AstronPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MongoPath;
        private System.Windows.Forms.Button MongoLocate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox dbPath;
        private System.Windows.Forms.Button mongoDbLocate;
        private System.Windows.Forms.Button SrcFolderLocate;
        private System.Windows.Forms.TextBox srcPath;
        private System.Windows.Forms.CheckBox srcCheckBox;
        private System.Windows.Forms.Button clusterLocate;
        private System.Windows.Forms.TextBox clusterPath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ppythonLocate;
        private System.Windows.Forms.TextBox ppythonPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.Label label7;
    }
}