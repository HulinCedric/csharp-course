using System;

namespace Exercice1
{
	public class Controleur
	{
		private string nom;
		private string localisation;
		private int nbMachines;
		private decimal temperatureSurchauffeMaximal;
		
		public Controleur ()
		{
			nom= "Default";
			localisation= "Default";
			nbMachines= 0;
			temperatureSurchauffeMaximal= 0;
		}
		
		public Controleur (string nom, string localisation)
		{
			this.nom= nom;
			this.localisation= localisation;
			nbMachines= 0;
			temperatureSurchauffeMaximal= 0;
		}
		
		public string Nom
		{
			get { return nom; }
			set { nom= value; }
		}
		
		public string Localisation
		{
			get { return localisation; }
			set { localisation= value; }
		}
		
		public int NbMachines
		{
			get { return nbMachines; }
		}
		
		public decimal TemperatureSurchauffeMaximal
		{
			get { return temperatureSurchauffeMaximal; }
		}

		public void Surveiller (object sender, TemperatureTropHauteEventArgs e)
		{
			Console.Beep(1500, 3000);
			nbMachines++;
			if (e.Temperature > temperatureSurchauffeMaximal)
				temperatureSurchauffeMaximal= e.Temperature;
			Console.WriteLine(e);
		}
	}
}