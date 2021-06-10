using System;

namespace Exercice2
{
	class Exercice2
	{
		public static void Main (string[] args)
		{
			Employe jean= new Employe();
			
			Console.WriteLine(jean);
			
			Employe bea= new Employe("Beatrice", "Defont", new DateTime(1987, 08, 22), 1200.0);
			
			Console.WriteLine(bea);
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