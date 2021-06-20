using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stage
{
    public partial class FormPrinc : Form
    {
        public FormPrinc()
        {
            InitializeComponent();
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEtud f = new FormEtud();
            f.Show();
        }

        

        private void affichageEnTableauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStageTab f = new FormStageTab();
            f.Show();
        }

        private void affichageParStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStage f = new FormStage();
            f.Show();

        }

        private void affectationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAffectation f = new FormAffectation();
            f.Show();

        }
    }
}