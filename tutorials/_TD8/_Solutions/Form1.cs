using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TD6___Reut.Compo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void affichagageParStageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableStage t = new tableStage();
            t.Show();
        }

        private void affichageEnTableauToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tableStageTableau t = new tableStageTableau();
            t.Show();
        }

        private void etudiantsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableEtudiant t = new tableEtudiant();
            t.Show();
        }

        private void affectationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tableAffectation t = new tableAffectation();
            t.Show();
        }
    }
}