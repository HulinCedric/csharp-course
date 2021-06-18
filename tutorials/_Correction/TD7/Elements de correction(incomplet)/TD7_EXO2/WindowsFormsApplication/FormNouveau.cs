using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using PersonnelDLL;

namespace WindowsFormsApplication
{
    public partial class FormNouveau : Form
    {
       protected Collaborateur col;
        public FormNouveau()
        {
            InitializeComponent();
        }

        public Collaborateur GetIndividu()
        {
            return col;
        }
    }
}
