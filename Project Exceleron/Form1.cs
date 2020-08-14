using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using Project_Exceleron.Properties;

namespace Project_Exceleron
{
    public sealed partial class Form1 : Form
    {
        
        List<Form> ActiveComponents = new List<Form>();

        public Form1()
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.DoubleBuffer | ControlStyles.OptimizedDoubleBuffer,
                true);
            ResizeRedraw = true;

            newWorkspaceToolStripMenuItem_Click(null, null);
        }

        private void moderatioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void questMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestMaker questMakerMDIChild = new QuestMaker();
            questMakerMDIChild.MdiParent = this;
            ActiveComponents.Add(questMakerMDIChild);
            questMakerMDIChild.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorInfo authorInfoForm = new AuthorInfo();
            authorInfoForm.Show();
        }

        private void newWorkspaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveComponents.Count > 0)
            {
                foreach (Form t in ActiveComponents)
                {
                    t.Close();
                }
            }
            
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                menuStrip1.Items[i].Enabled = true;
            }
        }

        private void typeANameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypeAName typeANameMDIChild = new TypeAName();
            typeANameMDIChild.MdiParent = this;
            ActiveComponents.Add(typeANameMDIChild);
            typeANameMDIChild.Show();
        }

        private void startMongoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartForm mongoMDIChild = new ProcessStartForm();
            mongoMDIChild.MdiParent = this;
            ActiveComponents.Add(mongoMDIChild);
            mongoMDIChild.filename = Values.Mongod();
            mongoMDIChild.arguments = @"--dbpath " + Values.MongoDbPath();
            mongoMDIChild.Show();
        }

        private void startAstronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartForm astronMDIChild = new ProcessStartForm();
            astronMDIChild.MdiParent = this;
            ActiveComponents.Add(astronMDIChild);
            astronMDIChild.filename = Values.Astrond();
            astronMDIChild.arguments = @"--pretty --loglevel debug " + Values.AstronCluster();
            astronMDIChild.Show();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Options OptionsMDIChild = new Options();
            OptionsMDIChild.MdiParent = this;
            ActiveComponents.Add(OptionsMDIChild);
            OptionsMDIChild.Show();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void startUberdogToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartForm uberdogMDIChild = new ProcessStartForm();
            uberdogMDIChild.MdiParent = this;
            ActiveComponents.Add(uberdogMDIChild);
            uberdogMDIChild.filename = Values.PpythonPath();
            uberdogMDIChild.workingDirectory = Settings.Default.srcPath;
            uberdogMDIChild.arguments = @"-m toontown.uberdog.ServiceStart --base-channel 1000000 --max-channels 999999 --stateserver 4002 --astron-ip 127.0.0.1:7199 --eventlogger-ip 127.0.0.1:7197";
            uberdogMDIChild.Show();
        }

        private void fixMongoLockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process firstOrDefault = Process.GetProcessesByName("mongod.exe").FirstOrDefault();
            if(firstOrDefault != null)
                Process.Start("Resources\\SafeKillMongo.exe",
                    firstOrDefault.Id.ToString());
        }

        private void startAIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProcessStartForm uberdogMdiChild = new ProcessStartForm();
            uberdogMdiChild.MdiParent = this;
            ActiveComponents.Add(uberdogMdiChild);
            uberdogMdiChild.filename = Values.PpythonPath();
            uberdogMdiChild.workingDirectory = Settings.Default.srcPath;
            uberdogMdiChild.arguments = @"-m toontown.ai.ServiceStart --base-channel 401000000 --max-channels 999999 --stateserver 4002 --astron-ip 127.0.0.1:7199 --eventlogger-ip 127.0.0.1:7197 --district-name ""Test Canvas"" --start-time ""6""";
            uberdogMdiChild.Show();
        }

        private void localhostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setEnvVars();
            ProcessStartForm gameConsoleMdiChild = new ProcessStartForm();
            gameConsoleMdiChild.MdiParent = this;
            ActiveComponents.Add(gameConsoleMdiChild);
            gameConsoleMdiChild.filename = Values.PpythonPath();
            gameConsoleMdiChild.workingDirectory = Settings.Default.srcPath;
            gameConsoleMdiChild.arguments = @"-m toontown.toonbase.ClientStart";
            gameConsoleMdiChild.Show();
        }

        private void setEnvVars()
        {
            Environment.SetEnvironmentVariable("TT_PLAYCOOKIE", Values.Username());
            Environment.SetEnvironmentVariable("TT_USERNAME", Values.Username());
            Environment.SetEnvironmentVariable("TT_PASSWORD", Values.Password());
            Environment.SetEnvironmentVariable("TT_GAMESERVER", "127.0.0.1");
        }

        private void startALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.startMongoToolStripMenuItem_Click(sender, e);
            Thread.Sleep(100);
            this.startAstronToolStripMenuItem_Click(sender, e);
            Thread.Sleep(100);
            this.startUberdogToolStripMenuItem_Click(sender, e);
            Thread.Sleep(100);
            this.startAIToolStripMenuItem_Click(sender, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void NPCTool_Click(object sender, EventArgs e)
        {
            NPCTool NPC = new NPCTool();
            NPC.MdiParent = this;
            ActiveComponents.Add(NPC);
            NPC.Show();
        }

        private void QuestDialog_Click(object sender, EventArgs e)
        {
            QuestDialogTool QuestDG = new QuestDialogTool();
            QuestDG.MdiParent = this;
            ActiveComponents.Add(QuestDG);
            QuestDG.Show();
        }

        private void QuestItem_Click(object sender, EventArgs e)
        {
            QuestItemTool QuestIT = new QuestItemTool();
            QuestIT.MdiParent = this;
            ActiveComponents.Add(QuestIT);
            QuestIT.Show();
        }

        private void NPCNameTool_Click(object sender, EventArgs e)
        {
            NPCNameTool NPCNT = new NPCNameTool();
            NPCNT.MdiParent = this;
            ActiveComponents.Add(NPCNT);
            NPCNT.Show();
        }
    }
}
