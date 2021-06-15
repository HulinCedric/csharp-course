using System;
using CollaborateurDLL;

namespace Exercice1
{
	public class classMain
	{
		static void Main (string[] args)
		{
			CollaborateurList list1= CollaborateurList.getInstance();
			list1.Add(new Employe("Anne", "22081987", 35, 8.07));
			list1.Add(new Commercial("Jean", "12081988", 1800, 60000));
			list1.Add(new Manager("Jaques", "10021999", 2500, 200));
			
			Console.WriteLine("list 1 : ");
			
			foreach (Collaborateur col in list1)
				Console.WriteLine(col);
			
			CollaborateurList list2= CollaborateurList.getInstance();
			
			Console.WriteLine("list 2 : ");
			
			foreach (Collaborateur col in list2)
				Console.WriteLine(col);
		}
	}
}