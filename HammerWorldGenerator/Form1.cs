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
        float TailleTexture;

        string save;
        string bloc;
        string materialtop = "MC/BEDROCK";
        string materialright = "MC/BEDROCK";
        string materialleft = "MC/BEDROCK";
        string materialbehind = "MC/BEDROCK";
        string materialfront = "MC/BEDROCK";
        string materialunder = "MC/BEDROCK";

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
        
        private void butGenerate_Click(object sender, EventArgs e)
        {
            // generation
            var world = GenerateWorld( Convert.ToInt32( nUDownSeed.Value ), Convert.ToInt32( numericUpDownBlockSize.Value ), Convert.ToInt32( nUDownChunks.Value ), Convert.ToInt32( nUDownChunkWidth.Value ), Convert.ToInt32( nUDownChunkHeight.Value ), 15, 30, 3 );
            entityid = 0;
            solidid = 0;
            planeid = 0;

            string bloctype;
            bool breakable = ckBoxFullBreakable.Checked;

            save = "versioninfo\r\n{\r\n\t\"editorversion\" \"400\"\r\n\t\"editorbuild\" \"8261\"\r\n\t\"mapversion\" \"19\"\r\n\t\"formatversion\" \"100\"\r\n\t\"prefab\" \"0\"\r\n}\r\nvisgroups\r\n{\r\n}\r\nviewsettings\r\n{\r\n\t\"bSnapToGrid\" \"1\"\r\n\t\"bShowGrid\" \"1\"\r\n\t\"bShowLogicalGrid\" \"0\"\r\n\t\"nGridSpacing\" \"8\"\r\n\t\"bShow3DGrid\" \"0\"\r\n}\r\nworld\r\n{\r\n\t\"id\" \"1\"\r\n\t\"mapversion\" \"19\"\r\n\t\"classname\" \"worldspawn\"\r\n\t\"detailmaterial\" \"detail/detailsprites\"\r\n\t\"detailvbsp\" \"detail.vbsp\"\r\n\t\"maxpropscreenwidth\" \"-1\"\r\n\t\"skyname\" \"minecraft_sky_\"\r\n";

            if (breakable == true)
            {
                save += "}\r\n";
            }

            string output = "world = {\n";
            for ( int c = 0; c < world.Length; c++ )
            {
                output = output + "\t["+c+ "] = {\n";
                for ( int y = 0; y < world[c].Length; y++ )
                {
                    output = output + "\t\t[" +y+ "] = { ";
                    for ( int x = 0; x < world[c][y].Length; x++)
                    {
                        var xv = world[c][y][x];
                        output = output + xv +", ";

                        if ( xv <= 0 ) continue;

                        // get position & size
                        var s = numericUpDownBlockSize.Value;
                        var chunkOff = c * Chunk3D.getChunkWidth() * Chunk3D.getCellSize();
                        var position = new decimal[3] { x * s + chunkOff, 1, y * s };
                        var size = new decimal[3] { s, s, s };

                        switch(xv)
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

                        CreateBloc( bloctype, breakable, position, size );
                    }
                    output = output + " },\n";
                }
                output = output + "\t},\n";
            }
            output = output + "}";

            OutputTextBox.Text = output;

            if (breakable == false)
            {
                save += "}\r\n";
            }
            
            // get position & size
            //int[] position = new int[3] { 1, 1, 1 };
            //decimal[] size = new decimal[3] { numericUpDownBlockSize.Value, numericUpDownBlockSize.Value, numericUpDownBlockSize.Value };

            //bloctype = "skybox";
            //CreateBloc(bloctype, breakable, position, size);

            // on ferme {} de world si le monde est cassable, la skybox doit être crée avant cette ligne
            //if (breakable == true)
            //{
            //    save += "}\r\n";
            //}

            //bloctype = "grass";
            //CreateBloc(bloctype, breakable, position, size);
            //bloctype = "dirt";
            //CreateBloc(bloctype, breakable, position, size);
            //bloctype = "stone";
            //CreateBloc(bloctype, breakable, position, size);

            //if (breakable == false)
            //{
            //    save += "}\r\n";
            //}
            save += "cameras\r\n{\r\n\t\"activecamera\" \"-1\"\r\n}\r\ncordon\r\n{\t\"mins\" \"(-1024 -1024 -1024)\"\r\n\t\"maxs\" \"(1024 1024 1024)\"\r\n\t\"active\" \"0\"\r\n}\r\n";

            StreamWriter sw = new StreamWriter(tBoxOutputPath.Text);
                        sw.Write(save);
                        sw.Close();

            MessageBox.Show(this, "Succesfully generated the vmf file ! Saved in " + tBoxOutputPath.Text,
                                      "Notification", MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);

            // save file path 
            StreamWriter _sw = new StreamWriter("preferences.txt");
                _sw.Write(tBoxOutputPath.Text);
                _sw.Close();
        }
        
        private int[][][] GenerateWorld( int seed, int blockSize, int nChunks, int chunkW, int chunkH, int y, int minY, int maxY ) {
            Chunk3D.set( seed, blockSize, chunkW, chunkH, y, minY, maxY );
            Chunk3D.setFill( ckBoxChunkFill.Checked );
            int[][][] world = Chunk3D.generateWorld( nChunks );

            return world;
        }
        
        // Faut améliorer cette fonction :
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

            GetBlocMat(bloctype);

            if (bloctype == "skybox")
            {
                bloc = "\tsolid\r\n\t{\r\n\t\t\"id\" \"" + solidid++ + "\"\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + x + " " + y + " " + zs + ") (" + x + " " + ys + " " + zs + ") (" + xs + "  " + ys + " " + zs + ")\"\r\n" +
                       "\t\t\t\"material\" \"MC/BEDROCK\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + x + " " + ys + " " + z + ") (" + x + " " + y + " " + z + ") (" + xs + " " + y + " " + z + ")\"\r\n" +
                       "\t\t\t\"material\" \"TOOLS/TOOLSSKYBOX\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + x + " " + y + " " + z + ") (" + x + " " + ys + " " + z + ") (" + x + " " + ys + " " + zs + ")\"\r\n" +
                       "\t\t\t\"material\" \"TOOLS/TOOLSSKYBOX\"\r\n\t\t\t\"uaxis\" \"[0 -1 0 0] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + xs + " " + ys + " " + z + ") (" + xs + " " + y + " " + z + ") (" + xs + " " + y + " " + zs + ")\"\r\n" +
                       "\t\t\t\"material\" \"TOOLS/TOOLSSKYBOX\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + x + " " + ys + " " + z + ") (" + xs + " " + ys + " " + z + ") (" + xs + " " + ys + " " + zs + ")\"\r\n" +
                       "\t\t\t\"material\" \"TOOLS/TOOLSSKYBOX\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] 0.3125\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] 0.3125\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + xs + " " + y + " " + z + ") (" + x + " " + y + " " + z + ") (" + x + " " + y + " " + zs + ")\"\r\n" +
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
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + x + " " + y + " " + zs + ") (" + x + " " + ys + " " + zs + ") (" + xs + "  " + ys + " " + zs + ")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialtop + "\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] " + TailleTexture + "\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + x + " " + ys + " " + z + ") (" + x + " " + y + " " + z + ") (" + xs + " " + y + " " + z + ")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialunder + "\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] " + TailleTexture + "\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + x + " " + y + " " + z + ") (" + x + " " + ys + " " + z + ") (" + x + " " + ys + " " + zs + ")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialfront + "\"\r\n\t\t\t\"uaxis\" \"[0 -1 0 0] " + TailleTexture + "\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + xs + " " + ys + " " + z + ") (" + xs + " " + y + " " + z + ") (" + xs + " " + y + " " + zs + ")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialright + "\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] " + TailleTexture + "\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + x + " " + ys + " " + z + ") (" + xs + " " + ys + " " + z + ") (" + xs + " " + ys + " " + zs + ")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialleft + "\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] " + TailleTexture + "\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"(" + xs + " " + y + " " + z + ") (" + x + " " + y + " " + z + ") (" + x + " " + y + " " + zs + ")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialbehind + "\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] "+TailleTexture+ "\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n" +
                       "\t\teditor\r\n\t\t{\r\n\t\t\t\"color\" \"0 155 180\"\r\n\t\t\t\"visgroupshown\" \"1\"\r\n\t\t\t\"visgroupautoshown\" \"1\"\r\n\t\t}\r\n\t}\r\n" +
                       "\teditor\r\n\t{\r\n\t\t\"color\" \"220 30 220\"\r\n\t\t\"visgroupshown\" \"1\"\r\n\t\t\"visgroupautoshown\" \"1\"\r\n\t\t\"logicalpos\" \"[0 11000]\"\r\n\t}\r\n}\r\n";
                save += bloc;
            }

            if (bloctype != "skybox" && breakable == false)
            {
                bloc = "\tsolid\r\n\t{\r\n\t\t\"id\" \"" + solidid++ + "\"\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"("+x+" "+y+" "+zs+ ") ("+x+" "+ys+" "+zs+") ("+xs+"  "+ys+" "+zs+")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialtop + "\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] "+TailleTexture+ "\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"("+x+" "+ys+" "+z+") ("+x+" "+y+" "+z+") ("+xs+" "+y+" "+z+")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialunder + "\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] "+TailleTexture+ "\"\r\n\t\t\t\"vaxis\" \"[0 -1 0 0] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"("+x+" "+y+" "+z+") ("+x+" "+ys+" "+z+") ("+x+" "+ys+" "+zs+")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialfront + "\"\r\n\t\t\t\"uaxis\" \"[0 -1 0 0] "+TailleTexture+ "\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"("+xs+" "+ys+" "+z+") ("+xs+" "+y+" "+z+") ("+xs+" "+y+" "+zs+")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialright + "\"\r\n\t\t\t\"uaxis\" \"[0 1 0 0] "+TailleTexture+ "\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"("+x+" "+ys+" "+z+") ("+xs+" "+ys+" "+z+") ("+xs+" "+ys+" "+zs+")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialleft + "\"\r\n\t\t\t\"uaxis\" \"[-1 0 0 51.2] "+TailleTexture+ "\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n\t\tside\r\n" +
                       "\t\t{\r\n\t\t\t\"id\" \"" + planeid++ + "\"\r\n\t\t\t\"plane\" \"("+xs+" "+y+" "+z+") ("+x+" "+y+" "+z+") ("+x+" "+y+" "+zs+")\"\r\n" +
                       "\t\t\t\"material\" \"" + materialbehind + "\"\r\n\t\t\t\"uaxis\" \"[1 0 0 -51.2] "+TailleTexture+ "\"\r\n\t\t\t\"vaxis\" \"[0 0 -1 -64] " + TailleTexture + "\"\r\n" +
                       "\t\t\t\"rotation\" \"0\"\r\n\t\t\t\"lightmapscale\" \"16\"\r\n\t\t\t\"smoothing_groups\" \"0\"\r\n\t\t}\r\n" +
                       "\t\teditor\r\n\t\t{\r\n\t\t\t\"color\" \"0 155 180\"\r\n\t\t\t\"visgroupshown\" \"1\"\r\n\t\t\t\"visgroupautoshown\" \"1\"\r\n\t\t}\r\n\t}\r\n";
                save += bloc;
            }
        }
        private void GetBlocMat(string bloctype)
        {
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
            else if (bloctype == "cobblestone")
            {
                materialtop = "MC/COBBLESTONE";
                materialright = "MC/COBBLESTONE";
                materialleft = "MC/COBBLESTONE";
                materialbehind = "MC/COBBLESTONE";
                materialfront = "MC/COBBLESTONE";
                materialunder = "MC/COBBLESTONE";
            }
            else if (bloctype == "snowgrass")
            {
                materialtop = "MC/SNOW";
                materialright = "MC/DIRT_SNOWSIDE";
                materialleft = "MC/DIRT_SNOWSIDE";
                materialbehind = "MC/DIRT_SNOWSIDE";
                materialfront = "MC/DIRT_SNOWSIDE";
                materialunder = "MC/DIRT";
            }
            else if (bloctype == "snowbloc")
            {
                materialtop = "MC/SNOW";
                materialright = "MC/SNOW";
                materialleft = "MC/SNOW";
                materialbehind = "MC/SNOW";
                materialfront = "MC/SNOW";
                materialunder = "MC/SNOW";
            }
            else if (bloctype == "clay")
            {
                materialtop = "MC/CLAY";
                materialright = "MC/CLAY";
                materialleft = "MC/CLAY";
                materialbehind = "MC/CLAY";
                materialfront = "MC/CLAY";
                materialunder = "MC/CLAY";
            }
            else if (bloctype == "sand")
            {
                materialtop = "MC/SAND";
                materialright = "MC/SAND";
                materialleft = "MC/SAND";
                materialbehind = "MC/SAND";
                materialfront = "MC/SAND";
                materialunder = "MC/SAND";
            }
            else if (bloctype == "glass")
            {
                materialtop = "MC/GLASS";
                materialright = "MC/GLASS";
                materialleft = "MC/GLASS";
                materialbehind = "MC/GLASS";
                materialfront = "MC/GLASS";
                materialunder = "MC/GLASS";
            }
            else if (bloctype == "ice")
            {
                materialtop = "MC/ICE";
                materialright = "MC/ICE";
                materialleft = "MC/ICE";
                materialbehind = "MC/ICE";
                materialfront = "MC/ICE";
                materialunder = "MC/ICE";
            }
            //TailleTexture = Decimal.Divide(128, numericUpDownBlockSize.Value);
            TailleTexture = (float)numericUpDownBlockSize.Value / 128;
            Console.WriteLine( "TT:" + TailleTexture );
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
