namespace Exercice2
{
    partial class FormCollaborateur
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LabelNom = new System.Windows.Forms.Label();
            this.TextBoxNom = new System.Windows.Forms.TextBox();
            this.BoutonOk = new System.Windows.Forms.Button();
            this.LabelNaissance = new System.Windows.Forms.Label();
            this.DateNaissance = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // LabelNom
            // 
            this.LabelNom.AutoSize = true;
            this.LabelNom.Location = new System.Drawing.Point(26, 34);
            this.LabelNom.Name = "LabelNom";
            this.LabelNom.Size = new System.Drawing.Size(29, 13);
            this.LabelNom.TabIndex = 0;
            this.LabelNom.Text = "Nom";
            // 
            // TextBoxNom
            // 
            this.TextBoxNom.Location = new System.Drawing.Point(99, 31);
            this.TextBoxNom.Name = "TextBoxNom";
            this.TextBoxNom.Size = new System.Drawing.Size(211, 20);
            this.TextBoxNom.TabIndex = 1;
            // 
            // BoutonOk
            // 
            this.BoutonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BoutonOk.Location = new System.Drawing.Point(235, 237);
            this.BoutonOk.Name = "BoutonOk";
            this.BoutonOk.Size = new System.Drawing.Size(75, 23);
            this.BoutonOk.TabIndex = 2;
            this.BoutonOk.Text = "Ok";
            this.BoutonOk.UseVisualStyleBackColor = true;
            // 
            // LabelNaissance
            // 
            this.LabelNaissance.AutoSize = true;
            this.LabelNaissance.Location = new System.Drawing.Point(26, 89);
            this.LabelNaissance.Name = "LabelNaissance";
            this.LabelNaissance.Size = new System.Drawing.Size(35, 13);
            this.LabelNaissance.TabIndex = 3;
            this.LabelNaissance.Text = "Né. le";
            // 
            // DateNaissance
            // 
            this.DateNaissance.Location = new System.Drawing.Point(99, 86);
            this.DateNaissance.Name = "DateNaissance";
            this.DateNaissance.Size = new System.Drawing.Size(211, 20);
            this.DateNaissance.TabIndex = 9;
            // 
            // FormCollaborateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 286);
            this.Controls.Add(this.DateNaissance);
            this.Controls.Add(this.LabelNaissance);
            this.Controls.Add(this.BoutonOk);
            this.Controls.Add(this.TextBoxNom);
            this.Controls.Add(this.LabelNom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCollaborateur";
            this.Text = "Nouveau personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNom;
        private System.Windows.Forms.Label LabelNaissance;
        protected System.Windows.Forms.TextBox TextBoxNom;
        protected System.Windows.Forms.DateTimePicker DateNaissance;
        public System.Windows.Forms.Button BoutonOk;
    }
}