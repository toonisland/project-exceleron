namespace Project_Exceleron
{
    partial class QuestDialogTool
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
            this.DialogBox = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.QuestColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AddQuest = new System.Windows.Forms.Button();
            this.RemoveQuest = new System.Windows.Forms.Button();
            this.QuestIDValue = new System.Windows.Forms.TextBox();
            this.TTLocalizerOpen = new System.Windows.Forms.Button();
            this.TTLocalizerValue = new System.Windows.Forms.TextBox();
            this.QuestLabel = new System.Windows.Forms.Label();
            this.GreetingLabel = new System.Windows.Forms.Label();
            this.QuestValue = new System.Windows.Forms.RichTextBox();
            this.GreetingValue = new System.Windows.Forms.RichTextBox();
            this.CompleteLabel = new System.Windows.Forms.Label();
            this.LeavingLabel = new System.Windows.Forms.Label();
            this.CompleteValue = new System.Windows.Forms.RichTextBox();
            this.LeavingValue = new System.Windows.Forms.RichTextBox();
            this.IncompleteLabel = new System.Windows.Forms.Label();
            this.WrongNPCLabel = new System.Windows.Forms.Label();
            this.IncompleteValue = new System.Windows.Forms.RichTextBox();
            this.WrongNPCValue = new System.Windows.Forms.RichTextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DialogBox
            // 
            this.DialogBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.QuestColumn});
            this.DialogBox.FullRowSelect = true;
            this.DialogBox.HideSelection = false;
            this.DialogBox.Location = new System.Drawing.Point(12, 41);
            this.DialogBox.MultiSelect = false;
            this.DialogBox.Name = "DialogBox";
            this.DialogBox.Size = new System.Drawing.Size(310, 246);
            this.DialogBox.TabIndex = 0;
            this.DialogBox.UseCompatibleStateImageBehavior = false;
            this.DialogBox.View = System.Windows.Forms.View.Details;
            this.DialogBox.SelectedIndexChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            this.IDColumn.Width = 70;
            // 
            // QuestColumn
            // 
            this.QuestColumn.Text = "Quest";
            this.QuestColumn.Width = 236;
            // 
            // AddQuest
            // 
            this.AddQuest.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddQuest.Location = new System.Drawing.Point(12, 293);
            this.AddQuest.Name = "AddQuest";
            this.AddQuest.Size = new System.Drawing.Size(30, 30);
            this.AddQuest.TabIndex = 1;
            this.AddQuest.Text = "+";
            this.AddQuest.UseVisualStyleBackColor = true;
            this.AddQuest.Click += new System.EventHandler(this.AddQuestWithID);
            // 
            // RemoveQuest
            // 
            this.RemoveQuest.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveQuest.Location = new System.Drawing.Point(48, 293);
            this.RemoveQuest.Name = "RemoveQuest";
            this.RemoveQuest.Size = new System.Drawing.Size(30, 30);
            this.RemoveQuest.TabIndex = 2;
            this.RemoveQuest.Text = "-";
            this.RemoveQuest.UseVisualStyleBackColor = true;
            this.RemoveQuest.Click += new System.EventHandler(this.RemoveQuestWithID);
            // 
            // QuestIDValue
            // 
            this.QuestIDValue.Location = new System.Drawing.Point(84, 299);
            this.QuestIDValue.Name = "QuestIDValue";
            this.QuestIDValue.Size = new System.Drawing.Size(238, 20);
            this.QuestIDValue.TabIndex = 3;
            // 
            // TTLocalizerOpen
            // 
            this.TTLocalizerOpen.Location = new System.Drawing.Point(12, 12);
            this.TTLocalizerOpen.Name = "TTLocalizerOpen";
            this.TTLocalizerOpen.Size = new System.Drawing.Size(108, 23);
            this.TTLocalizerOpen.TabIndex = 4;
            this.TTLocalizerOpen.Text = "Select TTLocalizer";
            this.TTLocalizerOpen.UseVisualStyleBackColor = true;
            this.TTLocalizerOpen.Click += new System.EventHandler(this.SelectLocalizer);
            // 
            // TTLocalizerValue
            // 
            this.TTLocalizerValue.Location = new System.Drawing.Point(126, 15);
            this.TTLocalizerValue.Name = "TTLocalizerValue";
            this.TTLocalizerValue.ReadOnly = true;
            this.TTLocalizerValue.Size = new System.Drawing.Size(196, 20);
            this.TTLocalizerValue.TabIndex = 5;
            // 
            // QuestLabel
            // 
            this.QuestLabel.Location = new System.Drawing.Point(328, 18);
            this.QuestLabel.Name = "QuestLabel";
            this.QuestLabel.Size = new System.Drawing.Size(128, 13);
            this.QuestLabel.TabIndex = 6;
            this.QuestLabel.Text = "Quest";
            // 
            // GreetingLabel
            // 
            this.GreetingLabel.Location = new System.Drawing.Point(456, 18);
            this.GreetingLabel.Name = "GreetingLabel";
            this.GreetingLabel.Size = new System.Drawing.Size(128, 13);
            this.GreetingLabel.TabIndex = 7;
            this.GreetingLabel.Text = "Greeting";
            // 
            // QuestValue
            // 
            this.QuestValue.Location = new System.Drawing.Point(331, 34);
            this.QuestValue.Name = "QuestValue";
            this.QuestValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.QuestValue.Size = new System.Drawing.Size(125, 73);
            this.QuestValue.TabIndex = 8;
            this.QuestValue.Text = "";
            // 
            // GreetingValue
            // 
            this.GreetingValue.Location = new System.Drawing.Point(459, 34);
            this.GreetingValue.Name = "GreetingValue";
            this.GreetingValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.GreetingValue.Size = new System.Drawing.Size(125, 73);
            this.GreetingValue.TabIndex = 9;
            this.GreetingValue.Text = "";
            // 
            // CompleteLabel
            // 
            this.CompleteLabel.Location = new System.Drawing.Point(328, 110);
            this.CompleteLabel.Name = "CompleteLabel";
            this.CompleteLabel.Size = new System.Drawing.Size(128, 13);
            this.CompleteLabel.TabIndex = 10;
            this.CompleteLabel.Text = "Complete";
            // 
            // LeavingLabel
            // 
            this.LeavingLabel.Location = new System.Drawing.Point(456, 110);
            this.LeavingLabel.Name = "LeavingLabel";
            this.LeavingLabel.Size = new System.Drawing.Size(128, 13);
            this.LeavingLabel.TabIndex = 11;
            this.LeavingLabel.Text = "Leaving";
            // 
            // CompleteValue
            // 
            this.CompleteValue.Location = new System.Drawing.Point(331, 126);
            this.CompleteValue.Name = "CompleteValue";
            this.CompleteValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.CompleteValue.Size = new System.Drawing.Size(125, 73);
            this.CompleteValue.TabIndex = 12;
            this.CompleteValue.Text = "";
            // 
            // LeavingValue
            // 
            this.LeavingValue.Location = new System.Drawing.Point(462, 126);
            this.LeavingValue.Name = "LeavingValue";
            this.LeavingValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.LeavingValue.Size = new System.Drawing.Size(125, 73);
            this.LeavingValue.TabIndex = 13;
            this.LeavingValue.Text = "";
            // 
            // IncompleteLabel
            // 
            this.IncompleteLabel.Location = new System.Drawing.Point(328, 202);
            this.IncompleteLabel.Name = "IncompleteLabel";
            this.IncompleteLabel.Size = new System.Drawing.Size(128, 13);
            this.IncompleteLabel.TabIndex = 14;
            this.IncompleteLabel.Text = "Incomplete";
            // 
            // WrongNPCLabel
            // 
            this.WrongNPCLabel.Location = new System.Drawing.Point(459, 202);
            this.WrongNPCLabel.Name = "WrongNPCLabel";
            this.WrongNPCLabel.Size = new System.Drawing.Size(128, 13);
            this.WrongNPCLabel.TabIndex = 15;
            this.WrongNPCLabel.Text = "Wrong NPC";
            // 
            // IncompleteValue
            // 
            this.IncompleteValue.Location = new System.Drawing.Point(331, 218);
            this.IncompleteValue.Name = "IncompleteValue";
            this.IncompleteValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.IncompleteValue.Size = new System.Drawing.Size(125, 73);
            this.IncompleteValue.TabIndex = 16;
            this.IncompleteValue.Text = "";
            // 
            // WrongNPCValue
            // 
            this.WrongNPCValue.Location = new System.Drawing.Point(459, 218);
            this.WrongNPCValue.Name = "WrongNPCValue";
            this.WrongNPCValue.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.WrongNPCValue.Size = new System.Drawing.Size(125, 73);
            this.WrongNPCValue.TabIndex = 17;
            this.WrongNPCValue.Text = "";
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(331, 293);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(125, 30);
            this.SaveButton.TabIndex = 18;
            this.SaveButton.Text = "Save Dialog";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveCurrent);
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(459, 293);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(125, 30);
            this.ApplyButton.TabIndex = 19;
            this.ApplyButton.Text = "Apply Changes";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.SaveToFile);
            // 
            // QuestDialogTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 331);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.WrongNPCValue);
            this.Controls.Add(this.IncompleteValue);
            this.Controls.Add(this.WrongNPCLabel);
            this.Controls.Add(this.IncompleteLabel);
            this.Controls.Add(this.LeavingValue);
            this.Controls.Add(this.CompleteValue);
            this.Controls.Add(this.LeavingLabel);
            this.Controls.Add(this.CompleteLabel);
            this.Controls.Add(this.GreetingValue);
            this.Controls.Add(this.QuestValue);
            this.Controls.Add(this.GreetingLabel);
            this.Controls.Add(this.QuestLabel);
            this.Controls.Add(this.TTLocalizerValue);
            this.Controls.Add(this.TTLocalizerOpen);
            this.Controls.Add(this.QuestIDValue);
            this.Controls.Add(this.RemoveQuest);
            this.Controls.Add(this.AddQuest);
            this.Controls.Add(this.DialogBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuestDialogTool";
            this.Text = "Quest Dialog Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView DialogBox;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader QuestColumn;
        private System.Windows.Forms.Button AddQuest;
        private System.Windows.Forms.Button RemoveQuest;
        private System.Windows.Forms.TextBox QuestIDValue;
        private System.Windows.Forms.Button TTLocalizerOpen;
        private System.Windows.Forms.TextBox TTLocalizerValue;
        private System.Windows.Forms.Label QuestLabel;
        private System.Windows.Forms.Label GreetingLabel;
        private System.Windows.Forms.RichTextBox QuestValue;
        private System.Windows.Forms.RichTextBox GreetingValue;
        private System.Windows.Forms.Label CompleteLabel;
        private System.Windows.Forms.Label LeavingLabel;
        private System.Windows.Forms.RichTextBox CompleteValue;
        private System.Windows.Forms.RichTextBox LeavingValue;
        private System.Windows.Forms.Label IncompleteLabel;
        private System.Windows.Forms.Label WrongNPCLabel;
        private System.Windows.Forms.RichTextBox IncompleteValue;
        private System.Windows.Forms.RichTextBox WrongNPCValue;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ApplyButton;
    }
}