using System;

namespace Exercice1
{
	class Exercice1
	{
		public static void Main(string[] args)
        {
            float min, max;
            float[] tab = { 2.0f, 3.0f, 4.0f, 10.0f, 0.0f, 8.0f };

			// Trouve les valeurs min et max dans le tableau
			minMax (tab, out min, out max);
			
			Console.WriteLine ("La valeur Minimal est {0}", min);
			Console.WriteLine ("La valeur Maximal est {0}", max);
			
			// Permute les deux valeurs
			echange(ref min, ref max);
			
			Console.WriteLine ("La valeur Minimal est {0}", min);
			Console.WriteLine ("La valeur Maximal est {0}", max);
        }

        public static void minMax (float[] tab, out float min, out float max)
		{
           	min = tab[0];
         	max = min;
           
            foreach (float val in tab) 
			{
                if (val <= min) min = val;
                if (val > max) max = val;
            }		
		}
		
		public static void echange (ref float val1, ref float val2)
		{
			float temp= val1;
			val1= val2;
			val2= temp;
		}
	}
}
