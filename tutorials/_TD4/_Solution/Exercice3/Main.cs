using System;

namespace Exercice3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Simulateur[] simulateur = new Simulateur[4];
			
			simulateur[0] = new SimulateurTauren("Diablon", "15");
			
			simulateur[1] = new SimulateurOrc("Azag", "5");
			
			simulateur[2] = new SimulateurTroll("ArKor", "Heinken");
			
			simulateur[3] = new SimulateurHumain("Kir", "Bleu");
			
			foreach (Simulateur simu in simulateur) {
				
				simu.Simuler ();
				Console.WriteLine ("Created by {0}", simu.GetType ().Name);
			}
		}
	}
}
