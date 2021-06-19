using System;
using System.Collections.Generic;
using System.Text;

namespace EvtDecouvert
{ 
   	public  class CompteLivret : Compte
    {
        private double taux;
        
        public CompteLivret(string num, string nom, double depot, double taux) : base(num, nom, depot)
        {
            this.taux = taux;
        }

        public override string ToString()
        {
            return base.ToString() + " < taux " + taux*100 + " % >";
        }
        
        public double Taux
        {
            get { return taux; }
            set { taux = value; }
        }
    }
}
