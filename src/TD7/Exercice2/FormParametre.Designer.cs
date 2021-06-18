namespace Exercice2
{
    partial class FormParametre
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
            this.LabelTauxEmp = new System.Windows.Forms.Label();
            this.TextBoxTauxEmp = new System.Windows.Forms.TextBox();
            this.TextBoxTauxCom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BoutonOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelTauxEmp
            // 
            this.LabelTauxEmp.AutoSize = true;
            this.LabelTauxEmp.Location = new System.Drawing.Point(54, 40);
            this.LabelTauxEmp.Name = "LabelTauxEmp";
            this.LabelTauxEmp.Size = new System.Drawing.Size(74, 13);
            this.LabelTauxEmp.TabIndex = 0;
            this.LabelTauxEmp.Text = "Taux Employé";
            // 
            // TextBoxTauxEmp
            // 
            this.TextBoxTauxEmp.Location = new System.Drawing.Point(134, 37);
            this.TextBoxTauxEmp.Name = "TextBoxTauxEmp";
            this.TextBoxTauxEmp.Size = new System.Drawing.Size(165, 20);
            this.TextBoxTauxEmp.TabIndex = 1;
            // 
            // TextBoxTauxCom
            // 
            this.TextBoxTauxCom.Location = new System.Drawing.Point(134, 114);
            this.TextBoxTauxCom.Name = "TextBoxTauxCom";
            this.TextBoxTauxCom.Size = new System.Drawing.Size(165, 20);
            this.TextBoxTauxCom.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Taux Commercial";
            // 
            // BoutonOk
            // 
            this.BoutonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BoutonOk.Location = new System.Drawing.Point(240, 180);
            this.BoutonOk.Name = "BoutonOk";
            this.BoutonOk.Size = new System.Drawing.Size(75, 23);
            this.BoutonOk.TabIndex = 4;
            this.BoutonOk.Text = "OK";
            this.BoutonOk.UseVisualStyleBackColor = true;
            // 
            // FormParametre
            // 
            this.AcceptButton = this.BoutonOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 225);
            this.ControlBox = false;
            this.Controls.Add(this.BoutonOk);
            this.Controls.Add(this.TextBoxTauxCom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TextBoxTauxEmp);
            this.Controls.Add(this.LabelTauxEmp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormParametre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormParametre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelTauxEmp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BoutonOk;
        public System.Windows.Forms.TextBox TextBoxTauxEmp;
        public System.Windows.Forms.TextBox TextBoxTauxCom;
    }
}