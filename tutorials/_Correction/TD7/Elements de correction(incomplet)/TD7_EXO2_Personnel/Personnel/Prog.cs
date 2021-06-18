using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class Prog
    {
        public static void Main()
        {
            TabCollaborateur tab=new TabCollaborateur();
           
            Employe e1 = new Employe("Lejaune", DateTime.Parse("13/05/1956"), 20, 30);
            Employe e2 = new Employe("LeBlanc", DateTime.Parse("20/05/1970"), 15, 100);
            Manager m1 = new Manager("LeRouge", DateTime.Parse("14/01/1998"), 2500, 150);
            Manager m2 = new Manager("LeVert", DateTime.Parse("29/10/1987"), 3000, 200);
            Commercial c1 = new Commercial("LeNoir", DateTime.Parse("29/01/1987"), 4000, 30000);
            Commercial c2 = new Commercial("LeViolet", DateTime.Parse("29/01/1987"), 3000, 30000);
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
