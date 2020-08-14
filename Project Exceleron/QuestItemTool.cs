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
    public partial class QuestItemTool : Form
    {
        private ItemParser parser;
        private int SelectedIndex = -1;

        public QuestItemTool()
        {
            InitializeComponent();
            parser = new ItemParser(Items);

            if(!string.IsNullOrEmpty(Properties.Settings.Default.srcPath))
            {
                TTLocalizerValue.Text = Properties.Settings.Default.srcPath + @"\toontown\toonbase\TTLocalizerEnglish.py";
            }
        }

        private void SelectLocalizer(object sender, EventArgs e)
        {
            OpenFileDialog selector = new OpenFileDialog();
            selector.InitialDirectory = "C:\\Users\\nines\\Documents\\QuestTest"; //"c:\\";
            selector.Filter = "TTLocalizerEnglish (TTLocalizerEnglish.py)|TTLocalizerEnglish.py|Python Files (*.py)|*.py|All files (*.*)|*.*";
            selector.FilterIndex = 2;
            selector.RestoreDirectory = true;

            if (selector.ShowDialog() == DialogResult.OK)
            {
                parser.FilePath = selector.FileName;
                TTLocalizerValue.Text = selector.FileName;
                parser.LoadData();
            }
        }

        private void Reset()
        {
            SingleValue.Text = "";
            PluralValue.Text = "";
            ArticleValue.Text = "";
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
                    ItemObject TItemO = parser.Items[ItemIndex];

                    SingleValue.Text = TItemO.Single;
                    PluralValue.Text = TItemO.Plural;
                    ArticleValue.Text = TItemO.Article;
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
                ItemObject EmptyItem = new ItemObject();
                ListViewItem LV = new ListViewItem(new string[]{
                    ItemID.ToString(),
                    "",
                    "",
                    ""
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
            ItemObject Data = new ItemObject();
            Data.Single = SingleValue.Text;
            Data.Plural = PluralValue.Text;
            Data.Article = ArticleValue.Text;
            parser.SaveQuest(SelectedIndex, Data);
        }

        private void SaveToFile(object sender, EventArgs e)
        {
            string Dictionary = parser.ConstructDictionary();
            parser.WriteToFile(Dictionary);
            parser.LoadData();


        }
    }

    class ItemParser
    {
        public string FilePath = "";
        private int LastLine;
        private int FirstLine;
        public List<ItemObject> Items = new List<ItemObject>();
        private ListView ItemBox;

        public ItemParser(ListView ItemBoxX)
        {
            ItemBox = ItemBoxX;
        }

        public void SaveQuest(int Index, ItemObject New)
        {
            Items[Index].Single = New.Single;
            Items[Index].Plural = New.Plural;
            Items[Index].Article = New.Article;
            Items[Index].AssociatedItem.SubItems[1].Text = New.Single;
            Items[Index].AssociatedItem.SubItems[2].Text = New.Plural;
            Items[Index].AssociatedItem.SubItems[3].Text = New.Article;

        }



        public string ConstructDictionary()
        {
            string ItemDict = "QuestsItemDict = {\n";
            foreach (ItemObject Item in Items)
            {
                string Constructed = Item.ID.ToString() + ": [" + Item.Single + ", " + Item.Plural + ", " + Item.Article + "]";
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
            FirstLine = 0;
            LastLine = 0;
        }

        public void LoadData()
        {
            List<string> Lines = new List<string>(File.ReadAllLines(FilePath));
            for (int i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].Contains("QuestsItemDict") && FirstLine == 0)
                {
                    Lines.RemoveRange(0, i);
                    FirstLine = i;
                }
                if (Lines[i].Contains("}") && FirstLine != 0)
                {
                    Lines.RemoveRange(i, Lines.Count - (i + 1));
                    LastLine = i;
                    break;
                }
            }
            string Raw = string.Join("\n", Lines.ToArray());
            Log.Info("Raw Length: " + Raw.Length);
            Regex RawReg = new Regex("{(.*?)(?=})", RegexOptions.Singleline);
            MatchCollection matches = RawReg.Matches(Raw);
            if (matches.Count == 0)
            {
                MessageBox.Show("Invalid file");
                return;
            }

            ItemBox.Items.Clear();
            Items.Clear();
            string Data = matches[0].Value;
            List<string> DataLines = new List<string>(Data.Split('\n'));
            ItemObject DG = new ItemObject(); // totally didn't copy off the dialog tool
            
            Regex IDReg = new Regex("(?<=[ {])([0-9]*)(?=:)");
            Regex ContentReg = new Regex("(?<=\\[).*[^\\],}]");

            foreach (string Line in DataLines)
            {
                if (Line == " ") { continue; }
                string CleanLine = " " + Line.Replace("\x09", "");
                MatchCollection IDMatches = IDReg.Matches(CleanLine);
                if (IDMatches.Count != 0)
                {
                    DG.ID = Int32.Parse(IDMatches[0].Value);
                }

                string Content = ContentReg.Match(CleanLine).Value;
                string[] SContent = Content.Split(new string[] { ", " }, StringSplitOptions.None);
                DG.Single = SContent[0];
                DG.Plural = SContent[1];
                DG.Article = SContent[2];
                
                Items.Add(DG.Clone());
                DG = new ItemObject();
            }

            foreach (ItemObject Item in Items)
            {
                ListViewItem LV = new ListViewItem(new string[]{
                    Item.ID.ToString(),
                    Item.Single,
                    Item.Plural,
                    Item.Article
                });

                Item.AssociatedItem = LV;
                ItemBox.Items.Add(LV);
            }


        }
    }

    public class ItemObject
    {
        public int ID = 0;
        public string Single = " ";
        public string Plural = " ";
        public string Article = " ";
        public ListViewItem AssociatedItem;

        public ItemObject Clone()
        {
            return (ItemObject)this.MemberwiseClone();
        }


    }
}
