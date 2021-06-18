namespace Stage
{
    partial class FormPrinc
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.etudiantsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageEnTableauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageParStageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.etudiantsToolStripMenuItem,
            this.stageToolStripMenuItem,
            this.affectationToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(292, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // etudiantsToolStripMenuItem
            // 
            this.etudiantsToolStripMenuItem.Name = "etudiantsToolStripMenuItem";
            this.etudiantsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.etudiantsToolStripMenuItem.Text = "Etudiants";
            this.etudiantsToolStripMenuItem.Click += new System.EventHandler(this.etudiantsToolStripMenuItem_Click);
            // 
            // stageToolStripMenuItem
            // 
            this.stageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.affichageEnTableauToolStripMenuItem,
            this.affichageParStageToolStripMenuItem});
            this.stageToolStripMenuItem.Name = "stageToolStripMenuItem";
            this.stageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.stageToolStripMenuItem.Text = "Stages";
            // 
            // affichageEnTableauToolStripMenuItem
            // 
            this.affichageEnTableauToolStripMenuItem.Name = "affichageEnTableauToolStripMenuItem";
            this.affichageEnTableauToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.affichageEnTableauToolStripMenuItem.Text = "Affichage en tableau";
            this.affichageEnTableauToolStripMenuItem.Click += new System.EventHandler(this.affichageEnTableauToolStripMenuItem_Click);
            // 
            // affichageParStageToolStripMenuItem
            // 
            this.affichageParStageToolStripMenuItem.Name = "affichageParStageToolStripMenuItem";
            this.affichageParStageToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.affichageParStageToolStripMenuItem.Text = "Affichage par stage";
            this.affichageParStageToolStripMenuItem.Click += new System.EventHandler(this.affichageParStageToolStripMenuItem_Click);
            // 
            // affectationToolStripMenuItem
            // 
            this.affectationToolStripMenuItem.Name = "affectationToolStripMenuItem";
            this.affectationToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.affectationToolStripMenuItem.Text = "Affectation";
            this.affectationToolStripMenuItem.Click += new System.EventHandler(this.affectationToolStripMenuItem_Click);
            // 
            // FormPrinc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormPrinc";
            this.Text = "MENU";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem etudiantsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affectationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageEnTableauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageParStageToolStripMenuItem;
    }
}

