using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PersonnelDLL;

namespace WindowsFormsApplication
{
    public partial class FormParametre : Form
    {
        public FormParametre()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.CompareTo(string.Empty) == 0)
            {
                MessageBox.Show("Veuillez entrer un taux employé.", "Information", MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
            }
            else

                if (textBox2.Text.CompareTo(string.Empty) == 0)
                {
                    MessageBox.Show("Veuillez entrer un taux commercial.", "Information", MessageBoxButtons.OK,
                     MessageBoxIcon.Error);
                }
                else
                {
                    Commercial.TauxCom = float.Parse(textBox2.Text);
                    Employe.TauxEmp = float.Parse(textBox1.Text);
                    Close();
                }
        }
    }

 }
