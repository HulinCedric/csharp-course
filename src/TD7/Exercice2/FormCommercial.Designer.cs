namespace Exercice2
{
    partial class FormCommercial
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
            this.NumericCA = new System.Windows.Forms.NumericUpDown();
            this.NumericSommeF = new System.Windows.Forms.NumericUpDown();
            this.LabelCA = new System.Windows.Forms.Label();
            this.LabelSommeF = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericCA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSommeF)).BeginInit();
            this.SuspendLayout();
            // 
            // BoutonOk
            // 
            this.BoutonOk.Click += new System.EventHandler(this.BoutonOk_Click);
            // 
            // NumericCA
            // 
            this.NumericCA.DecimalPlaces = 2;
            this.NumericCA.Location = new System.Drawing.Point(99, 186);
            this.NumericCA.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericCA.Name = "NumericCA";
            this.NumericCA.Size = new System.Drawing.Size(211, 20);
            this.NumericCA.TabIndex = 23;
            this.NumericCA.ThousandsSeparator = true;
            // 
            // NumericSommeF
            // 
            this.NumericSommeF.DecimalPlaces = 2;
            this.NumericSommeF.Location = new System.Drawing.Point(99, 135);
            this.NumericSommeF.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericSommeF.Name = "NumericSommeF";
            this.NumericSommeF.Size = new System.Drawing.Size(211, 20);
            this.NumericSommeF.TabIndex = 22;
            this.NumericSommeF.ThousandsSeparator = true;
            // 
            // LabelCA
            // 
            this.LabelCA.AutoSize = true;
            this.LabelCA.Location = new System.Drawing.Point(26, 188);
            this.LabelCA.Name = "LabelCA";
            this.LabelCA.Size = new System.Drawing.Size(71, 13);
            this.LabelCA.TabIndex = 21;
            this.LabelCA.Text = "C.A. Semaine";
            // 
            // LabelSommeF
            // 
            this.LabelSommeF.AutoSize = true;
            this.LabelSommeF.Location = new System.Drawing.Point(26, 137);
            this.LabelSommeF.Name = "LabelSommeF";
            this.LabelSommeF.Size = new System.Drawing.Size(64, 13);
            this.LabelSommeF.TabIndex = 20;
            this.LabelSommeF.Text = "Somme Fixe";
            // 
            // FormCommercial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(344, 286);
            this.Controls.Add(this.NumericCA);
            this.Controls.Add(this.NumericSommeF);
            this.Controls.Add(this.LabelCA);
            this.Controls.Add(this.LabelSommeF);
            this.Name = "FormCommercial";
            this.Text = "Nouveau commercial";
            this.Controls.SetChildIndex(this.TextBoxNom, 0);
            this.Controls.SetChildIndex(this.DateNaissance, 0);
            this.Controls.SetChildIndex(this.BoutonOk, 0);
            this.Controls.SetChildIndex(this.LabelSommeF, 0);
            this.Controls.SetChildIndex(this.LabelCA, 0);
            this.Controls.SetChildIndex(this.NumericSommeF, 0);
            this.Controls.SetChildIndex(this.NumericCA, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NumericCA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSommeF)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericCA;
        private System.Windows.Forms.NumericUpDown NumericSommeF;
        private System.Windows.Forms.Label LabelCA;
        private System.Windows.Forms.Label LabelSommeF;
    }
}
