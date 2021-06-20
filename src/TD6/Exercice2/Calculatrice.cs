using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercice2
{
    public partial class Calculatrice : Form
    {
        private Calculette calculette;
        private bool opEnCours;

        public Calculatrice()
        {
            InitializeComponent();
            calculette = new Calculette(new ModeTape());
            opEnCours = false;
            Refresh();
        }

        private void AfficherResultat()
        {
            Afficheur.Text = calculette.Resultat.ToString();
        }

        private void Afficher()
        {
            if (opEnCours)
                Afficheur.Text = calculette.ValeurOperation.ToString();
            else
                Afficheur.Text = calculette.Valeur.ToString();
        }

        private void BoutonClick_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Text)
            {
                case "0":
                    calculette.Ajout(0.0f);
                    Afficher();
                    break;

                case "1":
                    calculette.Ajout(1.0f);
                    Afficher();
                    break;

                case "2":
                    calculette.Ajout(2.0f);
                    Afficher();
                    break;

                case "3":
                    calculette.Ajout(3.0f);
                    Afficher();
                    break;

                case "4":
                    calculette.Ajout(4.0f);
                    Afficher();
                    break;

                case "5":
                    calculette.Ajout(5.0f);
                    Afficher();
                    break;

                case "6":
                    calculette.Ajout(6.0f);
                    Afficher();
                    break;

                case "7":
                    calculette.Ajout(7.0f);
                    Afficher();
                    break;

                case "8":
                    calculette.Ajout(8.0f);
                    Afficher();
                    break;

                case "9":
                    calculette.Ajout(9.0f);
                    Afficher();
                    break;

                case "+":
                    if (opEnCours)
                    {
                        calculette.Operation();
                        calculette.Etat = new ModeAddition();
                        AfficherResultat();
                    }
                    else
                    {
                        calculette.Etat = new ModeAddition();
                        opEnCours = true;
                    }
                    break;

                case "-":
                    if (opEnCours)
                    {
                        calculette.Operation();
                        calculette.Etat = new ModeSoustraction();
                        AfficherResultat();
                    }
                    else
                    {
                        calculette.Etat = new ModeSoustraction();
                        opEnCours = true;
                    }
                    break;

                case "/":
                    if (opEnCours)
                    {
                        calculette.Operation();
                        calculette.Etat = new ModeDivision();
                        AfficherResultat();
                    }
                    else
                    {
                        calculette.Etat = new ModeDivision();
                        opEnCours = true;
                    }
                    break;

                case "*":
                    if (opEnCours)
                    {
                        calculette.Operation();
                        calculette.Etat = new ModeMultiplication();
                        AfficherResultat();
                    }
                    else
                    {
                        calculette.Etat = new ModeMultiplication();
                        opEnCours = true;
                    }
                    break;

                case "=":
                    calculette.Operation();
                    opEnCours = false;
                    AfficherResultat();
                    break;

                case ".":
                    break;

                case "CE":
                    calculette.Valeur = 0.0f;
                    calculette.Resultat = 0.0f;
                    opEnCours = false;
                    Afficher();
                    break;
            }
        }
    }
}
