namespace Project_Exceleron
{
    sealed partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveWorkspaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.presetsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.launcherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moderatioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.questMakerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questModifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NPCTool = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QuestDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.moderationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.typeANameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applicationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creativeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pTexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developmentToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startMongoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fixMongoLockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAstronToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startUberdogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startAIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.localhostToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bam2EggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bam2EggToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.egg2BamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egg2BamToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.egg2ObjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.egg2XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.objsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obj2EggToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.x2ObjToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.NPCNameTool = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.questsToolStripMenuItem1,
            this.localizerToolStripMenuItem,
            this.moderationToolStripMenuItem,
            this.creativeToolStripMenuItem,
            this.developmentToolStripMenuItem1,
            this.toolToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1056, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWorkspaceToolStripMenuItem,
            this.loadWorkspaceToolStripMenuItem,
            this.saveWorkspaceToolStripMenuItem,
            this.presetsToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.fileToolStripMenuItem.Text = "Workspace";
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // newWorkspaceToolStripMenuItem
            // 
            this.newWorkspaceToolStripMenuItem.Name = "newWorkspaceToolStripMenuItem";
            this.newWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.newWorkspaceToolStripMenuItem.Text = "New Workspace";
            this.newWorkspaceToolStripMenuItem.Click += new System.EventHandler(this.newWorkspaceToolStripMenuItem_Click);
            // 
            // loadWorkspaceToolStripMenuItem
            // 
            this.loadWorkspaceToolStripMenuItem.Name = "loadWorkspaceToolStripMenuItem";
            this.loadWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.loadWorkspaceToolStripMenuItem.Text = "Load Workspace";
            // 
            // saveWorkspaceToolStripMenuItem
            // 
            this.saveWorkspaceToolStripMenuItem.Enabled = false;
            this.saveWorkspaceToolStripMenuItem.Name = "saveWorkspaceToolStripMenuItem";
            this.saveWorkspaceToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.saveWorkspaceToolStripMenuItem.Text = "Save Workspace";
            // 
            // presetsToolStripMenuItem
            // 
            this.presetsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.developmentToolStripMenuItem,
            this.moderatioToolStripMenuItem,
            this.questsToolStripMenuItem,
            this.testingToolStripMenuItem});
            this.presetsToolStripMenuItem.Enabled = false;
            this.presetsToolStripMenuItem.Name = "presetsToolStripMenuItem";
            this.presetsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.presetsToolStripMenuItem.Text = "Presets";
            // 
            // developmentToolStripMenuItem
            // 
            this.developmentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.webToolStripMenuItem,
            this.gameToolStripMenuItem,
            this.launcherToolStripMenuItem});
            this.developmentToolStripMenuItem.Name = "developmentToolStripMenuItem";
            this.developmentToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.developmentToolStripMenuItem.Text = "Development";
            // 
            // webToolStripMenuItem
            // 
            this.webToolStripMenuItem.Name = "webToolStripMenuItem";
            this.webToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.webToolStripMenuItem.Text = "Web";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // launcherToolStripMenuItem
            // 
            this.launcherToolStripMenuItem.Name = "launcherToolStripMenuItem";
            this.launcherToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.launcherToolStripMenuItem.Text = "Launcher";
            // 
            // moderatioToolStripMenuItem
            // 
            this.moderatioToolStripMenuItem.Name = "moderatioToolStripMenuItem";
            this.moderatioToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.moderatioToolStripMenuItem.Text = "Moderation";
            this.moderatioToolStripMenuItem.Click += new System.EventHandler(this.moderatioToolStripMenuItem_Click);
            // 
            // questsToolStripMenuItem
            // 
            this.questsToolStripMenuItem.Name = "questsToolStripMenuItem";
            this.questsToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.questsToolStripMenuItem.Text = "Quests";
            // 
            // testingToolStripMenuItem
            // 
            this.testingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem1});
            this.testingToolStripMenuItem.Name = "testingToolStripMenuItem";
            this.testingToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.testingToolStripMenuItem.Text = "Testing";
            // 
            // gameToolStripMenuItem1
            // 
            this.gameToolStripMenuItem1.Name = "gameToolStripMenuItem1";
            this.gameToolStripMenuItem1.Size = new System.Drawing.Size(105, 22);
            this.gameToolStripMenuItem1.Text = "Game";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.optionsToolStripMenuItem.Text = "Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // questsToolStripMenuItem1
            // 
            this.questsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.questMakerToolStripMenuItem,
            this.questModifierToolStripMenuItem});
            this.questsToolStripMenuItem1.Name = "questsToolStripMenuItem1";
            this.questsToolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.questsToolStripMenuItem1.Text = "Quests";
            // 
            // questMakerToolStripMenuItem
            // 
            this.questMakerToolStripMenuItem.Name = "questMakerToolStripMenuItem";
            this.questMakerToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.questMakerToolStripMenuItem.Text = "Quest Maker";
            this.questMakerToolStripMenuItem.Click += new System.EventHandler(this.questMakerToolStripMenuItem_Click);
            // 
            // questModifierToolStripMenuItem
            // 
            this.questModifierToolStripMenuItem.Name = "questModifierToolStripMenuItem";
            this.questModifierToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.questModifierToolStripMenuItem.Text = "Quest Modifier";
            // 
            // localizerToolStripMenuItem
            // 
            this.localizerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NPCTool,
            this.NPCNameTool,
            this.QuestItem,
            this.QuestDialog});
            this.localizerToolStripMenuItem.Name = "localizerToolStripMenuItem";
            this.localizerToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.localizerToolStripMenuItem.Text = "Localizer";
            // 
            // NPCTool
            // 
            this.NPCTool.Name = "NPCTool";
            this.NPCTool.Size = new System.Drawing.Size(168, 22);
            this.NPCTool.Text = "NPC Tool";
            this.NPCTool.Click += new System.EventHandler(this.NPCTool_Click);
            // 
            // QuestItem
            // 
            this.QuestItem.Name = "QuestItem";
            this.QuestItem.Size = new System.Drawing.Size(168, 22);
            this.QuestItem.Text = "Quest Item Tool";
            this.QuestItem.Click += new System.EventHandler(this.QuestItem_Click);
            // 
            // QuestDialog
            // 
            this.QuestDialog.Name = "QuestDialog";
            this.QuestDialog.Size = new System.Drawing.Size(168, 22);
            this.QuestDialog.Text = "Quest Dialog Tool";
            this.QuestDialog.Click += new System.EventHandler(this.QuestDialog_Click);
            // 
            // moderationToolStripMenuItem
            // 
            this.moderationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.typeANameToolStripMenuItem,
            this.applicationsToolStripMenuItem});
            this.moderationToolStripMenuItem.Enabled = false;
            this.moderationToolStripMenuItem.Name = "moderationToolStripMenuItem";
            this.moderationToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.moderationToolStripMenuItem.Text = "Moderation";
            // 
            // typeANameToolStripMenuItem
            // 
            this.typeANameToolStripMenuItem.Name = "typeANameToolStripMenuItem";
            this.typeANameToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.typeANameToolStripMenuItem.Text = "Type-A-Name";
            this.typeANameToolStripMenuItem.Click += new System.EventHandler(this.typeANameToolStripMenuItem_Click);
            // 
            // applicationsToolStripMenuItem
            // 
            this.applicationsToolStripMenuItem.Name = "applicationsToolStripMenuItem";
            this.applicationsToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.applicationsToolStripMenuItem.Text = "Applications";
            // 
            // creativeToolStripMenuItem
            // 
            this.creativeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pTexToolStripMenuItem});
            this.creativeToolStripMenuItem.Enabled = false;
            this.creativeToolStripMenuItem.Name = "creativeToolStripMenuItem";
            this.creativeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.creativeToolStripMenuItem.Text = "Creative";
            // 
            // pTexToolStripMenuItem
            // 
            this.pTexToolStripMenuItem.Name = "pTexToolStripMenuItem";
            this.pTexToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.pTexToolStripMenuItem.Text = "pTex";
            // 
            // developmentToolStripMenuItem1
            // 
            this.developmentToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.clientToolStripMenuItem});
            this.developmentToolStripMenuItem1.Enabled = false;
            this.developmentToolStripMenuItem1.Name = "developmentToolStripMenuItem1";
            this.developmentToolStripMenuItem1.Size = new System.Drawing.Size(90, 20);
            this.developmentToolStripMenuItem1.Text = "Development";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startALLToolStripMenuItem,
            this.startMongoToolStripMenuItem,
            this.fixMongoLockToolStripMenuItem,
            this.startAstronToolStripMenuItem,
            this.startUberdogToolStripMenuItem,
            this.startAIToolStripMenuItem});
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.serverToolStripMenuItem.Text = "Server";
            // 
            // startALLToolStripMenuItem
            // 
            this.startALLToolStripMenuItem.Name = "startALLToolStripMenuItem";
            this.startALLToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.startALLToolStripMenuItem.Text = "Start ALL";
            this.startALLToolStripMenuItem.Click += new System.EventHandler(this.startALLToolStripMenuItem_Click);
            // 
            // startMongoToolStripMenuItem
            // 
            this.startMongoToolStripMenuItem.Name = "startMongoToolStripMenuItem";
            this.startMongoToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.startMongoToolStripMenuItem.Text = "Start Mongo";
            this.startMongoToolStripMenuItem.Click += new System.EventHandler(this.startMongoToolStripMenuItem_Click);
            // 
            // fixMongoLockToolStripMenuItem
            // 
            this.fixMongoLockToolStripMenuItem.Name = "fixMongoLockToolStripMenuItem";
            this.fixMongoLockToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.fixMongoLockToolStripMenuItem.Text = "Fix Mongo Lock";
            this.fixMongoLockToolStripMenuItem.Click += new System.EventHandler(this.fixMongoLockToolStripMenuItem_Click);
            // 
            // startAstronToolStripMenuItem
            // 
            this.startAstronToolStripMenuItem.Name = "startAstronToolStripMenuItem";
            this.startAstronToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.startAstronToolStripMenuItem.Text = "Start Astron";
            this.startAstronToolStripMenuItem.Click += new System.EventHandler(this.startAstronToolStripMenuItem_Click);
            // 
            // startUberdogToolStripMenuItem
            // 
            this.startUberdogToolStripMenuItem.Name = "startUberdogToolStripMenuItem";
            this.startUberdogToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.startUberdogToolStripMenuItem.Text = "Start Uberdog";
            this.startUberdogToolStripMenuItem.Click += new System.EventHandler(this.startUberdogToolStripMenuItem_Click);
            // 
            // startAIToolStripMenuItem
            // 
            this.startAIToolStripMenuItem.Name = "startAIToolStripMenuItem";
            this.startAIToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.startAIToolStripMenuItem.Text = "Start ai";
            this.startAIToolStripMenuItem.Click += new System.EventHandler(this.startAIToolStripMenuItem_Click);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.localhostToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // localhostToolStripMenuItem
            // 
            this.localhostToolStripMenuItem.Name = "localhostToolStripMenuItem";
            this.localhostToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.localhostToolStripMenuItem.Text = "Localhost";
            this.localhostToolStripMenuItem.Click += new System.EventHandler(this.localhostToolStripMenuItem_Click);
            // 
            // toolToolStripMenuItem
            // 
            this.toolToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bam2EggToolStripMenuItem,
            this.egg2BamToolStripMenuItem,
            this.objsToolStripMenuItem,
            this.xsToolStripMenuItem});
            this.toolToolStripMenuItem.Enabled = false;
            this.toolToolStripMenuItem.Name = "toolToolStripMenuItem";
            this.toolToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.toolToolStripMenuItem.Text = "Tools";
            // 
            // bam2EggToolStripMenuItem
            // 
            this.bam2EggToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bam2EggToolStripMenuItem1});
            this.bam2EggToolStripMenuItem.Name = "bam2EggToolStripMenuItem";
            this.bam2EggToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.bam2EggToolStripMenuItem.Text = "Bams";
            // 
            // bam2EggToolStripMenuItem1
            // 
            this.bam2EggToolStripMenuItem1.Name = "bam2EggToolStripMenuItem1";
            this.bam2EggToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.bam2EggToolStripMenuItem1.Text = "Bam2Egg";
            // 
            // egg2BamToolStripMenuItem
            // 
            this.egg2BamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.egg2BamToolStripMenuItem2,
            this.egg2ObjToolStripMenuItem,
            this.egg2XToolStripMenuItem});
            this.egg2BamToolStripMenuItem.Name = "egg2BamToolStripMenuItem";
            this.egg2BamToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.egg2BamToolStripMenuItem.Text = "Eggs";
            // 
            // egg2BamToolStripMenuItem2
            // 
            this.egg2BamToolStripMenuItem2.Name = "egg2BamToolStripMenuItem2";
            this.egg2BamToolStripMenuItem2.Size = new System.Drawing.Size(124, 22);
            this.egg2BamToolStripMenuItem2.Text = "Egg2Bam";
            // 
            // egg2ObjToolStripMenuItem
            // 
            this.egg2ObjToolStripMenuItem.Name = "egg2ObjToolStripMenuItem";
            this.egg2ObjToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.egg2ObjToolStripMenuItem.Text = "Egg2Obj";
            // 
            // egg2XToolStripMenuItem
            // 
            this.egg2XToolStripMenuItem.Name = "egg2XToolStripMenuItem";
            this.egg2XToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.egg2XToolStripMenuItem.Text = "Egg2X";
            // 
            // objsToolStripMenuItem
            // 
            this.objsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obj2EggToolStripMenuItem});
            this.objsToolStripMenuItem.Name = "objsToolStripMenuItem";
            this.objsToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.objsToolStripMenuItem.Text = "Objs";
            // 
            // obj2EggToolStripMenuItem
            // 
            this.obj2EggToolStripMenuItem.Name = "obj2EggToolStripMenuItem";
            this.obj2EggToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.obj2EggToolStripMenuItem.Text = "Obj2Egg";
            // 
            // xsToolStripMenuItem
            // 
            this.xsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.x2ObjToolStripMenuItem});
            this.xsToolStripMenuItem.Name = "xsToolStripMenuItem";
            this.xsToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.xsToolStripMenuItem.Text = "Xs";
            // 
            // x2ObjToolStripMenuItem
            // 
            this.x2ObjToolStripMenuItem.Name = "x2ObjToolStripMenuItem";
            this.x2ObjToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.x2ObjToolStripMenuItem.Text = "X2Obj";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // nPCNameToolToolStripMenuItem
            // 
            this.NPCNameTool.Name = "nPCNameToolToolStripMenuItem";
            this.NPCNameTool.Size = new System.Drawing.Size(168, 22);
            this.NPCNameTool.Text = "NPC Name Tool";
            this.NPCNameTool.Click += new System.EventHandler(this.NPCNameTool_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1056, 503);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Project Exceleron - Altis Tool Suite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResizeEnd += new System.EventHandler(this.Form1_ResizeEnd);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newWorkspaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem presetsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moderatioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem launcherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem questsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem questMakerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questModifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NPCTool;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moderationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem typeANameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applicationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creativeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pTexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developmentToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem toolToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bam2EggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bam2EggToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem egg2BamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egg2BamToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem egg2ObjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem egg2XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem objsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obj2EggToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem x2ObjToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serverToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startMongoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fixMongoLockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAstronToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startUberdogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startAIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem localhostToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QuestItem;
        private System.Windows.Forms.ToolStripMenuItem QuestDialog;
        private System.Windows.Forms.ToolStripMenuItem NPCNameTool;
    }
}

