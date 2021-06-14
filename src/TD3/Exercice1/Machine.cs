using System;

namespace Exercice1
{
	public class Machine
	{
		public delegate void TemperatureTropHauteHandler(object sender, TemperatureTropHauteEventArgs e);
		public event TemperatureTropHauteHandler TemperatureTropHaute;
		
		// Nom de la machine
		//
		private string nom;
		
		// Temperature observée
		//
		private decimal temperature;
		
		// Temperature maximale
		//
		private decimal seuil;
		
		public Machine()
		{
			nom= "Default";
			temperature= 0;
			seuil= 0;
		}
		
		public Machine(string nom, decimal temperature, decimal seuil)
		{
			this.nom= nom;
			this.temperature= temperature;
			this.seuil= seuil;
		}
		
		public string Nom
		{
			get { return nom; }
			set { nom= value; }
		}
		
		public decimal Temperature
		{
			get { return temperature; }
			set 
			{ 
				temperature= value;
				
				if (temperature > seuil)
					OnTemperatureTropHaute(nom, temperature, seuil);
			}
		}
		
		public decimal Seuil
		{
			get { return seuil; }
			set { seuil= value; }
		}
		
		public override string ToString()
		{
			return "Machine : " + nom + "\tSeuil : " + seuil + "\tTemperature : " + temperature;
		}
		
		public void OnTemperatureTropHaute(string nom, decimal temperature, decimal seuil)
        {
            if (TemperatureTropHaute != null)
                TemperatureTropHaute(this, new TemperatureTropHauteEventArgs(nom, temperature, seuil));
        }
	}
}