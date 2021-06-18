using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TD6___Reut.Compo
{
    public partial class tableStageTableau : Form
    {
        public tableStageTableau()
        {
            InitializeComponent();
        }

        private void stagesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.stagesBindingSource.EndEdit();
            this.stagesTableAdapter.Update(this._TD6_ReutCompoDataSet.Stages);

        }

        private void tableStageTableau_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table '_TD6_ReutCompoDataSet.Stages'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.stagesTableAdapter.Fill(this._TD6_ReutCompoDataSet.Stages);

        }
    }
}