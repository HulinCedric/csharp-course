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
    public partial class FormListe : Form
    {
        private string type;
        public FormListe(string type)
        {
            InitializeComponent();
            this.type = type;
        }

        public void ajouterindividu_individuCree(Collaborateur ind)
        {
            List<Collaborateur> listInd = ((FormMenu)this.MdiParent).ListInd;
            listInd.Add(ind);
            ((FormMenu)this.MdiParent).UpdateAllViews();

        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Collaborateur ind;
            FormNouveau ajouterIndividu=null;
            if (type == "man")
            {
                ajouterIndividu = new FormNouveauManager();
                
            }
            if (type == "emp")
            {
               ajouterIndividu = new FormNouveauEmployé();
                
            }

            if (type == "com")
            {
               MessageBox.Show(" Non encore Traité");
               return;

            }

            if (type == "col")
            {
                MessageBox.Show(" Non encore Traité");
                return;
                // Demander le type à creer emp, man, com
            }

            DialogResult d = ajouterIndividu.ShowDialog();

            if (d == DialogResult.OK)
            {
                 ind = ajouterIndividu.GetIndividu();
                if (ind != null)
                    ajouterindividu_individuCree(ind);
            }

        }


        private void Remplir()
        {
            List<Collaborateur> listInd = ((FormMenu)this.MdiParent).ListInd;
            listBox1.Items.Clear();
            foreach (Collaborateur ind in listInd)
            {
                if ((ind is Employe) && (type == "emp"))
                    listBox1.Items.Add(ind);
                if ((ind is Manager) && (type == "man"))
                    listBox1.Items.Add(ind);
                if ((ind is Employe) && (type == "com"))
                    listBox1.Items.Add(ind);
                if (type == "col")
                    listBox1.Items.Add(ind);
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            Remplir();
        }

        private void FormListDirecteur_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Remplir();
        }

        private void FormListe_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Remplir();
        }
    }
}
