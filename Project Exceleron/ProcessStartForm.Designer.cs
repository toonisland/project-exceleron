namespace Project_Exceleron
{
    partial class ProcessStartForm
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.consoleControl1 = new ConsoleControl.ConsoleControl();
            this.scrollCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // consoleControl1
            // 
            this.consoleControl1.IsInputEnabled = true;
            this.consoleControl1.Location = new System.Drawing.Point(12, 12);
            this.consoleControl1.Name = "consoleControl1";
            this.consoleControl1.SendKeyboardCommandsToProcess = false;
            this.consoleControl1.ShowDiagnostics = false;
            this.consoleControl1.Size = new System.Drawing.Size(739, 490);
            this.consoleControl1.TabIndex = 0;
            // 
            // scrollCheckBox
            // 
            this.scrollCheckBox.AutoSize = true;
            this.scrollCheckBox.Checked = true;
            this.scrollCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.scrollCheckBox.Location = new System.Drawing.Point(678, 0);
            this.scrollCheckBox.Name = "scrollCheckBox";
            this.scrollCheckBox.Size = new System.Drawing.Size(85, 17);
            this.scrollCheckBox.TabIndex = 1;
            this.scrollCheckBox.Text = "Scroll to end";
            this.scrollCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProcessStartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 514);
            this.Controls.Add(this.scrollCheckBox);
            this.Controls.Add(this.consoleControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProcessStartForm";
            this.Text = "Roaming Ralph Test";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessStartForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProcessStartForm_FormClosed);
            this.Load += new System.EventHandler(this.ProcessStartForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ConsoleControl.ConsoleControl consoleControl1;
        private System.Windows.Forms.CheckBox scrollCheckBox;
    }
}