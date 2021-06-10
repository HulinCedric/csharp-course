using System;

namespace Exercice3
{
	class Exercice3
	{
		public static void Main (string[] args)
		{
			TabEmp tab= new TabEmp(3);
			
			tab[0]= new Employe();
			tab[1]= new Employe("Beatrice", "Defont", new DateTime(1987, 08, 22), 1200.0);
			tab[2]= new Employe("Jack", "Leventreur", new DateTime(1950, 06, 12), 900.0);
			
			Console.WriteLine("Jack est a la {0}e place\n", tab["Jack"]);
			
			for(int i= 0 ; i < tab.Max ; i++)
			{
				Console.WriteLine(tab[i].ToString());
			}
		}
	}
	
	public class TabEmp 
	{
		// Tableau privé interne qui contient les employés.
		//
		private Employe [] emps; 
		
		// Nombre maximum d’éléments
		//
		private int max;	 
		
		// Le constructeur qui initialise le tableau.
		//
		public TabEmp(int max) 
		{
			emps= new Employe[max];
			this.max= max;
		}
				
		public int Max
		{
			get { return max; }
		}
				
		// L'indexeur qui retourne l'index de l’employé à partir du nom.
		public int this[string nom] 
		{
			get 
			{
				int index= 1;
				foreach (Employe person in emps)
				{
					if (person.Nom == nom) return index;
					index++;
				}
				return -1;
			}
		}

		// L'indexeur qui retourne ou affecte un employé à partir de l’index.
		public Employe this[int i] 
		{
			get { return emps[i]; }
			set { emps[i]= value; }
		}
	}
	
	public class Employe
	{
		private int matricule;
		private string nom;
		private string prenom;
		private DateTime dateDeNaissance;
		private double salaire;
		private static int nbEmployes;
		
		public int Matricule
		{
			get { return matricule; }
		}
		
		public string Nom
		{
			get { return nom; }
			set { nom= value; }
		}
		
		public string Prenom
		{
			get { return prenom; }
			set { prenom= value; }
		}
		
		public DateTime DateDeNaissance
		{
			get { return dateDeNaissance; }
			set { dateDeNaissance= value; }
		}
	
		public double Salaire 
		{
			get { return salaire; }
			set { salaire= value; }
		}
		
		public int NbEmployes
		{
			get { return nbEmployes; }
		}
		
		public Employe ()
		{
			matricule= ++nbEmployes;
			nom= "Default";
			prenom= "Default";
			dateDeNaissance= new DateTime();
			salaire= 0.0;
		}
		
		public Employe (string nom, string prenom, DateTime dateDeNaissance, double salaire)
		{
			matricule= ++nbEmployes;
			this.nom= nom;
			this.prenom= prenom;
			this.dateDeNaissance= dateDeNaissance;
			this.salaire= salaire;
		}
		
	 	static Employe()
		{
			nbEmployes=0;
		}
		
		public static int age (int annee) 
		{
			return DateTime.Now.Year - annee;
		}
		
		public override string ToString()
		{
			return 	matricule + " " + 
					nom + " " + 
					prenom + " " + 
					dateDeNaissance + " " +
					age(dateDeNaissance.Year) + " "  + 
					salaire + " " +
					nbEmployes;
		}		
	}
}
