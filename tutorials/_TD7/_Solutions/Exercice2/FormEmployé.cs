using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PersonnelDLL;

namespace Exercice2
{
    public partial class FormEmployé : Exercice2.FormCollaborateur
    {
        public FormEmployé()
        {
            InitializeComponent();
        }

        private void BoutonOk_Click(object sender, EventArgs e)
        {
            while (TextBoxNom.Text == "")
                MessageBox.Show("Remplissez tous les champs");

            try
            {
                Employe c = new Employe(TextBoxNom.Text, DateNaissance.Value, (float)NumericTarif.Value, (int)NumericHSupp.Value);
                ajouterPersonnel(c);
            }
            catch (Exception s)
            {
                MessageBox.Show("Probleme de valeur");
            }

            Close();
        }
    }
}
