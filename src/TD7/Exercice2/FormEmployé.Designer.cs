namespace Exercice2
{
    partial class FormEmployé
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
            this.LabelTarif = new System.Windows.Forms.Label();
            this.LabelHSupp = new System.Windows.Forms.Label();
            this.NumericTarif = new System.Windows.Forms.NumericUpDown();
            this.NumericHSupp = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NumericTarif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericHSupp)).BeginInit();
            this.SuspendLayout();
            // 
            // BoutonOk
            // 
            this.BoutonOk.Click += new System.EventHandler(this.BoutonOk_Click);
            // 
            // LabelTarif
            // 
            this.LabelTarif.AutoSize = true;
            this.LabelTarif.Location = new System.Drawing.Point(26, 138);
            this.LabelTarif.Name = "LabelTarif";
            this.LabelTarif.Size = new System.Drawing.Size(42, 13);
            this.LabelTarif.TabIndex = 10;
            this.LabelTarif.Text = "Tarif H.";
            // 
            // LabelHSupp
            // 
            this.LabelHSupp.AutoSize = true;
            this.LabelHSupp.Location = new System.Drawing.Point(26, 189);
            this.LabelHSupp.Name = "LabelHSupp";
            this.LabelHSupp.Size = new System.Drawing.Size(49, 13);
            this.LabelHSupp.TabIndex = 12;
            this.LabelHSupp.Text = "H. Supp.";
            // 
            // NumericTarif
            // 
            this.NumericTarif.DecimalPlaces = 2;
            this.NumericTarif.Location = new System.Drawing.Point(99, 136);
            this.NumericTarif.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericTarif.Name = "NumericTarif";
            this.NumericTarif.Size = new System.Drawing.Size(211, 20);
            this.NumericTarif.TabIndex = 14;
            this.NumericTarif.ThousandsSeparator = true;
            // 
            // NumericHSupp
            // 
            this.NumericHSupp.Location = new System.Drawing.Point(99, 187);
            this.NumericHSupp.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.NumericHSupp.Name = "NumericHSupp";
            this.NumericHSupp.Size = new System.Drawing.Size(211, 20);
            this.NumericHSupp.TabIndex = 15;
            this.NumericHSupp.ThousandsSeparator = true;
            // 
            // FormEmployé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(344, 282);
            this.Controls.Add(this.NumericHSupp);
            this.Controls.Add(this.NumericTarif);
            this.Controls.Add(this.LabelHSupp);
            this.Controls.Add(this.LabelTarif);
            this.Name = "FormEmployé";
            this.Text = "Nouvel employé";
            this.Controls.SetChildIndex(this.TextBoxNom, 0);
            this.Controls.SetChildIndex(this.BoutonOk, 0);
            this.Controls.SetChildIndex(this.DateNaissance, 0);
            this.Controls.SetChildIndex(this.LabelTarif, 0);
            this.Controls.SetChildIndex(this.LabelHSupp, 0);
            this.Controls.SetChildIndex(this.NumericTarif, 0);
            this.Controls.SetChildIndex(this.NumericHSupp, 0);
            ((System.ComponentModel.ISupportInitialize)(this.NumericTarif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumericHSupp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTarif;
        private System.Windows.Forms.Label LabelHSupp;
        private System.Windows.Forms.NumericUpDown NumericTarif;
        private System.Windows.Forms.NumericUpDown NumericHSupp;
    }
}
