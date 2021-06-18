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
    public partial class FormListe : Form
    {
        private string type;

        public FormListe()
        {
            InitializeComponent();
            type="Collaborateur";
            ContextMenuStrip = contextMenuStrip;
        }

        public void Remplir()
        {
            List<Collaborateur> listCollaborateur = ((Formulaire)MdiParent).ListCollaborateur;
            DataList.Items.Clear();
            foreach (Collaborateur o in listCollaborateur)
            {
                if (type == "Collaborateur")
                    DataList.Items.Add(o);
                if (o.GetType().Name == type)
                    DataList.Items.Add(o);
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            Remplir();
        }

        private void FormListe_TextChanged(object sender, EventArgs e)
        {
            switch (Text)
            {
                case "Liste des personnels":
                    contextMenuStrip.Items.RemoveAt(0);
                    type = "Collaborateur";
                    break;

                case "Liste des managers":
                    type = "Manager";
                    break;

                case "Liste des employés":
                    type = "Employe";
                    break;

                case "Liste des commercial":
                    type = "Commercial";
                    break;
            }
        }

        private void Nouveau_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "Manager":
                    FormManager formM = new FormManager();
                    formM.MdiParent = MdiParent;
                    formM.Show();
                    break;

                case "Employe":
                    FormEmployé formE = new FormEmployé();
                    formE.MdiParent = MdiParent;
                    formE.Show();
                    break;

                case "Commercial":
                    FormCommercial formC = new FormCommercial();
                    formC.MdiParent = MdiParent;
                    formC.Show();
                    break;
            }
        }
    }
}
