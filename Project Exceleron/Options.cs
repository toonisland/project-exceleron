using System;
using System.Windows.Forms;
using Project_Exceleron.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Project_Exceleron
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }

        private void AstronLocate_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePickerDialog = new OpenFileDialog {Filter = @"astrond.exe|astrond.exe|All Files(*.*)|*.*"};
            DialogResult result = filePickerDialog.ShowDialog(this);
            if(result != DialogResult.OK)
                return;
            AstronPath.Text = filePickerDialog.FileName;
        }

        private void Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            Settings.Default.inheritSrc = srcCheckBox.Checked;
            if(Settings.Default.inheritSrc)
            {
                Settings.Default.srcPath = srcPath.Text;
            }
            else
            {
                Settings.Default.AstronPath = AstronPath.Text;
                Settings.Default.MongoPath = MongoPath.Text;
                Settings.Default.MongoDbPath = dbPath.Text;
                Settings.Default.clusterPath = clusterPath.Text;
                Settings.Default.ppythonPath = ppythonPath.Text;
            }
            Settings.Default.username = usernameField.Text;
            Settings.Default.password = passwordField.Text;
            Settings.Default.Save();
        }

        private void LoadSettings()
        {
            if(Settings.Default.inheritSrc)
            {
                srcPath.Text = Settings.Default.srcPath;
                srcCheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                srcCheckBox.CheckState = CheckState.Unchecked;
                srcCheckBox_CheckStateChanged(new object(), EventArgs.Empty);
                AstronPath.Text = Settings.Default.AstronPath;
                MongoPath.Text = Settings.Default.MongoPath;
                dbPath.Text = Settings.Default.MongoDbPath;
                clusterPath.Text = Settings.Default.clusterPath;
                ppythonPath.Text = Settings.Default.ppythonPath;
            }
            usernameField.Text = Settings.Default.username;
            passwordField.Text = Settings.Default.password;
        }

        private void Options_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            SaveSettings();
            Save.Text = @"Saved!";
        }

        private void MongoLocate_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePickerDialog = new OpenFileDialog();
            filePickerDialog.Filter = @"mongod.exe|mongod.exe|All Files(*.*)|*.*";
            DialogResult result = filePickerDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            MongoPath.Text = filePickerDialog.FileName;
        }

        private void mongoDbLocate_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderPicker = new CommonOpenFileDialog();
            folderPicker.IsFolderPicker = true;
            CommonFileDialogResult result = folderPicker.ShowDialog();
            if (result != CommonFileDialogResult.Ok)
                return;
            dbPath.Text = folderPicker.FileName;
        }

        private void SrcFolderLocate_Click(object sender, EventArgs e)
        {
            CommonOpenFileDialog folderPicker = new CommonOpenFileDialog();
            folderPicker.IsFolderPicker = true;
            CommonFileDialogResult result = folderPicker.ShowDialog();
            if (result != CommonFileDialogResult.Ok)
                return;
            srcPath.Text = folderPicker.FileName;
        }

        private void srcCheckBox_CheckStateChanged(object sender, EventArgs e)
        {
            if(srcCheckBox.CheckState == CheckState.Checked)
            {
                Settings.Default.inheritSrc = true;

                srcPath.Enabled = true;
                SrcFolderLocate.Enabled = true;

                dbPath.Enabled = false;
                mongoDbLocate.Enabled = false;

                MongoPath.Enabled = false;
                MongoLocate.Enabled = false;

                AstronPath.Enabled = false;
                AstronLocate.Enabled = false;

                clusterPath.Enabled = false;
                clusterLocate.Enabled = false;

                ppythonPath.Enabled = false;
                ppythonLocate.Enabled = false;
            }
            else if(srcCheckBox.CheckState == CheckState.Unchecked)
            {
                Settings.Default.inheritSrc = false;

                srcPath.Enabled = false;
                SrcFolderLocate.Enabled = false;

                dbPath.Enabled = true;
                mongoDbLocate.Enabled = true;

                MongoPath.Enabled = true;
                MongoLocate.Enabled = true;

                AstronPath.Enabled = true;
                AstronLocate.Enabled = true;

                clusterPath.Enabled = true;
                clusterLocate.Enabled = true;

                ppythonPath.Enabled = true;
                ppythonLocate.Enabled = true;
            }
            Refresh();
        }

        private void clusterLocate_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePickerDialog = new OpenFileDialog();
            filePickerDialog.Filter = @"*.yml|*.yml|All Files(*.*)|*.*";
            DialogResult result = filePickerDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            clusterPath.Text = filePickerDialog.FileName;
        }

        private void ppythonLocate_Click(object sender, EventArgs e)
        {
            OpenFileDialog filePickerDialog = new OpenFileDialog();
            filePickerDialog.Filter = @"ppython.exe|ppython.exe|python.exe|python.exe|All Files(*.*)|*.*";
            DialogResult result = filePickerDialog.ShowDialog(this);
            if (result != DialogResult.OK)
                return;
            ppythonPath.Text = filePickerDialog.FileName;
        }
    }
}
