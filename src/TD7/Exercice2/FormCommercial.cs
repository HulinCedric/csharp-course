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
    public partial class FormCommercial : Exercice2.FormCollaborateur
    {
        public FormCommercial()
        {
            InitializeComponent();
        }

        private void BoutonOk_Click(object sender, EventArgs e)
        {
            while (TextBoxNom.Text == "")
                MessageBox.Show("Remplissez tous les champs");

            try
            {
                Commercial c = new Commercial(TextBoxNom.Text, DateNaissance.Value, (float)NumericSommeF.Value, (float)NumericCA.Value);
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
