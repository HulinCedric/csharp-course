using System;

namespace Exercice1
{
	public class TemperatureTropHauteEventArgs : EventArgs
    {
		// Nom de la machine
		//
        private string nom;
		
		// Temperature observée
		//
        private decimal temperature;
		
		// Temperature maximale
		//
        private decimal seuil;

        public TemperatureTropHauteEventArgs(string nom, decimal temperature, decimal seuil)
        {
            this.nom= nom;
            this.temperature= temperature;
            this.seuil= seuil;
        }
		
        public string Nom
        {
            get { return nom; }
        }
		
        public decimal Temperature
        {
            get { return temperature; }
        }

        public decimal Seuil
        {
            get { return seuil; }
        }

        public override string ToString()
        {
            return "Machine " + nom + " en surchauffe : Temperature " + temperature + " C : Seuil " + seuil + " C";
        }
    }
}