namespace WindowsFormsApplication
{
    partial class FormMenu
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
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personnelToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employéToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.commercialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paramètresToolStripMenuItem,
            this.editerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(529, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
            // 
            // editerToolStripMenuItem
            // 
            this.editerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personnelToolStripMenuItem1,
            this.managerToolStripMenuItem1,
            this.employéToolStripMenuItem1,
            this.commercialToolStripMenuItem});
            this.editerToolStripMenuItem.Name = "editerToolStripMenuItem";
            this.editerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.editerToolStripMenuItem.Text = "Affichage";
            // 
            // personnelToolStripMenuItem1
            // 
            this.personnelToolStripMenuItem1.Name = "personnelToolStripMenuItem1";
            this.personnelToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.personnelToolStripMenuItem1.Text = "Personnels";
            this.personnelToolStripMenuItem1.Click += new System.EventHandler(this.personnelToolStripMenuItem1_Click);
            // 
            // managerToolStripMenuItem1
            // 
            this.managerToolStripMenuItem1.Name = "managerToolStripMenuItem1";
            this.managerToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.managerToolStripMenuItem1.Text = "Managers";
            this.managerToolStripMenuItem1.Click += new System.EventHandler(this.managerToolStripMenuItem1_Click);
            // 
            // employéToolStripMenuItem1
            // 
            this.employéToolStripMenuItem1.Name = "employéToolStripMenuItem1";
            this.employéToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.employéToolStripMenuItem1.Text = "Employés";
            this.employéToolStripMenuItem1.Click += new System.EventHandler(this.employéToolStripMenuItem1_Click);
            // 
            // commercialToolStripMenuItem
            // 
            this.commercialToolStripMenuItem.Name = "commercialToolStripMenuItem";
            this.commercialToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.commercialToolStripMenuItem.Text = "Commercial";
            this.commercialToolStripMenuItem.Click += new System.EventHandler(this.commercialToolStripMenuItem_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 364);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personnelToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employéToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem commercialToolStripMenuItem;
    }
}

