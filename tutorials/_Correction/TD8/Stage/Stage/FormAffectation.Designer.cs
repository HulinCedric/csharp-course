namespace Stage
{
    partial class FormAffectation
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
            this.listBoxEtud = new System.Windows.Forms.ListBox();
            this.listBoxStage = new System.Windows.Forms.ListBox();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxEnt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonValider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBoxEtud
            // 
            this.listBoxEtud.FormattingEnabled = true;
            this.listBoxEtud.Location = new System.Drawing.Point(85, 33);
            this.listBoxEtud.Name = "listBoxEtud";
            this.listBoxEtud.Size = new System.Drawing.Size(129, 95);
            this.listBoxEtud.TabIndex = 0;
            this.listBoxEtud.SelectedIndexChanged += new System.EventHandler(this.listBoxEtud_SelectedIndexChanged);
            // 
            // listBoxStage
            // 
            this.listBoxStage.FormattingEnabled = true;
            this.listBoxStage.Location = new System.Drawing.Point(313, 33);
            this.listBoxStage.Name = "listBoxStage";
            this.listBoxStage.Size = new System.Drawing.Size(120, 95);
            this.listBoxStage.TabIndex = 1;
            this.listBoxStage.SelectedIndexChanged += new System.EventHandler(this.listBoxStage_SelectedIndexChanged);
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(83, 168);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.Size = new System.Drawing.Size(129, 20);
            this.textBoxNom.TabIndex = 2;
            // 
            // textBoxEnt
            // 
            this.textBoxEnt.Location = new System.Drawing.Point(317, 168);
            this.textBoxEnt.Name = "textBoxEnt";
            this.textBoxEnt.Size = new System.Drawing.Size(116, 20);
            this.textBoxEnt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-6, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Prénom Etudiant";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(253, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enttreprise";
            // 
            // buttonValider
            // 
            this.buttonValider.Location = new System.Drawing.Point(207, 248);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(101, 28);
            this.buttonValider.TabIndex = 8;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = true;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nom Etudiant";
            // 
            // FormAffectation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 335);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxEnt);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.listBoxStage);
            this.Controls.Add(this.listBoxEtud);
            this.Name = "FormAffectation";
            this.Text = "Affectation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAffectation_FormClosed);
            this.Load += new System.EventHandler(this.FormAffectation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxEtud;
        private System.Windows.Forms.ListBox listBoxStage;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxEnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.Label label4;
    }
}