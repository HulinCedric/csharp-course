namespace Exercice1
{
    partial class DateControl
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

        #region Code généré par le Concepteur de composants

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(13, 20);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(30, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "Date";
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(49, 17);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(129, 20);
            this.TextBox.TabIndex = 1;
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // DateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Label);
            this.Name = "DateControl";
            this.Size = new System.Drawing.Size(188, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox TextBox;
    }
}
