namespace Exercice1bis
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
            this.Bouton = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.Label = new System.Windows.Forms.Label();
            this.dateControl = new Exercice1.DateControl();
            this.SuspendLayout();
            // 
            // Bouton
            // 
            this.Bouton.Location = new System.Drawing.Point(107, 105);
            this.Bouton.Name = "Bouton";
            this.Bouton.Size = new System.Drawing.Size(78, 30);
            this.Bouton.TabIndex = 1;
            this.Bouton.Text = "Ok";
            this.Bouton.UseVisualStyleBackColor = true;
            this.Bouton.Click += new System.EventHandler(this.Bouton_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(113, 196);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(129, 20);
            this.TextBox.TabIndex = 2;
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(12, 199);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(95, 13);
            this.Label.TabIndex = 3;
            this.Label.Text = "Date Selectionnée";
            // 
            // dateControl
            // 
            this.dateControl.Location = new System.Drawing.Point(41, 22);
            this.dateControl.Name = "dateControl";
            this.dateControl.Size = new System.Drawing.Size(188, 50);
            this.dateControl.TabIndex = 4;
            // 
            // Formulaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.dateControl);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Bouton);
            this.Name = "Formulaire";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Bouton;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Label Label;
        private Exercice1.DateControl dateControl;

    }
}

