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
        public Frame()
        {
            InitializeComponent();
        }

        private void CkBoxChunkFill_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void NumericUpDownBlockHeight_ValueChanged(object sender, EventArgs e)
        {
        }

        private void NumericUpDownBlockWidth_ValueChanged(object sender, EventArgs e)
        {
        }

        private void gBoxOptions_Enter(object sender, EventArgs e)
        {
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void ButCompile_Click(object sender, EventArgs e)
        {
            Console.Write( "HI" );
            int world = GenerateWorld( int.Parse( tBoxChunkSeed.Text ), Decimal.ToInt32( numericUpDownBlockSize.Value ), 10, Decimal.ToInt32( nUDownChunkWidth.Value ), Decimal.ToInt32( nUDownChunkHeight.Value ), 15, 30, 5 );
            foreach ( int c in world ) {
                Console.WriteLine( c );
            }
        }
  
        private void butGenerate_Click(object sender, EventArgs e)
        {
            string save = "versioninfo\r\n{\r\n\t\"editorversion\" \"400\"\r\n\t\"editorbuild\" \"8261\"\r\n\t\"mapversion\" \"19\"\r\n\t\"formatversion\" \"100\"\r\n\t\"prefab\" \"0\"\r\n}\r\nvisgroups\r\n{\r\n}\r\nviewsettings\r\n{\r\n\t\"bSnapToGrid\" \"1\"\r\n\t\"bShowGrid\" \"1\"\r\n\t\"bShowLogicalGrid\" \"0\"\r\n\t\"nGridSpacing\" \"8\"\r\n\t\"bShow3DGrid\" \"0\"\r\n}\r\nworld\r\n{\r\n\t\"id\" \"1\"\r\n\t\"mapversion\" \"19\"\r\n\t\"classname\" \"worldspawn\"\r\n\t\"detailmaterial\" \"detail/detailsprites\"\r\n\t\"detailvbsp\" \"detail.vbsp\"\r\n\t\"maxpropscreenwidth\" \"-1\"\r\n\t\"skyname\" \"minecraft_sky_\"\r\n";


            //save = save + lignes[i] + "\r\n";
            StreamWriter sw = new StreamWriter(this.tBoxOutputPath.Text);
            sw.Write(save);
            sw.Close();
            MessageBox.Show(this, "Succesfully generated the vmf file ! Saved in " + tBoxOutputPath.Text,
                                   "Notification", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);
        }

        private int GenerateWorld( int seed, int blockSize, int nChunks, int chunkW, int chunkH, int y, int minY, int maxY ) {
            Chunk3D chunk3d = new Chunk3D();
            int[] world = chunk3d.set( seed, blockSize, chunkW, chunkH, y, minY, maxY );
            world.generateWorld( nChunks );

            return world;
        }

        private string CreateSkybox(string skyname, bool size)
        {
            
        }
        
        // CreateBloc( className, posVec, sizeVec, topMat, otherMat );
        private string CreateBloc(string bloctype, bool breakable) 
        {
            
            string plane = "\t\t\t\"plane\" \"(";
            string[] stringSeparators = new string[] { ") (", " ", ")\"" };
            ligne = ligne.Substring(13);

            NumberFormatInfo provider = new NumberFormatInfo();
            provider.NumberDecimalSeparator = ".";

            string[] groupede3;
            groupede3 = ligne.Split(stringSeparators, StringSplitOptions.RemoveEmptyEntries);

            int n = 0;

            foreach (var element in groupede3)
            {
                double result;
                result = Convert.ToDouble(groupede3[n], provider);

                double nombre = Math.Round(result, MidpointRounding.AwayFromZero);
                groupede3[n] = nombre.ToString();
                n = n + 1;
            }

            ligne = plane + groupede3[0] + " " + groupede3[1] + " " + groupede3[2] + ") ";
            ligne += "(" + groupede3[3] + " " + groupede3[4] + " " + groupede3[5] + ") ";
            ligne += "(" + groupede3[6] + " " + groupede3[7] + " " + groupede3[8] + ")\"";
            output2.Text = output2.Text + ligne.Substring(3) + "\r\n";

            return ligne;
        }
    }
}
