using System;

namespace Exercice1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			 // Création d'un contexte , l'état peut-être par défaut à initialiser éventuellement dans le constructeur
            Avion avion = new Avion(new DansLeGarage());

            // Exécution des requetes
            avion.SortirDuGarage();
            avion.Decoller();
            avion.Atterrir();
            avion.EntrerAuGarage();
			
			avion.Decoller();
		}
	}
}
