using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PersonnelDLL;

namespace WindowsFormsApplication
{
    public partial class FormNouveauEmployé : WindowsFormsApplication.FormNouveau
    {
        public FormNouveauEmployé()
        {
            InitializeComponent();
            userControlDate1.BringToFront(); // en avant plan
        }

        
        private void button1_Click_1(object sender, EventArgs e)
       
        {
            
            if (textBoxNom.Text.CompareTo(string.Empty) == 0) 
            {
                MessageBox.Show("Veuillez entrer un nom.", "Information", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
    
               
            }
            else
                if (textBoxTarif.Text.CompareTo(string.Empty) == 0)
                {
                   MessageBox.Show("Veuillez entrer un tarif horaire.", "Information", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);
                  
                }
                else

                   if (textBoxNbH.Text.CompareTo(string.Empty) == 0)
                   {
                     MessageBox.Show("Veuillez entrer un nombre d'heures.", "Information", MessageBoxButtons.OK,
                      MessageBoxIcon.Error);

                   }
                   else
                     {

                         col = new Employe(textBoxNom.Text, userControlDate1.Date,float.Parse(textBoxTarif.Text), Int32.Parse(textBoxNbH.Text));
                         this.DialogResult = DialogResult.OK;
                     }
            }

           
      }

   }

   