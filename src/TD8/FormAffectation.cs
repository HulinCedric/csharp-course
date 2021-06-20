using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data.OleDb;

namespace Stage
{
    public partial class FormAffectation : Form
    {
        private OleDbConnection connection;
     
        public FormAffectation()
        {
            
           
            InitializeComponent();

        }

        private void FormAffectation_FormClosed(object sender, FormClosedEventArgs e)
        {
            connection.Close();
        }

        private void FormAffectation_Load(object sender, EventArgs e)
        {

          
            string urlStr = " Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=C:\Users\rosa\ROSA\APO\C#_SQL2005\Réutilisation_Composant\TD09_10\TD8\stage.accdb";

            //connection = new OdbcConnection(urlStr);
            connection = new OleDbConnection(urlStr);
            
           
            connection.Open();
            RemplirListEtud();
            RemplirListStage();
           
        }

        private void buttonValider_Click(object sender, EventArgs e)
        {
            int n1 = listBoxStage.SelectedIndex;
            int n2=listBoxEtud.SelectedIndex;
            if (n1 >= 0 && n2 >= 0)
            {
                int stage = Int32.Parse((listBoxStage.SelectedItem).ToString());
                string idSelected = (listBoxEtud.SelectedItem).ToString();

                String req = "UPDATE TEtudiants SET numStage = " + stage + "  WHERE nomEtud ='" + idSelected + "' ";
                OleDbCommand commandSelect = new OleDbCommand(req, connection);
                commandSelect.ExecuteNonQuery();
                textBoxNom.Text = "";
                textBoxEnt.Text = "";
                listBoxEtud.Items.Clear();
                listBoxStage.Items.Clear();
                RemplirListEtud();
                RemplirListStage();
            }
        }

        public void RemplirListEtud()
        {
           
            string req = "Select nomEtud from TEtudiants where numStage is Null ";
            OleDbCommand commandSelect = new OleDbCommand(req, connection);
            OleDbDataReader rdr = commandSelect.ExecuteReader();
            while (rdr.Read())
            {
               
                listBoxEtud.Items.Add(rdr[0].ToString());
            }
        }

        public void RemplirListStage()
        {
            string req = "SELECT * FROM TStages ";
            req += " WHERE (((TStages.nombre)>(Select count(*) From TEtudiants where TStages.numStage=TEtudiants.numStage)))";
            OleDbCommand commandSelect = new OleDbCommand(req, connection);
            OleDbDataReader rdr = commandSelect.ExecuteReader();
            while (rdr.Read())
                listBoxStage.Items.Add(rdr[0].ToString());
        }

        private void listBoxEtud_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n=listBoxEtud.SelectedIndex;
            if (n >= 0)
            {

                string idSelected =  (listBoxEtud.SelectedItem).ToString();

                String req = "Select PrenomEtud from TEtudiants WHERE nomEtud ='" + idSelected + "' ";
                OleDbCommand commandSelect = new OleDbCommand(req, connection);
                textBoxNom.Text = (commandSelect.ExecuteScalar()).ToString();
                
            }

           

        }

        private void listBoxStage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int n=listBoxStage.SelectedIndex;
            if (n >= 0)
            {

               int idSelected = Int32.Parse((listBoxStage.SelectedItem).ToString());

                String req = "Select nomEnt from TStages WHERE numStage = " + idSelected + " ";
                OleDbCommand commandSelect = new OleDbCommand(req, connection);
                textBoxEnt.Text = (commandSelect.ExecuteScalar()).ToString();
            }

        }


        
    }
}