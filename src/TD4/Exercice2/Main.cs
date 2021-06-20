using System;

namespace Exercice2
{
	class MainClass
	{
		public static void Main (string[] args)
		{	
		 	Personnage p1;
            Personnage p2;
            Personnage p3;
            Personnage p4;
            

            // Contexte de stratégies différentes
            p1 = new Orc("Azag",5);
            p1.Combat();
            Console.WriteLine(p1);
            Console.WriteLine();


            p2 = new Tauren("Diablon",15);
            p2.Combat();
            Console.WriteLine(p2);
            Console.WriteLine();

            p3 = new Troll("Arkor","Heinken");
            p3.Combat();
            Console.WriteLine(p3);
            Console.WriteLine();

            p4 = new Humain("Kir","Bleu");
            p4.Combat();
            Console.WriteLine(p4);
            Console.WriteLine();

            p2.Stategy = new AvecEpéé();
            p2.Combat();
            Console.WriteLine(p2);
            Console.WriteLine();
		}
	}
}