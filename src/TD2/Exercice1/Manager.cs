using System;

namespace Exercice1
{
	public class Manager : Collaborateur
	{
		private int salaireBase;
		private double prime;
		
		public Manager () : base() {}
		
		public Manager (string nom, string dateDeNaissance, int salaireBase, double prime) : base(nom, dateDeNaissance)
		{
			this.salaireBase= salaireBase;
			this.prime= prime;
		}
		
		public override double Salaire()
		{
			return salaireBase + prime;
		}
		
		public override string ToString()
		{
			return 	base.ToString() +  "\tSalaire : " + Salaire() + "\tManager";
		}	
	}
}