using System;

namespace Exercice1
{
	public class Prog
	{
        public static void Main()
        {
            TabCollaborateur tab=new TabCollaborateur();
            
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
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
            
			tab.Add(c1);
            tab.Add(e1); 
            tab.Add(m1);
            tab.Add(e2);
            tab.Add(m2);
            tab.Add(c2);
            
			Console.WriteLine("COLLABORATEUR AYANT PLUS HAUT SALAIRE");
            Console.WriteLine(tab.PlusHautSal());
            
			Console.WriteLine("EMPLOYE AYANT PLUS HAUT SALAIRE");
            Console.WriteLine(tab.PlusHautSal("Employe"));
            
			Console.WriteLine("MANAGER AYANT PLUS HAUT SALAIRE");
            Console.WriteLine(tab.PlusHautSal("Manager"));
            
			Console.WriteLine("COMMERCIAL AYANT PLUS HAUT SALAIRE");
            Console.WriteLine(tab.PlusHautSal("Commercial"));
			
            Console.WriteLine("TRI SUR AGE ");
            tab.Sort();
            foreach (Collaborateur c in tab)
                Console.WriteLine(c);
			
            Console.WriteLine("TRI SUR SALAIRE ");
            tab.Sort(new TriSalaire());
            foreach (Collaborateur c in tab)
                Console.WriteLine(c);
         }
    }
}