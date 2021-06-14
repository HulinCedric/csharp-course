using System;

namespace Exercice1
{
	public class Prog
	{
		public static void Main()
        {
			Machine m1= new Machine("M1", 15, 30);
			Controleur c1= new Controleur("C1", "Nice");
			m1.TemperatureTropHaute+= c1.Surveiller;
			
			// Mise en surchauffe
			//
			m1.Temperature= 31;
		}
	}
}
