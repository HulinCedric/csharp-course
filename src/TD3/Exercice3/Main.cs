using System;
using ArbreDLL;
using CollaborateurDLL;

namespace Exercice3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Arbre<Collaborateur> arbre;
        
			Employe e1= null, e2= null;
			Manager m1= null, m2= null;
			Commercial c1= null, c2= null;
			
			try 
			{
				e1 = new Employe("LeJaune", "13051956", 20, 30);
	            e2 = new Employe("LeBlanc", "20051970", 15, 100);
	            
				m1 = new Manager("LeRoug", "14011998", 2500, 150);
	            m2 = new Manager("LeVert", "29101987", 3000, 200);
				
				c1 = new Commercial("LeNoir", "29011987", 4000, 30000);
	            c2 = new Commercial("LeViolet", "29011987", 3000, 30000);
			}
			catch (ExceptionDateInvalide e)
			{
				Console.WriteLine(e);
				System.Environment.Exit(-1);
			}
			
			arbre = new Arbre<Collaborateur>(e1, m1, c1);
			
			Console.WriteLine("Vide : " + arbre.Vide);
			Console.WriteLine();
			
			Console.WriteLine("Valeur Racine : ");
			Console.WriteLine(arbre.ValeurRacine);
			Console.WriteLine();

		  	Console.WriteLine("Etat Initial :");
            	arbre.Parcours();
			Console.WriteLine();

			Console.WriteLine("Suppression :");
            	arbre.Remove(e1);
            	arbre.Remove(m1);
            	arbre.Parcours();
			Console.WriteLine();
          
			Console.WriteLine("Ajout :");
   			arbre.Add(e2);
            arbre.Add(m2);
            arbre.Add(c2);		
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