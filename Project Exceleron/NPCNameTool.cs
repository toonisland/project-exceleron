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
    public partial class NPCNameTool : Form
    {
        private NPCParser parser;
        private int SelectedIndex = -1;

        public NPCNameTool()
        {
            InitializeComponent();
            parser = new NPCParser(Items);
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
            NPCName.Text = "";
            SelectedIndex = -1;
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (Items.SelectedItems.Count != 0)
            {
                try
                {
                    ListViewItem TItem = Items.SelectedItems[0];
                    int ItemIndex = parser.Items.FindIndex(item => item.AssociatedItem == TItem);
                    NPCNameObject TItemO = parser.Items[ItemIndex];

                    NPCName.Text = TItemO.Name;
                    SelectedIndex = ItemIndex;
                }
                catch (Exception ex)
                {
                    return;
                }
            }
        }

        private void AddItemWithID(object sender, EventArgs e)
        {
            int ItemID;
            if (Int32.TryParse(ItemIDValue.Text, out ItemID))
            {
                NPCNameObject EmptyItem = new NPCNameObject();
                ListViewItem LV = new ListViewItem(new string[]{
                    ItemID.ToString(),
                    "",
                });

                EmptyItem.AssociatedItem = LV;
                EmptyItem.ID = ItemID;
                Items.Items.Add(LV);
                parser.Items.Add(EmptyItem);

                ItemIDValue.Text = (ItemID + 1).ToString();
            }
        }

        private void RemoveItemWithID(object sender, EventArgs e)
        {
            int ItemID;
            if (Int32.TryParse(ItemIDValue.Text, out ItemID))
            {
                int DiagIndex = parser.Items.FindIndex(item => item.ID == ItemID);
                if (DiagIndex != -1)
                {
                    parser.Items.RemoveAt(DiagIndex);
                    Items.Items.RemoveAt(DiagIndex);
                    if (DiagIndex == SelectedIndex)
                    {
                        Reset();
                    }
                }
            }
        }

        private void SaveCurrent(object sender, EventArgs e)
        {
            if (SelectedIndex == -1)
            {
                return;
            }
            NPCNameObject Data = new NPCNameObject();
            Data.Name = NPCName.Text;
            parser.SaveNPC(SelectedIndex, Data);
        }

        private void SaveToFile(object sender, EventArgs e)
        {
            string Dictionary = parser.ConstructDictionary();
            parser.WriteToFile(Dictionary);
            parser.LoadData();


        }
    }

    class NPCParser
    {
        public string FilePath = "";
        private int LastLine;
        private int FirstLine = 0;
        public List<NPCNameObject> Items = new List<NPCNameObject>();
        private ListView ItemBox;

        public NPCParser(ListView ItemBoxX)
        {
            ItemBox = ItemBoxX;
        }

        public void SaveNPC(int Index, NPCNameObject New)
        {
            Items[Index].Name = New.Name;
            Items[Index].AssociatedItem.SubItems[1].Text = New.Name;
        }



        public string ConstructDictionary()
        {
            string ItemDict = "NPCToonNames = {\n";
            foreach (var Item in Items)
            {
                Console.WriteLine(Item.Name);
                string Constructed = " " + Item.ID.ToString() + ": " + Item.Name;
                ItemDict += Constructed + ",\n";
            }
            ItemDict += "}\n";
            return ItemDict;
        }

        public void WriteToFile(string ItemDict)
        {
            List<string> Lines = new List<string>(File.ReadAllLines(FilePath));
            Lines.RemoveRange(FirstLine, LastLine);
            Lines.InsertRange(FirstLine, new List<string>(ItemDict.Split('\n')));
            File.WriteAllLines(FilePath, Lines.ToArray());
            this.FirstLine = 0;
            this.LastLine = 0;
        }

        public void LoadData()
        {
            List<string> Lines = new List<string>(File.ReadAllLines(FilePath));
            for (var i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].Contains("NPCToonNames = {") && this.FirstLine == 0)
                {
                    Lines.RemoveRange(0, i);
                    this.FirstLine = i;
                    i = 1;
                }
                if (Lines[i].Contains("}") && (this.FirstLine != 0))
                {
                    Lines.RemoveRange(i + 1, Lines.Count - (i + 1));
                    LastLine = (i + 1);
                    break;
                }
            }
            string Raw = string.Join("\n", Lines.ToArray());
            Log.Info("Raw Length: " + Raw.Length);
            Regex RawReg = new Regex("(?<={).*[^}]", RegexOptions.Singleline);
            MatchCollection matches = RawReg.Matches(Raw);
            if (matches.Count == 0)
            {
                MessageBox.Show("Invalid file");
                return;
            }

            try
            {
                ItemBox.Items.Clear();
                Items.Clear();
            } catch (Exception e) {}
            string Data = matches[0].Value;
            List<string> DataLines = new List<string>(Data.Split('\n'));
            NPCNameObject DG = new NPCNameObject();
            
            Regex IDReg = new Regex("(?<=[ {])([0-9]*)(?=:)");
            Regex ContentReg = new Regex("(?<=: ).*[^},]");

            foreach (var Line in DataLines)
            {
                string CleanLine = " " + Line.Replace("\x09", "");
                MatchCollection IDMatches = IDReg.Matches(CleanLine);
                if (IDMatches.Count != 0)
                {
                    DG.ID = Int32.Parse(IDMatches[0].Value);
                }

                DG.Name = ContentReg.Match(CleanLine).Value;

                if (DG.ID != 0)
                {
                    Items.Add(DG.Clone());
                }
                DG = new NPCNameObject();
            }

            foreach (var Item in Items)
            {
                ListViewItem LV = new ListViewItem(new string[]{
                    Item.ID.ToString(),
                    Item.Name
                });

                Item.AssociatedItem = LV;
                ItemBox.Items.Add(LV);
            }


        }
    }

    public class NPCNameObject
    {
        public int ID = 0;
        public string Name = " ";
        public ListViewItem AssociatedItem;

        public NPCNameObject Clone()
        {
            return (NPCNameObject)this.MemberwiseClone();
        }


    }
}
