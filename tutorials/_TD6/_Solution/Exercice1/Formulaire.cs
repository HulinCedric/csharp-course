using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Exercice1
{
    public partial class Formulaire : Form
    {
        public Formulaire()
        {
            InitializeComponent();
        }

        private void TransfererUn(ListBox source, ListBox destination)
        {
            if (source.SelectedIndex==-1)
                MessageBox.Show("Vous devez d'abord sélectionner un élément dans la liste de " + source.Tag);
            else
            {
                destination.Items.Add(source.Items[source.SelectedIndex]);
                source.Items.RemoveAt(source.SelectedIndex);
            }
        }

        private void TransfererTous(ListBox source, ListBox destination)
        {
            foreach (Object item in source.Items)
                destination.Items.Add(item);
            source.Items.Clear();
        }

        private void AjouterElem(TextBox tb, ListBox liste)
        {
            if (tb.Text=="")
                MessageBox.Show("Vous devez d'abord saisir un élément dans la zone de " + liste.Tag);
            else
            {
                liste.Items.Add(tb.Text);
                tb.Clear();
                tb.Focus();
            }
        }

        private void SupprimerElem(ListBox liste)
        {
            if (liste.SelectedIndex==-1)
                MessageBox.Show("Vous devez d'abord sélectionner l'élément à supprimer de la liste de " + liste.Tag);
            else
                liste.Items.RemoveAt(liste.SelectedIndex);
        }

        private void bt_quitter_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous réellement quitter ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void BoutonElemDroit_Click(object sender, EventArgs e)
        {
            TransfererUn(ListeGauche, ListeDroite);
        }

        private void BoutonElemGauche_Click(object sender, EventArgs e)
        {
            TransfererUn(ListeDroite, ListeGauche);
        }

        private void BoutonTousDroit_Click(object sender, EventArgs e)
        {
            TransfererTous(ListeGauche, ListeDroite);
        }

        private void BoutonTousGauche_Click(object sender, EventArgs e)
        {
            TransfererTous(ListeDroite, ListeGauche);
        }

        private void BoutonPlusGauche_Click(object sender, EventArgs e)
        {
            AjouterElem(ChampGauche, ListeGauche);
        }

        private void BoutonPlusDroit_Click(object sender, EventArgs e)
        {
            AjouterElem(ChampDroit, ListeDroite);
        }

        private void BoutonMoinsGauche_Click(object sender, EventArgs e)
        {
            SupprimerElem(ListeGauche);
        }

        private void BoutonMoinsDroit_Click(object sender, EventArgs e)
        {
            SupprimerElem(ListeDroite);
        }

        private void ListeGauche_DoubleClick(object sender, EventArgs e)
        {
            TransfererUn(ListeGauche, ListeDroite);
        }

        private void ListeDroite_DoubleClick(object sender, EventArgs e)
        {
            TransfererUn(ListeDroite, ListeGauche);
        }
    }
}