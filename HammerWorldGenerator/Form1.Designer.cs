namespace HammerWorldGenerator
{
    partial class Frame
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.gBoxOptions = new System.Windows.Forms.GroupBox();
            this.gBoxSave = new System.Windows.Forms.GroupBox();
            this.ButReset = new System.Windows.Forms.Button();
            this.ButLoad = new System.Windows.Forms.Button();
            this.ButSave = new System.Windows.Forms.Button();
            this.labelresult = new System.Windows.Forms.Label();
            this.coBoxResult = new System.Windows.Forms.ComboBox();
            this.gBoxPerlin = new System.Windows.Forms.GroupBox();
            this.cBoxNoiseType = new System.Windows.Forms.ComboBox();
            this.labelnoisetype = new System.Windows.Forms.Label();
            this.labelgain = new System.Windows.Forms.Label();
            this.nUDownFracGain = new System.Windows.Forms.NumericUpDown();
            this.labellacunarity = new System.Windows.Forms.Label();
            this.nUDownFracLacunarity = new System.Windows.Forms.NumericUpDown();
            this.labeloctaves = new System.Windows.Forms.Label();
            this.nUDownFracOctaves = new System.Windows.Forms.NumericUpDown();
            this.labelfrequency = new System.Windows.Forms.Label();
            this.coBoxInterp = new System.Windows.Forms.ComboBox();
            this.labelinterpolation = new System.Windows.Forms.Label();
            this.nUDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.labeltype = new System.Windows.Forms.Label();
            this.rButPerlin3D = new System.Windows.Forms.RadioButton();
            this.rBut3D = new System.Windows.Forms.RadioButton();
            this.rBut2D = new System.Windows.Forms.RadioButton();
            this.nUDownSeed = new System.Windows.Forms.NumericUpDown();
            this.gBoxMinecraft = new System.Windows.Forms.GroupBox();
            this.ckBoxFullBreakable = new System.Windows.Forms.CheckBox();
            this.labelblocksize = new System.Windows.Forms.Label();
            this.numericUpDownBlockSize = new System.Windows.Forms.NumericUpDown();
            this.ckBoxChunkFill = new System.Windows.Forms.CheckBox();
            this.labelseed = new System.Windows.Forms.Label();
            this.gBoxChunk = new System.Windows.Forms.GroupBox();
            this.labelheight = new System.Windows.Forms.Label();
            this.nUDownChunkHeight = new System.Windows.Forms.NumericUpDown();
            this.labelwidth = new System.Windows.Forms.Label();
            this.nUDownChunkWidth = new System.Windows.Forms.NumericUpDown();
            this.labeloutput = new System.Windows.Forms.Label();
            this.tBoxOutputPath = new System.Windows.Forms.TextBox();
            this.ButGenerate = new System.Windows.Forms.Button();
            this.gBoxOutput = new System.Windows.Forms.GroupBox();
            this.pBarFinish = new System.Windows.Forms.ProgressBar();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ButReload = new System.Windows.Forms.Button();
            this.gBoxOptions.SuspendLayout();
            this.gBoxSave.SuspendLayout();
            this.gBoxPerlin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFracGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFracLacunarity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFracOctaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownSeed)).BeginInit();
            this.gBoxMinecraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).BeginInit();
            this.gBoxChunk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkWidth)).BeginInit();
            this.gBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxOptions
            // 
            this.gBoxOptions.Controls.Add(this.ButReload);
            this.gBoxOptions.Controls.Add(this.gBoxSave);
            this.gBoxOptions.Controls.Add(this.labelresult);
            this.gBoxOptions.Controls.Add(this.coBoxResult);
            this.gBoxOptions.Controls.Add(this.gBoxPerlin);
            this.gBoxOptions.Controls.Add(this.labeltype);
            this.gBoxOptions.Controls.Add(this.rButPerlin3D);
            this.gBoxOptions.Controls.Add(this.rBut3D);
            this.gBoxOptions.Controls.Add(this.rBut2D);
            this.gBoxOptions.Controls.Add(this.nUDownSeed);
            this.gBoxOptions.Controls.Add(this.gBoxMinecraft);
            this.gBoxOptions.Controls.Add(this.labelseed);
            this.gBoxOptions.Controls.Add(this.gBoxChunk);
            this.gBoxOptions.Location = new System.Drawing.Point(12, 12);
            this.gBoxOptions.Name = "gBoxOptions";
            this.gBoxOptions.Size = new System.Drawing.Size(472, 449);
            this.gBoxOptions.TabIndex = 0;
            this.gBoxOptions.TabStop = false;
            this.gBoxOptions.Text = "Generator Options";
            // 
            // gBoxSave
            // 
            this.gBoxSave.Controls.Add(this.ButReset);
            this.gBoxSave.Controls.Add(this.ButLoad);
            this.gBoxSave.Controls.Add(this.ButSave);
            this.gBoxSave.Location = new System.Drawing.Point(207, 246);
            this.gBoxSave.Name = "gBoxSave";
            this.gBoxSave.Size = new System.Drawing.Size(253, 197);
            this.gBoxSave.TabIndex = 23;
            this.gBoxSave.TabStop = false;
            this.gBoxSave.Text = "Save Options";
            // 
            // ButReset
            // 
            this.ButReset.Location = new System.Drawing.Point(10, 77);
            this.ButReset.Name = "ButReset";
            this.ButReset.Size = new System.Drawing.Size(139, 23);
            this.ButReset.TabIndex = 2;
            this.ButReset.Text = "Reset settings";
            this.ButReset.UseVisualStyleBackColor = true;
            this.ButReset.Click += new System.EventHandler(this.ButReset_Click);
            // 
            // ButLoad
            // 
            this.ButLoad.Location = new System.Drawing.Point(10, 49);
            this.ButLoad.Name = "ButLoad";
            this.ButLoad.Size = new System.Drawing.Size(139, 23);
            this.ButLoad.TabIndex = 1;
            this.ButLoad.Text = "Load settings";
            this.ButLoad.UseVisualStyleBackColor = true;
            this.ButLoad.Click += new System.EventHandler(this.ButLoad_Click);
            // 
            // ButSave
            // 
            this.ButSave.Location = new System.Drawing.Point(10, 20);
            this.ButSave.Name = "ButSave";
            this.ButSave.Size = new System.Drawing.Size(139, 23);
            this.ButSave.TabIndex = 0;
            this.ButSave.Text = "Save settings";
            this.ButSave.UseVisualStyleBackColor = true;
            this.ButSave.Click += new System.EventHandler(this.ButSave_Click);
            // 
            // labelresult
            // 
            this.labelresult.AutoSize = true;
            this.labelresult.Location = new System.Drawing.Point(249, 23);
            this.labelresult.Name = "labelresult";
            this.labelresult.Size = new System.Drawing.Size(43, 13);
            this.labelresult.TabIndex = 22;
            this.labelresult.Text = "Result :";
            // 
            // coBoxResult
            // 
            this.coBoxResult.FormattingEnabled = true;
            this.coBoxResult.Items.AddRange(new object[] {
            "Minecraft",
            "Displacement"});
            this.coBoxResult.Location = new System.Drawing.Point(298, 20);
            this.coBoxResult.Name = "coBoxResult";
            this.coBoxResult.Size = new System.Drawing.Size(147, 21);
            this.coBoxResult.TabIndex = 21;
            this.coBoxResult.Text = "Displacement";
            // 
            // gBoxPerlin
            // 
            this.gBoxPerlin.Controls.Add(this.cBoxNoiseType);
            this.gBoxPerlin.Controls.Add(this.labelnoisetype);
            this.gBoxPerlin.Controls.Add(this.labelgain);
            this.gBoxPerlin.Controls.Add(this.nUDownFracGain);
            this.gBoxPerlin.Controls.Add(this.labellacunarity);
            this.gBoxPerlin.Controls.Add(this.nUDownFracLacunarity);
            this.gBoxPerlin.Controls.Add(this.labeloctaves);
            this.gBoxPerlin.Controls.Add(this.nUDownFracOctaves);
            this.gBoxPerlin.Controls.Add(this.labelfrequency);
            this.gBoxPerlin.Controls.Add(this.coBoxInterp);
            this.gBoxPerlin.Controls.Add(this.labelinterpolation);
            this.gBoxPerlin.Controls.Add(this.nUDownFrequency);
            this.gBoxPerlin.Location = new System.Drawing.Point(13, 68);
            this.gBoxPerlin.Name = "gBoxPerlin";
            this.gBoxPerlin.Size = new System.Drawing.Size(447, 171);
            this.gBoxPerlin.TabIndex = 12;
            this.gBoxPerlin.TabStop = false;
            this.gBoxPerlin.Text = "Perlin Options";
            // 
            // cBoxNoiseType
            // 
            this.cBoxNoiseType.FormattingEnabled = true;
            this.cBoxNoiseType.Items.AddRange(new object[] {
            "Perlin",
            "Perlin Fractal",
            "Cubic",
            "Cubic Fractal",
            "Simplex",
            "Simplex Fractal",
            "Value",
            "Value Fractal",
            "White Noise",
            "Cellular"});
            this.cBoxNoiseType.Location = new System.Drawing.Point(107, 49);
            this.cBoxNoiseType.Name = "cBoxNoiseType";
            this.cBoxNoiseType.Size = new System.Drawing.Size(147, 21);
            this.cBoxNoiseType.TabIndex = 20;
            this.cBoxNoiseType.Text = "Perlin Fractal";
            // 
            // labelnoisetype
            // 
            this.labelnoisetype.AutoSize = true;
            this.labelnoisetype.Location = new System.Drawing.Point(30, 52);
            this.labelnoisetype.Name = "labelnoisetype";
            this.labelnoisetype.Size = new System.Drawing.Size(67, 13);
            this.labelnoisetype.TabIndex = 19;
            this.labelnoisetype.Text = "Noise Type :";
            // 
            // labelgain
            // 
            this.labelgain.AutoSize = true;
            this.labelgain.Location = new System.Drawing.Point(30, 139);
            this.labelgain.Name = "labelgain";
            this.labelgain.Size = new System.Drawing.Size(70, 13);
            this.labelgain.TabIndex = 18;
            this.labelgain.Text = "Fractal Gain :";
            // 
            // nUDownFracGain
            // 
            this.nUDownFracGain.DecimalPlaces = 2;
            this.nUDownFracGain.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUDownFracGain.Location = new System.Drawing.Point(107, 137);
            this.nUDownFracGain.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDownFracGain.Name = "nUDownFracGain";
            this.nUDownFracGain.Size = new System.Drawing.Size(68, 20);
            this.nUDownFracGain.TabIndex = 17;
            this.nUDownFracGain.TabStop = false;
            this.nUDownFracGain.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // labellacunarity
            // 
            this.labellacunarity.AutoSize = true;
            this.labellacunarity.Location = new System.Drawing.Point(4, 113);
            this.labellacunarity.Name = "labellacunarity";
            this.labellacunarity.Size = new System.Drawing.Size(97, 13);
            this.labellacunarity.TabIndex = 16;
            this.labellacunarity.Text = "Fractal Lacunarity :";
            // 
            // nUDownFracLacunarity
            // 
            this.nUDownFracLacunarity.DecimalPlaces = 2;
            this.nUDownFracLacunarity.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUDownFracLacunarity.Location = new System.Drawing.Point(107, 111);
            this.nUDownFracLacunarity.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDownFracLacunarity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDownFracLacunarity.Name = "nUDownFracLacunarity";
            this.nUDownFracLacunarity.Size = new System.Drawing.Size(68, 20);
            this.nUDownFracLacunarity.TabIndex = 15;
            this.nUDownFracLacunarity.TabStop = false;
            this.nUDownFracLacunarity.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // labeloctaves
            // 
            this.labeloctaves.AutoSize = true;
            this.labeloctaves.Location = new System.Drawing.Point(13, 87);
            this.labeloctaves.Name = "labeloctaves";
            this.labeloctaves.Size = new System.Drawing.Size(88, 13);
            this.labeloctaves.TabIndex = 14;
            this.labeloctaves.Text = "Fractal Octaves :";
            // 
            // nUDownFracOctaves
            // 
            this.nUDownFracOctaves.Location = new System.Drawing.Point(107, 85);
            this.nUDownFracOctaves.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nUDownFracOctaves.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDownFracOctaves.Name = "nUDownFracOctaves";
            this.nUDownFracOctaves.Size = new System.Drawing.Size(68, 20);
            this.nUDownFracOctaves.TabIndex = 13;
            this.nUDownFracOctaves.TabStop = false;
            this.nUDownFracOctaves.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // labelfrequency
            // 
            this.labelfrequency.AutoSize = true;
            this.labelfrequency.Location = new System.Drawing.Point(295, 25);
            this.labelfrequency.Name = "labelfrequency";
            this.labelfrequency.Size = new System.Drawing.Size(63, 13);
            this.labelfrequency.TabIndex = 12;
            this.labelfrequency.Text = "Frequency :";
            // 
            // coBoxInterp
            // 
            this.coBoxInterp.FormattingEnabled = true;
            this.coBoxInterp.Items.AddRange(new object[] {
            "Quintic",
            "Linear",
            "Hermite"});
            this.coBoxInterp.Location = new System.Drawing.Point(107, 22);
            this.coBoxInterp.Name = "coBoxInterp";
            this.coBoxInterp.Size = new System.Drawing.Size(147, 21);
            this.coBoxInterp.TabIndex = 9;
            this.coBoxInterp.Text = "Quintic";
            // 
            // labelinterpolation
            // 
            this.labelinterpolation.AutoSize = true;
            this.labelinterpolation.Location = new System.Drawing.Point(30, 25);
            this.labelinterpolation.Name = "labelinterpolation";
            this.labelinterpolation.Size = new System.Drawing.Size(71, 13);
            this.labelinterpolation.TabIndex = 8;
            this.labelinterpolation.Text = "Interpolation :";
            // 
            // nUDownFrequency
            // 
            this.nUDownFrequency.DecimalPlaces = 2;
            this.nUDownFrequency.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nUDownFrequency.Location = new System.Drawing.Point(364, 23);
            this.nUDownFrequency.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDownFrequency.Name = "nUDownFrequency";
            this.nUDownFrequency.Size = new System.Drawing.Size(68, 20);
            this.nUDownFrequency.TabIndex = 11;
            this.nUDownFrequency.TabStop = false;
            this.nUDownFrequency.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labeltype
            // 
            this.labeltype.AutoSize = true;
            this.labeltype.Location = new System.Drawing.Point(14, 47);
            this.labeltype.Name = "labeltype";
            this.labeltype.Size = new System.Drawing.Size(37, 13);
            this.labeltype.TabIndex = 11;
            this.labeltype.Text = "Type :";
            // 
            // rButPerlin3D
            // 
            this.rButPerlin3D.AutoSize = true;
            this.rButPerlin3D.Checked = true;
            this.rButPerlin3D.Location = new System.Drawing.Point(153, 45);
            this.rButPerlin3D.Name = "rButPerlin3D";
            this.rButPerlin3D.Size = new System.Drawing.Size(68, 17);
            this.rButPerlin3D.TabIndex = 10;
            this.rButPerlin3D.TabStop = true;
            this.rButPerlin3D.Text = "Perlin 3D";
            this.rButPerlin3D.UseVisualStyleBackColor = true;
            // 
            // rBut3D
            // 
            this.rBut3D.AutoSize = true;
            this.rBut3D.Enabled = false;
            this.rBut3D.Location = new System.Drawing.Point(108, 45);
            this.rBut3D.Name = "rBut3D";
            this.rBut3D.Size = new System.Drawing.Size(39, 17);
            this.rBut3D.TabIndex = 9;
            this.rBut3D.Text = "3D";
            this.rBut3D.UseVisualStyleBackColor = true;
            // 
            // rBut2D
            // 
            this.rBut2D.AutoSize = true;
            this.rBut2D.Location = new System.Drawing.Point(58, 45);
            this.rBut2D.Name = "rBut2D";
            this.rBut2D.Size = new System.Drawing.Size(39, 17);
            this.rBut2D.TabIndex = 8;
            this.rBut2D.Text = "2D";
            this.rBut2D.UseVisualStyleBackColor = true;
            // 
            // nUDownSeed
            // 
            this.nUDownSeed.Location = new System.Drawing.Point(57, 20);
            this.nUDownSeed.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.nUDownSeed.Name = "nUDownSeed";
            this.nUDownSeed.Size = new System.Drawing.Size(104, 20);
            this.nUDownSeed.TabIndex = 5;
            // 
            // gBoxMinecraft
            // 
            this.gBoxMinecraft.Controls.Add(this.ckBoxFullBreakable);
            this.gBoxMinecraft.Controls.Add(this.labelblocksize);
            this.gBoxMinecraft.Controls.Add(this.numericUpDownBlockSize);
            this.gBoxMinecraft.Controls.Add(this.ckBoxChunkFill);
            this.gBoxMinecraft.Location = new System.Drawing.Point(13, 353);
            this.gBoxMinecraft.Name = "gBoxMinecraft";
            this.gBoxMinecraft.Size = new System.Drawing.Size(187, 90);
            this.gBoxMinecraft.TabIndex = 7;
            this.gBoxMinecraft.TabStop = false;
            this.gBoxMinecraft.Text = "Minecraft Options";
            // 
            // ckBoxFullBreakable
            // 
            this.ckBoxFullBreakable.AutoSize = true;
            this.ckBoxFullBreakable.Location = new System.Drawing.Point(89, 50);
            this.ckBoxFullBreakable.Name = "ckBoxFullBreakable";
            this.ckBoxFullBreakable.Size = new System.Drawing.Size(92, 17);
            this.ckBoxFullBreakable.TabIndex = 6;
            this.ckBoxFullBreakable.Text = "Full breakable";
            this.ckBoxFullBreakable.UseVisualStyleBackColor = true;
            // 
            // labelblocksize
            // 
            this.labelblocksize.AutoSize = true;
            this.labelblocksize.Location = new System.Drawing.Point(6, 22);
            this.labelblocksize.Name = "labelblocksize";
            this.labelblocksize.Size = new System.Drawing.Size(63, 13);
            this.labelblocksize.TabIndex = 5;
            this.labelblocksize.Text = "Block Size :";
            // 
            // numericUpDownBlockSize
            // 
            this.numericUpDownBlockSize.Location = new System.Drawing.Point(75, 19);
            this.numericUpDownBlockSize.Name = "numericUpDownBlockSize";
            this.numericUpDownBlockSize.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownBlockSize.TabIndex = 4;
            this.numericUpDownBlockSize.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // ckBoxChunkFill
            // 
            this.ckBoxChunkFill.AutoSize = true;
            this.ckBoxChunkFill.Location = new System.Drawing.Point(6, 51);
            this.ckBoxChunkFill.Name = "ckBoxChunkFill";
            this.ckBoxChunkFill.Size = new System.Drawing.Size(74, 17);
            this.ckBoxChunkFill.TabIndex = 4;
            this.ckBoxChunkFill.Text = "Fill Bottom";
            this.ckBoxChunkFill.UseVisualStyleBackColor = true;
            // 
            // labelseed
            // 
            this.labelseed.AutoSize = true;
            this.labelseed.Location = new System.Drawing.Point(13, 22);
            this.labelseed.Name = "labelseed";
            this.labelseed.Size = new System.Drawing.Size(38, 13);
            this.labelseed.TabIndex = 6;
            this.labelseed.Text = "Seed :";
            // 
            // gBoxChunk
            // 
            this.gBoxChunk.Controls.Add(this.labelheight);
            this.gBoxChunk.Controls.Add(this.nUDownChunkHeight);
            this.gBoxChunk.Controls.Add(this.labelwidth);
            this.gBoxChunk.Controls.Add(this.nUDownChunkWidth);
            this.gBoxChunk.Location = new System.Drawing.Point(13, 245);
            this.gBoxChunk.Name = "gBoxChunk";
            this.gBoxChunk.Size = new System.Drawing.Size(187, 102);
            this.gBoxChunk.TabIndex = 2;
            this.gBoxChunk.TabStop = false;
            this.gBoxChunk.Text = "Chunk Options";
            // 
            // labelheight
            // 
            this.labelheight.AutoSize = true;
            this.labelheight.Location = new System.Drawing.Point(6, 47);
            this.labelheight.Name = "labelheight";
            this.labelheight.Size = new System.Drawing.Size(44, 13);
            this.labelheight.TabIndex = 3;
            this.labelheight.Text = "Height :";
            // 
            // nUDownChunkHeight
            // 
            this.nUDownChunkHeight.Location = new System.Drawing.Point(53, 45);
            this.nUDownChunkHeight.Maximum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.nUDownChunkHeight.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDownChunkHeight.Name = "nUDownChunkHeight";
            this.nUDownChunkHeight.Size = new System.Drawing.Size(58, 20);
            this.nUDownChunkHeight.TabIndex = 2;
            this.nUDownChunkHeight.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // labelwidth
            // 
            this.labelwidth.AutoSize = true;
            this.labelwidth.Location = new System.Drawing.Point(9, 21);
            this.labelwidth.Name = "labelwidth";
            this.labelwidth.Size = new System.Drawing.Size(41, 13);
            this.labelwidth.TabIndex = 1;
            this.labelwidth.Text = "Width :";
            // 
            // nUDownChunkWidth
            // 
            this.nUDownChunkWidth.Location = new System.Drawing.Point(53, 19);
            this.nUDownChunkWidth.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nUDownChunkWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDownChunkWidth.Name = "nUDownChunkWidth";
            this.nUDownChunkWidth.Size = new System.Drawing.Size(58, 20);
            this.nUDownChunkWidth.TabIndex = 0;
            this.nUDownChunkWidth.Value = new decimal(new int[] {
            32,
            0,
            0,
            0});
            // 
            // labeloutput
            // 
            this.labeloutput.AutoSize = true;
            this.labeloutput.Location = new System.Drawing.Point(6, 22);
            this.labeloutput.Name = "labeloutput";
            this.labeloutput.Size = new System.Drawing.Size(45, 13);
            this.labeloutput.TabIndex = 9;
            this.labeloutput.Text = "Output :";
            // 
            // tBoxOutputPath
            // 
            this.tBoxOutputPath.Location = new System.Drawing.Point(57, 19);
            this.tBoxOutputPath.Name = "tBoxOutputPath";
            this.tBoxOutputPath.Size = new System.Drawing.Size(254, 20);
            this.tBoxOutputPath.TabIndex = 8;
            this.tBoxOutputPath.Text = "C:\\Users\\NAME\\Desktop\\generatemap.vmf";
            // 
            // ButGenerate
            // 
            this.ButGenerate.Location = new System.Drawing.Point(317, 17);
            this.ButGenerate.Name = "ButGenerate";
            this.ButGenerate.Size = new System.Drawing.Size(98, 23);
            this.ButGenerate.TabIndex = 1;
            this.ButGenerate.Text = "Generate";
            this.ButGenerate.UseVisualStyleBackColor = true;
            this.ButGenerate.Click += new System.EventHandler(this.ButGenerate_Click);
            // 
            // gBoxOutput
            // 
            this.gBoxOutput.Controls.Add(this.pBarFinish);
            this.gBoxOutput.Controls.Add(this.ButGenerate);
            this.gBoxOutput.Controls.Add(this.labeloutput);
            this.gBoxOutput.Controls.Add(this.tBoxOutputPath);
            this.gBoxOutput.Location = new System.Drawing.Point(490, 12);
            this.gBoxOutput.Name = "gBoxOutput";
            this.gBoxOutput.Size = new System.Drawing.Size(421, 449);
            this.gBoxOutput.TabIndex = 1;
            this.gBoxOutput.TabStop = false;
            this.gBoxOutput.Text = "Generator Output";
            // 
            // pBarFinish
            // 
            this.pBarFinish.Location = new System.Drawing.Point(6, 47);
            this.pBarFinish.Name = "pBarFinish";
            this.pBarFinish.Size = new System.Drawing.Size(409, 28);
            this.pBarFinish.TabIndex = 10;
            this.pBarFinish.Value = 100;
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(496, 93);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(409, 362);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // ButReload
            // 
            this.ButReload.Location = new System.Drawing.Point(167, 18);
            this.ButReload.Name = "ButReload";
            this.ButReload.Size = new System.Drawing.Size(54, 23);
            this.ButReload.TabIndex = 24;
            this.ButReload.Text = "Reload";
            this.ButReload.UseVisualStyleBackColor = true;
            this.ButReload.Click += new System.EventHandler(this.ButReload_Click);
            // 
            // Frame
            // 
            this.AccessibleName = "HammerWorldGenerator";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(923, 468);
            this.Controls.Add(this.OutputTextBox);
            this.Controls.Add(this.gBoxOutput);
            this.Controls.Add(this.gBoxOptions);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hammer World Generator";
            this.gBoxOptions.ResumeLayout(false);
            this.gBoxOptions.PerformLayout();
            this.gBoxSave.ResumeLayout(false);
            this.gBoxPerlin.ResumeLayout(false);
            this.gBoxPerlin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFracGain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFracLacunarity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFracOctaves)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFrequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownSeed)).EndInit();
            this.gBoxMinecraft.ResumeLayout(false);
            this.gBoxMinecraft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).EndInit();
            this.gBoxChunk.ResumeLayout(false);
            this.gBoxChunk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkWidth)).EndInit();
            this.gBoxOutput.ResumeLayout(false);
            this.gBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxOptions;
        private System.Windows.Forms.Button ButGenerate;
        private System.Windows.Forms.GroupBox gBoxOutput;
        private System.Windows.Forms.GroupBox gBoxChunk;
        private System.Windows.Forms.CheckBox ckBoxChunkFill;
        private System.Windows.Forms.Label labelheight;
        private System.Windows.Forms.NumericUpDown nUDownChunkHeight;
        private System.Windows.Forms.Label labelwidth;
        private System.Windows.Forms.NumericUpDown nUDownChunkWidth;
        private System.Windows.Forms.Label labelseed;
        private System.Windows.Forms.Label labelblocksize;
        private System.Windows.Forms.NumericUpDown numericUpDownBlockSize;
        private System.Windows.Forms.GroupBox gBoxMinecraft;
        private System.Windows.Forms.Label labeloutput;
        private System.Windows.Forms.TextBox tBoxOutputPath;
        private System.Windows.Forms.CheckBox ckBoxFullBreakable;
        private System.Windows.Forms.NumericUpDown nUDownSeed;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.RadioButton rBut3D;
        private System.Windows.Forms.RadioButton rBut2D;
        private System.Windows.Forms.Label labeltype;
        private System.Windows.Forms.RadioButton rButPerlin3D;
        private System.Windows.Forms.Label labelinterpolation;
        private System.Windows.Forms.Label labelfrequency;
        private System.Windows.Forms.NumericUpDown nUDownFrequency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUDownMaxY;
        private System.Windows.Forms.ProgressBar pBarFinish;
        private System.Windows.Forms.GroupBox gBoxPerlin;
        private System.Windows.Forms.ComboBox coBoxInterp;
        private System.Windows.Forms.Label labeloctaves;
        private System.Windows.Forms.NumericUpDown nUDownFracOctaves;
        private System.Windows.Forms.Label labelgain;
        private System.Windows.Forms.NumericUpDown nUDownFracGain;
        private System.Windows.Forms.Label labellacunarity;
        private System.Windows.Forms.NumericUpDown nUDownFracLacunarity;
        private System.Windows.Forms.ComboBox cBoxNoiseType;
        private System.Windows.Forms.Label labelnoisetype;
        private System.Windows.Forms.Label labelresult;
        private System.Windows.Forms.ComboBox coBoxResult;
        private System.Windows.Forms.GroupBox gBoxSave;
        private System.Windows.Forms.Button ButLoad;
        private System.Windows.Forms.Button ButSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ButReset;
        private System.Windows.Forms.Button ButReload;
    }
}

