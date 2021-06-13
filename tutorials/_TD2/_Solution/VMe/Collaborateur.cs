using System;

namespace Exercice1
{
	public class ExceptionDateInvalide : Exception
    {
        public ExceptionDateInvalide() : base("La date est invalide") {}
    }
	
	public class Collaborateur : IComparable
	{
		private int matricule;
		private string nom;
		private string dateDeNaissance;
		protected double salaire;
		private static int nbEmployes;
		
		public int Matricule
		{
			get { return matricule; }
		}
		
		public string Nom
		{
			get { return nom; }
		}
		
		public string DateDeNaissance
		{
			get { return dateDeNaissance; }
			set { dateDeNaissance= value; }
		}
	
		public double Salaire 
		{
			get { return salaire; }
		}
		
		public int NbEmployes
		{
			get { return nbEmployes; }
		}
		
		public Collaborateur ()
		{
			matricule= ++nbEmployes;
			nom= "Default";
			dateDeNaissance= "null";
			salaire= 0.0;
		}
		
		protected Collaborateur (string nom, string dateDeNaissance)
		{
			matricule= ++nbEmployes;
			this.nom= nom;
			if (!validiteDate(dateDeNaissance)) throw new ExceptionDateInvalide();
			this.dateDeNaissance= dateDeNaissance;
			salaire= 0.0;
		}
		
	 	static Collaborateur()
		{
			nbEmployes=0;
		}
		
		public int CompareTo(Object o)
        {
			Collaborateur p = (Collaborateur) o;
			
			int annee= Int32.Parse(p.DateDeNaissance.Substring(4,4));
			int mois= Int32.Parse(p.DateDeNaissance.Substring(2,2));
			int jour= Int32.Parse(p.DateDeNaissance.Substring(0,2));
			
			DateTime comp= new DateTime(annee, mois, jour);
			
			annee= Int32.Parse(DateDeNaissance.Substring(4,4));
			mois= Int32.Parse(DateDeNaissance.Substring(2,2));
			jour= Int32.Parse(DateDeNaissance.Substring(0,2));
			
            int res = comp.CompareTo(new DateTime(annee, mois, jour));
			
            return res;
		}
		
		public override string ToString()
		{
			int annee= Int32.Parse(DateDeNaissance.Substring(4,4));
			int mois= Int32.Parse(DateDeNaissance.Substring(2,2));
			int jour= Int32.Parse(DateDeNaissance.Substring(0,2));
			
			DateTime BirthDate= new DateTime(annee, mois, jour);
			
			int age = DateTime.Now.Year - BirthDate.Year;
			
			if (DateTime.Now.Month < BirthDate.Month || (DateTime.Now.Month == BirthDate.Month && DateTime.Now.Day < BirthDate.Day)) 
    				age--;
			
			return 	"Matricule : " + matricule +
					"\tNom : " + nom + 
					"\tDateNaissance : " + dateDeNaissance +
					"\tAge : " +  age + 
					"\tSalaire : " + salaire;
		}
		
		// --- Controle de validite de la date de naissance d'un titulaire
		//
		public static bool validiteDate(string date) 
		{
			// Controler la taille de la date
			//
   			if (date.Length != 8) return false;

   			// Controler la validite de l'annee
   			//
			int annee= Int32.Parse(date.Substring(4));  
   			if (annee <= 1850) return false;

  	 		// Determiner si l'annee est bissextile
   			//
			int nbJoursFevrier= 28;
			if (annee%400 == 0) nbJoursFevrier= 29;
			else if (annee%4 == 0 && annee%100 != 0) nbJoursFevrier= 29;

			// Controler la validite du mois
			//
		   	int mois= Int32.Parse(date.Substring(2, 2));
   			if (mois <= 0 || mois > 12) return false;

  		 	// Controler la validite du jour
		   	//
		   	int jour= Int32.Parse(date.Substring(0, 2));
		   	if (jour <= 0 || jour > 31) return false;
		
		   	if (mois==2 && jour > nbJoursFevrier) return false;
		
		   	if (jour > 30) 
			{	
		   		switch (mois) 
				{
		         	case 4  : return false;
		         	case 6  : return false;
		         	case 9  : return false;
		         	case 11 : return false;
		      	}
  	 		}
	   		
			return true;
		}
	}
}