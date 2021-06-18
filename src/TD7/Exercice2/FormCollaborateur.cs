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
    public partial class FormCollaborateur : Form
    {
        public FormCollaborateur()
        {
            InitializeComponent();
        }

        public void ajouterPersonnel(Collaborateur col)
        {
            List<Collaborateur> listCollaborateur = ((Formulaire)MdiParent).ListCollaborateur;
            listCollaborateur.Add(col);
            ((Formulaire)MdiParent).UpdateAllViews();
        }
    }
}
