using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Stage
{
    public partial class FormStageTab : Form
    {
        public FormStageTab()
        {
            InitializeComponent();
        }

        private void tStagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tStagesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.stageDataSet);

        }

        private void FormStageTab_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table 'stageDataSet.TStages'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.tStagesTableAdapter.Fill(this.stageDataSet.TStages);

        }
    }
}
