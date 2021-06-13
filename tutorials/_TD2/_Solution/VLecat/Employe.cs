using System;

namespace Exercice1
{
	public class Employe : Collaborateur
	{
		private static double pourcentHeureSupp;
		private int nbHeureSemaine;
		private double tarifHoraire;
		
		public Employe () : base() {}
		
		public Employe (string nom, string dateDeNaissance, int nbHeureSemaine, double tarifHoraire) : base (nom, dateDeNaissance)
		{	
			this.nbHeureSemaine= nbHeureSemaine;
			this.tarifHoraire= tarifHoraire;
		}
		
		public override double Salaire()
		{
			double resultat;
			
			if (nbHeureSemaine > 35)
			{
				int nbHeureSup= nbHeureSemaine - 35;
								
				resultat= 35*tarifHoraire*4;
				tarifHoraire+= tarifHoraire*(pourcentHeureSupp/100);
				resultat+= nbHeureSup*tarifHoraire;
			}
			else resultat= nbHeureSemaine*tarifHoraire*4;
			
			return resultat;
		}
		
	
	 	static Employe()
		{
			pourcentHeureSupp= 50.0;
		}
		
		public override string ToString()
		{
			return base.ToString() + "\tSalaire : " + Salaire() + "\tEmploye";
		}		
	}
}