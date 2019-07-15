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

        readonly string dispbase = "\tsolid\r\n\t{15}\r\n\t\t\"id\" \"{0}\"\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {3} {7}) ({2} {6} {7}) ({5} {6} {7})\"\r\n\t\t\t\"material\" \"MC/GRASS\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t\tdispinfo\r\n\t\t\t{15}\r\n\t\t\t\t\"power\" \"3\"\r\n\t\t\t\t\"startposition\" \"[0 0 256]\"\r\n\t\t\t\t\"flags\" \"0\"\r\n\t\t\t\t\"elevation\" \"0\"\r\n\t\t\t\t\"subdiv\" \"0\"\r\n\t\t\t\tnormals\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row1\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row2\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row3\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row4\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row5\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row6\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row7\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row8\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t{16}\r\n\t\t\t\tdistances\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row1\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row2\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row3\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row4\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row5\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row6\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row7\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row8\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t{16}\r\n\t\t\t\toffsets\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row1\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row2\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row3\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row4\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row5\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row6\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row7\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row8\" \"0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t{16}\r\n\t\t\t\toffset_normals\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row1\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row2\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row3\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row4\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row5\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row6\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row7\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t\t\"row8\" \"0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1 0 0 1\"\r\n\t\t\t\t{16}\r\n\t\t\t\talphas\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row1\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row2\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row3\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row4\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row5\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row6\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row7\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t\t\"row8\" \"0 0 0 0 0 0 0 0 0\"\r\n\t\t\t\t{16}\r\n\t\t\t\ttriangle_tags\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"row0\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row1\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row2\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row3\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row4\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row5\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row6\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t\t\"row7\" \"9 9 9 9 9 9 9 9 9 9 9 9 9 9 9 9\"\r\n\t\t\t\t{16}\r\n\t\t\t\tallowed_verts\r\n\t\t\t\t{15}\r\n\t\t\t\t\t\"10\" \"-1 -1 -1 -1 -1 -1 -1 -1 -1 -1\"\r\n\t\t\t\t{16}\r\n\t\t\t{16}\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {6} {4}) ({2} {3} {4}) ({5} {3} {4})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {3} {4}) ({2} {6} {4}) ({2} {6} {7})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({5} {6} {4}) ({5} {3} {4}) ({5} {3} {7})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({2} {6} {4}) ({5} {6} {4}) ({5} {6} {7})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\tside\r\n\t\t{15}\r\n\t\t\t\"id\" \"{1}\"\r\n\t\t\t\"plane\" \"({5} {3} {4}) ({2} {3} {4}) ({2} {3} {7})\"\r\n\t\t\t\"material\" \"MC/DIRT\"\r\n\t\t\t\"uaxis\" \"[1 0 0 0] 0.5\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 0] 0.5\"\r\n\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t{16}\r\n\t\teditor\r\n\t\t{15}\r\n\t\t\t\"color\" \"0 122 223\"\r\n\t\t\t\"visgroupshown\" \"1\"\r\n\t\t\t\"visgroupautoshown\" \"1\"\r\n\t\t{16}\r\n\t{16}\r\n";
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
            nUDownSeed.Value = DateTime.Now.Millisecond;

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
                ssw.WriteLine(nUDownChunkHeight.Value);
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
                    nUDownChunkHeight.Value = Convert.ToDecimal(ssr.ReadLine());
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
            nUDownSeed.Value = DateTime.Now.Millisecond;
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
            nUDownChunkHeight.Value = 32;
            numericUpDownBlockSize.Value = 40m;
            ckBoxChunkFill.Checked = false;
            ckBoxFullBreakable.Checked = false;
            MessageBox.Show(this, "Succesfully reseted the settings", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButReload_Click(object sender, EventArgs e)
        {
            nUDownSeed.Value = DateTime.Now.Millisecond;
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
                         "//       - Chunk Options -\r\n" +
                         "// Width              = " + nUDownChunkWidth.Value + "\r\n" +
                         "// Height             = " + nUDownChunkHeight.Value + "\r\n" +
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

                    var world = Generate2DWorld(Convert.ToInt32(nUDownSeed.Value), Convert.ToInt32(numericUpDownBlockSize.Value), 1, Convert.ToInt32(nUDownChunkWidth.Value), Convert.ToInt32(nUDownChunkHeight.Value), 15, 30, 3);
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
                var world = Generate3DWorld( Convert.ToInt32( nUDownSeed.Value ), Convert.ToInt32( numericUpDownBlockSize.Value ), 1, Convert.ToInt32( nUDownChunkWidth.Value ), Convert.ToInt32( nUDownChunkHeight.Value ), 15, 30, 3 );
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

                    var hMap = GeneratePerlin3DWorld(Convert.ToInt32(nUDownSeed.Value), 1, Convert.ToInt32(nUDownChunkWidth.Value)); //, Convert.ToInt32(nUDownChunkHeight.Value), 15, 30, 3); ->  marqué comme inutilisé, à supprimer ou utiliser
                    ConvertPerlin3DWorldToVmf(hMap, breakable);
                }
                else if (coBoxResult.Text == "Displacement")
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

                    var hMap = GenerateDispPerlin3DWorld(Convert.ToInt32(nUDownSeed.Value), 1, Convert.ToInt32(nUDownChunkWidth.Value)); //, Convert.ToInt32(nUDownChunkHeight.Value), 15, 30, 3); ->  marqué comme inutilisé, à supprimer ou utiliser
                    ConvertDispPerlin3DWorldToVmf(hMap, breakable);
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

        private float[][] GeneratePerlin3DWorld(int seed, int nChunks, int chunkW) //, int chunkH, int y, int minY, int maxY) ->  marqué comme inutilisé, à supprimer ou utiliser
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

        float[][] heightMap = new float[chunkW*nChunks][]; // 2D heightmap to create terrain
            for (int _x = 0; _x < chunkW * nChunks; _x++)
            {
                heightMap[_x] = new float[chunkW*nChunks];
                for (int _y = 0; _y < chunkW * nChunks; _y++)
                {
                    heightMap[_x][_y] = myNoise.GetNoise(_x, _y);
                }
            }

            return heightMap;
        }

        private float[][] GenerateDispPerlin3DWorld(int seed, int nChunks, int chunkW) //, int chunkH, int y, int minY, int maxY) ->  marqué comme inutilisé, à supprimer ou utiliser
        {
            FastNoise myNoise = new FastNoise(); // Create a FastNoise object
            myNoise.SetSeed(seed);
            myNoise.SetFrequency((float)nUDownFrequency.Value);
            myNoise.SetFractalGain((float)nUDownFracGain.Value);
            myNoise.SetFractalLacunarity((float)nUDownFracLacunarity.Value);
            myNoise.SetFractalOctaves(Convert.ToInt32(nUDownFracOctaves.Value));

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

            float[][] heightMap = new float[chunkW * nChunks][]; // 2D heightmap to create terrain
            for (int _x = 0; _x < chunkW * nChunks; _x++)
            {
                heightMap[_x] = new float[chunkW * nChunks];
                for (int _y = 0; _y < chunkW * nChunks; _y++)
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
                                CreateDisp(position, size);
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

        private void ConvertDispPerlin3DWorldToVmf(float[][] world, bool breakable)
        {
            string bloctype = "grass";

            if (breakable == true)
            {
                save += "}\r\n";
            }

            var i = 0;
            var max = world.Length * world[0].Length;

            Console.WriteLine("BlocType: " + bloctype);

            string output = "world = {\n";
            for (int x = 0; x < world.Length; x++)
            {
                output += "\t\t[" + x + "] = { ";
                for (int y = 0; y < world[x].Length; y++)
                {
                    var p = Math.Round( Convert.ToDouble( i / (max) * 100 ) );
                    pBarFinish.Value = Convert.ToInt32( p );

                    Console.WriteLine("i: " + i + " #w*#w: " + world.Length * world[x].Length + " p: " + p);

                    var z = world[x][y] * 10;
                    output += z + ", ";

                    // get position & size
                    var s = nUDownDispSize.Value;
                    var position = new decimal[3] { x * s, y * s, Convert.ToDecimal(z) };
                    var size = new decimal[3] { s, s, s };

                    //Console.WriteLine("x:" + position[0] + " y:" + position[1] + " z:" + position[2]);

                    CreateDisp(position, size);
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

        private void CreateDisp(decimal[] posVec, decimal[] sizeVec)
        {
            decimal x = posVec[0]; //
            decimal y = posVec[1]; // positions
            string z = posVec[2].ToString().Replace(",", "."); //

            decimal xs = x + sizeVec[0]; //
            decimal ys = y + sizeVec[1]; // size positions
            string zs = (posVec[2] + sizeVec[2]).ToString().Replace(",","."); //

            disp = string.Format(dispbase, solidid++, planeid++, x, y, z, xs, ys, zs, TailleTexture, materialtop, materialunder, materialfront, materialright, materialleft, materialbehind, "{", "}");
            
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
    }
}
