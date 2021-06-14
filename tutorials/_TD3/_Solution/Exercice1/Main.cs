using System;

namespace Exercice1
{
	public class Prog
	{
		public static void Main()
        {
			Machine m1= new Machine("M1", 15.0f, 30.0f);
			Controleur c1= new Controleur("C1", "Nice");
			m1.Surchauffe+= c1.Surveiller;
			
			m1.Temperature= 30.1f;
		}
	}
}
