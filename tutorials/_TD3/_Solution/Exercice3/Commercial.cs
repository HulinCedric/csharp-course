using System;

namespace CollaborateurDLL
{
	public class Commercial : Collaborateur
	{
		private static double pourcentChiffreAffaire;
		private int salaireBase;
		private double chiffreAffaire;
		
		public Commercial () : base() {}
		
		public Commercial (string nom, string dateDeNaissance, int salaireBase, double chiffreAffaire) : base(nom, dateDeNaissance)
		{
			this.salaireBase= salaireBase;
			this.chiffreAffaire= chiffreAffaire;
		}
		
		static Commercial ()
		{
			pourcentChiffreAffaire= 2.0;
		}
		
		public override double Salaire()
		{
			return salaireBase + chiffreAffaire*(pourcentChiffreAffaire/100);
		}
		
		public override string ToString()
		{
			return base.ToString() + "\tSalaire : " + Salaire() + "\tCommercial";
		}	
	}
}