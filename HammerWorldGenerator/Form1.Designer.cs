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
            this.nUDownSeed = new System.Windows.Forms.NumericUpDown();
            this.lOutputPath = new System.Windows.Forms.Label();
            this.tBoxOutputPath = new System.Windows.Forms.TextBox();
            this.gBoxMinecraft = new System.Windows.Forms.GroupBox();
            this.ckBoxFullBreakable = new System.Windows.Forms.CheckBox();
            this.ckBoxMinecraft = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBlockSize = new System.Windows.Forms.NumericUpDown();
            this.lSeed = new System.Windows.Forms.Label();
            this.gBoxChunk = new System.Windows.Forms.GroupBox();
            this.ckBoxChunkFill = new System.Windows.Forms.CheckBox();
            this.lHeight = new System.Windows.Forms.Label();
            this.nUDownChunkHeight = new System.Windows.Forms.NumericUpDown();
            this.lWidth = new System.Windows.Forms.Label();
            this.nUDownChunkWidth = new System.Windows.Forms.NumericUpDown();
            this.butGenerate = new System.Windows.Forms.Button();
            this.gBoxOutput = new System.Windows.Forms.GroupBox();
            this.OutputTextBox = new System.Windows.Forms.RichTextBox();
            this.nUDownChunks = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.gBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownSeed)).BeginInit();
            this.gBoxMinecraft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).BeginInit();
            this.gBoxChunk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkWidth)).BeginInit();
            this.gBoxOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunks)).BeginInit();
            this.SuspendLayout();
            // 
            // gBoxOptions
            // 
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
            // nUDownSeed
            // 
            this.nUDownSeed.Location = new System.Drawing.Point(57, 20);
            this.nUDownSeed.Maximum = new decimal(new int[] {
            -469762049,
            -590869294,
            5421010,
            0});
            this.nUDownSeed.Name = "nUDownSeed";
            this.nUDownSeed.Size = new System.Drawing.Size(259, 20);
            this.nUDownSeed.TabIndex = 5;
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
            // gBoxMinecraft
            // 
            this.gBoxMinecraft.Controls.Add(this.ckBoxFullBreakable);
            this.gBoxMinecraft.Controls.Add(this.ckBoxMinecraft);
            this.gBoxMinecraft.Controls.Add(this.label2);
            this.gBoxMinecraft.Controls.Add(this.numericUpDownBlockSize);
            this.gBoxMinecraft.Location = new System.Drawing.Point(227, 284);
            this.gBoxMinecraft.Name = "gBoxMinecraft";
            this.gBoxMinecraft.Size = new System.Drawing.Size(245, 159);
            this.gBoxMinecraft.TabIndex = 7;
            this.gBoxMinecraft.TabStop = false;
            this.gBoxMinecraft.Text = "Minecraft Options";
            // 
            // ckBoxFullBreakable
            // 
            this.ckBoxFullBreakable.AutoSize = true;
            this.ckBoxFullBreakable.Location = new System.Drawing.Point(87, 19);
            this.ckBoxFullBreakable.Name = "ckBoxFullBreakable";
            this.ckBoxFullBreakable.Size = new System.Drawing.Size(92, 17);
            this.ckBoxFullBreakable.TabIndex = 6;
            this.ckBoxFullBreakable.Text = "full_breakable";
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
            this.gBoxChunk.Controls.Add(this.ckBoxChunkFill);
            this.gBoxChunk.Controls.Add(this.lHeight);
            this.gBoxChunk.Controls.Add(this.nUDownChunkHeight);
            this.gBoxChunk.Controls.Add(this.lWidth);
            this.gBoxChunk.Controls.Add(this.nUDownChunkWidth);
            this.gBoxChunk.Location = new System.Drawing.Point(13, 284);
            this.gBoxChunk.Name = "gBoxChunk";
            this.gBoxChunk.Size = new System.Drawing.Size(208, 159);
            this.gBoxChunk.TabIndex = 2;
            this.gBoxChunk.TabStop = false;
            this.gBoxChunk.Text = "Chunk Options";
            // 
            // ckBoxChunkFill
            // 
            this.ckBoxChunkFill.AutoSize = true;
            this.ckBoxChunkFill.Location = new System.Drawing.Point(130, 19);
            this.ckBoxChunkFill.Name = "ckBoxChunkFill";
            this.ckBoxChunkFill.Size = new System.Drawing.Size(72, 17);
            this.ckBoxChunkFill.TabIndex = 4;
            this.ckBoxChunkFill.Text = "Fill Height";
            this.ckBoxChunkFill.UseVisualStyleBackColor = true;
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
            this.nUDownChunkHeight.Size = new System.Drawing.Size(68, 20);
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
            this.nUDownChunkWidth.Size = new System.Drawing.Size(68, 20);
            this.nUDownChunkWidth.TabIndex = 0;
            this.nUDownChunkWidth.Value = new decimal(new int[] {
            64,
            0,
            0,
            0});
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
            // OutputTextBox
            // 
            this.OutputTextBox.Location = new System.Drawing.Point(496, 57);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(409, 398);
            this.OutputTextBox.TabIndex = 2;
            this.OutputTextBox.Text = "";
            // 
            // nUDownChunks
            // 
            this.nUDownChunks.Location = new System.Drawing.Point(53, 71);
            this.nUDownChunks.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nUDownChunks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUDownChunks.Name = "nUDownChunks";
            this.nUDownChunks.Size = new System.Drawing.Size(68, 20);
            this.nUDownChunks.TabIndex = 5;
            this.nUDownChunks.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
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
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunks)).EndInit();
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
    }
}

