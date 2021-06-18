namespace Exercice2
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
            this.Menubar = new System.Windows.Forms.MenuStrip();
            this.Paramètres = new System.Windows.Forms.ToolStripMenuItem();
            this.Affichage = new System.Windows.Forms.ToolStripMenuItem();
            this.Personnels = new System.Windows.Forms.ToolStripMenuItem();
            this.Managers = new System.Windows.Forms.ToolStripMenuItem();
            this.Employés = new System.Windows.Forms.ToolStripMenuItem();
            this.Commerciaux = new System.Windows.Forms.ToolStripMenuItem();
            this.Menubar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menubar
            // 
            this.Menubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Paramètres,
            this.Affichage});
            this.Menubar.Location = new System.Drawing.Point(0, 0);
            this.Menubar.Name = "Menubar";
            this.Menubar.Size = new System.Drawing.Size(737, 24);
            this.Menubar.TabIndex = 1;
            this.Menubar.Text = "Menubar";
            // 
            // Paramètres
            // 
            this.Paramètres.Name = "Paramètres";
            this.Paramètres.Size = new System.Drawing.Size(74, 20);
            this.Paramètres.Text = "Paramètres";
            this.Paramètres.Click += new System.EventHandler(this.Paramètres_Click);
            // 
            // Affichage
            // 
            this.Affichage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Personnels,
            this.Managers,
            this.Employés,
            this.Commerciaux});
            this.Affichage.Name = "Affichage";
            this.Affichage.Size = new System.Drawing.Size(65, 20);
            this.Affichage.Text = "Affichage";
            // 
            // Personnels
            // 
            this.Personnels.Name = "Personnels";
            this.Personnels.Size = new System.Drawing.Size(152, 22);
            this.Personnels.Text = "Personnels";
            this.Personnels.Click += new System.EventHandler(this.Affichage_Click);
            // 
            // Managers
            // 
            this.Managers.Name = "Managers";
            this.Managers.Size = new System.Drawing.Size(152, 22);
            this.Managers.Text = "Managers";
            this.Managers.Click += new System.EventHandler(this.Affichage_Click);
            // 
            // Employés
            // 
            this.Employés.Name = "Employés";
            this.Employés.Size = new System.Drawing.Size(152, 22);
            this.Employés.Text = "Employés";
            this.Employés.Click += new System.EventHandler(this.Affichage_Click);
            // 
            // Commerciaux
            // 
            this.Commerciaux.Name = "Commerciaux";
            this.Commerciaux.Size = new System.Drawing.Size(152, 22);
            this.Commerciaux.Text = "Commerciaux";
            this.Commerciaux.Click += new System.EventHandler(this.Affichage_Click);
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 492);
            this.Controls.Add(this.Menubar);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.Menubar;
            this.Name = "Formulaire";
            this.Text = "Formulaire";
            this.Menubar.ResumeLayout(false);
            this.Menubar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menubar;
        private System.Windows.Forms.ToolStripMenuItem Paramètres;
        private System.Windows.Forms.ToolStripMenuItem Affichage;
        private System.Windows.Forms.ToolStripMenuItem Personnels;
        private System.Windows.Forms.ToolStripMenuItem Managers;
        private System.Windows.Forms.ToolStripMenuItem Employés;
        private System.Windows.Forms.ToolStripMenuItem Commerciaux;
    }
}

