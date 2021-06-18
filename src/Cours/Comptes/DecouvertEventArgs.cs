using System;
using System.Collections.Generic;
using System.Text;

namespace EvtDecouvert
{
	public class DecouvertEventArgs : EventArgs
    {
        private string num;
        double montant;
        DateTime jour;

        public DecouvertEventArgs(string num, double montant, DateTime jour)
        {
            this.num = num;
            this.montant = montant;
            this.jour = jour;
        }
		
        public string Num
        {
            get { return num; }
        }
		
        public double Montant
        {
            get { return montant; }
        }

        public DateTime Jour
        {
            get { return jour; }
        }

        public override string ToString()
        {
            return "Compte numero " + num + " a demande suite a un decouvert " + montant + " E " + "le " + jour;
        }
    }
}