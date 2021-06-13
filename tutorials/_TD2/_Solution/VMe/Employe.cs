using System;

namespace Exercice1
{
	public class Employe : Collaborateur
	{
		private static double pourcentHeureSupp;

		public Employe () : base() {}
		
		public Employe (string nom, string dateDeNaissance, int nbHeureSemaine, double tarifHoraire) : base (nom, dateDeNaissance)
		{	
			if (nbHeureSemaine > 35)
			{
				int nbHeureSup= nbHeureSemaine - 35;
								
				this.salaire= 35*tarifHoraire*4;
				tarifHoraire+= tarifHoraire*(pourcentHeureSupp/100);
				this.salaire+= nbHeureSup*tarifHoraire;
			}
			else this.salaire= nbHeureSemaine*tarifHoraire*4;
		}
		
	 	static Employe()
		{
			pourcentHeureSupp= 50.0;
		}
		
		public override string ToString()
		{
			return base.ToString() + "\tEmploye";
		}		
	}
}
