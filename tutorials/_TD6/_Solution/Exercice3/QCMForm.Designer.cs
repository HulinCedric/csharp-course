namespace Exercice3
{
    partial class QCMForm
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
            this.ChoixQCM = new System.Windows.Forms.ListBox();
            this.Question1 = new System.Windows.Forms.Label();
            this.Reponse1 = new System.Windows.Forms.TextBox();
            this.Reponse2 = new System.Windows.Forms.TextBox();
            this.Question2 = new System.Windows.Forms.Label();
            this.Reponse3 = new System.Windows.Forms.TextBox();
            this.Question3 = new System.Windows.Forms.Label();
            this.Validation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChoixQCM
            // 
            this.ChoixQCM.FormattingEnabled = true;
            this.ChoixQCM.Items.AddRange(new object[] {
            "Cinéma",
            "Musique",
            "Nature"});
            this.ChoixQCM.Location = new System.Drawing.Point(12, 8);
            this.ChoixQCM.Name = "ChoixQCM";
            this.ChoixQCM.Size = new System.Drawing.Size(230, 264);
            this.ChoixQCM.TabIndex = 0;
            this.ChoixQCM.SelectedIndexChanged += new System.EventHandler(this.ChoixQCM_SelectedIndexChanged);
            // 
            // Question1
            // 
            this.Question1.AutoSize = true;
            this.Question1.Location = new System.Drawing.Point(267, 18);
            this.Question1.Name = "Question1";
            this.Question1.Size = new System.Drawing.Size(55, 13);
            this.Question1.TabIndex = 1;
            this.Question1.Text = "Question1";
            // 
            // Reponse1
            // 
            this.Reponse1.Location = new System.Drawing.Point(270, 43);
            this.Reponse1.Name = "Reponse1";
            this.Reponse1.Size = new System.Drawing.Size(378, 20);
            this.Reponse1.TabIndex = 2;
            // 
            // Reponse2
            // 
            this.Reponse2.Location = new System.Drawing.Point(270, 123);
            this.Reponse2.Name = "Reponse2";
            this.Reponse2.Size = new System.Drawing.Size(378, 20);
            this.Reponse2.TabIndex = 4;
            // 
            // Question2
            // 
            this.Question2.AutoSize = true;
            this.Question2.Location = new System.Drawing.Point(267, 98);
            this.Question2.Name = "Question2";
            this.Question2.Size = new System.Drawing.Size(55, 13);
            this.Question2.TabIndex = 3;
            this.Question2.Text = "Question2";
            // 
            // Reponse3
            // 
            this.Reponse3.Location = new System.Drawing.Point(270, 200);
            this.Reponse3.Name = "Reponse3";
            this.Reponse3.Size = new System.Drawing.Size(378, 20);
            this.Reponse3.TabIndex = 6;
            // 
            // Question3
            // 
            this.Question3.AutoSize = true;
            this.Question3.Location = new System.Drawing.Point(267, 175);
            this.Question3.Name = "Question3";
            this.Question3.Size = new System.Drawing.Size(55, 13);
            this.Question3.TabIndex = 5;
            this.Question3.Text = "Question3";
            // 
            // Validation
            // 
            this.Validation.Location = new System.Drawing.Point(414, 240);
            this.Validation.Name = "Validation";
            this.Validation.Size = new System.Drawing.Size(75, 23);
            this.Validation.TabIndex = 7;
            this.Validation.Text = "Fini !";
            this.Validation.UseVisualStyleBackColor = true;
            this.Validation.Click += new System.EventHandler(this.Validation_Click);
            // 
            // QCMForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 281);
            this.Controls.Add(this.Validation);
            this.Controls.Add(this.Reponse3);
            this.Controls.Add(this.Question3);
            this.Controls.Add(this.Reponse2);
            this.Controls.Add(this.Question2);
            this.Controls.Add(this.Reponse1);
            this.Controls.Add(this.Question1);
            this.Controls.Add(this.ChoixQCM);
            this.Name = "QCMForm";
            this.Text = "QCM Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ChoixQCM;
        private System.Windows.Forms.Label Question1;
        private System.Windows.Forms.TextBox Reponse1;
        private System.Windows.Forms.TextBox Reponse2;
        private System.Windows.Forms.Label Question2;
        private System.Windows.Forms.TextBox Reponse3;
        private System.Windows.Forms.Label Question3;
        private System.Windows.Forms.Button Validation;
    }
}

