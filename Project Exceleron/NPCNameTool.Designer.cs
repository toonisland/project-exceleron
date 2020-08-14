namespace Project_Exceleron
{
    partial class NPCNameTool
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
            this.ItemIDValue = new System.Windows.Forms.TextBox();
            this.RemoveItem = new System.Windows.Forms.Button();
            this.AddItem = new System.Windows.Forms.Button();
            this.Items = new System.Windows.Forms.ListView();
            this.IDColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NPCName = new System.Windows.Forms.TextBox();
            this.SaveItem = new System.Windows.Forms.Button();
            this.SaveFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TTLocalizerValue
            // 
            this.TTLocalizerValue.Location = new System.Drawing.Point(126, 15);
            this.TTLocalizerValue.Name = "TTLocalizerValue";
            this.TTLocalizerValue.ReadOnly = true;
            this.TTLocalizerValue.Size = new System.Drawing.Size(196, 20);
            this.TTLocalizerValue.TabIndex = 11;
            // 
            // TTLocalizerOpen
            // 
            this.TTLocalizerOpen.Location = new System.Drawing.Point(12, 12);
            this.TTLocalizerOpen.Name = "TTLocalizerOpen";
            this.TTLocalizerOpen.Size = new System.Drawing.Size(108, 23);
            this.TTLocalizerOpen.TabIndex = 10;
            this.TTLocalizerOpen.Text = "Select TTLocalizer";
            this.TTLocalizerOpen.UseVisualStyleBackColor = true;
            this.TTLocalizerOpen.Click += new System.EventHandler(this.SelectLocalizer);
            // 
            // ItemIDValue
            // 
            this.ItemIDValue.Location = new System.Drawing.Point(84, 211);
            this.ItemIDValue.Name = "ItemIDValue";
            this.ItemIDValue.Size = new System.Drawing.Size(238, 20);
            this.ItemIDValue.TabIndex = 9;
            // 
            // RemoveItem
            // 
            this.RemoveItem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveItem.Location = new System.Drawing.Point(48, 205);
            this.RemoveItem.Name = "RemoveItem";
            this.RemoveItem.Size = new System.Drawing.Size(30, 30);
            this.RemoveItem.TabIndex = 8;
            this.RemoveItem.Text = "-";
            this.RemoveItem.UseVisualStyleBackColor = true;
            this.RemoveItem.Click += new System.EventHandler(this.RemoveItemWithID);
            // 
            // AddItem
            // 
            this.AddItem.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem.Location = new System.Drawing.Point(12, 205);
            this.AddItem.Name = "AddItem";
            this.AddItem.Size = new System.Drawing.Size(30, 30);
            this.AddItem.TabIndex = 7;
            this.AddItem.Text = "+";
            this.AddItem.UseVisualStyleBackColor = true;
            this.AddItem.Click += new System.EventHandler(this.AddItemWithID);
            // 
            // Items
            // 
            this.Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IDColumn,
            this.NameColumn});
            this.Items.FullRowSelect = true;
            this.Items.HideSelection = false;
            this.Items.Location = new System.Drawing.Point(12, 41);
            this.Items.MultiSelect = false;
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(310, 158);
            this.Items.TabIndex = 6;
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
            // NPCName
            // 
            this.NPCName.Location = new System.Drawing.Point(12, 241);
            this.NPCName.Name = "NPCName";
            this.NPCName.Size = new System.Drawing.Size(310, 20);
            this.NPCName.TabIndex = 12;
            // 
            // SaveItem
            // 
            this.SaveItem.Location = new System.Drawing.Point(12, 267);
            this.SaveItem.Name = "SaveItem";
            this.SaveItem.Size = new System.Drawing.Size(153, 31);
            this.SaveItem.TabIndex = 18;
            this.SaveItem.Text = "Save NPC";
            this.SaveItem.UseVisualStyleBackColor = true;
            this.SaveItem.Click += new System.EventHandler(this.SaveCurrent);
            // 
            // SaveFile
            // 
            this.SaveFile.Location = new System.Drawing.Point(169, 267);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(153, 31);
            this.SaveFile.TabIndex = 19;
            this.SaveFile.Text = "Apply Changes";
            this.SaveFile.UseVisualStyleBackColor = true;
            this.SaveFile.Click += new System.EventHandler(this.SaveToFile);
            // 
            // NPCNameTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 311);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.SaveItem);
            this.Controls.Add(this.NPCName);
            this.Controls.Add(this.TTLocalizerValue);
            this.Controls.Add(this.TTLocalizerOpen);
            this.Controls.Add(this.ItemIDValue);
            this.Controls.Add(this.RemoveItem);
            this.Controls.Add(this.AddItem);
            this.Controls.Add(this.Items);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NPCNameTool";
            this.Text = "NPC Name Tool";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TTLocalizerValue;
        private System.Windows.Forms.Button TTLocalizerOpen;
        private System.Windows.Forms.TextBox ItemIDValue;
        private System.Windows.Forms.Button RemoveItem;
        private System.Windows.Forms.Button AddItem;
        private System.Windows.Forms.ListView Items;
        private System.Windows.Forms.ColumnHeader IDColumn;
        private System.Windows.Forms.ColumnHeader NameColumn;
        private System.Windows.Forms.TextBox NPCName;
        private System.Windows.Forms.Button SaveItem;
        private System.Windows.Forms.Button SaveFile;
    }
}