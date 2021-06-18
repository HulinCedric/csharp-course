using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using PersonnelDLL;

namespace WindowsFormsApplication
{
    
    public partial class FormMenu : Form
    {
        private List<Collaborateur> listInd;
        public FormMenu()
        {
            InitializeComponent();
            listInd = new List<Collaborateur>();
        } 
        
        public List <Collaborateur> ListInd
        {
            get {return listInd;}
            set { listInd = value; }
        }

        private void personnelToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListe FormListCollaborateur = new FormListe("col");
            FormListCollaborateur.Text = "Liste des personnels";
            FormListCollaborateur.MdiParent = this;
            FormListCollaborateur.Show();
        }

        private void managerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListe FormListManager = new FormListe("man");
            FormListManager.Text = "Liste des managers";
            FormListManager.MdiParent = this;
            FormListManager.Show();

        }

        private void employéToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormListe FormListEmployé = new FormListe("emp");
            FormListEmployé.Text = "Liste des employés";
            FormListEmployé.MdiParent = this;
            FormListEmployé.Show();


        }

        private void commercialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormListe FormListCom = new FormListe("com");
            FormListCom.Text = "Liste des employés";
            FormListCom.MdiParent = this;
            FormListCom.Show();

        }


        public void UpdateAllViews()
        {
            if (this.MdiChildren.Length != 0)

                foreach (Form child in MdiChildren) // 

                    child.Refresh();

        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormParametre f = new FormParametre();
            f.MdiParent=this;
            f.Show();
        }


       
    }
}

 

       
         


       