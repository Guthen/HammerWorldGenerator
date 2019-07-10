namespace HammerWorldGenerator
{
    partial class Form1
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
            this.cBoxGeneratorType = new System.Windows.Forms.ComboBox();
            this.butCompile = new System.Windows.Forms.Button();
            this.gBoxOutput = new System.Windows.Forms.GroupBox();
            this.gBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxOptions
            // 
            this.gBoxOptions.Controls.Add(this.butCompile);
            this.gBoxOptions.Controls.Add(this.cBoxGeneratorType);
            this.gBoxOptions.Location = new System.Drawing.Point(12, 12);
            this.gBoxOptions.Name = "gBoxOptions";
            this.gBoxOptions.Size = new System.Drawing.Size(472, 51);
            this.gBoxOptions.TabIndex = 0;
            this.gBoxOptions.TabStop = false;
            this.gBoxOptions.Text = "Generator Options";
            this.gBoxOptions.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // cBoxGeneratorType
            // 
            this.cBoxGeneratorType.FormattingEnabled = true;
            this.cBoxGeneratorType.Items.AddRange(new object[] {
            "Minecraft",
            "Displacement"});
            this.cBoxGeneratorType.Location = new System.Drawing.Point(7, 20);
            this.cBoxGeneratorType.Name = "cBoxGeneratorType";
            this.cBoxGeneratorType.Size = new System.Drawing.Size(121, 21);
            this.cBoxGeneratorType.TabIndex = 0;
            this.cBoxGeneratorType.Text = "Generator Type..";
            // 
            // butCompile
            // 
            this.butCompile.Location = new System.Drawing.Point(368, 18);
            this.butCompile.Name = "butCompile";
            this.butCompile.Size = new System.Drawing.Size(98, 23);
            this.butCompile.TabIndex = 1;
            this.butCompile.Text = "Generate";
            this.butCompile.UseVisualStyleBackColor = true;
            this.butCompile.Click += new System.EventHandler(this.ButCompile_Click);
            // 
            // gBoxOutput
            // 
            this.gBoxOutput.Location = new System.Drawing.Point(13, 70);
            this.gBoxOutput.Name = "gBoxOutput";
            this.gBoxOutput.Size = new System.Drawing.Size(471, 391);
            this.gBoxOutput.TabIndex = 1;
            this.gBoxOutput.TabStop = false;
            this.gBoxOutput.Text = "Generator Output";
            // 
            // Form1
            // 
            this.AccessibleName = "HammerWorldGenerator";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.gBoxOutput);
            this.Controls.Add(this.gBoxOptions);
            this.Name = "Form1";
            this.Text = "Hammer World Generator";
            this.gBoxOptions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxOptions;
        private System.Windows.Forms.ComboBox cBoxGeneratorType;
        private System.Windows.Forms.Button butCompile;
        private System.Windows.Forms.GroupBox gBoxOutput;
    }
}

