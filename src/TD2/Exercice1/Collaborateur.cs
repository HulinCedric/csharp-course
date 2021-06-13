using System;

namespace Exercice1
{
	public class ExceptionDateInvalide : Exception
    {
        public ExceptionDateInvalide() : base("La date est invalide") {}
    }
	
	public abstract class Collaborateur : IComparable
	{
		private int matricule;
		private string nom;
		private string dateDeNaissance;
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
			get 
			{ 
				return string.Format("{0:00}/{1:00}/{2}", 
					                  Jour(dateDeNaissance), 
					                  Mois(dateDeNaissance), 
					                  Annee(dateDeNaissance)); 
			}
			set { dateDeNaissance= value; }
		}
		
		public int NbEmployes
		{
			get { return nbEmployes; }
		}
		
		public Collaborateur PlusHautSal(Collaborateur i)
		{
			if (i.Salaire() > Salaire())
				return i;
			else
				return this;
		}
		
		public static int Jour (string date)
		{
			if (!ValiditeDate(date)) throw new ExceptionDateInvalide();
				
			return Int32.Parse(date.Substring(0,2));
		}
		
		public static int Mois (string date)
		{
			if (!ValiditeDate(date)) throw new ExceptionDateInvalide();
				
			return Int32.Parse(date.Substring(2,2));
		}
		
		public static int Annee (string date)
		{
			if (!ValiditeDate(date)) throw new ExceptionDateInvalide();
				
			return Int32.Parse(date.Substring(4,4));
		}
		
		public int Age ()
		{
			int age = DateTime.Now.Year - Annee(dateDeNaissance);
			
			if (DateTime.Now.Month < Mois(dateDeNaissance) || (DateTime.Now.Month == Mois(dateDeNaissance) && DateTime.Now.Day < Jour(dateDeNaissance))) 
    				age--;
			
			return age;
		}
		
		public abstract double Salaire ();
		
		public Collaborateur ()
		{
			matricule= ++nbEmployes;
			nom= "Default";
			dateDeNaissance= "null";
		}
		
		protected Collaborateur (string nom, string dateDeNaissance)
		{
			matricule= ++nbEmployes;
			this.nom= nom;
			if (!ValiditeDate(dateDeNaissance)) throw new ExceptionDateInvalide();
			this.dateDeNaissance= dateDeNaissance;
		}
		
	 	static Collaborateur()
		{
			nbEmployes=0;
		}
		
		public int CompareTo(Object o)
        {
			Collaborateur p = (Collaborateur) o;

            return Age().CompareTo(p.Age());
		}
		
		public override string ToString()
		{
			return 	"Matricule : " + Matricule +
					"\tNom : " + Nom + 
					"\tDateNaissance : "	 + DateDeNaissance +
					"\tAge : " + Age();
		}
		
		// --- Controle de validite de la date de naissance d'un titulaire
		//
		public static bool ValiditeDate(string date) 
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