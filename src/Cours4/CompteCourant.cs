using System;
using System.Collections.Generic;
using System.Text;

namespace EvtDecouvert
{
	public class CompteCourant : Compte
    {
        public delegate void DecouvertEventHandler(object sender, DecouvertEventArgs e);
        private double decouvertAutorise;
        public event DecouvertEventHandler RetirerNonAut;
       
        public CompteCourant(string num, string nom) : base(num, nom)
        {
            decouvertAutorise = 0;
        }
		
        public CompteCourant(string num, string nom, double depot) : base(num, nom, depot)
        {
            decouvertAutorise = 0;
        }
		
        public CompteCourant(string num, string nom, double depot, double decouv) : base(num, nom, depot)
        {
            decouvertAutorise = decouv;
        }

        public override string ToString()
        {
            return base.ToString() + " < decouvert aut. " + decouvertAutorise + "  E >";
        }

        public double DecouvertAutorise
        {
            get { return decouvertAutorise; }
            set { decouvertAutorise = value; }
        }

        public override void retirer(double somme)
        {
            if (somme <= Solde + decouvertAutorise)
            {
                double frais = 0;
                if (somme > Solde)
                    frais = 0.12 * (somme - Solde);
                Solde = Solde - somme - frais;
            }
			// l'interêt de ne pas faire le write ici est
			// de pouvoir prévenir d'autres objets
			//
            else OnRetirerNonAut(Numero,somme,DateTime.Now);
        }

        //-- méthode publique qui lance l'événement :
		//
        public void OnRetirerNonAut(string num,double montant, DateTime jour)
        {
            if (RetirerNonAut != null)
                RetirerNonAut(this, new DecouvertEventArgs(num,montant,jour));
        }
 	}
}
