using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HammerWorldGenerator
{
    public partial class Frame : Form
    {
        int entityid = 0;
        int solidid = 0;
        int planeid = 0;
        decimal _TailleTexture = 0.5m;
        string TailleTexture;

        string save = "";
        string bloc = "";
        string disp = "";
        string savetype = "";

        string materialtop = "MC/BEDROCK";
        string materialright = "MC/BEDROCK";
        string materialleft = "MC/BEDROCK";
        string materialbehind = "MC/BEDROCK";
        string materialfront = "MC/BEDROCK";
        string materialunder = "MC/BEDROCK";

        readonly string dispbase = "\tsolid\r\n\t{15}\r\n\t\t\"id\" \"{0}\"\r\n\t\tside\r\n" +
                                   "\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {3} {7}) ({2} {6} {7}) ({5} {6} {7})\"\r\n" +
                                   "\t\t\t\"material\" \"MC/GRASS\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.5\"\r\n" + 
                                   "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t\tdispinfo\r\n" + 
                                   "\t\t\t{15}\r\n\t\t\t\t\"power\" \"3\"\r\n\t\t\t\t\"startposition\" \"[0 0 256]\"\r\n\t\t\t\t\"flags\" \"0\"\r\n" + 
                                   "\t\t\t\t\"elevation\" \"0\"\r\n\t\t\t\t\"subdiv\" \"0\"\r\n\t\t\t\tnormals\r\n\t\t\t\t{15}\r\n" +
                                   "\t\t\t\t\t\"row0\" \"0 0 {17} 0 0 {26} 0 0 {35} 0 0 {44} 0 0 {53} 0 0 {62} 0 0 {71} 0 0 {80} 0 0 {89}\"\r\n" +
                                   "\t\t\t\t\t\"row1\" \"0 0 {18} 0 0 {27} 0 0 {36} 0 0 {45} 0 0 {54} 0 0 {63} 0 0 {72} 0 0 {81} 0 0 {90}\"\r\n" +
                                   "\t\t\t\t\t\"row2\" \"0 0 {19} 0 0 {28} 0 0 {37} 0 0 {46} 0 0 {55} 0 0 {64} 0 0 {73} 0 0 {82} 0 0 {91}\"\r\n" +
                                   "\t\t\t\t\t\"row3\" \"0 0 {20} 0 0 {29} 0 0 {38} 0 0 {47} 0 0 {56} 0 0 {65} 0 0 {74} 0 0 {83} 0 0 {92}\"\r\n" +
                                   "\t\t\t\t\t\"row4\" \"0 0 {21} 0 0 {30} 0 0 {39} 0 0 {48} 0 0 {57} 0 0 {66} 0 0 {75} 0 0 {84} 0 0 {93}\"\r\n" +
                                   "\t\t\t\t\t\"row5\" \"0 0 {22} 0 0 {31} 0 0 {40} 0 0 {49} 0 0 {58} 0 0 {67} 0 0 {76} 0 0 {85} 0 0 {94}\"\r\n" +
                                   "\t\t\t\t\t\"row6\" \"0 0 {23} 0 0 {32} 0 0 {41} 0 0 {50} 0 0 {59} 0 0 {68} 0 0 {77} 0 0 {86} 0 0 {95}\"\r\n" +
                                   "\t\t\t\t\t\"row7\" \"0 0 {24} 0 0 {33} 0 0 {42} 0 0 {51} 0 0 {60} 0 0 {69} 0 0 {78} 0 0 {87} 0 0 {96}\"\r\n" +
                                   "\t\t\t\t\t\"row8\" \"0 0 {25} 0 0 {34} 0 0 {43} 0 0 {52} 0 0 {61} 0 0 {70} 0 0 {79} 0 0 {88} 0 0 {97}\"\r\n" + 
                                   "\t\t\t\t{16}\r\n\t\t\t\tdistances\r\n\t\t\t\t{15}\r\n" +
                                   "\t\t\t\t\t\"row0\" \"{98} {107} {116} {125} {134} {143} {152} {161} {170}\"\r\n" +
                                   "\t\t\t\t\t\"row1\" \"{99} {108} {117} {126} {135} {144} {153} {162} {171}\"\r\n" +
                                   "\t\t\t\t\t\"row2\" \"{100} {109} {118} {127} {136} {145} {154} {163} {172}\"\r\n" + 
                                   "\t\t\t\t\t\"row3\" \"{101} {110} {119} {128} {137} {146} {155} {164} {173}\"\r\n" + 
                                   "\t\t\t\t\t\"row4\" \"{102} {111} {120} {129} {138} {147} {156} {165} {174}\"\r\n" + 
                                   "\t\t\t\t\t\"row5\" \"{103} {112} {121} {130} {139} {148} {157} {166} {175}\"\r\n" + 
                                   "\t\t\t\t\t\"row6\" \"{104} {113} {122} {131} {140} {149} {158} {167} {176}\"\r\n" + 
                                   "\t\t\t\t\t\"row7\" \"{105} {114} {123} {132} {141} {150} {159} {168} {177}\"\r\n" + 
                                   "\t\t\t\t\t\"row8\" \"{106} {115} {124} {133} {142} {151} {160} {169} {178}\"\r\n" + 
                                   "\t\t\t\t{16}\r\n\t\t\t\toffsets\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row1\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row2\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row3\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row4\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row5\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row6\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row7\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row8\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t{16}\r\n\t\t\t\toffset_normals\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row1\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row2\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row3\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row4\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row5\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row6\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row7\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row8\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t{16}\r\n\t\t\t\talphas\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row1\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row2\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row3\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row4\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row5\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row6\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row7\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row8\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t{16}\r\n\t\t\t\ttriangle_tags\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row1\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row2\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row3\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row4\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row5\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row6\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row7\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t{16}\r\n\t\t\t\tallowed_verts\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"10\" \"-1 -1 -1 -1 -1 -1 -1 -1 -1 -1\"\r\n\t\t\t\t{16}\r\n\t\t\t{16}\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {6} {4}) ({2} {3} {4}) ({5} {3} {4})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {3} {4}) ({2} {6} {4}) ({2} {6} {7})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({5} {6} {4}) ({5} {3} {4}) ({5} {3} {7})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {6} {4}) ({5} {6} {4}) ({5} {6} {7})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({5} {3} {4}) ({2} {3} {4}) ({2} {3} {7})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\teditor\r\n\t\t{15}\r\n\t\t\t\"color\" \"0 122 223\"\r\n\t\t\t\"visgroupshown\" \"1\"\r\n\t\t\t\"visgroupautoshown\" \"1\"\r\n\t\t{16}\r\n\t{16}\r\n";
        //bloc = String.Format(blocbase, solidid++, planeid++, x, y, z, xs, ys, zs, TailleTexture, materialtop, materialunder, materialfront, materialright, materialleft, materialbehind, "{", "}");
        //                                  0         1        2  3  4  5   6   7        8             9            10                11           12              13           14          15   16

        readonly string blocbase = "\tsolid\r\n\t{15}\r\n\t\t\"id\" \"{0}\"\r\n\t\tside\r\n" +
                              "\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {3} {7}) ({2} {6} {7}) ({5}  {6} {7})\"\r\n" +
                              "\t\t\t\"material\" \"{9}\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] {8}\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] {8}\"\r\n" +
                              "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n" +
                              "\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {6} {4}) ({2} {3} {4}) ({5} {3} {4})\"\r\n" +
                              "\t\t\t\"material\" \"{10}\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 0] {8}\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] {8}\"\r\n" +
                              "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n" +
                              "\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {3} {4}) ({2} {6} {4}) ({2} {6} {7})\"\r\n" +
                              "\t\t\t\"material\" \"{11}\"\r\n\t\t\t\"uaxis\" \"[0 -1 0 0] {8}\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] {8}\"\r\n" +
                              "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n" +
                              "\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({5} {6} {4}) ({5} {3} {4}) ({5} {3} {7})\"\r\n" +
                              "\t\t\t\"material\" \"{12}\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] {8}\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] {8}\"\r\n" +
                              "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n" +
                              "\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {6} {4}) ({5} {6} {4}) ({5} {6} {7})\"\r\n" +
                              "\t\t\t\"material\" \"{13}\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 0] {8}\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] {8}\"\r\n" +
                              "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n" +
                              "\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({5} {3} {4}) ({2} {3} {4}) ({2} {3} {7})\"\r\n" +
                              "\t\t\t\"material\" \"{14}\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] {8}\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] {8}\"\r\n" +
                              "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n" +
                              "\t\teditor\r\n\t\t{15}\r\n\t\t\t\"color\" \"0 155 180\"\r\n\t\t\t\"visgroupshown\" \"1\"\r\n\t\t\t\"visgroupautoshown\" \"1\"\r\n\t\t{16}\r\n\t{16}\r\n";
        //bloc = String.Format(blocbase, solidid++, planeid++, x, y, z, xs, ys, zs, TailleTexture, materialtop, materialunder, materialfront, materialright, materialleft, materialbehind, "{", "}");
        //                                  0         1        2  3  4  5   6   7        8             9            10                11           12              13           14          15   16


        readonly int HammerBrushLimit = 1024;

        readonly string HWGVersion = "Alpha";
        readonly string HWGAuthor = "chesiren & Guthen";

        public Frame()
        {
            InitializeComponent();

            // Seed;
            var rnd = new Random(Convert.ToInt32(nUDownSeed.Value));
            var newSeed = DateTime.Now.Millisecond * rnd.Next(1, 200);

            nUDownSeed.Value = newSeed;

            // load file path
            if ( File.Exists( "preferences.txt" ) ) {
                StreamReader sr = new StreamReader("preferences.txt");
                        tBoxOutputPath.Text = sr.ReadLine();
                        sr.Close();
            }
        }

        private void ButSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Save text Files",

                CheckFileExists = false,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (rBut2D.Checked) { savetype = "2D"; } else if (rBut3D.Checked) { savetype = "3D"; } else if (rButPerlin3D.Checked) { savetype = "Perlin 3D"; } else { savetype = "unknown"; }
                // save file path 
                StreamWriter ssw = new StreamWriter(saveFileDialog1.FileName);
                ssw.WriteLine(tBoxOutputPath.Text);
                ssw.WriteLine(nUDownSeed.Value);
                ssw.WriteLine(savetype);
                ssw.WriteLine(coBoxInterp.SelectedItem);
                ssw.WriteLine(cBoxNoiseType.SelectedItem);
                ssw.WriteLine(nUDownFrequency.Value);
                ssw.WriteLine(nUDownFracOctaves.Value);
                ssw.WriteLine(nUDownFracLacunarity.Value);
                ssw.WriteLine(nUDownFracGain.Value);
                ssw.WriteLine(nUDownChunkWidth.Value);
                //ssw.WriteLine(nUDownChunkHeight.Value);
                ssw.WriteLine(numericUpDownBlockSize.Value);
                ssw.WriteLine(ckBoxChunkFill.CheckState);
                ssw.WriteLine(ckBoxFullBreakable.CheckState);
                ssw.Close();
                MessageBox.Show(this, "Succesfully saved current settings in " + saveFileDialog1.FileName, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ButLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = @"D:\",
                Title = "Load settings",

                CheckFileExists = true,
                CheckPathExists = true,

                DefaultExt = "txt",
                Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,
            };

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // load file path
                if (File.Exists(openFileDialog1.FileName))
                {
                    bool ck;
                    StreamReader ssr = new StreamReader(openFileDialog1.FileName);
                    tBoxOutputPath.Text = ssr.ReadLine();
                    nUDownSeed.Value = Convert.ToDecimal(ssr.ReadLine());
                    savetype = ssr.ReadLine();
                    if (savetype == "2D") { rBut2D.AutoCheck = true; } else { rBut2D.AutoCheck = false; }
                    if (savetype == "3D") { rBut3D.AutoCheck = true; } else { rBut3D.AutoCheck = false; }
                    if (savetype == "Perlin 3D") { rButPerlin3D.AutoCheck = true; } else { rButPerlin3D.AutoCheck = false; }
                    coBoxInterp.SelectedItem = ssr.ReadLine();
                    cBoxNoiseType.SelectedItem = ssr.ReadLine();
                    nUDownFrequency.Value = Convert.ToDecimal(ssr.ReadLine());
                    nUDownFracOctaves.Value = Convert.ToDecimal(ssr.ReadLine());
                    nUDownFracLacunarity.Value = Convert.ToDecimal(ssr.ReadLine());
                    nUDownFracGain.Value = Convert.ToDecimal(ssr.ReadLine());
                    nUDownChunkWidth.Value = Convert.ToDecimal(ssr.ReadLine());
                    //nUDownChunkHeight.Value = Convert.ToDecimal(ssr.ReadLine());
                    numericUpDownBlockSize.Value = Convert.ToDecimal(ssr.ReadLine());
                    if (ssr.ReadLine() == "Checked") { ck = true; } else { ck = false; }
                    ckBoxChunkFill.Checked = ck;
                    if (ssr.ReadLine() == "Checked") { ck = true; } else { ck = false; }
                    ckBoxFullBreakable.Checked = ck;
                    ssr.Close();
                    MessageBox.Show(this, "Succesfully loaded previous settings in " + openFileDialog1.FileName, "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ButReset_Click(object sender, EventArgs e)
        {
            tBoxOutputPath.Text = "C:\\Users\\NAME\\Desktop\\generatemap.vmf";
            // Seed;
            var rnd = new Random(Convert.ToInt32(nUDownSeed.Value));
            var newSeed = DateTime.Now.Millisecond * rnd.Next(1, 200);

            nUDownSeed.Value = newSeed;
            // ...;
            rBut2D.AutoCheck = false;
            rBut3D.AutoCheck = false;
            rButPerlin3D.AutoCheck = true;
            coBoxInterp.SelectedItem = "Quintic";
            cBoxNoiseType.SelectedItem = "Perlin Fractal";
            nUDownFrequency.Value = 0.01m;
            nUDownFracOctaves.Value = 3m;
            nUDownFracLacunarity.Value = 2.00m;
            nUDownFracGain.Value = 0.50m;
            nUDownChunkWidth.Value = 32;
            //nUDownChunkHeight.Value = 32;
            numericUpDownBlockSize.Value = 40m;
            ckBoxChunkFill.Checked = false;
            ckBoxFullBreakable.Checked = false;
            MessageBox.Show(this, "Succesfully reseted the settings", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButReload_Click(object sender, EventArgs e)
        {
            var rnd = new Random( Convert.ToInt32( nUDownSeed.Value ) );
            var newSeed = DateTime.Now.Millisecond * rnd.Next( 1, 200 );
            
            nUDownSeed.Value = newSeed;
        }

        private void ButGenerate_Click(object sender, EventArgs e)
        {
            string type;
            if (rBut2D.Checked) { type = "2D"; } else if (rBut3D.Checked) { type = "3D"; } else if (rButPerlin3D.Checked) { type = "Perlin 3D"; } else { type = "unknown"; }
            string comment = "/////////////////////////////////////////////////////////////////////////////\r\n" +
                         "// This .vmf has been created with Hammer World Generator\r\n" +
                         "// (https://github.com/Guthen/HammerWorldGenerator).\r\n" +
                         "//       - Hammer World Generator -\r\n" +
                         "// Authors            = " + HWGAuthor + "\r\n" +
                         "// Version            = " + HWGVersion + "\r\n" +
                         "// \r\n" +
                         "//       - Generator Options -\r\n" +
                         "// Seed               = " + nUDownSeed.Value + "\r\n" +
                         "// Type               = " + type + "\r\n" +
                         "// \r\n" +
                         "//       - Perlin Options -\r\n" +
                         "// Interpolation      = " + coBoxInterp.SelectedItem + "\r\n" +
                         "// Noise type         = " + cBoxNoiseType.SelectedItem + "\r\n" +
                         "// Frequency          = " + nUDownFrequency.Value + "\r\n" +
                         "// Fractal Octaves    = " + nUDownFracOctaves.Value + "\r\n" +
                         "// Fractal Lacunarity = " + nUDownFracLacunarity.Value + "\r\n" +
                         "// Fractal Gain       = " + nUDownFracGain.Value + "\r\n" +
                         "// \r\n" +
                         "//       - World Options -\r\n" +
                         "// Width              = " + nUDownChunkWidth.Value + "\r\n" +
                         //"// Height             = " + nUDownChunkHeight.Value + "\r\n" +
                         "// \r\n" +
                         "//       - Minecraft Options -\r\n" +
                         "// Block Size         = " + numericUpDownBlockSize.Value + "\r\n" +
                         "// Fill Bottom        = " + ckBoxChunkFill.CheckState + "\r\n" +
                         "// Full Breakable     = " + ckBoxFullBreakable.CheckState + "\r\n" +
                         "/////////////////////////////////////////////////////////////////////////////\r\n";
            // reset
            pBarFinish.Value = 0;

            // get the texture size
            _TailleTexture = Decimal.Divide(numericUpDownBlockSize.Value, 128);
            TailleTexture = _TailleTexture.ToString("0.0000").Replace(",", ".");
            Console.WriteLine("TT:" + TailleTexture);

            // generation
            entityid = 0;
            solidid = 0;
            planeid = 0;

            bool breakable = ckBoxFullBreakable.Checked;
            decimal grid;

            if (coBoxResult.Text == "Minecraft"){grid = numericUpDownBlockSize.Value;}else{grid = 64;}
            save = comment + "versioninfo\r\n{\r\n\t\"editorversion\" \"400\"\r\n\t\"editorbuild\" \"8261\"\r\n\t\"mapversion\" \"1\"\r\n\t\"formatversion\" \"100\"\r\n\t\"prefab\" \"0\"\r\n}\r\nvisgroups\r\n{\r\n}\r\nviewsettings\r\n{\r\n\t\"bSnapToGrid\" \"1\"\r\n\t\"bShowGrid\" \"1\"\r\n\t\"bShowLogicalGrid\" \"0\"\r\n\t\"nGridSpacing\" \"" + grid + "\"\r\n\t\"bShow3DGrid\" \"0\"\r\n}\r\nworld\r\n{\r\n\t\"id\" \"1\"\r\n\t\"mapversion\" \"1\"\r\n\t\"classname\" \"worldspawn\"\r\n\t\"detailmaterial\" \"detail/detailsprites\"\r\n\t\"detailvbsp\" \"detail.vbsp\"\r\n\t\"maxpropscreenwidth\" \"-1\"\r\n\t\"skyname\" \"minecraft_sky_\"\r\n\t\"vmf file created with\" \"Hammer World Generator\"\r\n";

            if (rBut2D.Checked) // 2d stuff
            {
                if ( coBoxResult.Text == "Minecraft" )
                {
                    if ( Convert.ToInt32( nUDownChunkWidth.Value ) > HammerBrushLimit ) {
                        var result = MessageBox.Show(this, "Attention, la limite de brush sera dépassée (" + HammerBrushLimit + ") si vous générez " + nUDownChunkWidth.Value +" brushs ! Souhaitez-vous continuer ?",
                                      "Warning", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        
                        if ( result == DialogResult.No )
                        {
                            return;
                        }
                    }

                    var world = Generate2DWorld(Convert.ToInt32(nUDownSeed.Value), Convert.ToInt32(numericUpDownBlockSize.Value), 1, Convert.ToInt32(nUDownChunkWidth.Value), 32, 15, 30, 3);
                    Convert2DWorldToVmf(world, breakable);
                }
                else
                {
                    MessageBox.Show(this, "Vous ne pouvez pas créer un displacement en 2D !",
                                      "Erreur", MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    return;
                }
            }
            else if (rBut3D.Checked) // 3d stuff
            {
                var world = Generate3DWorld( Convert.ToInt32( nUDownSeed.Value ), Convert.ToInt32( numericUpDownBlockSize.Value ), 1, Convert.ToInt32( nUDownChunkWidth.Value ), 32, 15, 30, 3 );
                Convert3DWorldToVmf(world, breakable);
            }
            else
            {
                if (coBoxResult.Text == "Minecraft")
                {
                    var w = Convert.ToInt32(nUDownChunkWidth.Value);
                    if (w * w > HammerBrushLimit)
                    {
                        var result = MessageBox.Show(this, "Attention, la limite de brush sera dépassée (" + HammerBrushLimit + ") si vous générez " + w * w + " brushs ! Souhaitez-vous continuer ?",
                                      "Warning", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

                        if (result == DialogResult.No)
                        {
                            return;
                        }
                    }

                    var hMap = GeneratePerlin3DWorld(true, Convert.ToInt32(nUDownSeed.Value), Convert.ToInt32(nUDownChunkWidth.Value)); //, Convert.ToInt32(nUDownChunkHeight.Value), 15, 30, 3); ->  marqué comme inutilisé, à supprimer ou utiliser
                    ConvertPerlin3DWorldToVmf(hMap, breakable);
                }
                else if (coBoxResult.Text == "Displacement")
                {
                    var hMap = GeneratePerlin3DWorld(false, Convert.ToInt32(nUDownSeed.Value), Convert.ToInt32(nUDownChunkWidth.Value)); //, Convert.ToInt32(nUDownChunkHeight.Value), 15, 30, 3); ->  marqué comme inutilisé, à supprimer ou utiliser
                    ConvertDispPerlin3DWorldToVmf(hMap);
                }

            }

            save += "cameras\r\n{\r\n\t\"activecamera\" \"-1\"\r\n}\r\ncordon\r\n{\t\"mins\" \"(-1024 -1024 -1024)\"\r\n\t\"maxs\" \"(1024 1024 1024)\"\r\n\t\"active\" \"0\"\r\n}\r\n";

            StreamWriter sw = new StreamWriter(tBoxOutputPath.Text);
                sw.Write(save);
                sw.Close();

            save = String.Empty;

            MessageBox.Show(this, "Succesfully generated the vmf file ! Saved in " + tBoxOutputPath.Text,
                                      "Notification", MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

            // save file path 
            StreamWriter _sw = new StreamWriter("preferences.txt");
                _sw.Write(tBoxOutputPath.Text);
                _sw.Close();

            // Clear memory
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private int[][][] Generate2DWorld( int seed, int blockSize, int nChunks, int chunkW, int chunkH, int y, int minY, int maxY ) {
            Chunk2D.set( seed, blockSize, chunkW, chunkH, y, minY, maxY );
            Chunk2D.setFill( ckBoxChunkFill.Checked );
            int[][][] world = Chunk2D.generateWorld( nChunks );

            return world;
        }

        private int[][][][] Generate3DWorld(int seed, int blockSize, int nChunks, int chunkW, int chunkH, int y, int minY, int maxY)
        {
            Chunk3D.set(seed, blockSize, chunkW, chunkH, y, minY, maxY);
            Chunk3D.setFill(ckBoxChunkFill.Checked);
            int[][][][] world = Chunk3D.generateWorld(nChunks);

            return world;
        }

        private float[][] GeneratePerlin3DWorld(bool isMinecraft, int seed, int chunkW) //, int chunkH, int y, int minY, int maxY) ->  marqué comme inutilisé, à supprimer ou utiliser
        {
            FastNoise myNoise = new FastNoise(); // Create a FastNoise object
                myNoise.SetSeed(seed);
                myNoise.SetFrequency((float)nUDownFrequency.Value);
                myNoise.SetFractalGain( (float)nUDownFracGain.Value );
                myNoise.SetFractalLacunarity((float)nUDownFracLacunarity.Value);
                myNoise.SetFractalOctaves( Convert.ToInt32( nUDownFracOctaves.Value ) );

            switch (cBoxNoiseType.Text)
            {
                case "Perlin":
                    myNoise.SetNoiseType(FastNoise.NoiseType.Perlin); // Set the desired noise type
                    break;
                case "Cubic":
                    myNoise.SetNoiseType(FastNoise.NoiseType.Cubic); // Set the desired noise type
                    break;
                case "Cubic Fractal":
                    myNoise.SetNoiseType(FastNoise.NoiseType.CubicFractal); // Set the desired noise type
                    break;
                case "Simplex":
                    myNoise.SetNoiseType(FastNoise.NoiseType.Simplex); // Set the desired noise type
                    break;
                case "Simplex Fractal":
                    myNoise.SetNoiseType(FastNoise.NoiseType.SimplexFractal); // Set the desired noise type
                    break;
                case "Cellular":
                    myNoise.SetNoiseType(FastNoise.NoiseType.Cellular); // Set the desired noise type
                    break;
                case "White Noise":
                    myNoise.SetNoiseType(FastNoise.NoiseType.WhiteNoise); // Set the desired noise type
                    break;
                case "Value":
                    myNoise.SetNoiseType(FastNoise.NoiseType.Value); // Set the desired noise type
                    break;
                case "Value Fractal":
                    myNoise.SetNoiseType(FastNoise.NoiseType.ValueFractal); // Set the desired noise type
                    break;
                default:
                    myNoise.SetNoiseType(FastNoise.NoiseType.PerlinFractal); // Set the desired noise type
                    break;
            }

            switch (coBoxInterp.Text)
            {
                case "Hermite":
                    myNoise.SetInterp(FastNoise.Interp.Hermite);
                    break;
                case "Linear":
                    myNoise.SetInterp(FastNoise.Interp.Linear);
                    break;
                default:
                    myNoise.SetInterp(FastNoise.Interp.Quintic);
                    break;
            }

            int size = chunkW;
            if (!isMinecraft)
            {
                if (chunkW % Convert.ToInt32(nUDownDispSize.Value) == 0)
                {
                    size = 9 * chunkW / Convert.ToInt32(nUDownDispSize.Value);
                }
            }

            Console.WriteLine("Size : " + size);

            float[][] heightMap = new float[size][]; // 2D heightmap to create terrain
            for (int _x = 0; _x < size; _x++)
            {
                heightMap[_x] = new float[size];
                for (int _y = 0; _y < size; _y++)
                {
                    heightMap[_x][_y] = myNoise.GetNoise(_x, _y);
                }
            }

            return heightMap;
        }

        private void Convert2DWorldToVmf( int[][][] world, bool breakable )
        {
            string bloctype;

            if (breakable == true)
            {
                save += "}\r\n";
            }

            string output = "world = {\n";
            for (int c = 0; c < world.Length; c++)
            {
                output += "\t[" + c + "] = {\n";
                for (int y = 0; y < world[c].Length; y++)
                {
                    output += "\t\t[" + y + "] = { ";
                    for (int x = 0; x < world[c][y].Length; x++)
                    {
                        var xv = world[c][y][x];
                        output += xv + ", ";

                        if (xv <= 0) continue;

                        // get position & size
                        var s = numericUpDownBlockSize.Value;
                        var chunkOff = c * Chunk2D.getChunkWidth() * Chunk2D.getCellSize();
                        var position = new decimal[3] { x * s + chunkOff, 1, y * s };
                        var size = new decimal[3] { s, s, s };

                        switch (xv)
                        {
                            case 1:
                                bloctype = "grass";
                                break;
                            case 2:
                                bloctype = "dirt";
                                break;
                            case 3:
                                bloctype = "stone";
                                break;
                            default:
                                bloctype = "ice";
                                break;
                        }

                        CreateBloc(bloctype, breakable, position, size);
                    }
                    output += " },\n";
                }
                output += "\t},\n";
            }
            output += "}";

            OutputTextBox.Text = output;

            if (breakable == false)
            {
                save += "}\r\n";
            }
        }

        private void Convert3DWorldToVmf(int[][][][] world, bool breakable)
        {
            string bloctype;

            if (breakable == true)
            {
                save += "}\r\n";
            }

            string output = "world = {\n";
            for (int c = 0; c < world.Length; c++)
            {
                output = output + "\t[" + c + "] = {\n";
                for (int y = 0; y < world[c].Length; y++)
                {
                    output = output + "\t\t[" + y + "] = {\n";
                    for (int x = 0; x < world[c][y].Length; x++)
                    {
                        output = output + "\t\t[" + x + "] = { ";
                        for (int z = 0; z < world[c][y][x].Length; z++)
                        {
                            var xv = world[c][y][x][z];
                            output = output + xv + ", ";

                            if (xv <= 0) continue;

                            // get position & size
                            var s = numericUpDownBlockSize.Value;
                            var chunkOff = c * Chunk2D.getChunkWidth() * Chunk2D.getCellSize();
                            var position = new decimal[3] { x * s + chunkOff, z * s, y * s };
                            var size = new decimal[3] { s, s, s };

                            switch (xv)
                            {
                                case 1:
                                    bloctype = "grass";
                                    break;
                                case 2:
                                    bloctype = "dirt";
                                    break;
                                case 3:
                                    bloctype = "stone";
                                    break;
                                default:
                                    bloctype = "";
                                    break;
                            }
                            if (coBoxResult.Text == "Minecraft")
                            {
                                CreateBloc(bloctype, breakable, position, size);
                            }
                            else if (coBoxResult.Text == "Displacement")
                            {
                                //CreateDisp(position, size);
                            }
                        }
                        output += " },\n";
                    }
                    output += "\t\t},\n";
                }
                output += "\t},\n";
            }
            output += "}";

            OutputTextBox.Text = output;

            if (breakable == false)
            {
                save += "}\r\n";
            }
        }

        private void ConvertPerlin3DWorldToVmf(float[][] world, bool breakable)
        {
            string bloctype;

            if (breakable == true)
            {
                save += "}\r\n";
            }

            var i = 0;
            var max = world.Length * world[0].Length;

            bloctype = coBoxSurface.Text.ToLower();

            string output = "world = {\n";
            for (int x = 0; x < world.Length; x++)
            {
                output += "\t\t[" + x + "] = { ";
                for (int y = 0; y < world[x].Length; y++)
                {
                    var p = i / (max) * 100;
                    pBarFinish.Value = p;

                    Console.WriteLine("i: " + i + "#w*#w: " + world.Length * world[x].Length + " p: " + p);

                    var z = Math.Round( world[x][y] * 10 );
                    output += z + ", ";

                    // get position & size
                    var s = numericUpDownBlockSize.Value;
                    var position = new decimal[3] { x * s, y * s, Convert.ToDecimal(z) * s };
                    var size = new decimal[3] { s, s, s };

                    //Console.WriteLine("x:" + position[0] + " y:" + position[1] + " z:" + position[2]);

                    CreateBloc(bloctype, breakable, position, size);
                    i++;
                }
                output += " },\n";
                i++;
            }
            output += "\t},\n";
            output += "}";

            OutputTextBox.Text = output;

            if (breakable == false)
            {
                save += "}\r\n";
            }
        }

        private void ConvertDispPerlin3DWorldToVmf(float[][] world)
        {
            string bloctype = "grass";
            bool breakable = ckBoxFullBreakable.Checked;

            if (breakable == true)
            {
                save += "}\r\n";
            }

            var s = nUDownDispSize.Value;
            var size = new decimal[3] { s, s, s };
            //var max = world.Length * world[0].Length;

            float[][] zPos = new float[9][];

            Console.WriteLine("BlocType: " + bloctype);

            string output = "world = {\n";
            for ( int u = 0; u <= Math.Round(s / nUDownDispSize.Value); u++ )
            {
                for (int x = 0; x < 9; x++)
                {
                    zPos[x] = new float[9];

                    output += "\t\t[" + x + "] = { ";
                    for (int y = 0; y < 9; y++)
                    {
                        //var p = Math.Round( Convert.ToDouble( i / (max) * 100 ) );
                        //pBarFinish.Value = Convert.ToInt32( p );

                        //Console.WriteLine("i: " + i + " #w*#w: " + world.Length * world[x].Length + " p: " + p);

                        var z = world[x][y] * 200;
                        zPos[x][y] = z;

                        output += z + ", ";
                        //Console.WriteLine("x:" + position[0] + " y:" + position[1] + " z:" + position[2]);
                    }
                    output += " },\n";
                }
                var position = new decimal[3] { u * s, u * s, -s - 64 };
                CreateDisp(position, size, zPos[0], zPos[1], zPos[2], zPos[3], zPos[4], zPos[5], zPos[6], zPos[7], zPos[8]);
            }

            output += "\t},\n";
            output += "}";

            OutputTextBox.Text = output;

            if (breakable == false)
            {
                save += "}\r\n";
            }
        }

        private int Norm( float n )
        {
            if (n < 0) return -1;
            if (n > 0) return 1;

            return 0;
        }

        private void CreateDisp(decimal[] posVec, decimal[] sizeVec, float[] zA, float[] zB, float[] zC, float[] zD, float[] zE, float[] zF, float[] zG, float[] zH, float[] zI)
        {
            decimal x = posVec[0]; //
            decimal y = posVec[1]; // positions
            string z = posVec[2].ToString().Replace(",", "."); //

            decimal xs = x + sizeVec[0]; //
            decimal ys = y + sizeVec[1]; // size positions
            string zs = (posVec[2] + sizeVec[2]).ToString().Replace(",","."); //

            disp = string.Format(dispbase, solidid++, planeid++, x, y, z, xs, ys, zs, TailleTexture, materialtop, materialunder, materialfront, materialright, materialleft, materialbehind, "{", "}", 
                            Norm(zA[0]), Norm(zA[1]), Norm(zA[2]), Norm(zA[3]), Norm(zA[4]), Norm(zA[5]), Norm(zA[6]), Norm(zA[7]), Norm(zA[8]), Norm(zB[0]), Norm(zB[1]), Norm(zB[2]), Norm(zB[3]), Norm(zB[4]), Norm(zB[5]), Norm(zB[6]), Norm(zB[7]), Norm(zB[8]), Norm(zC[0]), Norm(zC[1]), Norm(zC[2]), Norm(zC[3]), Norm(zC[4]), Norm(zC[5]), Norm(zC[6]), Norm(zC[7]), Norm(zC[8]), Norm(zD[0]), Norm(zD[1]), Norm(zD[2]), Norm(zD[3]), Norm(zD[4]), Norm(zD[5]), Norm(zD[6]), Norm(zD[7]), Norm(zD[8]), Norm(zE[0]), Norm(zE[1]), Norm(zE[2]), Norm(zE[3]), Norm(zE[4]), Norm(zE[5]), Norm(zE[6]), Norm(zE[7]), Norm(zE[8]), Norm(zF[0]), Norm(zF[1]), Norm(zF[2]), Norm(zF[3]), Norm(zF[4]), Norm(zF[5]), Norm(zF[6]), Norm(zF[7]), Norm(zF[8]), Norm(zG[0]), Norm(zG[1]), Norm(zG[2]), Norm(zG[3]), Norm(zG[4]), Norm(zG[5]), Norm(zG[6]), Norm(zG[7]), Norm(zG[8]), Norm(zH[0]), Norm(zH[1]), Norm(zH[2]), Norm(zH[3]), Norm(zH[4]), Norm(zH[5]), Norm(zH[6]), Norm(zH[7]), Norm(zH[8]), Norm(zI[0]), Norm(zI[1]), Norm(zI[2]), Norm(zI[3]), Norm(zI[4]), Norm(zI[5]), Norm(zI[6]), Norm(zI[7]), Norm(zI[8]),
                            zA[0].ToString().Replace(",","."), zA[1].ToString().Replace(",","."), zA[2].ToString().Replace(",","."), zA[3].ToString().Replace(",","."), zA[4].ToString().Replace(",","."), zA[5].ToString().Replace(",","."), zA[6].ToString().Replace(",","."), zA[7].ToString().Replace(",","."), zA[8].ToString().Replace(",","."), zB[0].ToString().Replace(",","."), zB[1].ToString().Replace(",","."), zB[2].ToString().Replace(",","."), zB[3].ToString().Replace(",","."), zB[4].ToString().Replace(",","."), zB[5].ToString().Replace(",","."), zB[6].ToString().Replace(",","."), zB[7].ToString().Replace(",","."), zB[8].ToString().Replace(",","."), zC[0].ToString().Replace(",","."), zC[1].ToString().Replace(",","."), zC[2].ToString().Replace(",","."), zC[3].ToString().Replace(",","."), zC[4].ToString().Replace(",","."), zC[5].ToString().Replace(",","."), zC[6].ToString().Replace(",","."), zC[7].ToString().Replace(",","."), zC[8].ToString().Replace(",","."), zD[0].ToString().Replace(",","."), zD[1].ToString().Replace(",","."), zD[2].ToString().Replace(",","."), zD[3].ToString().Replace(",","."), zD[4].ToString().Replace(",","."), zD[5].ToString().Replace(",","."), zD[6].ToString().Replace(",","."), zD[7].ToString().Replace(",","."), zD[8].ToString().Replace(",","."), zE[0].ToString().Replace(",","."), zE[1].ToString().Replace(",","."), zE[2].ToString().Replace(",","."), zE[3].ToString().Replace(",","."), zE[4].ToString().Replace(",","."), zE[5].ToString().Replace(",","."), zE[6].ToString().Replace(",","."), zE[7].ToString().Replace(",","."), zE[8].ToString().Replace(",","."), zF[0].ToString().Replace(",","."), zF[1].ToString().Replace(",","."), zF[2].ToString().Replace(",","."), zF[3].ToString().Replace(",","."), zF[4].ToString().Replace(",","."), zF[5].ToString().Replace(",","."), zF[6].ToString().Replace(",","."), zF[7].ToString().Replace(",","."), zF[8].ToString().Replace(",","."), zG[0].ToString().Replace(",","."), zG[1].ToString().Replace(",","."), zG[2].ToString().Replace(",","."), zG[3].ToString().Replace(",","."), zG[4].ToString().Replace(",","."), zG[5].ToString().Replace(",","."), zG[6].ToString().Replace(",","."), zG[7].ToString().Replace(",","."), zG[8].ToString().Replace(",","."), zH[0].ToString().Replace(",","."), zH[1].ToString().Replace(",","."), zH[2].ToString().Replace(",","."), zH[3].ToString().Replace(",","."), zH[4].ToString().Replace(",","."), zH[5].ToString().Replace(",","."), zH[6].ToString().Replace(",","."), zH[7].ToString().Replace(",","."), zH[8].ToString().Replace(",","."), zI[0].ToString().Replace(",","."), zI[1].ToString().Replace(",","."), zI[2].ToString().Replace(",","."), zI[3].ToString().Replace(",","."), zI[4].ToString().Replace(",","."), zI[5].ToString().Replace(",","."), zI[6].ToString().Replace(",","."), zI[7].ToString().Replace(",","."), zI[8].ToString().Replace(",",".") );
            
            save += disp;
        }

        // CreateBloc( blockType, breakable, posVec, sizeVec );
        private void CreateBloc(string bloctype, bool breakable, decimal[] posVec, decimal[] sizeVec)
        {
            decimal x = posVec[0]; //
            decimal y = posVec[1]; // positions
            decimal z = posVec[2]; //

            //decimal s = numericUpDownBlockSize.Value; // cubic size

            decimal xs = x + sizeVec[0]; //
            decimal ys = y + sizeVec[1]; // size positions
            decimal zs = z + sizeVec[2]; //

            GetBlocMat(bloctype, breakable);

            if (bloctype == "skybox")
            {
                bloc = string.Format(blocbase, solidid++, planeid++, x, y, z, xs, ys, zs, TailleTexture, materialtop, materialunder, materialfront, materialright, materialleft, materialbehind, "{", "}");
            }
            else if (bloctype != "skybox" &&  breakable == true)
            {
                bloc = "entity\r\n{\r\n\t\"id\" \"" + entityid++ + "\"\r\n\t\"classname\" \"func_breakable\"\r\n\t\"disablereceiveshadows\" \"0\"\r\n\t\"disableshadows\" \"0\"\r\n" +
                       "\t\"ExplodeDamage\" \"0\"\r\n\t\"explodemagnitude\" \"0\"\r\n\t\"ExplodeRadius\" \"0\"\r\n\t\"explosion\" \"1\"\r\n\t\"gibdir\" \"0 0 0\"\r\n" +
                       "\t\"gmod_allowphysgun\" \"0\"\r\n\t\"health\" \"30\"\r\n\t\"material\" \"5\"\r\n\t\"minhealthdmg\" \"0\"\r\n\t\"nodamageforces\" \"0\"\r\n" +
                       "\t\"origin\" \"100 124 36\"\r\n\t\"PerformanceMode\" \"0\"\r\n\t\"physdamagescale\" \"1.0\"\r\n\t\"pressuredelay\" \"0\"\r\n" +
                       "\t\"propdata\" \"0\"\r\n\t\"renderamt\" \"255\"\r\n\t\"rendercolor\" \"255 255 255\"\r\n\t\"renderfx\" \"0\"\r\n\t\"rendermode\" \"0\"\r\n" +
                       "\t\"spawnflags\" \"0\"\r\n\t\"spawnobject\" \"0\"\r\n";

                bloc += string.Format(blocbase, solidid++, planeid++, x, y, z, xs, ys, zs, TailleTexture, materialtop, materialunder, materialfront, materialright, materialleft, materialbehind, "{", "}");

                bloc += "\teditor\r\n\t{\r\n\t\t\"color\" \"220 30 220\"\r\n\t\t\"visgroupshown\" \"1\"\r\n\t\t\"visgroupautoshown\" \"1\"\r\n\t\t\"logicalpos\" \"[0 11000]\"\r\n\t}\r\n}\r\n";
            }
            else if (bloctype != "skybox" && breakable == false)
            {
                bloc = string.Format(blocbase, solidid++, planeid++, x, y, z, xs, ys, zs, TailleTexture, materialtop, materialunder, materialfront, materialright, materialleft, materialbehind, "{", "}");
            }
            save += bloc;
        }
        private void GetBlocMat(string bloctype, bool breakable)
        {
            switch( bloctype )
            {
                case "grass":
                    materialtop = "MC/GRASS";
                    materialright = "MC/DIRT_GRASSSIDE";
                    materialleft = "MC/DIRT_GRASSSIDE";
                    materialbehind = "MC/DIRT_GRASSSIDE";
                    materialfront = "MC/DIRT_GRASSSIDE";
                    materialunder = "MC/DIRT";
                    break;
                case "dirt":
                    materialtop = "MC/DIRT";
                    materialright = "MC/DIRT";
                    materialleft = "MC/DIRT";
                    materialbehind = "MC/DIRT";
                    materialfront = "MC/DIRT";
                    materialunder = "MC/DIRT";
                    break;
                case "stone":
                    materialtop = "MC/STONE";
                    materialright = "MC/STONE";
                    materialleft = "MC/STONE";
                    materialbehind = "MC/STONE";
                    materialfront = "MC/STONE";
                    materialunder = "MC/STONE";
                    break;
                case "cobblestone":
                    materialtop = "MC/COBBLESTONE";
                    materialright = "MC/COBBLESTONE";
                    materialleft = "MC/COBBLESTONE";
                    materialbehind = "MC/COBBLESTONE";
                    materialfront = "MC/COBBLESTONE";
                    materialunder = "MC/COBBLESTONE";
                    break;
                case "snowgrass":
                    materialtop = "MC/SNOW";
                    materialright = "MC/DIRT_SNOWSIDE";
                    materialleft = "MC/DIRT_SNOWSIDE";
                    materialbehind = "MC/DIRT_SNOWSIDE";
                    materialfront = "MC/DIRT_SNOWSIDE";
                    materialunder = "MC/DIRT";
                    break;
                case "snow":
                    materialtop = "MC/SNOW";
                    materialright = "MC/SNOW";
                    materialleft = "MC/SNOW";
                    materialbehind = "MC/SNOW";
                    materialfront = "MC/SNOW";
                    materialunder = "MC/SNOW";
                    break;
                case "clay":
                    materialtop = "MC/CLAY";
                    materialright = "MC/CLAY";
                    materialleft = "MC/CLAY";
                    materialbehind = "MC/CLAY";
                    materialfront = "MC/CLAY";
                    materialunder = "MC/CLAY";
                    break;
                case "sand":
                    materialtop = "MC/SAND";
                    materialright = "MC/SAND";
                    materialleft = "MC/SAND";
                    materialbehind = "MC/SAND";
                    materialfront = "MC/SAND";
                    materialunder = "MC/SAND";
                    break;
                case "glass":
                    materialtop = "MC/GLASS";
                    materialright = "MC/GLASS";
                    materialleft = "MC/GLASS";
                    materialbehind = "MC/GLASS";
                    materialfront = "MC/GLASS";
                    materialunder = "MC/GLASS";
                    break;
                case "ice":
                    materialtop = "MC/ICE";
                    materialright = "MC/ICE";
                    materialleft = "MC/ICE";
                    materialbehind = "MC/ICE";
                    materialfront = "MC/ICE";
                    materialunder = "MC/ICE";
                    break;
                case "skybox":
                    materialtop = "MC/BEDROCK";
                    materialright = "TOOLS/TOOLSSKYBOX";
                    materialleft = "TOOLS/TOOLSSKYBOX";
                    materialbehind = "TOOLS/TOOLSSKYBOX";
                    materialfront = "TOOLS/TOOLSSKYBOX";
                    materialunder = "TOOLS/TOOLSSKYBOX";
                    break;
                default:
                    materialtop = "MC/BEDROCK";
                    materialright = "MC/BEDROCK";
                    materialleft = "MC/BEDROCK";
                    materialbehind = "MC/BEDROCK";
                    materialfront = "MC/BEDROCK";
                    materialunder = "MC/BEDROCK";
                    break;
            }
            if (breakable == false && bloctype != "skybox")
            {
                materialunder = "TOOLS/TOOLSNODRAW";
            }
        }

        private void NUDownChunkWidth_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
