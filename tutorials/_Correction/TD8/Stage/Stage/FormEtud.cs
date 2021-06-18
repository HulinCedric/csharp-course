using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stage
{
    public partial class FormEtud : Form
    {
        public FormEtud()
        {
            InitializeComponent();
        }

        private void tEtudiantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tEtudiantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stageDataSet);

        }

        private void FormEtud_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'stageDataSet.TEtudiants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tEtudiantsTableAdapter.Fill(this.stageDataSet.TEtudiants);
            // TODO : cette ligne de code charge les données dans la table 'stageDataSet.TEtudiants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tEtudiantsTableAdapter.Fill(this.stageDataSet.TEtudiants);
            // TODO : cette ligne de code charge les données dans la table 'stageDataSet.TEtudiants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tEtudiantsTableAdapter.Fill(this.stageDataSet.TEtudiants);
            // TODO : cette ligne de code charge les données dans la table 'stageDataSet.TEtudiants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            //this.tEtudiantsTableAdapter.Fill(this.stageDataSet.TEtudiants);

        }

        private void tEtudiantsBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tEtudiantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stageDataSet);

        }

       
    }
}
