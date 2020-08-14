using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using System.Globalization;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace Project_Exceleron
{
    public partial class NPCTool : Form
    {
        private class ColoredProgressBar : ProgressBar
        {
            SolidBrush IColor = new SolidBrush(Color.FromArgb(222, 222, 222));

            public ColoredProgressBar()
            {
                this.SetStyle(ControlStyles.UserPaint, true);
                InitializeComponent();
            }

            public void SetRGB(int r, int g, int b)
            {
                this.IColor = new SolidBrush(Color.FromArgb(r, g, b));
            }

            public List<int> GetRGB()
            {
                List<int> RGB = new List<int>(3);
                RGB.Insert(0, this.IColor.Color.R);
                RGB.Insert(1, this.IColor.Color.G);
                RGB.Insert(2, this.IColor.Color.B);
                return RGB;
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                Rectangle rec = e.ClipRectangle;

                rec.Width = (int)(rec.Width * ((double)Value / Maximum)) - 4;
                if (ProgressBarRenderer.IsSupported)
                    ProgressBarRenderer.DrawHorizontalBar(e.Graphics, e.ClipRectangle);
                rec.Height = rec.Height - 4;
                e.Graphics.FillRectangle(IColor, 2, 2, rec.Width, rec.Height);
            }

            private void InitializeComponent()
            {
                this.SuspendLayout();
                this.ResumeLayout(false);

            }
        }

        private NPCDataParser Parser;
        private int Selected;
        private ColoredProgressBar ColorBar;

        public NPCTool()
        {
            InitializeComponent();
            Parser = new NPCDataParser(Items);

            //Make color picker progressbar
            this.ColorBar = new ColoredProgressBar();
            this.ColorBar.Location = new Point(328, 244);
            this.ColorBar.Name = "ColorBar";
            this.ColorBar.Size = new Size(352, 23);
            this.ColorBar.TabIndex = 32;
            this.ColorBar.Value = 100;
            this.Controls.Add(this.ColorBar);
            this.ColorBar.Update();
            this.ColorBar.Click += this.OpenColorPicker;

            if(!string.IsNullOrEmpty(Properties.Settings.Default.srcPath))
            {
                TTLocalizerValue.Text = Properties.Settings.Default.srcPath + @"\toontown\toonbase\TTLocalizerEnglish.py";
                NPCToonsValue.Text = Properties.Settings.Default.srcPath + @"\toontown\toon\NPCToons.py";
            }
        }

        private void OpenColorPicker(object sender, EventArgs e)
        {
            DialogResult result = ColorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                this.ColorBar.SetRGB(ColorDialog.Color.R, ColorDialog.Color.G, ColorDialog.Color.B);
                this.ColorBar.Refresh();
            }

        }

        private void OpenLocalizer(object sender, EventArgs e)
        {
            OpenFileDialog Selector = new OpenFileDialog();
            Selector.InitialDirectory = "C:\\Users\\nines\\Documents\\QuestTest"; //"c:\\";
            Selector.Filter = "TTLocalizerEnglish |TTLocalizerEnglish.py|Python Files (*.py)|*.py|All files (*.*)|*.*";
            Selector.FilterIndex = 2;
            Selector.RestoreDirectory = true;

            if (Selector.ShowDialog() == DialogResult.OK)
            {
                Parser.LocalizerPath = Selector.FileName;
                TTLocalizerValue.Text = Selector.FileName;
                Parser.LoadNamesData();
            }
        }

        private void OpenNPCToons(object sender, EventArgs e)
        {
            OpenFileDialog Selector = new OpenFileDialog();
            Selector.InitialDirectory = "C:\\Users\\nines\\Documents\\QuestTest"; //"c:\\";
            Selector.Filter = "NPCToons (NPCToons.py)|NPCToons.py|Python Files (*.py)|*.py|All files (*.*)|*.*";
            Selector.FilterIndex = 2;
            Selector.RestoreDirectory = true;

            if (Selector.ShowDialog() == DialogResult.OK)
            {
                Parser.NPCPath = Selector.FileName;
                NPCToonsValue.Text = Selector.FileName;
                Parser.LoadNPCData();
            }
        }

        private void SelectionChanged(object sender, EventArgs e)
        {
            if (Parser.NPCData.Count == 0)
            {
                MessageBox.Show("Please load in NPC data!");
                return;
            }

            ListViewItem TItem;
            try
            {
                TItem = Items.SelectedItems[0];
            } catch (Exception ex)
            {
                return;
            }
            int ItemIndex = Parser.Names.FindIndex(item => item.AssociatedItem == TItem);
            NPCNameObject Item = Parser.Names[ItemIndex];

            NPCObject INPC;
            int Index = Parser.NPCData.FindIndex(item => item.ID == Item.ID);
            if (Index != -1)
            {
                INPC = Parser.NPCData[Index];
            }  else { INPC = new NPCObject(); INPC.ID = Parser.NPCData.Count() + 1; Parser.NPCData.Add(INPC); }

            if (INPC.IsRandom == true)
            {
                MessageBox.Show("This toon is randomly generated!");
                return;
            }

            // lookup upon a lookup 0______________________0
            GenderBox.SelectedIndex = GenderBox.FindStringExact(Parser.Gender.FirstOrDefault(x => x.Value == INPC.Gender).Key);
            SpeciesBox.SelectedIndex = SpeciesBox.FindStringExact(Parser.Species.FirstOrDefault(x => x.Value == INPC.Species).Key);
            HeadBox.SelectedIndex = HeadBox.FindStringExact(Parser.Heads.FirstOrDefault(x => x.Value == INPC.Head).Key);
            MuzzleBox.SelectedIndex = MuzzleBox.FindStringExact(Parser.Muzzles.FirstOrDefault(x => x.Value == INPC.Muzzle).Key);
            TorsoBox.SelectedIndex = TorsoBox.FindStringExact(Parser.Torsos.FirstOrDefault(x => x.Value == INPC.Torso).Key);
            ClothesBox.SelectedIndex = ClothesBox.FindStringExact(Parser.Clothes.FirstOrDefault(x => x.Value == INPC.Clothes).Key);
            LegBox.SelectedIndex = LegBox.FindStringExact(Parser.Legs.FirstOrDefault(x => x.Value == INPC.Legs).Key);
            TypeBox.SelectedIndex = TypeBox.FindStringExact(Parser.Types.FirstOrDefault(x => x.Value == INPC.Type).Key);
            ZoneBox.Text = INPC.Zone.ToString();
            Toptex.Text = INPC.Toptex.ToString();
            ToptexColor.Text = INPC.ToptexColor.ToString();
            Bottex.Text = INPC.Bottex.ToString();
            BottexColor.Text = INPC.BottexColor.ToString();
            Sleevetex.Text = INPC.Sleevetex.ToString();
            SleevetexColor.Text = INPC.SleevetexColor.ToString();
            if (INPC.ColorIsCompatible == true)
            {
                ColorBar.SetRGB(INPC.Color[0], INPC.Color[1], INPC.Color[2]);
                ColorBar.Refresh();
            }
            else
            {
                List<int> Color = Parser.Colors[INPC.NumericColor];
                ColorBar.SetRGB(Color[0], Color[1], Color[2]);
                ColorBar.Refresh();
            }

            Selected = INPC.ID;
        }

        private int TryInt(string n)
        {
            int Out;
            if (Int32.TryParse(n, out Out))
            {
                return Out;
            }
            return 0;
        }

        private void DoSaveNPC(object sender, EventArgs e)
        {
            NPCObject NPC = Parser.NPCData[Parser.NPCData.FindIndex(item => item.ID == Selected)];
            NPC.Gender = Parser.Gender[GenderBox.Items[GenderBox.SelectedIndex].ToString()];
            NPC.Species = Parser.Species[SpeciesBox.Items[SpeciesBox.SelectedIndex].ToString()];
            NPC.Head = Parser.Heads[HeadBox.Items[HeadBox.SelectedIndex].ToString()];
            NPC.Muzzle = Parser.Muzzles[MuzzleBox.Items[MuzzleBox.SelectedIndex].ToString()];
            NPC.Torso = Parser.Torsos[TorsoBox.Items[TorsoBox.SelectedIndex].ToString()];
            NPC.Clothes = Parser.Clothes[ClothesBox.Items[ClothesBox.SelectedIndex].ToString()];
            NPC.Legs = Parser.Legs[LegBox.Items[LegBox.SelectedIndex].ToString()]; NPC.Species = Parser.Species[SpeciesBox.Items[SpeciesBox.SelectedIndex].ToString()];
            NPC.Type = Parser.Types[TypeBox.Items[TypeBox.SelectedIndex].ToString()];
            if (TryInt(ZoneBox.Text) != 0)
            {
                NPC.Zone = TryInt(ZoneBox.Text);
            }
            if (TryInt(Toptex.Text) != 0)
            {
                NPC.Toptex = TryInt(Toptex.Text);
            }
            if (TryInt(ToptexColor.Text) != 0)
            {
                NPC.ToptexColor = TryInt(ToptexColor.Text);
            }
            if (TryInt(Bottex.Text) != 0)
            {
                NPC.Bottex = TryInt(BottexColor.Text);
            }
            if (TryInt(BottexColor.Text) != 0)
            {
                NPC.BottexColor = TryInt(BottexColor.Text);
            }
            if (TryInt(Sleevetex.Text) != 0)
            {
                NPC.Sleevetex = TryInt(Sleevetex.Text);
            }
            if (TryInt(SleevetexColor.Text) != 0)
            {
                NPC.SleevetexColor = TryInt(SleevetexColor.Text);
            }
            if (NPC.ColorIsCompatible == true)
            {
                NPC.Color = ColorBar.GetRGB();
            }
        }

        private void DoApplyChanges(object sender, EventArgs e)
        {
            string NPCS = Parser.ConstructNPCDict();
            Parser.WriteToFile(NPCS);
            Parser.LoadNPCData();
        }

        private void DoGenRandom(object sender, EventArgs e)
        {
            Random Gen = new Random();
            GenderBox.SelectedIndex = Gen.Next(0, GenderBox.Items.Count);
            SpeciesBox.SelectedIndex = Gen.Next(0, SpeciesBox.Items.Count);
            HeadBox.SelectedIndex = Gen.Next(0, HeadBox.Items.Count);
            MuzzleBox.SelectedIndex = Gen.Next(0, MuzzleBox.Items.Count);
            TorsoBox.SelectedIndex = Gen.Next(0, TorsoBox.Items.Count);
            ClothesBox.SelectedIndex = Gen.Next(0, ClothesBox.Items.Count);
            LegBox.SelectedIndex = Gen.Next(0, LegBox.Items.Count);
            NPCObject NPC = Parser.NPCData[Parser.NPCData.FindIndex(item => item.ID == Selected)];
            NPC.ColorIsCompatible = false;
            NPC.NumericColor = Gen.Next(0, 26);
            List<int> Color = Parser.Colors[NPC.NumericColor];
            ColorBar.SetRGB(Color[0], Color[1], Color[2]);
            ColorBar.Refresh();

        }
    }

    public class NPCDataParser
    {
        int FirstLine;
        int LastLine;
        public string NPCPath = "";
        public string LocalizerPath = "";
        public List<NPCNameObject> Names = new List<NPCNameObject>();
        public List<NPCObject> NPCData = new List<NPCObject>();
        private ListView ItemsBox;
        public Dictionary<string, string> Gender = new Dictionary<string, string>();
        public Dictionary<string, string> Species = new Dictionary<string, string>();
        public Dictionary<string, string> Heads = new Dictionary<string, string>();
        public Dictionary<string, string> Muzzles = new Dictionary<string, string>();
        public Dictionary<string, string> Torsos = new Dictionary<string, string>();
        public Dictionary<string, string> Clothes = new Dictionary<string, string>();
        public Dictionary<string, string> Legs = new Dictionary<string, string>();
        public Dictionary<string, string> Types = new Dictionary<string, string>();
        public Dictionary<int, List<int>> Colors = new Dictionary<int, List<int>>();

        public void WriteToFile(string NPCDict)
        {
            List<string> Lines = new List<string>(File.ReadAllLines(NPCPath));
            Console.WriteLine(Lines.Count());
            Lines.RemoveRange(FirstLine, LastLine);
            Lines.InsertRange(FirstLine, new List<string>(NPCDict.Split('\n')));
            File.WriteAllLines(NPCPath + ".bak", Lines.ToArray());
            FirstLine = 0;
            LastLine = 0;
        }

        public List<int> MakeColor(double r, double g, double b, double o) // throw out O
        {
            List<int> RGB = new List<int>();
            RGB.Insert(0, (int)Math.Floor(r * 255));
            RGB.Insert(1, (int)Math.Floor(g * 255));
            RGB.Insert(2, (int)Math.Floor(b * 255));
            return RGB;
        }

        public NPCDataParser(ListView ItemsBox)
        {
            this.ItemsBox = ItemsBox;

            Gender.Add("Male", "m");
            Gender.Add("Female", "f");

            Species.Add("Dog", "d");
            Species.Add("Cat", "c");
            Species.Add("Horse", "h");
            Species.Add("Mouse", "m");
            Species.Add("Rabbit", "r");
            Species.Add("Duck", "f");
            Species.Add("Monkey", "p");
            Species.Add("Bear", "b");
            Species.Add("Pig", "s");
            Species.Add("Deer", "x");

            Heads.Add("Long Head", "l");
            Heads.Add("Short Head", "s");

            Muzzles.Add("Long Muzzle", "l");
            Muzzles.Add("Short Muzzle", "s");

            Torsos.Add("Long Torso", "l");
            Torsos.Add("Medium Torso", "m");
            Torsos.Add("Short Torso", "s");

            Clothes.Add("Dress", "d");
            Clothes.Add("Shorts", "s");

            Legs.Add("Long Legs", "l");
            Legs.Add("Medium Legs", "m");
            Legs.Add("Short Legs", "s");

            Types.Add("Regular", "NPC_REGULAR");
            Types.Add("HQ Officer", "NPC_HQ");
            Types.Add("Clerk", "NPC_CLERK");
            Types.Add("Tailor", "NPC_TAILOR");
            Types.Add("Blocker", "NPC_BLOCKER");
            Types.Add("Fisherman", "NPC_FISHERMAN");
            Types.Add("Partyperson", "NPC_PARTYPERSON");
            Types.Add("Special Quest Giver", "NPC_SPECIALQUESTGIVER");

            // using the magic of replace all!!
            Colors.Add(0, MakeColor(1.0, 1.0, 1.0, 1.0));
            Colors.Add(1, MakeColor(0.96875, 0.691406, 0.699219, 1.0));
            Colors.Add(2, MakeColor(0.933594, 0.265625, 0.28125, 1.0));
            Colors.Add(3, MakeColor(0.863281, 0.40625, 0.417969, 1.0));
            Colors.Add(4, MakeColor(0.710938, 0.234375, 0.4375, 1.0));
            Colors.Add(5, MakeColor(0.570312, 0.449219, 0.164062, 1.0));
            Colors.Add(6, MakeColor(0.640625, 0.355469, 0.269531, 1.0));
            Colors.Add(7, MakeColor(0.996094, 0.695312, 0.511719, 1.0));
            Colors.Add(8, MakeColor(0.832031, 0.5, 0.296875, 1.0));
            Colors.Add(9, MakeColor(0.992188, 0.480469, 0.167969, 1.0));
            Colors.Add(10, MakeColor(0.996094, 0.898438, 0.320312, 1.0));
            Colors.Add(11, MakeColor(0.996094, 0.957031, 0.597656, 1.0));
            Colors.Add(12, MakeColor(0.855469, 0.933594, 0.492188, 1.0));
            Colors.Add(13, MakeColor(0.550781, 0.824219, 0.324219, 1.0));
            Colors.Add(14, MakeColor(0.242188, 0.742188, 0.515625, 1.0));
            Colors.Add(15, MakeColor(0.304688, 0.96875, 0.402344, 1.0));
            Colors.Add(16, MakeColor(0.433594, 0.90625, 0.835938, 1.0));
            Colors.Add(17, MakeColor(0.347656, 0.820312, 0.953125, 1.0));
            Colors.Add(18, MakeColor(0.191406, 0.5625, 0.773438, 1.0));
            Colors.Add(19, MakeColor(0.558594, 0.589844, 0.875, 1.0));
            Colors.Add(20, MakeColor(0.285156, 0.328125, 0.726562, 1.0));
            Colors.Add(21, MakeColor(0.460938, 0.378906, 0.824219, 1.0));
            Colors.Add(22, MakeColor(0.546875, 0.28125, 0.75, 1.0));
            Colors.Add(23, MakeColor(0.726562, 0.472656, 0.859375, 1.0));
            Colors.Add(24, MakeColor(0.898438, 0.617188, 0.90625, 1.0));
            Colors.Add(25, MakeColor(0.7, 0.7, 0.8, 1.0));
            Colors.Add(26, MakeColor(0.3, 0.3, 0.35, 1.0));
            Colors.Add(27, MakeColor(0.891, 0.439, 0.698, 1.0));
            Colors.Add(28, MakeColor(0.741, 0.873, 0.957, 1.0));
            Colors.Add(29, MakeColor(0.641, 0.857, 0.673, 1.0));
            Colors.Add(30, MakeColor(0.039, 0.862, 0.654, 1.0));
            Colors.Add(31, MakeColor(0.196, 0.725, 0.714, 1.0));
            Colors.Add(32, MakeColor(0.984, 0.537, 0.396, 1.0));
            Colors.Add(33, MakeColor(0.968, 0.749, 0.349, 1.0));
            Colors.Add(34, MakeColor(0.658, 0.175, 0.258, 1.0));
            Colors.Add(35, MakeColor(0.411, 0.644, 0.282, 1.0));
            Colors.Add(36, MakeColor(0.325, 0.407, 0.601, 1.0));
            Colors.Add(37, MakeColor(0.235, 0.573, 0.984, 1.0));
            Colors.Add(38, MakeColor(0.0, 0.635294, 0.258823, 1.0));
            Colors.Add(39, MakeColor(0.674509, 0.925490, 1.0, 1.0));
            Colors.Add(40, MakeColor(0.988235, 0.894117, 0.745098, 1.0));
            Colors.Add(41, MakeColor(0.749019, 1.0, 0.847058, 1.0));
            Colors.Add(42, MakeColor(0.470588, 0.443137, 0.447058, 1.0));
            Colors.Add(43, MakeColor(0.996078, 0.254901, 0.392156, 1.0));
            Colors.Add(44, MakeColor(0.811764, 0.709803, 0.231372, 1.0));
            Colors.Add(45, MakeColor(0.749019, 0.756862, 0.760784, 1.0));
            Colors.Add(46, MakeColor(1.0, 0.639215, 0.262745, 1.0));
            Colors.Add(47, MakeColor(0.0, 0.403921, 0.647058, 1.0));
            Colors.Add(48, MakeColor(0.862745, 0.078431, 0.235294, 1.0));
            Colors.Add(49, MakeColor(0.0, 0.635294, 0.513725, 1.0));
            Colors.Add(50, MakeColor(0.803921, 0.498039, 0.196078, 1.0));
            Colors.Add(51, MakeColor(0.70, 0.52, 0.75, 1.0));
            Colors.Add(52, MakeColor(1.0, 0, 1.0, 1.0));
            Colors.Add(53, MakeColor(0.5764, 0.4392, 0.8588, 1.0));
            Colors.Add(54, MakeColor(1.0, 1.0, 0.94117, 1.0));
            Colors.Add(55, MakeColor(0.9333, 0.8235, 0.9333, 1.0));
            Colors.Add(56, MakeColor(0.0, 1.0, 0.4980, 1.0));
            Colors.Add(57, MakeColor(0.8549, 0.6470, 0.1254, 1.0));
            Colors.Add(58, MakeColor(1.0, 0.59607, 0.0705, 1.0));
            Colors.Add(59, MakeColor(0.8039, 0.6862, 0.5843, 1.0));
            Colors.Add(60, MakeColor(0.2196, 0.5568, 0.5568, 1.0));
            Colors.Add(61, MakeColor(0.7764, 0.4431, 0.4431, 1.0));
            Colors.Add(62, MakeColor(0.8901, 0.8117, 0.3411, 1.0));
            Colors.Add(63, MakeColor(0.4117, 0.4117, 0.4117, 1.0));
            Colors.Add(64, MakeColor(1.0, 0.8431, 0.0, 1.0));
            Colors.Add(65, MakeColor(0.9333, 0.7882, 0.0, 1.0));

        }

        public string ConstructNPCDict()
        {
            string final = "NPCToonDict = {\n";
            foreach (var NPC in NPCData)
            {
                string NPCS = " " + NPC.ID.ToString() + ": (" + NPC.Zone.ToString() + ",\n";
                string Spaces = new String(' ', NPC.ID.ToString().Length + 4);
                NPCS += Spaces + "lnames[" + NPC.ID.ToString() + "],\n";
                if (NPC.IsRandom == true)
                {
                    NPCS += Spaces + "'r',\n";
                }
                else
                {
                    NPCS += Spaces + "('" + NPC.Species + NPC.Head + NPC.Muzzle + "',\n";
                    NPCS += Spaces + " " + "'" + NPC.Torso + NPC.Clothes + "',\n";
                    NPCS += Spaces + " " + "'" + NPC.Legs + "',\n";
                    NPCS += Spaces + " " + "'" + NPC.Gender + "',\n";
                    if (NPC.ColorIsCompatible == false)
                    {
                        NPCS += Spaces + " " + NPC.NumericColor.ToString() + ",\n";
                        NPCS += Spaces + " " + "0,\n";
                        NPCS += Spaces + " " + NPC.NumericColor.ToString() + ",\n";
                        NPCS += Spaces + " " + NPC.NumericColor.ToString() + ",\n";
                    }
                    else
                    {
                        string ColorString = "(" + ((float)NPC.Color[0] / 255).ToString("0.000000");
                        ColorString += ", " + ((float)NPC.Color[1] / 255).ToString("0.000000");
                        ColorString += ", " + ((float)NPC.Color[2] / 255).ToString("0.000000") + "),\n";
                        NPCS += Spaces + " " + ColorString;
                        NPCS += Spaces + " " + "0,\n";
                        NPCS += Spaces + " " + ColorString;
                        NPCS += Spaces + " " + ColorString;
                    }
                    NPCS += Spaces + " " + NPC.Toptex.ToString() + ",\n";
                    NPCS += Spaces + " " + NPC.ToptexColor.ToString() + ",\n";
                    NPCS += Spaces + " " + NPC.Sleevetex.ToString() + ",\n";
                    NPCS += Spaces + " " + NPC.SleevetexColor.ToString() + ",\n";
                    NPCS += Spaces + " " + NPC.Bottex.ToString() + ",\n";
                    NPCS += Spaces + " " + NPC.BottexColor.ToString() + "),\n";
                }
                NPCS += Spaces + "'" + NPC.Gender + "',\n";
                NPCS += Spaces + NPC.Protected.ToString() + ",\n";
                NPCS += Spaces + NPC.Type.Replace(" ", "") + "),\n";
                final += NPCS;
            }
            final += "}";
            return final;
        }

        public void LoadNPCData()
        {
            List<string> Lines = new List<string>(File.ReadAllLines(NPCPath));
            for (var i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].Contains("NPCToonDict = {") && (this.FirstLine == 0))
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
            Raw.Replace("{", "");
            Raw.Replace("}", "");
            Regex RawReg = new Regex("(?<={).*[^}]", RegexOptions.Singleline);
            MatchCollection matches = RawReg.Matches(Raw);
            if (matches.Count == 0)
            {
                MessageBox.Show("Invalid file");
                return;
            }

            NPCData.Clear();
            string Data = matches[0].Value;
            List<string> DataLines = new List<string>(Data.Split('\n'));
            NPCObject DG = new NPCObject();
            Regex StringReg = new Regex("(?<=').*(?=')");
            Regex NumberReg = new Regex(".*(?=,)");

            int CurrentIndex = 0;

            foreach (var CLine in DataLines)
            {
                string Line = " " + CLine.Replace("\x09", "").Replace("{", "").Replace(")", "");
                if (CLine.Count() != 0)
                {
                    if (CLine.ElementAt(0) == "#".ToCharArray()[0])
                    {
                        continue;
                    }
                } else { continue; }
                if (DG.IsRandom == true)
                {
                    if (CurrentIndex == 3)
                    {
                        DG.Gender = StringReg.Matches(Line)[0].Value;
                    }
                    if (CurrentIndex == 5)
                    {
                        DG.Type = NumberReg.Matches(Line)[0].Value;
                        if (DG.ID != 0)
                        {
                            NPCData.Add(DG.Clone());
                        }
                        CurrentIndex = -1;
                        DG = new NPCObject();
                    }
                    CurrentIndex += 1;
                    continue;
                }
                switch (CurrentIndex)
                {
                    case 0:
                        int ID;
                        int Zone; // disgusting inlining
                        if (Int32.TryParse(new Regex("(?<=\\().*[^,]").Matches(Line)[0].Value, out Zone))
                        {
                            DG.Zone = Zone;
                        }

                        if (Int32.TryParse(new Regex(".+(?=:)").Matches(Line)[0].Value, out ID))
                        {
                            DG.ID = ID;
                        }
                        break;
                    case 2:
                        char[] Head = StringReg.Matches(Line)[0].Value.ToCharArray();
                        if (Head.Count() == 1)
                        {
                            DG.IsRandom = true;
                        }
                        else
                        {
                            DG.Species = Head[0].ToString();
                            DG.Head = Head[1].ToString();
                            DG.Muzzle = Head[2].ToString();
                        }
                        break;
                    case 3:
                        char[] Torso = StringReg.Matches(Line)[0].Value.ToCharArray();
                        DG.Torso = Torso[0].ToString();
                        if (Torso.Count() == 2)
                        {
                            DG.Clothes = Torso[1].ToString();
                        }
                        break;
                    case 4:
                        DG.Legs = StringReg.Matches(Line)[0].Value;
                        break;
                    case 5:
                        DG.Gender = StringReg.Matches(Line)[0].Value;
                        break;
                    case 6: // just sample from a single color
                        if (Line.Contains("("))
                        {
                            DG.ColorIsCompatible = true;
                            DG.Color = new List<int>(3);
                            List<string> Colors = new List<string>(new Regex("(?<=\\().*[^)]").Matches(Line)[0].Value.Split(','));
                            DG.Color.Insert(0, (int)Math.Floor(float.Parse(Colors[0].Replace(" ", ""), CultureInfo.InvariantCulture)*255));
                            DG.Color.Insert(1, (int)Math.Floor(float.Parse(Colors[1].Replace(" ", ""), CultureInfo.InvariantCulture)*255));
                            DG.Color.Insert(2, (int)Math.Floor(float.Parse(Colors[2].Replace(" ", ""), CultureInfo.InvariantCulture)*255));
                        }
                        else
                        {
                            DG.NumericColor = Int32.Parse(NumberReg.Matches(Line)[0].Value);
                            DG.ColorIsCompatible = false;
                        }
                        break;
                    case 10:
                        DG.Toptex = Int32.Parse(NumberReg.Matches(Line)[0].Value);
                        break;
                    case 11:
                        DG.ToptexColor = Int32.Parse(NumberReg.Matches(Line)[0].Value);
                        break;
                    case 12:
                        DG.Sleevetex = Int32.Parse(NumberReg.Matches(Line)[0].Value);
                        break;
                    case 13:
                        DG.SleevetexColor = Int32.Parse(NumberReg.Matches(Line)[0].Value);
                        break;
                    case 14:
                        DG.Bottex = Int32.Parse(NumberReg.Matches(Line)[0].Value);
                        break;
                    case 15:
                        DG.BottexColor = Int32.Parse(NumberReg.Matches(Line)[0].Value);
                        break;
                    case 17:
                        DG.Protected = Int32.Parse(NumberReg.Matches(Line)[0].Value);
                        break;
                    case 18:
                        DG.Type = NumberReg.Matches(Line.Replace(" ", ""))[0].Value; // numberreg works for this lol
                        if (DG.ID != 0)
                        {
                            NPCData.Add(DG.Clone());
                        }
                        CurrentIndex = -1;
                        DG = new NPCObject();
                        break;


                }
                CurrentIndex += 1;
            }
        }

        public void LoadNamesData()
        {
            bool FoundNames = false;
            List<string> Lines = new List<string>(File.ReadAllLines(LocalizerPath));
            for (var i = 0; i < Lines.Count; i++)
            {
                if (Lines[i].Contains("NPCToonNames"))
                {
                    Lines.RemoveRange(0, i);
                    i = 1;
                    FoundNames = true;
                }
                if (Lines[i].Contains("}") && (FoundNames != false))
                {
                    Lines.RemoveRange(i + 1, Lines.Count - (i + 1));
                    break;
                }
            }
            string Raw = string.Join("\n", Lines.ToArray());
            Regex RawReg = new Regex("(?<={).*[^}]", RegexOptions.Singleline);
            MatchCollection matches = RawReg.Matches(Raw);
            if (matches.Count == 0)
            {
                MessageBox.Show("Invalid TTLocalizer");
                return;
            }

            try
            {
                ItemsBox.Items.Clear();
                Names.Clear();
            }
            catch (Exception e) { }
            string Data = matches[0].Value;
            List<string> DataLines = new List<string>(Data.Split('\n'));
            INPCNameObject DG = new INPCNameObject();

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
                    Names.Add(DG.Clone());
                }
                DG = new INPCNameObject();
            }

            foreach (var Item in Names)
            {
                ListViewItem LV = new ListViewItem(new string[]{
                    Item.ID.ToString(),
                    Item.Name
                });

                Item.AssociatedItem = LV;
                ItemsBox.Items.Add(LV);
            }


        }
    }

    public class INPCNameObject : NPCNameObject
    {
        NPCObject AssociatedObject;
    }

    public class NPCObject
    {
        public int ID;
        public string Gender = "m";
        public string Species = "d";
        public string Head = "l";
        public string Muzzle = "l";
        public string Torso = "l";
        public string Legs = "l";
        public string Clothes = "s";
        public bool IsRandom = false;
        public bool ColorIsCompatible = false;
        public int NumericColor = 0;
        public List<int> Color = new List<int>();
        public int Zone = -1;
        public int Toptex = 0;
        public int ToptexColor = 0;
        public int Bottex = 0;
        public int BottexColor = 0;
        public int Sleevetex = 0;
        public int SleevetexColor = 0;
        public int Protected = 0;
        public string Type = "NPC_NORMAL";

        public NPCObject Clone()
        {
            return (NPCObject)this.MemberwiseClone();
        }
    }
}
