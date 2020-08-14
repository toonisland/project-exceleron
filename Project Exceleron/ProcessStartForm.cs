using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Exceleron
{
    public partial class ProcessStartForm : Form
    {
        public string filename = "";
        public string arguments = "";
        public string workingDirectory = "";

        public ProcessStartForm()
        {
            InitializeComponent();
        }

        private void ProcessStartForm_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(filename))
            {
                MessageBox.Show(this, @"Empty filename.\nPlease set Src or EXE paths in Workspace -> options.");

                return;
            }

            consoleControl1.StartProcess(filename, arguments, workingDirectory);
            consoleControl1.SendKeyboardCommandsToProcess = true;

            consoleControl1.InternalRichTextBox.TextChanged += richTextBox_TextChanged;
        }

        private void ProcessStartForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                ProcessStartInfo info = new ProcessStartInfo
                {
                    WindowStyle = ProcessWindowStyle.Hidden,
                    FileName = "Resources\\SafeKillMongo.exe",
                    Arguments = consoleControl1.ProcessInterface.Process.Id.ToString()
                };

                Process.Start(info);
            }
            catch(Exception ex)
            {
                Log.Error(ex);
            }

        }

        private void ProcessStartForm_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void richTextBox_TextChanged(object sender, EventArgs e)
        {
            if(!scrollCheckBox.Checked)
                return;
            // set the current caret position to the end
            consoleControl1.InternalRichTextBox.SelectionStart = consoleControl1.InternalRichTextBox.Text.Length;
            // scroll it automatically
            consoleControl1.InternalRichTextBox.ScrollToCaret();
        }
    }
}
