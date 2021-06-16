using System;

namespace Exercice3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			StationMeteo stationMeteto = new StationMeteo();
            new EcranAnalogique(stationMeteto);
            new EcranNumerique(stationMeteto);
            
            // Changement d'état
            stationMeteto.Temperature = 19;
            stationMeteto.Humidite = 50;
		}
	}
}