namespace Exercice1
{
    partial class Formulaire
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
            this.ListeGauche = new System.Windows.Forms.ListBox();
            this.ListeDroite = new System.Windows.Forms.ListBox();
            this.BoutonTousDroit = new System.Windows.Forms.Button();
            this.BoutonTousGauche = new System.Windows.Forms.Button();
            this.BoutonPlusGauche = new System.Windows.Forms.Button();
            this.BoutonMoinsGauche = new System.Windows.Forms.Button();
            this.BoutonMoinsDroit = new System.Windows.Forms.Button();
            this.BoutonPlusDroit = new System.Windows.Forms.Button();
            this.BoutonQuitter = new System.Windows.Forms.Button();
            this.ChampGauche = new System.Windows.Forms.TextBox();
            this.ChampDroit = new System.Windows.Forms.TextBox();
            this.BoutonElemDroit = new System.Windows.Forms.Button();
            this.BoutonElemGauche = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListeGauche
            // 
            this.ListeGauche.FormattingEnabled = true;
            this.ListeGauche.Location = new System.Drawing.Point(32, 44);
            this.ListeGauche.Name = "ListeGauche";
            this.ListeGauche.Size = new System.Drawing.Size(147, 147);
            this.ListeGauche.TabIndex = 0;
            this.ListeGauche.Tag = "";
            this.ListeGauche.DoubleClick += new System.EventHandler(this.ListeGauche_DoubleClick);
            // 
            // ListeDroite
            // 
            this.ListeDroite.FormattingEnabled = true;
            this.ListeDroite.Location = new System.Drawing.Point(252, 44);
            this.ListeDroite.Name = "ListeDroite";
            this.ListeDroite.Size = new System.Drawing.Size(147, 147);
            this.ListeDroite.TabIndex = 1;
            this.ListeDroite.Tag = "";
            this.ListeDroite.DoubleClick += new System.EventHandler(this.ListeDroite_DoubleClick);
            // 
            // BoutonTousDroit
            // 
            this.BoutonTousDroit.Location = new System.Drawing.Point(196, 62);
            this.BoutonTousDroit.Name = "BoutonTousDroit";
            this.BoutonTousDroit.Size = new System.Drawing.Size(41, 23);
            this.BoutonTousDroit.TabIndex = 3;
            this.BoutonTousDroit.Text = ">>";
            this.BoutonTousDroit.UseVisualStyleBackColor = true;
            this.BoutonTousDroit.Click += new System.EventHandler(this.BoutonTousDroit_Click);
            // 
            // BoutonTousGauche
            // 
            this.BoutonTousGauche.Location = new System.Drawing.Point(196, 101);
            this.BoutonTousGauche.Name = "BoutonTousGauche";
            this.BoutonTousGauche.Size = new System.Drawing.Size(41, 23);
            this.BoutonTousGauche.TabIndex = 4;
            this.BoutonTousGauche.Text = "<<";
            this.BoutonTousGauche.UseVisualStyleBackColor = true;
            this.BoutonTousGauche.Click += new System.EventHandler(this.BoutonTousGauche_Click);
            // 
            // BoutonPlusGauche
            // 
            this.BoutonPlusGauche.Location = new System.Drawing.Point(32, 223);
            this.BoutonPlusGauche.Name = "BoutonPlusGauche";
            this.BoutonPlusGauche.Size = new System.Drawing.Size(66, 23);
            this.BoutonPlusGauche.TabIndex = 5;
            this.BoutonPlusGauche.Text = "+";
            this.BoutonPlusGauche.UseVisualStyleBackColor = true;
            this.BoutonPlusGauche.Click += new System.EventHandler(this.BoutonPlusGauche_Click);
            // 
            // BoutonMoinsGauche
            // 
            this.BoutonMoinsGauche.Location = new System.Drawing.Point(113, 223);
            this.BoutonMoinsGauche.Name = "BoutonMoinsGauche";
            this.BoutonMoinsGauche.Size = new System.Drawing.Size(66, 23);
            this.BoutonMoinsGauche.TabIndex = 6;
            this.BoutonMoinsGauche.Text = "-";
            this.BoutonMoinsGauche.UseVisualStyleBackColor = true;
            this.BoutonMoinsGauche.Click += new System.EventHandler(this.BoutonMoinsGauche_Click);
            // 
            // BoutonMoinsDroit
            // 
            this.BoutonMoinsDroit.Location = new System.Drawing.Point(333, 223);
            this.BoutonMoinsDroit.Name = "BoutonMoinsDroit";
            this.BoutonMoinsDroit.Size = new System.Drawing.Size(66, 23);
            this.BoutonMoinsDroit.TabIndex = 8;
            this.BoutonMoinsDroit.Text = "-";
            this.BoutonMoinsDroit.UseVisualStyleBackColor = true;
            this.BoutonMoinsDroit.Click += new System.EventHandler(this.BoutonMoinsDroit_Click);
            // 
            // BoutonPlusDroit
            // 
            this.BoutonPlusDroit.Location = new System.Drawing.Point(252, 223);
            this.BoutonPlusDroit.Name = "BoutonPlusDroit";
            this.BoutonPlusDroit.Size = new System.Drawing.Size(66, 23);
            this.BoutonPlusDroit.TabIndex = 7;
            this.BoutonPlusDroit.Text = "+";
            this.BoutonPlusDroit.UseVisualStyleBackColor = true;
            this.BoutonPlusDroit.Click += new System.EventHandler(this.BoutonPlusDroit_Click);
            // 
            // BoutonQuitter
            // 
            this.BoutonQuitter.Location = new System.Drawing.Point(183, 264);
            this.BoutonQuitter.Name = "BoutonQuitter";
            this.BoutonQuitter.Size = new System.Drawing.Size(66, 23);
            this.BoutonQuitter.TabIndex = 9;
            this.BoutonQuitter.Text = "Quitter";
            this.BoutonQuitter.UseVisualStyleBackColor = true;
            this.BoutonQuitter.Click += new System.EventHandler(this.bt_quitter_Click);
            // 
            // ChampGauche
            // 
            this.ChampGauche.Location = new System.Drawing.Point(32, 197);
            this.ChampGauche.Name = "ChampGauche";
            this.ChampGauche.Size = new System.Drawing.Size(147, 20);
            this.ChampGauche.TabIndex = 10;
            // 
            // ChampDroit
            // 
            this.ChampDroit.Location = new System.Drawing.Point(252, 197);
            this.ChampDroit.Name = "ChampDroit";
            this.ChampDroit.Size = new System.Drawing.Size(147, 20);
            this.ChampDroit.TabIndex = 11;
            // 
            // BoutonElemDroit
            // 
            this.BoutonElemDroit.Location = new System.Drawing.Point(196, 141);
            this.BoutonElemDroit.Name = "BoutonElemDroit";
            this.BoutonElemDroit.Size = new System.Drawing.Size(40, 22);
            this.BoutonElemDroit.TabIndex = 12;
            this.BoutonElemDroit.Text = ">";
            this.BoutonElemDroit.UseVisualStyleBackColor = true;
            this.BoutonElemDroit.Click += new System.EventHandler(this.BoutonElemDroit_Click);
            // 
            // BoutonElemGauche
            // 
            this.BoutonElemGauche.Location = new System.Drawing.Point(196, 169);
            this.BoutonElemGauche.Name = "BoutonElemGauche";
            this.BoutonElemGauche.Size = new System.Drawing.Size(40, 22);
            this.BoutonElemGauche.TabIndex = 13;
            this.BoutonElemGauche.Text = "<";
            this.BoutonElemGauche.UseVisualStyleBackColor = true;
            this.BoutonElemGauche.Click += new System.EventHandler(this.BoutonElemGauche_Click);
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 307);
            this.Controls.Add(this.BoutonElemGauche);
            this.Controls.Add(this.BoutonElemDroit);
            this.Controls.Add(this.ChampDroit);
            this.Controls.Add(this.ChampGauche);
            this.Controls.Add(this.BoutonQuitter);
            this.Controls.Add(this.BoutonMoinsDroit);
            this.Controls.Add(this.BoutonPlusDroit);
            this.Controls.Add(this.BoutonMoinsGauche);
            this.Controls.Add(this.BoutonPlusGauche);
            this.Controls.Add(this.BoutonTousGauche);
            this.Controls.Add(this.BoutonTousDroit);
            this.Controls.Add(this.ListeDroite);
            this.Controls.Add(this.ListeGauche);
            this.Name = "Formulaire";
            this.Text = "Deux Listes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListeGauche;
        private System.Windows.Forms.ListBox ListeDroite;
        private System.Windows.Forms.Button BoutonTousDroit;
        private System.Windows.Forms.Button BoutonTousGauche;
        private System.Windows.Forms.Button BoutonPlusGauche;
        private System.Windows.Forms.Button BoutonMoinsGauche;
        private System.Windows.Forms.Button BoutonMoinsDroit;
        private System.Windows.Forms.Button BoutonPlusDroit;
        private System.Windows.Forms.Button BoutonQuitter;
        private System.Windows.Forms.TextBox ChampGauche;
        private System.Windows.Forms.TextBox ChampDroit;
        private System.Windows.Forms.Button BoutonElemDroit;
        private System.Windows.Forms.Button BoutonElemGauche;
    }
}

