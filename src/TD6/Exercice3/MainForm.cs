using System;
using System.Collections.Generic;
//using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercice_7
{
    public partial class MainForm : Form
    {
        private TextBox[] labels;
        private ComboBox[] combos;

        public MainForm()
        {
            InitializeComponent();

            labels = new TextBox[3] { textBox1, textBox2, textBox3 };
            combos = new ComboBox[3]{comboBox1, comboBox2, comboBox3};
            this.SuspendLayout(); 

            foreach (QCM q in QCMList.QCMS)
            {
                
                listBox.Items.Add(q);
            }
            listBox.EndUpdate();
            listBox.SelectedItem = listBox.Items[0];
            this.ResumeLayout(true);
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                QCM qcm = (QCM)listBox.SelectedItem;

                //On affiche les questions
                for (int i = 0; i < labels.Length; i++)
                    
                    labels[i].Text =  qcm.Questions[i];

                //On ajoute les choix aux ComboBox
                for (int i = 0; i < combos.Length; i++)
                {
                    combos[i].Items.Clear();
                    combos[i].Items.AddRange(qcm.Choix[i]);
                    combos[i].Text = "";
                }
            }
        }

        private void buttonFin_Click(object sender, EventArgs e)
        {
            if (listBox.SelectedItem != null)
            {
                QCM qcm = (QCM)listBox.SelectedItem;

                int juste = 0;
                int total = qcm.Questions.Length;

                for (int i = 0; i < combos.Length; i++)
                {
                    if (combos[i].SelectedItem == null)
                    {
                        MessageBox.Show("Vous n'avez pas répondu à toutes les questions !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (combos[i].SelectedItem.ToString() == qcm.Reponses[i])
                        juste++;
                }

             
                if (juste == 0)
                {
                    MessageBox.Show( "Dommage, vous avez tout faux !");
                        
                }
                else if (juste == total)
                {
                    MessageBox.Show("Félicitations, vous avez tout juste !");
                    
                }
                else
                {
                     MessageBox.Show("Votre score : " + juste.ToString() + "/ " +total.ToString());
                    
                }
                
            }
        }
    }
}