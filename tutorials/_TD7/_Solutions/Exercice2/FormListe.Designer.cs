namespace Exercice2
{
    partial class FormListe
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
            this.components = new System.ComponentModel.Container();
            this.DataList = new System.Windows.Forms.ListBox();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Nouveau = new System.Windows.Forms.ToolStripMenuItem();
            this.Supprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.Modifier = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataList
            // 
            this.DataList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataList.FormattingEnabled = true;
            this.DataList.Location = new System.Drawing.Point(0, 0);
            this.DataList.Name = "DataList";
            this.DataList.Size = new System.Drawing.Size(439, 264);
            this.DataList.TabIndex = 0;
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Nouveau,
            this.Supprimer,
            this.Modifier});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(153, 92);
            // 
            // Nouveau
            // 
            this.Nouveau.Name = "Nouveau";
            this.Nouveau.Size = new System.Drawing.Size(152, 22);
            this.Nouveau.Text = "Nouveau";
            this.Nouveau.Click += new System.EventHandler(this.Nouveau_Click);
            // 
            // Supprimer
            // 
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(152, 22);
            this.Supprimer.Text = "Supprimer";
            // 
            // Modifier
            // 
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(152, 22);
            this.Modifier.Text = "Modifier";
            // 
            // FormListe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 266);
            this.Controls.Add(this.DataList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormListe";
            this.Text = "FormListe";
            this.TextChanged += new System.EventHandler(this.FormListe_TextChanged);
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox DataList;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem Nouveau;
        private System.Windows.Forms.ToolStripMenuItem Supprimer;
        private System.Windows.Forms.ToolStripMenuItem Modifier;

    }
}