namespace Project_Exceleron
{
    partial class NPCTool
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
            this.TTLocalizerValue = new System.Windows.Forms.TextBox();
            this.TTLocalizerOpen = new System.Windows.Forms.Button();
            this.NPCToonsValue = new System.Windows.Forms.TextBox();
            this.NPCToonsOpen = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GenderBox = new System.Windows.Forms.ComboBox();
            this.GenRandom = new System.Windows.Forms.Button();
            this.SpeciesBox = new System.Windows.Forms.ComboBox();
            this.MuzzleBox = new System.Windows.Forms.ComboBox();
            this.HeadBox = new System.Windows.Forms.ComboBox();
            this.TorsoBox = new System.Windows.Forms.ComboBox();
            this.ClothesBox = new System.Windows.Forms.ComboBox();
            this.LegBox = new System.Windows.Forms.ComboBox();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            this.ZoneBox = new System.Windows.Forms.TextBox();
            this.ToptexLabel = new System.Windows.Forms.Label();
            this.Toptex = new System.Windows.Forms.TextBox();
            this.ToptexColor = new System.Windows.Forms.TextBox();
            this.BottexLabel = new System.Windows.Forms.Label();
            this.Bottex = new System.Windows.Forms.TextBox();
            this.BottexColor = new System.Windows.Forms.TextBox();
            this.SaveNPC = new System.Windows.Forms.Button();
            this.ApplyChanges = new System.Windows.Forms.Button();
            this.Sleevetex = new System.Windows.Forms.TextBox();
            this.SleevetexColor = new System.Windows.Forms.TextBox();
            this.SleevetexLabel = new System.Windows.Forms.Label();
            this.ColorDialog = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // TTLocalizerValue
            // 
            this.TTLocalizerValue.Location = new System.Drawing.Point(126, 15);
            this.TTLocalizerValue.Name = "TTLocalizerValue";
            this.TTLocalizerValue.ReadOnly = true;
            this.TTLocalizerValue.Size = new System.Drawing.Size(196, 20);
            this.TTLocalizerValue.TabIndex = 13;
            // 
            // TTLocalizerOpen
            // 
            this.TTLocalizerOpen.Location = new System.Drawing.Point(12, 12);
            this.TTLocalizerOpen.Name = "TTLocalizerOpen";
            this.TTLocalizerOpen.Size = new System.Drawing.Size(108, 23);
            this.TTLocalizerOpen.TabIndex = 12;
            this.TTLocalizerOpen.Text = "Select TTLocalizer";
            this.TTLocalizerOpen.UseVisualStyleBackColor = true;
            this.TTLocalizerOpen.Click += new System.EventHandler(this.OpenLocalizer);
            // 
            // NPCToonsValue
            // 
            this.NPCToonsValue.Location = new System.Drawing.Point(126, 41);
            this.NPCToonsValue.Name = "NPCToonsValue";
            this.NPCToonsValue.ReadOnly = true;
            this.NPCToonsValue.Size = new System.Drawing.Size(196, 20);
            this.NPCToonsValue.TabIndex = 15;
            // 
            // NPCToonsOpen
            // 
            this.NPCToonsOpen.Location = new System.Drawing.Point(12, 41);
            this.NPCToonsOpen.Name = "NPCToonsOpen";
            this.NPCToonsOpen.Size = new System.Drawing.Size(108, 23);
            this.NPCToonsOpen.TabIndex = 14;
            this.NPCToonsOpen.Text = "Select NPCToons";
            this.NPCToonsOpen.UseVisualStyleBackColor = true;
            this.NPCToonsOpen.Click += new System.EventHandler(this.OpenNPCToons);
            // 
            // Items
            // 
            this.Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.NameColumn});
            this.Items.FullRowSelect = true;
            this.Items.HideSelection = false;
            this.Items.Location = new System.Drawing.Point(12, 70);
            this.Items.MultiSelect = false;
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(310, 234);
            this.Items.TabIndex = 16;
            this.Items.UseCompatibleStateImageBehavior = false;
            this.Items.View = System.Windows.Forms.View.Details;
            this.Items.SelectedIndexChanged += new System.EventHandler(this.SelectionChanged);
            // 
            // IDColumn
            // 
            this.IDColumn.Text = "ID";
            this.IDColumn.Width = 70;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Name";
            this.NameColumn.Width = 236;
            // 
            // GenderBox
            // 
            this.GenderBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GenderBox.FormattingEnabled = true;
            this.GenderBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderBox.Location = new System.Drawing.Point(328, 40);
            this.GenderBox.Name = "GenderBox";
            this.GenderBox.Size = new System.Drawing.Size(173, 21);
            this.GenderBox.TabIndex = 17;
            // 
            // GenRandom
            // 
            this.GenRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GenRandom.Location = new System.Drawing.Point(328, 12);
            this.GenRandom.Name = "GenRandom";
            this.GenRandom.Size = new System.Drawing.Size(352, 23);
            this.GenRandom.TabIndex = 18;
            this.GenRandom.Text = "Generate Random";
            this.GenRandom.UseVisualStyleBackColor = true;
            this.GenRandom.Click += new System.EventHandler(this.DoGenRandom);
            // 
            // SpeciesBox
            // 
            this.SpeciesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpeciesBox.FormattingEnabled = true;
            this.SpeciesBox.Items.AddRange(new object[] {
            "Dog",
            "Cat",
            "Horse",
            "Mouse",
            "Rabbit",
            "Duck",
            "Monkey",
            "Bear",
            "Pig",
            "Deer"});
            this.SpeciesBox.Location = new System.Drawing.Point(507, 40);
            this.SpeciesBox.Name = "SpeciesBox";
            this.SpeciesBox.Size = new System.Drawing.Size(173, 21);
            this.SpeciesBox.TabIndex = 19;
            // 
            // MuzzleBox
            // 
            this.MuzzleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MuzzleBox.FormattingEnabled = true;
            this.MuzzleBox.Items.AddRange(new object[] {
            "Long Muzzle",
            "Short Muzzle"});
            this.MuzzleBox.Location = new System.Drawing.Point(507, 67);
            this.MuzzleBox.Name = "MuzzleBox";
            this.MuzzleBox.Size = new System.Drawing.Size(173, 21);
            this.MuzzleBox.TabIndex = 20;
            // 
            // HeadBox
            // 
            this.HeadBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.HeadBox.FormattingEnabled = true;
            this.HeadBox.Items.AddRange(new object[] {
            "Long Head",
            "Short Head"});
            this.HeadBox.Location = new System.Drawing.Point(328, 67);
            this.HeadBox.Name = "HeadBox";
            this.HeadBox.Size = new System.Drawing.Size(173, 21);
            this.HeadBox.TabIndex = 20;
            // 
            // TorsoBox
            // 
            this.TorsoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TorsoBox.FormattingEnabled = true;
            this.TorsoBox.Items.AddRange(new object[] {
            "Long Torso",
            "Medium Torso",
            "Short Torso"});
            this.TorsoBox.Location = new System.Drawing.Point(328, 94);
            this.TorsoBox.Name = "TorsoBox";
            this.TorsoBox.Size = new System.Drawing.Size(173, 21);
            this.TorsoBox.TabIndex = 21;
            // 
            // ClothesBox
            // 
            this.ClothesBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClothesBox.FormattingEnabled = true;
            this.ClothesBox.Items.AddRange(new object[] {
            "Dress",
            "Shorts"});
            this.ClothesBox.Location = new System.Drawing.Point(507, 94);
            this.ClothesBox.Name = "ClothesBox";
            this.ClothesBox.Size = new System.Drawing.Size(173, 21);
            this.ClothesBox.TabIndex = 22;
            // 
            // LegBox
            // 
            this.LegBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LegBox.FormattingEnabled = true;
            this.LegBox.Items.AddRange(new object[] {
            "Long Legs",
            "Medium Legs",
            "Short Legs"});
            this.LegBox.Location = new System.Drawing.Point(329, 121);
            this.LegBox.Name = "LegBox";
            this.LegBox.Size = new System.Drawing.Size(173, 21);
            this.LegBox.TabIndex = 23;
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "Regular",
            "HQ Officer",
            "Clerk",
            "Tailor",
            "Blocker",
            "Fisherman",
            "Partyperson",
            "Special Quest Giver",
            ""});
            this.TypeBox.Location = new System.Drawing.Point(507, 121);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(173, 21);
            this.TypeBox.TabIndex = 24;
            // 
            // ZoneBox
            // 
            this.ZoneBox.Location = new System.Drawing.Point(328, 148);
            this.ZoneBox.Name = "ZoneBox";
            this.ZoneBox.Size = new System.Drawing.Size(352, 20);
            this.ZoneBox.TabIndex = 25;
            // 
            // ToptexLabel
            // 
            this.ToptexLabel.Location = new System.Drawing.Point(328, 175);
            this.ToptexLabel.Name = "ToptexLabel";
            this.ToptexLabel.Size = new System.Drawing.Size(112, 17);
            this.ToptexLabel.TabIndex = 26;
            this.ToptexLabel.Text = "Toptex";
            // 
            // Toptex
            // 
            this.Toptex.Location = new System.Drawing.Point(401, 172);
            this.Toptex.Name = "Toptex";
            this.Toptex.Size = new System.Drawing.Size(137, 20);
            this.Toptex.TabIndex = 27;
            // 
            // ToptexColor
            // 
            this.ToptexColor.Location = new System.Drawing.Point(543, 172);
            this.ToptexColor.Name = "ToptexColor";
            this.ToptexColor.Size = new System.Drawing.Size(137, 20);
            this.ToptexColor.TabIndex = 28;
            // 
            // BottexLabel
            // 
            this.BottexLabel.Location = new System.Drawing.Point(328, 198);
            this.BottexLabel.Name = "BottexLabel";
            this.BottexLabel.Size = new System.Drawing.Size(112, 17);
            this.BottexLabel.TabIndex = 29;
            this.BottexLabel.Text = "Bottex";
            // 
            // Bottex
            // 
            this.Bottex.Location = new System.Drawing.Point(401, 195);
            this.Bottex.Name = "Bottex";
            this.Bottex.Size = new System.Drawing.Size(137, 20);
            this.Bottex.TabIndex = 30;
            // 
            // BottexColor
            // 
            this.BottexColor.Location = new System.Drawing.Point(544, 195);
            this.BottexColor.Name = "BottexColor";
            this.BottexColor.Size = new System.Drawing.Size(137, 20);
            this.BottexColor.TabIndex = 31;
            // 
            // SaveNPC
            // 
            this.SaveNPC.Location = new System.Drawing.Point(328, 273);
            this.SaveNPC.Name = "SaveNPC";
            this.SaveNPC.Size = new System.Drawing.Size(173, 31);
            this.SaveNPC.TabIndex = 33;
            this.SaveNPC.Text = "Save NPC";
            this.SaveNPC.UseVisualStyleBackColor = true;
            this.SaveNPC.Click += new System.EventHandler(this.DoSaveNPC);
            // 
            // ApplyChanges
            // 
            this.ApplyChanges.Location = new System.Drawing.Point(507, 273);
            this.ApplyChanges.Name = "ApplyChanges";
            this.ApplyChanges.Size = new System.Drawing.Size(173, 31);
            this.ApplyChanges.TabIndex = 34;
            this.ApplyChanges.Text = "Apply Changes";
            this.ApplyChanges.UseVisualStyleBackColor = true;
            this.ApplyChanges.Click += new System.EventHandler(this.DoApplyChanges);
            // 
            // Sleevetex
            // 
            this.Sleevetex.Location = new System.Drawing.Point(401, 218);
            this.Sleevetex.Name = "Sleevetex";
            this.Sleevetex.Size = new System.Drawing.Size(137, 20);
            this.Sleevetex.TabIndex = 36;
            // 
            // SleevetexColor
            // 
            this.SleevetexColor.Location = new System.Drawing.Point(544, 218);
            this.SleevetexColor.Name = "SleevetexColor";
            this.SleevetexColor.Size = new System.Drawing.Size(137, 20);
            this.SleevetexColor.TabIndex = 37;
            // 
            // SleevetexLabel
            // 
            this.SleevetexLabel.Location = new System.Drawing.Point(328, 221);
            this.SleevetexLabel.Name = "SleevetexLabel";
            this.SleevetexLabel.Size = new System.Drawing.Size(67, 17);
            this.SleevetexLabel.TabIndex = 38;
            this.SleevetexLabel.Text = "Sleevetex";
            // 
            // NPCTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 317);
            this.Controls.Add(this.SleevetexLabel);
            this.Controls.Add(this.SleevetexColor);
            this.Controls.Add(this.Sleevetex);
            this.Controls.Add(this.ApplyChanges);
            this.Controls.Add(this.SaveNPC);
            this.Controls.Add(this.BottexColor);
            this.Controls.Add(this.Bottex);
            this.Controls.Add(this.BottexLabel);
            this.Controls.Add(this.ToptexColor);
            this.Controls.Add(this.Toptex);
            this.Controls.Add(this.ToptexLabel);
            this.Controls.Add(this.ZoneBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.LegBox);
            this.Controls.Add(this.ClothesBox);
            this.Controls.Add(this.TorsoBox);
            this.Controls.Add(this.HeadBox);
            this.Controls.Add(this.MuzzleBox);
            this.Controls.Add(this.SpeciesBox);
            this.Controls.Add(this.GenRandom);
            this.Controls.Add(this.GenderBox);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.NPCToonsValue);
            this.Controls.Add(this.NPCToonsOpen);
            this.Controls.Add(this.TTLocalizerValue);
            this.Controls.Add(this.TTLocalizerOpen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NPCTool";
            this.Text = "NPC Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TTLocalizerValue;
        private System.Windows.Forms.Button TTLocalizerOpen;
        private System.Windows.Forms.TextBox NPCToonsValue;
        private System.Windows.Forms.Button NPCToonsOpen;
        private System.Windows.Forms.ListView Items;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.ComboBox GenderBox;
        private System.Windows.Forms.Button GenRandom;
        private System.Windows.Forms.ComboBox SpeciesBox;
        private System.Windows.Forms.ComboBox MuzzleBox;
        private System.Windows.Forms.ComboBox HeadBox;
        private System.Windows.Forms.ComboBox TorsoBox;
        private System.Windows.Forms.ComboBox ClothesBox;
        private System.Windows.Forms.ComboBox LegBox;
        private System.Windows.Forms.ComboBox TypeBox;
        private System.Windows.Forms.TextBox ZoneBox;
        private System.Windows.Forms.Label ToptexLabel;
        private System.Windows.Forms.TextBox Toptex;
        private System.Windows.Forms.TextBox ToptexColor;
        private System.Windows.Forms.Label BottexLabel;
        private System.Windows.Forms.TextBox Bottex;
        private System.Windows.Forms.TextBox BottexColor;
        private System.Windows.Forms.Button SaveNPC;
        private System.Windows.Forms.Button ApplyChanges;
        private System.Windows.Forms.TextBox Sleevetex;
        private System.Windows.Forms.TextBox SleevetexColor;
        private System.Windows.Forms.Label SleevetexLabel;
        private System.Windows.Forms.ColorDialog ColorDialog;
    }
}