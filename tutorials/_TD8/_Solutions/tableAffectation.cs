using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.Odbc;

namespace TD6___Reut.Compo
{
    public partial class tableAffectation : Form
    {
        ArrayList listeEtudiants;
        public tableAffectation()
        {
            listeEtudiants = new ArrayList();
            InitializeComponent();
        }

        private void etudiantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.etudiantsBindingSource.EndEdit();
            this.etudiantsTableAdapter.Update(this._TD6_ReutCompoDataSet.Etudiants);

        }

        private void tableAffectation_Load(object sender, EventArgs e)
        {
            // TODO : cette ligne de code charge les données dans la table '_TD6_ReutCompoDataSet.Stages'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.stagesTableAdapter.Fill(this._TD6_ReutCompoDataSet.Stages);
            // TODO : cette ligne de code charge les données dans la table '_TD6_ReutCompoDataSet.Etudiants'. Vous pouvez la déplacer ou la supprimer selon vos besoins.
            this.etudiantsTableAdapter.Fill(this._TD6_ReutCompoDataSet.Etudiants);
            remplirEtudiants();
            remplirStage();
        }

        public void remplirEtudiants()
        {
            listeEtudiants.Clear();
            nomsEtudiantsListBox.Items.Clear();
            string urlStr = "Driver={Microsoft Access Driver (*.mdb)};" +
            @"DBQ=C:\Documents and Settings\HULIN\Bureau\Projects\TD8\bin\Debug\TD6-ReutCompo.mdb";
            OdbcConnection connection = new OdbcConnection(urlStr);
            connection.Open();
            string sql = "SELECT * FROM ETUDIANTS WHERE numeroStage IS NULL;";
            OdbcCommand commandeAjout = new OdbcCommand(sql);
            commandeAjout.Connection = connection;
            OdbcDataReader odr = commandeAjout.ExecuteReader();
            while (odr.Read())
            {
                nomsEtudiantsListBox.Items.Add(odr[1].ToString());
                listeEtudiants.Add(odr[0].ToString());
            }
            connection.Close();
        }

        private void nomsEtudiantsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stagesListBox.SelectedIndex < 0 || nomsEtudiantsListBox.SelectedIndex < 0) return;
            string urlStr = "Driver={Microsoft Access Driver (*.mdb)};" +
            @"DBQ=C:\Documents and Settings\HULIN\Bureau\Projects\TD8\bin\Debug\TD6-ReutCompo.mdb";
            OdbcConnection connection = new OdbcConnection(urlStr);
            connection.Open();
            string sql = "SELECT * FROM ETUDIANTS WHERE numEtudiant = " + listeEtudiants[nomsEtudiantsListBox.SelectedIndex] + ";";
            OdbcCommand commandeAjout = new OdbcCommand(sql);
            commandeAjout.Connection = connection;
            OdbcDataReader odr = commandeAjout.ExecuteReader();
            while (odr.Read())
                prenomEtudiantTB.Text = odr[2].ToString();
            connection.Close();
                
        }

        public void remplirStage()
        {
            stagesListBox.Items.Clear();
            string urlStr = "Driver={Microsoft Access Driver (*.mdb)};" +
            @"DBQ=C:\Documents and Settings\HULIN\Bureau\Projects\TD8\bin\Debug\TD6-ReutCompo.mdb";
            OdbcConnection connection = new OdbcConnection(urlStr);
            connection.Open();
            string sql = "SELECT * FROM STAGES AS st WHERE nombreStagiaires > (SELECT COUNT(*) FROM ETUDIANTS WHERE numeroStage = st.numeroStage);";
            OdbcCommand commandeAjout = new OdbcCommand(sql);
            commandeAjout.Connection = connection;
            OdbcDataReader odr = commandeAjout.ExecuteReader();
            while (odr.Read())
            {
                stagesListBox.Items.Add(odr[0].ToString());
            }
            connection.Close();
        }

        public override void Refresh()
        {
            base.Refresh();
            if (stagesListBox.SelectedIndex < 0)
            {
                entrepriseTB.Text = "";
            }
            if (nomsEtudiantsListBox.SelectedIndex < 0)
            {
                prenomEtudiantTB.Text = "";
            }
        }
        private void stagesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (stagesListBox.SelectedIndex < 0 || nomsEtudiantsListBox.SelectedIndex < 0) return;
            string urlStr = "Driver={Microsoft Access Driver (*.mdb)};" +
            @"DBQ=C:\Documents and Settings\HULIN\Bureau\Projects\TD8\bin\Debug\TD6-ReutCompo.mdb";
            OdbcConnection connection = new OdbcConnection(urlStr);
            connection.Open();
            string sql = "SELECT * FROM STAGES WHERE numeroStage = " + stagesListBox.Items[stagesListBox.SelectedIndex] + ";";
            OdbcCommand commandeAjout = new OdbcCommand(sql);
            commandeAjout.Connection = connection;
            OdbcDataReader odr = commandeAjout.ExecuteReader();
            while (odr.Read())
                entrepriseTB.Text = odr[1].ToString();
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stagesListBox.SelectedIndex < 0 || nomsEtudiantsListBox.SelectedIndex < 0) return;
            string urlStr = "Driver={Microsoft Access Driver (*.mdb)};" +
            @"DBQ=C:\Documents and Settings\HULIN\Bureau\Projects\TD8\bin\Debug\TD6-ReutCompo.mdb";
            OdbcConnection connection = new OdbcConnection(urlStr);
            connection.Open();
            string sql = "UPDATE Etudiants SET numeroStage = " + stagesListBox.Items[stagesListBox.SelectedIndex] + " WHERE numEtudiant = " + listeEtudiants[nomsEtudiantsListBox.SelectedIndex] + ";";
            OdbcCommand commandeAjout = new OdbcCommand(sql);
            commandeAjout.Connection = connection;
            commandeAjout.ExecuteNonQuery();
            connection.Close();
            remplirEtudiants();
            remplirStage();
            Refresh();
        }
    }
}