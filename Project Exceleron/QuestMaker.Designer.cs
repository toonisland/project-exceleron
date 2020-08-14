namespace Project_Exceleron
{
    partial class QuestMaker
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
            this.QuestFileButton = new System.Windows.Forms.Button();
            this.QuestDictLabel = new System.Windows.Forms.Label();
            this.QuestFileView = new System.Windows.Forms.TextBox();
            this.QuestDictValue = new System.Windows.Forms.TextBox();
            this.RequiredQuestAdd = new System.Windows.Forms.Button();
            this.RequiredQuestValue = new System.Windows.Forms.TextBox();
            this.QuestClassAdd = new System.Windows.Forms.Button();
            this.QuestClassValue = new System.Windows.Forms.TextBox();
            this.StartingQuest = new System.Windows.Forms.Button();
            this.ContinuedQuest = new System.Windows.Forms.Button();
            this.StartingNPCLabel = new System.Windows.Forms.Label();
            this.StartingNPCValue = new System.Windows.Forms.TextBox();
            this.ToNPCLabel = new System.Windows.Forms.Label();
            this.ToNPCValue = new System.Windows.Forms.TextBox();
            this.RewardLabel = new System.Windows.Forms.Label();
            this.RewardValue = new System.Windows.Forms.TextBox();
            this.NextQuestLabel = new System.Windows.Forms.Label();
            this.NextQuestValue = new System.Windows.Forms.TextBox();
            this.DialogLabel = new System.Windows.Forms.Label();
            this.DialogValue = new System.Windows.Forms.TextBox();
            this.ExpLabel = new System.Windows.Forms.Label();
            this.ExpRewardValue = new System.Windows.Forms.TextBox();
            this.JBRewardLabel = new System.Windows.Forms.Label();
            this.JBRewardValue = new System.Windows.Forms.TextBox();
            this.ResultBox = new System.Windows.Forms.RichTextBox();
            this.Reset = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.AddToQuests = new System.Windows.Forms.Button();
            this.QuestIDLabel = new System.Windows.Forms.Label();
            this.QuestIDValue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // QuestFileButton
            // 
            this.QuestFileButton.Location = new System.Drawing.Point(12, 9);
            this.QuestFileButton.Name = "QuestFileButton";
            this.QuestFileButton.Size = new System.Drawing.Size(108, 23);
            this.QuestFileButton.TabIndex = 1;
            this.QuestFileButton.Text = "Select Quests.py";
            this.QuestFileButton.UseVisualStyleBackColor = true;
            this.QuestFileButton.Click += new System.EventHandler(this.SelectQuestFile);
            // 
            // QuestDictLabel
            // 
            this.QuestDictLabel.AutoSize = true;
            this.QuestDictLabel.Location = new System.Drawing.Point(20, 40);
            this.QuestDictLabel.Name = "QuestDictLabel";
            this.QuestDictLabel.Size = new System.Drawing.Size(100, 13);
            this.QuestDictLabel.TabIndex = 3;
            this.QuestDictLabel.Text = "QuestDict Last Line";
            // 
            // QuestFileView
            // 
            this.QuestFileView.Location = new System.Drawing.Point(126, 11);
            this.QuestFileView.Name = "QuestFileView";
            this.QuestFileView.ReadOnly = true;
            this.QuestFileView.Size = new System.Drawing.Size(387, 20);
            this.QuestFileView.TabIndex = 4;
            // 
            // QuestDictValue
            // 
            this.QuestDictValue.Location = new System.Drawing.Point(126, 37);
            this.QuestDictValue.Name = "QuestDictValue";
            this.QuestDictValue.Size = new System.Drawing.Size(387, 20);
            this.QuestDictValue.TabIndex = 5;
            this.QuestDictValue.TextChanged += new System.EventHandler(this.SetLastLine);
            // 
            // RequiredQuestAdd
            // 
            this.RequiredQuestAdd.Location = new System.Drawing.Point(12, 70);
            this.RequiredQuestAdd.Name = "RequiredQuestAdd";
            this.RequiredQuestAdd.Size = new System.Drawing.Size(188, 23);
            this.RequiredQuestAdd.TabIndex = 6;
            this.RequiredQuestAdd.Text = "Add Required Quest";
            this.RequiredQuestAdd.UseVisualStyleBackColor = true;
            this.RequiredQuestAdd.Click += new System.EventHandler(this.AddRequiredQuest);
            // 
            // RequiredQuestValue
            // 
            this.RequiredQuestValue.Location = new System.Drawing.Point(206, 73);
            this.RequiredQuestValue.Name = "RequiredQuestValue";
            this.RequiredQuestValue.Size = new System.Drawing.Size(307, 20);
            this.RequiredQuestValue.TabIndex = 7;
            // 
            // QuestClassAdd
            // 
            this.QuestClassAdd.Location = new System.Drawing.Point(12, 99);
            this.QuestClassAdd.Name = "QuestClassAdd";
            this.QuestClassAdd.Size = new System.Drawing.Size(188, 23);
            this.QuestClassAdd.TabIndex = 8;
            this.QuestClassAdd.Text = "Add Quest Class";
            this.QuestClassAdd.UseVisualStyleBackColor = true;
            this.QuestClassAdd.Click += new System.EventHandler(this.AddQuestClass);
            // 
            // QuestClassValue
            // 
            this.QuestClassValue.Location = new System.Drawing.Point(206, 99);
            this.QuestClassValue.Name = "QuestClassValue";
            this.QuestClassValue.Size = new System.Drawing.Size(307, 20);
            this.QuestClassValue.TabIndex = 9;
            // 
            // StartingQuest
            // 
            this.StartingQuest.Location = new System.Drawing.Point(12, 129);
            this.StartingQuest.Name = "StartingQuest";
            this.StartingQuest.Size = new System.Drawing.Size(248, 23);
            this.StartingQuest.TabIndex = 10;
            this.StartingQuest.Text = "Starting Quest";
            this.StartingQuest.UseVisualStyleBackColor = true;
            this.StartingQuest.Click += new System.EventHandler(this.SetStartingQuest);
            // 
            // ContinuedQuest
            // 
            this.ContinuedQuest.Location = new System.Drawing.Point(265, 129);
            this.ContinuedQuest.Name = "ContinuedQuest";
            this.ContinuedQuest.Size = new System.Drawing.Size(248, 23);
            this.ContinuedQuest.TabIndex = 11;
            this.ContinuedQuest.Text = "Continued Quest";
            this.ContinuedQuest.UseVisualStyleBackColor = true;
            this.ContinuedQuest.Click += new System.EventHandler(this.SetContinuedQuest);
            // 
            // StartingNPCLabel
            // 
            this.StartingNPCLabel.Location = new System.Drawing.Point(9, 187);
            this.StartingNPCLabel.Name = "StartingNPCLabel";
            this.StartingNPCLabel.Size = new System.Drawing.Size(191, 15);
            this.StartingNPCLabel.TabIndex = 12;
            this.StartingNPCLabel.Text = "Starting NPC";
            // 
            // StartingNPCValue
            // 
            this.StartingNPCValue.Location = new System.Drawing.Point(206, 184);
            this.StartingNPCValue.Name = "StartingNPCValue";
            this.StartingNPCValue.Size = new System.Drawing.Size(307, 20);
            this.StartingNPCValue.TabIndex = 13;
            this.StartingNPCValue.TextChanged += new System.EventHandler(this.SetStartingNPC);
            // 
            // ToNPCLabel
            // 
            this.ToNPCLabel.Location = new System.Drawing.Point(9, 213);
            this.ToNPCLabel.Name = "ToNPCLabel";
            this.ToNPCLabel.Size = new System.Drawing.Size(191, 15);
            this.ToNPCLabel.TabIndex = 14;
            this.ToNPCLabel.Text = "To NPC";
            // 
            // ToNPCValue
            // 
            this.ToNPCValue.Location = new System.Drawing.Point(206, 210);
            this.ToNPCValue.Name = "ToNPCValue";
            this.ToNPCValue.Size = new System.Drawing.Size(307, 20);
            this.ToNPCValue.TabIndex = 15;
            this.ToNPCValue.TextChanged += new System.EventHandler(this.SetToNPC);
            // 
            // RewardLabel
            // 
            this.RewardLabel.Location = new System.Drawing.Point(9, 239);
            this.RewardLabel.Name = "RewardLabel";
            this.RewardLabel.Size = new System.Drawing.Size(191, 16);
            this.RewardLabel.TabIndex = 16;
            this.RewardLabel.Text = "Reward";
            // 
            // RewardValue
            // 
            this.RewardValue.Location = new System.Drawing.Point(206, 236);
            this.RewardValue.Name = "RewardValue";
            this.RewardValue.Size = new System.Drawing.Size(307, 20);
            this.RewardValue.TabIndex = 17;
            this.RewardValue.TextChanged += new System.EventHandler(this.SetReward);
            // 
            // NextQuestLabel
            // 
            this.NextQuestLabel.Location = new System.Drawing.Point(9, 265);
            this.NextQuestLabel.Name = "NextQuestLabel";
            this.NextQuestLabel.Size = new System.Drawing.Size(191, 16);
            this.NextQuestLabel.TabIndex = 18;
            this.NextQuestLabel.Text = "Next Quest";
            // 
            // NextQuestValue
            // 
            this.NextQuestValue.Location = new System.Drawing.Point(206, 262);
            this.NextQuestValue.Name = "NextQuestValue";
            this.NextQuestValue.Size = new System.Drawing.Size(307, 20);
            this.NextQuestValue.TabIndex = 19;
            this.NextQuestValue.TextChanged += new System.EventHandler(this.SetNextQuest);
            // 
            // DialogLabel
            // 
            this.DialogLabel.Location = new System.Drawing.Point(9, 291);
            this.DialogLabel.Name = "DialogLabel";
            this.DialogLabel.Size = new System.Drawing.Size(191, 16);
            this.DialogLabel.TabIndex = 20;
            this.DialogLabel.Text = "Dialog Number";
            // 
            // DialogValue
            // 
            this.DialogValue.Location = new System.Drawing.Point(206, 288);
            this.DialogValue.Name = "DialogValue";
            this.DialogValue.Size = new System.Drawing.Size(307, 20);
            this.DialogValue.TabIndex = 21;
            this.DialogValue.TextChanged += new System.EventHandler(this.SetDialogNumber);
            // 
            // ExpLabel
            // 
            this.ExpLabel.Location = new System.Drawing.Point(9, 317);
            this.ExpLabel.Name = "ExpLabel";
            this.ExpLabel.Size = new System.Drawing.Size(191, 16);
            this.ExpLabel.TabIndex = 22;
            this.ExpLabel.Text = "EXP Reward";
            // 
            // ExpRewardValue
            // 
            this.ExpRewardValue.Location = new System.Drawing.Point(206, 313);
            this.ExpRewardValue.Name = "ExpRewardValue";
            this.ExpRewardValue.Size = new System.Drawing.Size(307, 20);
            this.ExpRewardValue.TabIndex = 23;
            this.ExpRewardValue.TextChanged += new System.EventHandler(this.SetExpReward);
            // 
            // JBRewardLabel
            // 
            this.JBRewardLabel.Location = new System.Drawing.Point(9, 342);
            this.JBRewardLabel.Name = "JBRewardLabel";
            this.JBRewardLabel.Size = new System.Drawing.Size(191, 16);
            this.JBRewardLabel.TabIndex = 24;
            this.JBRewardLabel.Text = "Jellybean Reward";
            // 
            // JBRewardValue
            // 
            this.JBRewardValue.Location = new System.Drawing.Point(206, 339);
            this.JBRewardValue.Name = "JBRewardValue";
            this.JBRewardValue.Size = new System.Drawing.Size(307, 20);
            this.JBRewardValue.TabIndex = 25;
            this.JBRewardValue.TextChanged += new System.EventHandler(this.SetJBReward);
            // 
            // ResultBox
            // 
            this.ResultBox.Location = new System.Drawing.Point(12, 365);
            this.ResultBox.Name = "ResultBox";
            this.ResultBox.Size = new System.Drawing.Size(338, 55);
            this.ResultBox.TabIndex = 26;
            this.ResultBox.Text = "";
            // 
            // Reset
            // 
            this.Reset.Location = new System.Drawing.Point(356, 365);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(157, 26);
            this.Reset.TabIndex = 27;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.DoReset);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(356, 394);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(157, 26);
            this.Generate.TabIndex = 28;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.ManualGenerate);
            // 
            // AddToQuests
            // 
            this.AddToQuests.Location = new System.Drawing.Point(12, 426);
            this.AddToQuests.Name = "AddToQuests";
            this.AddToQuests.Size = new System.Drawing.Size(501, 33);
            this.AddToQuests.TabIndex = 29;
            this.AddToQuests.Text = "Add To Quests";
            this.AddToQuests.UseVisualStyleBackColor = true;
            this.AddToQuests.Click += new System.EventHandler(this.WriteToQuests);
            // 
            // QuestIDLabel
            // 
            this.QuestIDLabel.Location = new System.Drawing.Point(9, 163);
            this.QuestIDLabel.Name = "QuestIDLabel";
            this.QuestIDLabel.Size = new System.Drawing.Size(191, 15);
            this.QuestIDLabel.TabIndex = 30;
            this.QuestIDLabel.Text = "Quest ID";
            // 
            // QuestIDValue
            // 
            this.QuestIDValue.Location = new System.Drawing.Point(206, 158);
            this.QuestIDValue.Name = "QuestIDValue";
            this.QuestIDValue.Size = new System.Drawing.Size(307, 20);
            this.QuestIDValue.TabIndex = 31;
            this.QuestIDValue.TextChanged += new System.EventHandler(this.SetQuestID);
            // 
            // QuestMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 468);
            this.Controls.Add(this.QuestIDValue);
            this.Controls.Add(this.QuestIDLabel);
            this.Controls.Add(this.AddToQuests);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.ResultBox);
            this.Controls.Add(this.JBRewardValue);
            this.Controls.Add(this.JBRewardLabel);
            this.Controls.Add(this.ExpRewardValue);
            this.Controls.Add(this.ExpLabel);
            this.Controls.Add(this.DialogValue);
            this.Controls.Add(this.DialogLabel);
            this.Controls.Add(this.NextQuestValue);
            this.Controls.Add(this.NextQuestLabel);
            this.Controls.Add(this.RewardValue);
            this.Controls.Add(this.RewardLabel);
            this.Controls.Add(this.ToNPCValue);
            this.Controls.Add(this.ToNPCLabel);
            this.Controls.Add(this.StartingNPCValue);
            this.Controls.Add(this.StartingNPCLabel);
            this.Controls.Add(this.ContinuedQuest);
            this.Controls.Add(this.StartingQuest);
            this.Controls.Add(this.QuestClassValue);
            this.Controls.Add(this.QuestClassAdd);
            this.Controls.Add(this.RequiredQuestValue);
            this.Controls.Add(this.RequiredQuestAdd);
            this.Controls.Add(this.QuestDictValue);
            this.Controls.Add(this.QuestFileView);
            this.Controls.Add(this.QuestDictLabel);
            this.Controls.Add(this.QuestFileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "QuestMaker";
            this.Text = "QuestMaker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button QuestFileButton;
        private System.Windows.Forms.Label QuestDictLabel;
        private System.Windows.Forms.TextBox QuestFileView;
        private System.Windows.Forms.TextBox QuestDictValue;
        private System.Windows.Forms.Button RequiredQuestAdd;
        private System.Windows.Forms.TextBox RequiredQuestValue;
        private System.Windows.Forms.Button QuestClassAdd;
        private System.Windows.Forms.TextBox QuestClassValue;
        private System.Windows.Forms.Button StartingQuest;
        private System.Windows.Forms.Button ContinuedQuest;
        private System.Windows.Forms.Label StartingNPCLabel;
        private System.Windows.Forms.TextBox StartingNPCValue;
        private System.Windows.Forms.Label ToNPCLabel;
        private System.Windows.Forms.TextBox ToNPCValue;
        private System.Windows.Forms.Label RewardLabel;
        private System.Windows.Forms.TextBox RewardValue;
        private System.Windows.Forms.Label NextQuestLabel;
        private System.Windows.Forms.TextBox NextQuestValue;
        private System.Windows.Forms.Label DialogLabel;
        private System.Windows.Forms.TextBox DialogValue;
        private System.Windows.Forms.Label ExpLabel;
        private System.Windows.Forms.TextBox ExpRewardValue;
        private System.Windows.Forms.Label JBRewardLabel;
        private System.Windows.Forms.TextBox JBRewardValue;
        private System.Windows.Forms.RichTextBox ResultBox;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button AddToQuests;
        private System.Windows.Forms.Label QuestIDLabel;
        private System.Windows.Forms.TextBox QuestIDValue;
    }
}