namespace WindowsFormsApplication
{
    partial class FormNouveauEmployé
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNbH = new System.Windows.Forms.TextBox();
            this.textBoxTarif = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre d\'heures";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "tarif horaire";
            // 
            // textBoxNbH
            // 
            this.textBoxNbH.Location = new System.Drawing.Point(128, 127);
            this.textBoxNbH.Name = "textBoxNbH";
            this.textBoxNbH.Size = new System.Drawing.Size(111, 20);
            this.textBoxNbH.TabIndex = 6;
            // 
            // textBoxTarif
            // 
            this.textBoxTarif.Location = new System.Drawing.Point(130, 197);
            this.textBoxTarif.Name = "textBoxTarif";
            this.textBoxTarif.Size = new System.Drawing.Size(108, 20);
            this.textBoxTarif.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 34);
            this.button1.TabIndex = 8;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // FormNouveauEmployé
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(492, 349);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxTarif);
            this.Controls.Add(this.textBoxNbH);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "FormNouveauEmployé";
            this.Text = "Nouvel employé";
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBoxNbH, 0);
            this.Controls.SetChildIndex(this.textBoxTarif, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxNbH;
        private System.Windows.Forms.TextBox textBoxTarif;
        private System.Windows.Forms.Button button1;
    }
}
