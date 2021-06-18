using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice1bis
{
    public partial class Formulaire : Form
    {
        public Formulaire()
        {
            InitializeComponent();
        }

        private void Bouton_Click(object sender, EventArgs e)
        {
            if (dateControl.Textdate == "")
                return;
            else
                TextBox.Text = dateControl.Textdate;
        }
    }
}
