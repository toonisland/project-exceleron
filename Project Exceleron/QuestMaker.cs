using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Exceleron
{
    public partial class QuestMaker : Form
    {
        private QuestGenerator Generator = new QuestGenerator();

        public QuestMaker()
        {
            InitializeComponent();

            if(!string.IsNullOrEmpty(Properties.Settings.Default.srcPath))
            {
                QuestFileView.Text = Properties.Settings.Default.srcPath + @"\toontown\quest\Quests.py";
            }
        }

        private void UpdateResult()
        {
            if (this.Generator.HasGenerated == true)
            {
                this.ResultBox.Text = this.Generator.GenerateString();
            }
        }

        private void ManualGenerate(object sender, EventArgs e)
        {
            this.Generator.GenerateString();
            UpdateResult();
        }

        private void SetQuestID(object sender, EventArgs e)
        {
            this.Generator.QuestID = this.QuestIDValue.Text;
            UpdateResult();
        }

        private void SetStartingNPC(object sender, EventArgs e)
        {
            this.Generator.StartingNPC = this.StartingNPCValue.Text;
            UpdateResult();
        }

        private void SetToNPC(object sender, EventArgs e)
        {
            this.Generator.ToNPC = this.ToNPCValue.Text;
            UpdateResult();
        }

        private void SetReward(object sender, EventArgs e)
        {
            this.Generator.Reward = this.RewardValue.Text;
            UpdateResult();
        }

        private void SetNextQuest(object sender, EventArgs e)
        {
            this.Generator.NextQuest = this.NextQuestValue.Text;
            UpdateResult();
        }

        private void SetDialogNumber(object sender, EventArgs e)
        {
            this.Generator.DialogNumber = this.DialogValue.Text;
            UpdateResult();
        }

        private void SetExpReward(object sender, EventArgs e)
        {
            this.Generator.ExpReward = this.ExpRewardValue.Text;
            UpdateResult();
        }

        private void SetJBReward(object sender, EventArgs e)
        {
            this.Generator.JBReward = this.JBRewardValue.Text;
            UpdateResult();
        }

        private void SetLastLine(object sender, EventArgs e)
        {
            try
            {
                this.Generator.LastLine = Int32.Parse(this.QuestDictValue.Text);
            } catch (Exception ex) {
                return;
            }
        }

        private void AddQuestClass(object sender, EventArgs e)
        {
            this.Generator.QuestClasses.Add(this.QuestClassValue.Text);
            UpdateResult();
        }

        private void AddRequiredQuest(object sender, EventArgs e)
        {
            this.Generator.RequiredQuests.Add(this.RequiredQuestValue.Text);
            UpdateResult();
        }

        private void SetStartingQuest(object sender, EventArgs e)
        {
            this.Generator.QuestPosition = "Start";
            UpdateResult();
        }

        private void SetContinuedQuest(object sender, EventArgs e)
        {
            this.Generator.QuestPosition = "Cont";
            UpdateResult();
        }

        private void DoReset(object sender, EventArgs e)
        {
            this.QuestIDValue.Text = "";
            this.StartingNPCValue.Text = "";
            this.ToNPCValue.Text = "";
            this.RewardValue.Text = "";
            this.NextQuestValue.Text = "";
            this.DialogValue.Text = "";
            this.ExpRewardValue.Text = "";
            this.JBRewardValue.Text = "";
            this.Generator.RequiredQuests = new List<string>();
            this.Generator.QuestClasses = new List<string>();
            this.Generator.QuestID = "";
            this.Generator.QuestPosition = "Start";
            this.Generator.StartingNPC = "";
            this.Generator.ToNPC = "";
            this.Generator.Reward = "";
            this.Generator.NextQuest = "";
            this.Generator.DialogNumber = "";
            this.Generator.ExpReward = "";
            this.Generator.JBReward = "";
            
        }

        private void SelectQuestFile(object sender, EventArgs e)
        {
            OpenFileDialog Selector = new OpenFileDialog();
            Selector.InitialDirectory = "c:\\";
            Selector.Filter = "Python Files (*.py)|*.py";
            Selector.FilterIndex = 2;
            Selector.RestoreDirectory = true;

            if (Selector.ShowDialog() == DialogResult.OK)
            {
                this.Generator.FilePath = Selector.FileName;
                this.QuestFileView.Text = Selector.FileName;
            }
        }

        private void WriteToQuests(object sender, EventArgs e)
        {
            QuestWriter writer = new QuestWriter(this.Generator.FilePath, this.ResultBox.Text, this.Generator.LastLine);
            writer.DoWrite();

            this.Generator.LastLine += 1;
            this.QuestDictValue.Text = this.Generator.LastLine.ToString();
        }
    }

    class QuestGenerator
    {
        public bool HasGenerated = false;
        public string FilePath = "";
        public int LastLine = 0;
        public List<string> RequiredQuests = new List<string>();
        public List<string> QuestClasses = new List<string>();
        public string QuestID = "";
        public string QuestPosition = "Start";
        public string StartingNPC = "";
        public string ToNPC = "";
        public string Reward = "";
        public string NextQuest = "";
        public string DialogNumber = "";
        public string ExpReward = "";
        public string JBReward = "";

        public QuestGenerator() { }
        
        public string GenerateString()
        {
            string Result = " ";

            Result += this.QuestID;
            Result += ": (";

            string RequiredQuestsString = "[";
            if (this.RequiredQuests.Count() == 0)
            {
                RequiredQuestsString += "]";
            } else
            {
                RequiredQuestsString += this.RequiredQuests[0];
                for (int n = 1; n < this.RequiredQuests.Count; n++)
                {
                    RequiredQuestsString += ", ";
                    RequiredQuestsString += this.RequiredQuests[n];
                }
                RequiredQuestsString += "]";
            }

            Result += RequiredQuestsString;
            Result += ", ";
            Result += this.QuestPosition;
            Result += ", ";

            Result += "(";
            if (this.QuestClasses.Count() == 0)
            {
                Result += ",), ";
            } else
            {
                foreach (string QClass in this.QuestClasses)
                {
                    Result += QClass;
                    Result += ", ";
                }
                Result += "), ";
            }

            Result += this.StartingNPC;
            Result += ", ";
            Result += this.ToNPC;
            Result += ", ";
            Result += this.Reward;
            Result += ", ";
            Result += this.NextQuest;
            Result += ", ";
            Result += "TTLocalizer.QuestDialogDict[" + this.DialogNumber + "]";
            Result += ", ";
            Result += this.ExpReward;
            Result += ", ";
            Result += this.JBReward;
            Result += ")}"; // assume that this is the end and let questwriter take care of it

            this.HasGenerated = true;
            return Result;
        }

    }

    class QuestWriter
    {
        private string Path;
        private string Quest;
        private int LastLine;

        private void FixLastLine(string NString)
        {
            List<string> Lines = new List<string>(File.ReadAllLines(Path));
            Lines[LastLine - 1] = NString;
            File.WriteAllLines(Path, Lines);
        }

        private void InsertLine(string NString)
        {
            List<string> Lines = new List<string>(File.ReadAllLines(Path));
            Lines.Insert(LastLine, NString);
            File.WriteAllLines(Path, Lines);
        }

        private string ReadLastLine()
        {
            List<string> Lines = new List<string>(File.ReadAllLines(Path));
            return Lines[LastLine - 1];
        }

        public QuestWriter(string Path, string QuestText, int LastLine)
        {
            this.Path = Path;
            this.Quest = QuestText;
            this.LastLine = LastLine;
        }

        public void DoWrite()
        {
            string LL = ReadLastLine();
            if (LL.Contains("}"))
            {
                LL = LL.Replace("}", ",");
                FixLastLine(LL);
            }

            InsertLine(Quest);
        }
    }
}
