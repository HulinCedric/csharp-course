using System;

namespace Exercice2
{
	class MainClass
	{
		public static void Main()
       	{
        		Arbre<int> arbre = new Arbre<int>(5, 10, 1, 8, 6, 3, 14);
			
			Console.WriteLine("Vide : " + arbre.Vide);
			Console.WriteLine();
			
			Console.WriteLine("Valeur Racine : " + arbre.ValeurRacine);
			Console.WriteLine();

		  	Console.WriteLine("Etat Initial :");
            	arbre.Parcours();
			Console.WriteLine();
			
			Console.WriteLine("Suppression :");
            	arbre.Remove(10);
            	arbre.Remove(1);
            	arbre.Parcours();
			Console.WriteLine();
          
			Console.WriteLine("Ajout :");
			arbre.Add(0);
			arbre.Add(7);
            	arbre.Add(12);
            	arbre.Parcours();
			Console.WriteLine();
			
			Console.WriteLine("Arbre Droit :");
		   	arbre.ArbreDroit.Parcours();
			Console.WriteLine();
			
			Console.WriteLine("Arbre Gauche :");
		   	arbre.ArbreGauche.Parcours();	
			Console.WriteLine();
       	}
	}
}