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
        string save;
        public Frame()
        {
            InitializeComponent();
        }
        
       /* private void butGenerate_Click(object sender, EventArgs e) // a fusionner avec celui d'en dessous
        {
            Console.Write( "HI" );
            int world = GenerateWorld( int.Parse( tBoxChunkSeed.Text ), Decimal.ToInt32( numericUpDownBlockSize.Value ), 10, Decimal.ToInt32( nUDownChunkWidth.Value ), Decimal.ToInt32( nUDownChunkHeight.Value ), 15, 30, 5 );
            foreach ( int c in world ) {
                Console.WriteLine( c );
            }
        }*/
        
        private void butGenerate_Click(object sender, EventArgs e)
        {
            GenerateWorld( Convert.ToInt32( nUDownSeed.Value ), Convert.ToInt32( numericUpDownBlockSize.Value ), 5, Convert.ToInt32( nUDownChunkWidth.Value ), Convert.ToInt32( nUDownChunkHeight.Value ), 15, 30, 5 );

            entityid = 0;
            solidid = 0;
            planeid = 0;
            string bloctype;
            bool breakable = ckBoxFullBreakable.Checked;

            save = "versioninfo\r\n{\r\n\t\"editorversion\" \"400\"\r\n\t\"editorbuild\" \"8261\"\r\n\t\"mapversion\" \"19\"\r\n\t\"formatversion\" \"100\"\r\n\t\"prefab\" \"0\"\r\n}\r\nvisgroups\r\n{\r\n}\r\nviewsettings\r\n{\r\n\t\"bSnapToGrid\" \"1\"\r\n\t\"bShowGrid\" \"1\"\r\n\t\"bShowLogicalGrid\" \"0\"\r\n\t\"nGridSpacing\" \"8\"\r\n\t\"bShow3DGrid\" \"0\"\r\n}\r\nworld\r\n{\r\n\t\"id\" \"1\"\r\n\t\"mapversion\" \"19\"\r\n\t\"classname\" \"worldspawn\"\r\n\t\"detailmaterial\" \"detail/detailsprites\"\r\n\t\"detailvbsp\" \"detail.vbsp\"\r\n\t\"maxpropscreenwidth\" \"-1\"\r\n\t\"skyname\" \"minecraft_sky_\"\r\n";

            bloctype = "skybox";
            CreateBloc(bloctype, breakable);

            // on ferme {} de world si le monde est cassable
            if (breakable == true)
            {
                save += "}\r\n";
            }

            bloctype = "grass";
            CreateBloc(bloctype, breakable);
            bloctype = "dirt";
            CreateBloc(bloctype, breakable);
            bloctype = "stone";
            CreateBloc(bloctype, breakable);

            if (breakable == false)
            {
                save += "}\r\n";
            }
            save += "cameras\r\n{\r\n\t\"activecamera\" \"-1\"\r\n}\r\ncordon\r\n{\t\"mins\" \"(-1024 -1024 -1024)\"\r\n\t\"maxs\" \"(1024 1024 1024)\"\r\n\t\"active\" \"0\"\r\n}\r\n";

                StreamWriter sw = new StreamWriter(this.tBoxOutputPath.Text);
                sw.Write(save);
                sw.Close();
                MessageBox.Show(this, "Succesfully generated the vmf file ! Saved in " + tBoxOutputPath.Text,
                                    "Notification", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
        }
        
        private int[][][] GenerateWorld( int seed, int blockSize, int nChunks, int chunkW, int chunkH, int y, int minY, int maxY ) {
            Chunk3D.set( seed, blockSize, chunkW, chunkH, y, minY, maxY );
            int[][][] world = Chunk3D.generateWorld( nChunks );

            Console.WriteLine( world.Length + " " + world[1].Length + " " + world[1][1].Length );

            return world;
        }
        
        // Faut améliorer cette fonction :
        // CreateBloc( blockType, posVec, sizeVec );
        private void CreateBloc(string bloctype, bool breakable)
        {
            string bloc;
            string materialtop = "MC/BEDROCK";
            string materialright = "MC/BEDROCK";
            string materialleft = "MC/BEDROCK";
            string materialbehind = "MC/BEDROCK";
            string materialfront = "MC/BEDROCK";
            string materialunder = "MC/BEDROCK";
            if (bloctype == "grass")
            {
                materialtop = "MC/GRASS";
                materialright = "MC/DIRT_GRASSSIDE";
                materialleft = "MC/DIRT_GRASSSIDE";
                materialbehind = "MC/DIRT_GRASSSIDE";
                materialfront = "MC/DIRT_GRASSSIDE";
                materialunder = "MC/DIRT";
            }
            else if (bloctype == "dirt")
            {
                materialtop = "MC/DIRT";
                materialright = "MC/DIRT";
                materialleft = "MC/DIRT";
                materialbehind = "MC/DIRT";
                materialfront = "MC/DIRT";
                materialunder = "MC/DIRT";
            }
            else if (bloctype == "stone")
            {
                materialtop = "MC/STONE";
                materialright = "MC/STONE";
                materialleft = "MC/STONE";
                materialbehind = "MC/STONE";
                materialfront = "MC/STONE";
                materialunder = "MC/STONE";
            }

            if (bloctype == "skybox")
            {
                bloc = "\tsolid\r\n\t{\r\n\t\t\"id\" \"" + solidid++ + "\"\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 0 20) (56 40 20) (96 40 20)\"\r\n" +
                       "\t\t\t\"material\" \"MC/BEDROCK\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 40 -20) (56 0 -20) (96 0 -20)\"\r\n" +
                       "\t\t\t\"material\" \"TOOLS/TOOLSSKYBOX\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 0 -20) (56 40 -20) (56 40 20)\"\r\n" +
                       "\t\t\t\"material\" \"TOOLS/TOOLSSKYBOX\"\r\n\t\t\t\"uaxis\" \"[0 -1 0 0] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(96 40 -20) (96 0 -20) (96 0 20)\"\r\n" +
                       "\t\t\t\"material\" \"TOOLS/TOOLSSKYBOX\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 40 -20) (96 40 -20) (96 40 20)\"\r\n" +
                       "\t\t\t\"material\" \"TOOLS/TOOLSSKYBOX\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(96 0 -20) (56 0 -20) (56 0 20)\"\r\n" +
                       "\t\t\t\"material\" \"TOOLS/TOOLSSKYBOX\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n" +
                       "\t\teditor\r\n\t\t{\r\n\t\t\t\"color\" \"0 155 180\"\r\n\t\t\t\"visgroupshown\" \"1\"\r\n\t\t\t\"visgroupautoshown\" \"1\"\r\n\t\t}\r\n\t}\r\n";
                save += bloc;
            }

            if (bloctype != "skybox" &&  breakable == true)
            {
                bloc = "entity\r\n{\r\n\t\"id\" \"" + entityid++ + "\"\r\n\t\"classname\" \"func_breakable\"\r\n\t\"disablereceiveshadows\" \"0\"\r\n\t\"disableshadows\" \"0\"\r\n" +
                       "\t\"ExplodeDamage\" \"0\"\r\n\t\"explodemagnitude\" \"0\"\r\n\t\"ExplodeRadius\" \"0\"\r\n\t\"explosion\" \"1\"\r\n\t\"gibdir\" \"0 0 0\"\r\n" +
                       "\t\"gmod_allowphysgun\" \"0\"\r\n\t\"health\" \"30\"\r\n\t\"material\" \"5\"\r\n\t\"minhealthdmg\" \"0\"\r\n\t\"nodamageforces\" \"0\"\r\n" +
                       "\t\"origin\" \"100 124 36\"\r\n\t\"PerformanceMode\" \"0\"\r\n\t\"physdamagescale\" \"1.0\"\r\n\t\"pressuredelay\" \"0\"\r\n" +
                       "\t\"propdata\" \"0\"\r\n\t\"renderamt\" \"255\"\r\n\t\"rendercolor\" \"255 255 255\"\r\n\t\"renderfx\" \"0\"\r\n\t\"rendermode\" \"0\"\r\n" +
                       "\t\"spawnflags\" \"0\"\r\n\t\"spawnobject\" \"0\"\r\n\tsolid\r\n\t{\r\n\t\t\"id\" \"" + solidid++ + "\"\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 0 20) (56 40 20) (96 40 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialtop + "\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 40 -20) (56 0 -20) (96 0 -20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialunder + "\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 0 -20) (56 40 -20) (56 40 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialfront + "\"\r\n\t\t\t\"uaxis\" \"[0 -1 0 0] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(96 40 -20) (96 0 -20) (96 0 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialright + "\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 40 -20) (96 40 -20) (96 40 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialleft + "\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(96 0 -20) (56 0 -20) (56 0 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialbehind + "\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n" +
                       "\t\teditor\r\n\t\t{\r\n\t\t\t\"color\" \"0 155 180\"\r\n\t\t\t\"visgroupshown\" \"1\"\r\n\t\t\t\"visgroupautoshown\" \"1\"\r\n\t\t}\r\n\t}\r\n" +
                       "\teditor\r\n\t{\r\n\t\t\"color\" \"220 30 220\"\r\n\t\t\"visgroupshown\" \"1\"\r\n\t\t\"visgroupautoshown\" \"1\"\r\n\t\t\"logicalpos\" \"[0 11000]\"\r\n\t}\r\n}\r\n";
                save += bloc;
            }

            if (bloctype != "skybox" && breakable == false)
            {
                bloc = "\tsolid\r\n\t{\r\n\t\t\"id\" \"" + solidid++ + "\"\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 0 20) (56 40 20) (96 40 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialtop + "\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 40 -20) (56 0 -20) (96 0 -20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialunder + "\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 0 -20) (56 40 -20) (56 40 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialfront + "\"\r\n\t\t\t\"uaxis\" \"[0 -1 0 0] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(96 40 -20) (96 0 -20) (96 0 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialright + "\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(56 40 -20) (96 40 -20) (96 40 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialleft + "\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(96 0 -20) (56 0 -20) (56 0 20)\"\r\n" +
                       "\t\t\t\"material\" \"" + materialbehind + "\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n" +
                       "\t\teditor\r\n\t\t{\r\n\t\t\t\"color\" \"0 155 180\"\r\n\t\t\t\"visgroupshown\" \"1\"\r\n\t\t\t\"visgroupautoshown\" \"1\"\r\n\t\t}\r\n\t}\r\n";
                save += bloc;
            }
        }
    }
}
