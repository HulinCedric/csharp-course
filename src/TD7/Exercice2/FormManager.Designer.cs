namespace Exercice2
{
    partial class FormManager
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
            this.NumericPrime = new System.Windows.Forms.NumericUpDown();
            this.NumericSalaire = new System.Windows.Forms.NumericUpDown();
            this.LabelPrime = new System.Windows.Forms.Label();
            this.LabelSalaire = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSalaire)).BeginInit();
            this.SuspendLayout();
            // 
            // BoutonOk
            // 
            this.BoutonOk.Click += new System.EventHandler(this.BoutonOk_Click);
            // 
            // NumericPrime
            // 
            this.NumericPrime.DecimalPlaces = 2;
            this.NumericPrime.Location = new System.Drawing.Point(99, 185);
            this.NumericPrime.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericPrime.Name = "NumericPrime";
            this.NumericPrime.Size = new System.Drawing.Size(211, 20);
            this.NumericPrime.TabIndex = 19;
            this.NumericPrime.ThousandsSeparator = true;
            // 
            // NumericSalaire
            // 
            this.NumericSalaire.DecimalPlaces = 2;
            this.NumericSalaire.Location = new System.Drawing.Point(99, 134);
            this.NumericSalaire.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericSalaire.Name = "NumericSalaire";
            this.NumericSalaire.Size = new System.Drawing.Size(211, 20);
            this.NumericSalaire.TabIndex = 18;
            this.NumericSalaire.ThousandsSeparator = true;
            // 
            // LabelPrime
            // 
            this.LabelPrime.AutoSize = true;
            this.LabelPrime.Location = new System.Drawing.Point(26, 187);
            this.LabelPrime.Name = "LabelPrime";
            this.LabelPrime.Size = new System.Drawing.Size(33, 13);
            this.LabelPrime.TabIndex = 17;
            this.LabelPrime.Text = "Prime";
            // 
            // LabelSalaire
            // 
            this.LabelSalaire.AutoSize = true;
            this.LabelSalaire.Location = new System.Drawing.Point(26, 136);
            this.LabelSalaire.Name = "LabelSalaire";
            this.LabelSalaire.Size = new System.Drawing.Size(39, 13);
            this.LabelSalaire.TabIndex = 16;
            this.LabelSalaire.Text = "Salaire";
            // 
            // FormManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(344, 286);
            this.Controls.Add(this.NumericPrime);
            this.Controls.Add(this.NumericSalaire);
            this.Controls.Add(this.LabelPrime);
            this.Controls.Add(this.LabelSalaire);
            this.Name = "FormManager";
            this.Text = "Nouveau manager";
            this.Controls.SetChildIndex(this.TextBoxNom, 0);
            this.Controls.SetChildIndex(this.BoutonOk, 0);
            this.Controls.SetChildIndex(this.DateNaissance, 0);
            this.Controls.SetChildIndex(this.LabelSalaire, 0);
            this.Controls.SetChildIndex(this.LabelPrime, 0);
            this.Controls.SetChildIndex(this.NumericSalaire, 0);
            this.Controls.SetChildIndex(this.NumericPrime, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NumericPrime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericSalaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown NumericPrime;
        private System.Windows.Forms.NumericUpDown NumericSalaire;
        private System.Windows.Forms.Label LabelPrime;
        private System.Windows.Forms.Label LabelSalaire;
    }
}
