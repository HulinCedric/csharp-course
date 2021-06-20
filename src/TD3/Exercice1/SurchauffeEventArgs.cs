using System;

namespace Exercice1
{
	public class SurchauffeEventArgs : EventArgs
    {
        private string nom;
        private float temperature;
        private float seuilLimiteTemperature;

        public SurchauffeEventArgs(string nom, float temperature, float seuilLimiteTemperature)
        {
            this.nom= nom;
            this.temperature= temperature;
            this.seuilLimiteTemperature= seuilLimiteTemperature;
        }
		
        public string Nom
        {
            get { return nom; }
        }
		
        public float Temperature
        {
            get { return temperature; }
        }

        public float SeuilLimiteTemperature
        {
            get { return seuilLimiteTemperature; }
        }

        public override string ToString()
        {
            return "Machine " + nom + " en surchauffe : Temperature " + temperature + " C : Seuil " + seuilLimiteTemperature + " C";
        }
    }
}