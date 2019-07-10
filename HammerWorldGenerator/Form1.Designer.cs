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
            this.gBoxOptions = new System.Windows.Forms.GroupBox();
            this.butCompile = new System.Windows.Forms.Button();
            this.gBoxOutput = new System.Windows.Forms.GroupBox();
            this.gBoxChunk = new System.Windows.Forms.GroupBox();
            this.nUDownChunkWidth = new System.Windows.Forms.NumericUpDown();
            this.lWidth = new System.Windows.Forms.Label();
            this.lHeight = new System.Windows.Forms.Label();
            this.nUDownChunkHeight = new System.Windows.Forms.NumericUpDown();
            this.ckBoxChunkFill = new System.Windows.Forms.CheckBox();
            this.tBoxChunkSeed = new System.Windows.Forms.TextBox();
            this.lSeed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownBlockSize = new System.Windows.Forms.NumericUpDown();
            this.gBoxMinecraft = new System.Windows.Forms.GroupBox();
            this.ckBoxMinecraft = new System.Windows.Forms.CheckBox();
            this.gBoxOptions.SuspendLayout();
            this.gBoxOutput.SuspendLayout();
            this.gBoxChunk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).BeginInit();
            this.gBoxMinecraft.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxOptions
            // 
            this.gBoxOptions.Controls.Add(this.gBoxMinecraft);
            this.gBoxOptions.Controls.Add(this.lSeed);
            this.gBoxOptions.Controls.Add(this.gBoxChunk);
            this.gBoxOptions.Controls.Add(this.tBoxChunkSeed);
            this.gBoxOptions.Location = new System.Drawing.Point(12, 12);
            this.gBoxOptions.Name = "gBoxOptions";
            this.gBoxOptions.Size = new System.Drawing.Size(472, 320);
            this.gBoxOptions.TabIndex = 0;
            this.gBoxOptions.TabStop = false;
            this.gBoxOptions.Text = "Generator Options";
            this.gBoxOptions.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // butCompile
            // 
            this.butCompile.Location = new System.Drawing.Point(6, 19);
            this.butCompile.Name = "butCompile";
            this.butCompile.Size = new System.Drawing.Size(98, 23);
            this.butCompile.TabIndex = 1;
            this.butCompile.Text = "Generate";
            this.butCompile.UseVisualStyleBackColor = true;
            this.butCompile.Click += new System.EventHandler(this.ButCompile_Click);
            // 
            // gBoxOutput
            // 
            this.gBoxOutput.Controls.Add(this.butCompile);
            this.gBoxOutput.Location = new System.Drawing.Point(13, 338);
            this.gBoxOutput.Name = "gBoxOutput";
            this.gBoxOutput.Size = new System.Drawing.Size(471, 123);
            this.gBoxOutput.TabIndex = 1;
            this.gBoxOutput.TabStop = false;
            this.gBoxOutput.Text = "Generator Output";
            // 
            // gBoxChunk
            // 
            this.gBoxChunk.Controls.Add(this.ckBoxChunkFill);
            this.gBoxChunk.Controls.Add(this.lHeight);
            this.gBoxChunk.Controls.Add(this.nUDownChunkHeight);
            this.gBoxChunk.Controls.Add(this.lWidth);
            this.gBoxChunk.Controls.Add(this.nUDownChunkWidth);
            this.gBoxChunk.Location = new System.Drawing.Point(7, 214);
            this.gBoxChunk.Name = "gBoxChunk";
            this.gBoxChunk.Size = new System.Drawing.Size(208, 100);
            this.gBoxChunk.TabIndex = 2;
            this.gBoxChunk.TabStop = false;
            this.gBoxChunk.Text = "Chunk Options";
            // 
            // nUDownChunkWidth
            // 
            this.nUDownChunkWidth.Location = new System.Drawing.Point(53, 19);
            this.nUDownChunkWidth.Name = "nUDownChunkWidth";
            this.nUDownChunkWidth.Size = new System.Drawing.Size(68, 20);
            this.nUDownChunkWidth.TabIndex = 0;
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
            this.nUDownChunkHeight.Name = "nUDownChunkHeight";
            this.nUDownChunkHeight.Size = new System.Drawing.Size(68, 20);
            this.nUDownChunkHeight.TabIndex = 2;
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
            this.ckBoxChunkFill.CheckedChanged += new System.EventHandler(this.CkBoxChunkFill_CheckedChanged);
            // 
            // tBoxChunkSeed
            // 
            this.tBoxChunkSeed.Location = new System.Drawing.Point(57, 19);
            this.tBoxChunkSeed.Name = "tBoxChunkSeed";
            this.tBoxChunkSeed.Size = new System.Drawing.Size(158, 20);
            this.tBoxChunkSeed.TabIndex = 5;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Block Size :";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
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
            this.numericUpDownBlockSize.ValueChanged += new System.EventHandler(this.NumericUpDownBlockWidth_ValueChanged);
            // 
            // gBoxMinecraft
            // 
            this.gBoxMinecraft.Controls.Add(this.ckBoxMinecraft);
            this.gBoxMinecraft.Controls.Add(this.label2);
            this.gBoxMinecraft.Controls.Add(this.numericUpDownBlockSize);
            this.gBoxMinecraft.Location = new System.Drawing.Point(221, 214);
            this.gBoxMinecraft.Name = "gBoxMinecraft";
            this.gBoxMinecraft.Size = new System.Drawing.Size(245, 100);
            this.gBoxMinecraft.TabIndex = 7;
            this.gBoxMinecraft.TabStop = false;
            this.gBoxMinecraft.Text = "Minecraft Options";
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
            // Frame
            // 
            this.AccessibleName = "HammerWorldGenerator";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 468);
            this.Controls.Add(this.gBoxOutput);
            this.Controls.Add(this.gBoxOptions);
            this.Name = "Frame";
            this.Text = "Hammer World Generator";
            this.gBoxOptions.ResumeLayout(false);
            this.gBoxOptions.PerformLayout();
            this.gBoxOutput.ResumeLayout(false);
            this.gBoxChunk.ResumeLayout(false);
            this.gBoxChunk.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDownChunkHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBlockSize)).EndInit();
            this.gBoxMinecraft.ResumeLayout(false);
            this.gBoxMinecraft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxOptions;
        private System.Windows.Forms.Button butCompile;
        private System.Windows.Forms.GroupBox gBoxOutput;
        private System.Windows.Forms.GroupBox gBoxChunk;
        private System.Windows.Forms.CheckBox ckBoxChunkFill;
        private System.Windows.Forms.Label lHeight;
        private System.Windows.Forms.NumericUpDown nUDownChunkHeight;
        private System.Windows.Forms.Label lWidth;
        private System.Windows.Forms.NumericUpDown nUDownChunkWidth;
        private System.Windows.Forms.Label lSeed;
        private System.Windows.Forms.TextBox tBoxChunkSeed;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownBlockSize;
        private System.Windows.Forms.GroupBox gBoxMinecraft;
        private System.Windows.Forms.CheckBox ckBoxMinecraft;
    }
}

