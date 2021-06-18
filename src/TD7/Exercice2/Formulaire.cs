using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonnelDLL;

namespace Exercice2
{
    public partial class Formulaire : Form
    {
        private List<Collaborateur> listCollaborateur;

        public Formulaire()
        {
            InitializeComponent();
            listCollaborateur = new List<Collaborateur>();
        }

        public List<Collaborateur> ListCollaborateur
        {
            get { return listCollaborateur; }
        }

        public void UpdateAllViews()
        {
            if (MdiChildren.Length != 0)
                foreach (Form child in MdiChildren)
                    child.Refresh();
        }

        private void Paramètres_Click(object sender, EventArgs e)
        {
            FormParametre param = new FormParametre();
            param.ShowDialog();
            while (param.TextBoxTauxCom.Text == "" || param.TextBoxTauxEmp.Text == "")
            {
                MessageBox.Show("Remplissez tous les champs");
                param.ShowDialog();
            }

            try
            {
                Commercial.TauxCom = float.Parse(param.TextBoxTauxCom.Text);
            }
            catch (Exception s)
            {
                MessageBox.Show("Ne mettez que des chiffres. Le taux commercial reste à " + Commercial.TauxCom);
            }

            try
            {
                Employe.TauxEmp = float.Parse(param.TextBoxTauxEmp.Text);
            }
            catch (Exception s)
            {
                MessageBox.Show("Ne mettez que des chiffres. Le taux employé reste à " + Employe.TauxEmp);
            }
        }

        private void Affichage_Click(object sender, EventArgs e)
        {
            FormListe ajouter = new FormListe();
            ajouter.MdiParent = this;
            switch (((ToolStripItem)sender).Name)
            {
                case "Personnels":
                    ajouter.Text = "Liste des personnels";
                    break;

                case "Managers":
                    ajouter.Text = "Liste des managers";
                    break;

                case "Employés":
                    ajouter.Text = "Liste des employés";
                    break;

                case "Commerciaux":
                    ajouter.Text = "Liste des commercial";
                    break;
            }
            ajouter.Remplir();
            ajouter.Show();
        }
    }
}
