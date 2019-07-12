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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxNoiseType = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nUDownFracGain = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.nUDownFracLacunarity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.nUDownFracOctaves = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.coBoxInterp = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nUDownFrequency = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.rButPerlin3D = new System.Windows.Forms.RadioButton();
            this.rBut3D = new System.Windows.Forms.RadioButton();
            this.rBut2D = new System.Windows.Forms.RadioButton();
            this.nUDownSeed = new System.Windows.Forms.NumericUpDown();
            this.gBoxMinecraft = new System.Windows.Forms.GroupBox();
            this.ckBoxFullBreakable = new System.Windows.Forms.CheckBox();
            this.ckBoxMinecraft = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBlockSize = new System.Windows.Forms.NumericUpDown();
            this.ckBoxChunkFill = new System.Windows.Forms.CheckBox();
            this.lSeed = new System.Windows.Forms.Label();
            this.gBoxChunk = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nUDownChunks = new System.Windows.Forms.NumericUpDown();
            this.lHeight = new System.Windows.Forms.Label();
            this.nUDownChunkHeight = new System.Windows.Forms.NumericUpDown();
            this.lWidth = new System.Windows.Forms.Label();
            this.nUDownChunkWidth = new System.Windows.Forms.NumericUpDown();
            this.lOutputPath = new System.Windows.Forms.Label();
            this.tBoxOutputPath = new System.Windows.Forms.TextBox();
            this.butGenerate = new System.Windows.Forms.Button();
            this.gBoxOutput = new System.Windows.Forms.GroupBox();
            this.pBarFinish = new System.Windows.Forms.ProgressBar();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.gBoxOptions.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFracGain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFracLacunarity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFracOctaves)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownFrequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownSeed)).BeginInit();
            this.gBoxMinecraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).BeginInit();
            this.gBoxChunk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkWidth)).BeginInit();
            this.gBoxOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxOptions
            // 
            this.gBoxOptions.Controls.Add(this.groupBox1);
            this.gBoxOptions.Controls.Add(this.label3);
            this.gBoxOptions.Controls.Add(this.rButPerlin3D);
            this.gBoxOptions.Controls.Add(this.rBut3D);
            this.gBoxOptions.Controls.Add(this.rBut2D);
            this.gBoxOptions.Controls.Add(this.nUDownSeed);
            this.gBoxOptions.Controls.Add(this.gBoxMinecraft);
            this.gBoxOptions.Controls.Add(this.lSeed);
            this.gBoxOptions.Controls.Add(this.gBoxChunk);
            this.gBoxOptions.Location = new System.Drawing.Point(12, 12);
            this.gBoxOptions.Name = "gBoxOptions";
            this.gBoxOptions.Size = new System.Drawing.Size(472, 449);
            this.gBoxOptions.TabIndex = 0;
            this.gBoxOptions.TabStop = false;
            this.gBoxOptions.Text = "Generator Options";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cBoxNoiseType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nUDownFracGain);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.nUDownFracLacunarity);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.nUDownFracOctaves);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.coBoxInterp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nUDownFrequency);
            this.groupBox1.Location = new System.Drawing.Point(13, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 171);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Perlin Options";
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Noise Type :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fractal Gain :";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Fractal Lacunarity :";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Fractal Octaves :";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Frequency :";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Interpolation :";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Type :";
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
            this.rBut3D.CheckedChanged += new System.EventHandler(this.RBut3D_CheckedChanged);
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
            this.rBut2D.CheckedChanged += new System.EventHandler(this.RBut2D_CheckedChanged);
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
            this.nUDownSeed.Size = new System.Drawing.Size(164, 20);
            this.nUDownSeed.TabIndex = 5;
            // 
            // gBoxMinecraft
            // 
            this.gBoxMinecraft.Controls.Add(this.ckBoxFullBreakable);
            this.gBoxMinecraft.Controls.Add(this.ckBoxMinecraft);
            this.gBoxMinecraft.Controls.Add(this.label2);
            this.gBoxMinecraft.Controls.Add(this.numericUpDownBlockSize);
            this.gBoxMinecraft.Controls.Add(this.ckBoxChunkFill);
            this.gBoxMinecraft.Location = new System.Drawing.Point(279, 245);
            this.gBoxMinecraft.Name = "gBoxMinecraft";
            this.gBoxMinecraft.Size = new System.Drawing.Size(187, 198);
            this.gBoxMinecraft.TabIndex = 7;
            this.gBoxMinecraft.TabStop = false;
            this.gBoxMinecraft.Text = "Minecraft Options";
            // 
            // ckBoxFullBreakable
            // 
            this.ckBoxFullBreakable.AutoSize = true;
            this.ckBoxFullBreakable.Location = new System.Drawing.Point(80, 136);
            this.ckBoxFullBreakable.Name = "ckBoxFullBreakable";
            this.ckBoxFullBreakable.Size = new System.Drawing.Size(101, 17);
            this.ckBoxFullBreakable.TabIndex = 6;
            this.ckBoxFullBreakable.Text = "full_breakable ?";
            this.ckBoxFullBreakable.UseVisualStyleBackColor = true;
            // 
            // ckBoxMinecraft
            // 
            this.ckBoxMinecraft.AutoSize = true;
            this.ckBoxMinecraft.Checked = true;
            this.ckBoxMinecraft.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckBoxMinecraft.Location = new System.Drawing.Point(9, 19);
            this.ckBoxMinecraft.Name = "ckBoxMinecraft";
            this.ckBoxMinecraft.Size = new System.Drawing.Size(71, 17);
            this.ckBoxMinecraft.TabIndex = 0;
            this.ckBoxMinecraft.Text = "Activated";
            this.ckBoxMinecraft.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Block Size :";
            // 
            // numericUpDownBlockSize
            // 
            this.numericUpDownBlockSize.Location = new System.Drawing.Point(75, 42);
            this.numericUpDownBlockSize.Name = "numericUpDownBlockSize";
            this.numericUpDownBlockSize.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownBlockSize.TabIndex = 4;
            this.numericUpDownBlockSize.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
            // 
            // ckBoxChunkFill
            // 
            this.ckBoxChunkFill.AutoSize = true;
            this.ckBoxChunkFill.Location = new System.Drawing.Point(9, 136);
            this.ckBoxChunkFill.Name = "ckBoxChunkFill";
            this.ckBoxChunkFill.Size = new System.Drawing.Size(74, 17);
            this.ckBoxChunkFill.TabIndex = 4;
            this.ckBoxChunkFill.Text = "Fill Bottom";
            this.ckBoxChunkFill.UseVisualStyleBackColor = true;
            // 
            // lSeed
            // 
            this.lSeed.AutoSize = true;
            this.lSeed.Location = new System.Drawing.Point(13, 22);
            this.lSeed.Name = "lSeed";
            this.lSeed.Size = new System.Drawing.Size(38, 13);
            this.lSeed.TabIndex = 6;
            this.lSeed.Text = "Seed :";
            // 
            // gBoxChunk
            // 
            this.gBoxChunk.Controls.Add(this.label1);
            this.gBoxChunk.Controls.Add(this.nUDownChunks);
            this.gBoxChunk.Controls.Add(this.lHeight);
            this.gBoxChunk.Controls.Add(this.nUDownChunkHeight);
            this.gBoxChunk.Controls.Add(this.lWidth);
            this.gBoxChunk.Controls.Add(this.nUDownChunkWidth);
            this.gBoxChunk.Location = new System.Drawing.Point(13, 245);
            this.gBoxChunk.Name = "gBoxChunk";
            this.gBoxChunk.Size = new System.Drawing.Size(260, 198);
            this.gBoxChunk.TabIndex = 2;
            this.gBoxChunk.TabStop = false;
            this.gBoxChunk.Text = "Chunk Options";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chunks :";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // nUDownChunks
            // 
            this.nUDownChunks.Location = new System.Drawing.Point(53, 71);
            this.nUDownChunks.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUDownChunks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDownChunks.Name = "nUDownChunks";
            this.nUDownChunks.Size = new System.Drawing.Size(58, 20);
            this.nUDownChunks.TabIndex = 5;
            this.nUDownChunks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lHeight
            // 
            this.lHeight.AutoSize = true;
            this.lHeight.Location = new System.Drawing.Point(6, 47);
            this.lHeight.Name = "lHeight";
            this.lHeight.Size = new System.Drawing.Size(44, 13);
            this.lHeight.TabIndex = 3;
            this.lHeight.Text = "Height :";
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
            // lWidth
            // 
            this.lWidth.AutoSize = true;
            this.lWidth.Location = new System.Drawing.Point(9, 21);
            this.lWidth.Name = "lWidth";
            this.lWidth.Size = new System.Drawing.Size(41, 13);
            this.lWidth.TabIndex = 1;
            this.lWidth.Text = "Width :";
            // 
            // nUDownChunkWidth
            // 
            this.nUDownChunkWidth.Location = new System.Drawing.Point(53, 19);
            this.nUDownChunkWidth.Maximum = new decimal(new int[] {
            128,
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
            64,
            0,
            0,
            0});
            // 
            // lOutputPath
            // 
            this.lOutputPath.AutoSize = true;
            this.lOutputPath.Location = new System.Drawing.Point(6, 22);
            this.lOutputPath.Name = "lOutputPath";
            this.lOutputPath.Size = new System.Drawing.Size(45, 13);
            this.lOutputPath.TabIndex = 9;
            this.lOutputPath.Text = "Output :";
            // 
            // tBoxOutputPath
            // 
            this.tBoxOutputPath.Location = new System.Drawing.Point(57, 19);
            this.tBoxOutputPath.Name = "tBoxOutputPath";
            this.tBoxOutputPath.Size = new System.Drawing.Size(254, 20);
            this.tBoxOutputPath.TabIndex = 8;
            this.tBoxOutputPath.Text = "C:\\Users\\NAME\\Desktop\\generatemap.vmf";
            // 
            // butGenerate
            // 
            this.butGenerate.Location = new System.Drawing.Point(317, 17);
            this.butGenerate.Name = "butGenerate";
            this.butGenerate.Size = new System.Drawing.Size(98, 23);
            this.butGenerate.TabIndex = 1;
            this.butGenerate.Text = "Generate";
            this.butGenerate.UseVisualStyleBackColor = true;
            this.butGenerate.Click += new System.EventHandler(this.butGenerate_Click);
            // 
            // gBoxOutput
            // 
            this.gBoxOutput.Controls.Add(this.pBarFinish);
            this.gBoxOutput.Controls.Add(this.butGenerate);
            this.gBoxOutput.Controls.Add(this.lOutputPath);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkWidth)).EndInit();
            this.gBoxOutput.ResumeLayout(false);
            this.gBoxOutput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxOptions;
        private System.Windows.Forms.Button butGenerate;
        private System.Windows.Forms.GroupBox gBoxOutput;
        private System.Windows.Forms.GroupBox gBoxChunk;
        private System.Windows.Forms.CheckBox ckBoxChunkFill;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.NumericUpDown nUDownChunkHeight;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.NumericUpDown nUDownChunkWidth;
        private System.Windows.Forms.Label lSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBlockSize;
        private System.Windows.Forms.GroupBox gBoxMinecraft;
        private System.Windows.Forms.CheckBox ckBoxMinecraft;
        private System.Windows.Forms.Label lOutputPath;
        private System.Windows.Forms.TextBox tBoxOutputPath;
        private System.Windows.Forms.CheckBox ckBoxFullBreakable;
        private System.Windows.Forms.NumericUpDown nUDownSeed;
        private System.Windows.Forms.RichTextBox OutputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nUDownChunks;
        private System.Windows.Forms.RadioButton rBut3D;
        private System.Windows.Forms.RadioButton rBut2D;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rButPerlin3D;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nUDownFrequency;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nUDownMaxY;
        private System.Windows.Forms.ProgressBar pBarFinish;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox coBoxInterp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nUDownFracOctaves;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nUDownFracGain;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown nUDownFracLacunarity;
        private System.Windows.Forms.ComboBox cBoxNoiseType;
        private System.Windows.Forms.Label label10;
    }
}

