using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TD6___Reut.Compo
{
    public partial class tableEtudiant : Form
    {
        public tableEtudiant()
        {
            InitializeComponent();
        }

        private void tableEtudiant_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table '_TD6_ReutCompoDataSet1.Etudiants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.etudiantsTableAdapter.Fill(this._TD6_ReutCompoDataSet1.Etudiants);

        }

        private void etudiantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.etudiantsBindingSource.EndEdit();
            this.etudiantsTableAdapter.Update(this._TD6_ReutCompoDataSet1.Etudiants);

        }
    }
}