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
using System.Text.RegularExpressions;

namespace Project_Exceleron
{
    public partial class QuestDialogTool : Form
    {
        private DialogParser parser;
        private int SelectedIndex = -1;

        public QuestDialogTool()
        {
            InitializeComponent();
            parser = new DialogParser(DialogBox);
        }

        private void SelectLocalizer(object sender, EventArgs e)
        {
            OpenFileDialog Selector = new OpenFileDialog();
            Selector.InitialDirectory = "C:\\Users\\nines\\Documents\\QuestTest"; //"c:\\";
            Selector.Filter = "Python Files (*.py)|*.py";
            Selector.FilterIndex = 2;
            Selector.RestoreDirectory = true;

            if (Selector.ShowDialog() == DialogResult.OK)
            {
                parser.FilePath = Selector.FileName;
                TTLocalizerValue.Text = Selector.FileName;
                parser.LoadData();
            }
        }

        private void Reset()
        {
            QuestValue.Text = "";
            GreetingValue.Text = "";
            LeavingValue.Text = "";
            CompleteValue.Text = "";
            IncompleteValue.Text = "";
            WrongNPCValue.Text = "";
            SelectedIndex = -1;
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (DialogBox.SelectedItems.Count != 0)
            {
                try // stop throwing exceptions :(
                {
                    ListViewItem TItem = DialogBox.SelectedItems[0];
                    int DiagIndex = parser.Dialogs.FindIndex(item => item.AssociatedItem == TItem);
                    DialogObject TDiag = parser.Dialogs[DiagIndex];

                    QuestValue.Text = TDiag.Quest;
                    GreetingValue.Text = TDiag.Greeting;
                    LeavingValue.Text = TDiag.Leaving;
                    CompleteValue.Text = TDiag.Complete;
                    IncompleteValue.Text = TDiag.IncompleteProgress;
                    WrongNPCValue.Text = TDiag.WrongNpc;
                    SelectedIndex = DiagIndex;
                } catch (Exception ex)
                {
                    return;
                }
            }
        }

        private void AddQuestWithID(object sender, EventArgs e)
        {
            int QuestID;
            if (Int32.TryParse(QuestIDValue.Text, out QuestID))
            {
                DialogObject EmptyDialog = new DialogObject();
                ListViewItem LV = new ListViewItem(new string[]{
                    QuestID.ToString(),
                    "",
                });

                EmptyDialog.AssociatedItem = LV;
                EmptyDialog.ID = QuestID;
                DialogBox.Items.Add(LV);
                parser.Dialogs.Add(EmptyDialog);

                // make it a little easier for all you quest-makers :P
                QuestIDValue.Text = (QuestID + 1).ToString();
            }
        }

        private void RemoveQuestWithID(object sender, EventArgs e)
        {
            int QuestID;
            if (Int32.TryParse(QuestIDValue.Text, out QuestID))
            {
                int DiagIndex = parser.Dialogs.FindIndex(item => item.ID == QuestID);
                if (DiagIndex != -1)
                {
                    parser.Dialogs.RemoveAt(DiagIndex);
                    DialogBox.Items.RemoveAt(DiagIndex);
                    if (DiagIndex == SelectedIndex)
                    {
                        Reset();
                    }
                }
            }
        }

        private void SaveCurrent(object sender, EventArgs e)
        {
            if (SelectedIndex ==  -1)
            {
                return;
            }
            DialogObject Data = new DialogObject();
            Data.Quest = QuestValue.Text;
            Data.Greeting = GreetingValue.Text;
            Data.Complete = CompleteValue.Text;
            Data.Leaving = LeavingValue.Text;
            Data.IncompleteProgress = IncompleteValue.Text;
            Data.WrongNpc = WrongNPCValue.Text;
            parser.SaveQuest(SelectedIndex, Data);
        }

        private void SaveToFile(object sender, EventArgs e)
        {
            string Dictionary = parser.ConstructDictionary();
            parser.WriteToFile(Dictionary);
            parser.LoadData();

        }
    }

    class DialogParser
    {
        public string FilePath = "";
        private int LastLine;
        private int FirstLine;
        public List<DialogObject> Dialogs = new List<DialogObject>();
        private ListView DialogBox;

        public DialogParser(ListView DialogBox)
        {
            this.DialogBox = DialogBox;
        }

        public void SaveQuest(int Index, DialogObject New)
        {
            Dialogs[Index].Quest = New.Quest;
            Dialogs[Index].Greeting = New.Greeting;
            Dialogs[Index].Complete = New.Complete;
            Dialogs[Index].Leaving = New.Leaving;
            Dialogs[Index].IncompleteProgress = New.IncompleteProgress;
            Dialogs[Index].WrongNpc = New.WrongNpc;
            Dialogs[Index].AssociatedItem.SubItems[1].Text = New.Quest;
        }

        private string ConstructDialog(DialogObject D)
        {
            string Dialog = " ";
            Dialog += D.ID.ToString() + ": {QUEST: " + D.Quest;
            if (D.Greeting != "")
            {
                Dialog += ",\n       GREETING: " + D.Greeting;
            }
            if (D.Complete != "")
            {
                Dialog += ",\n       COMPLETE: " + D.Complete;
            }
            if (D.Leaving != "")
            {
                Dialog += ",\n       tLEAVING: " + D.Leaving;
            }
            if (D.IncompleteProgress != "")
            {
                Dialog += ",\n       INCOMPLETE_PROGRESS: " + D.IncompleteProgress;   
            }
            if (D.WrongNpc != "")
            {
                Dialog += ",\n       INCOMPLETE_WRONG_NPC: " + D.WrongNpc;
            }
            return Dialog + "}";
        }
        
        public string ConstructDictionary()
        {
            string QuestDict = "QuestDialogDict = {\n";
            foreach (DialogObject Diag in Dialogs)
            {
                string Constructed = ConstructDialog(Diag);
                QuestDict += Constructed + ",\n";
            }
            QuestDict = QuestDict.Substring(0, QuestDict.Length - 2);
            QuestDict += "}";
            return QuestDict;
        }

        public void WriteToFile(string QuestDict)
        {
            List<string> Lines = new List<string>(File.ReadAllLines(FilePath));
            Lines.RemoveRange(FirstLine, LastLine);
            Lines.InsertRange(FirstLine, new List<string>(QuestDict.Split('\n')));
            File.WriteAllLines(FilePath, Lines.ToArray());
            FirstLine = 0;
            LastLine = 0;
        }

        public void LoadData()
        {
            bool FoundNames = false;
            List<string> Lines = new List<string>(File.ReadAllLines(FilePath));
            for (var i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].Contains("QuestDialogDict = {") && (this.FirstLine == 0))
                {
                    Lines.RemoveRange(0, i);
                    FirstLine = i;
                    i = 1;
                    FoundNames = true;
                }
                if (Lines[i].Contains("}}") && (FoundNames != false))
                {
                    LastLine = (i + 1);
                    Lines.RemoveRange(i + 1, Lines.Count - (i + 1));
                    break;
                }
            }
            string Raw = string.Join("\n", Lines.ToArray());
            Console.WriteLine(Raw);
            Log.Info("Raw Length: " + Raw.Length);
            Regex RawReg = new Regex("{(.*?)}}", RegexOptions.Singleline);
            MatchCollection matches = RawReg.Matches(Raw);
            if (matches.Count == 0)
            {
                MessageBox.Show("Invalid file");
                return;
            }
			
			try {
				DialogBox.Items.Clear();
				Dialogs.Clear();
			} catch (Exception ex) { }
            string Data = matches[0].Value;
            List<string> DataLines = new List<string>(Data.Split('\n'));
            DialogObject DG = new DialogObject();

            // REGEX IS THE DEATH OF ME
            Regex IDReg = new Regex("(?<=[ {])([0-9]*)(?=:)");
            Regex StringReg = new Regex("(?<=QUEST: |GREETING: |COMPLETE: |INCOMPLETE_PROGRESS: |LEAVING: |INCOMPLETE_WRONG_NPC: ).+[^},]");
            Regex IdentReg = new Regex("(QUEST|GREETING|COMPLETE|INCOMPLETE_PROGRESS|LEAVING|INCOMPLETE_WRONG_NPC)");

            foreach (string Line in DataLines)
            {
                string CleanLine = " " + Line.Replace("\x09", "");
                MatchCollection IDMatches = IDReg.Matches(CleanLine);
                if (IDMatches.Count != 0)
                {
                    DG.ID = Int32.Parse(IDMatches[0].Value);
                }

                MatchCollection IdentMatches = IdentReg.Matches(CleanLine);
                if (IdentMatches.Count == 0)
                {
                    Log.Warn("Possible encoding error with line '" + Line + "'");
                } else
                {
                    string Ident = IdentMatches[0].Value;
                    if (Ident == "QUEST")
                    {
                        DG.Quest = StringReg.Match(CleanLine).Value;
                    } else
                    if (Ident == "GREETING")
                    {
                        DG.Greeting = StringReg.Match(CleanLine).Value;
                    } else
                    if (Ident == "COMPLETE")
                    {
                        DG.Complete = StringReg.Match(CleanLine).Value;
                    } else
                    if (Ident == "LEAVING")
                    {
                        DG.Leaving = StringReg.Match(CleanLine).Value;
                    } else
                    if (Ident == "INCOMPLETE_PROGRESS")
                    {
                        DG.IncompleteProgress = StringReg.Match(CleanLine).Value;
                    } else
                    if (Ident == "INCOMPLETE_WRONG_NPC")
                    {
                        DG.WrongNpc = StringReg.Match(CleanLine).Value;
                    }

                }

                if (CleanLine.Contains("},") || CleanLine.Contains("}}")) 
                {
                    Dialogs.Add(DG.Clone());
                    DG = new DialogObject();
                }
            }

            foreach (DialogObject Dialog in Dialogs)
            {
                ListViewItem LV = new ListViewItem(new string[]{
                    Dialog.ID.ToString(),
                    Dialog.Quest,
                });

                Dialog.AssociatedItem = LV;
                DialogBox.Items.Add(LV);
            }

            
        }
    }

    public class DialogObject
    {
        public int ID = 0;
        public string Greeting = "";
        public string Quest = "";
        public string IncompleteProgress = "";
        public string WrongNpc = "";
        public string Complete = "";
        public string Leaving = "";
        public ListViewItem AssociatedItem;

        public DialogObject Clone()
        {
            return (DialogObject)this.MemberwiseClone();
        }

        
    }
}
