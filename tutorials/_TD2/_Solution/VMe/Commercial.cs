using System;

namespace Exercice1
{
	public class Commercial : Collaborateur
	{
		private static double pourcentChiffreAffaire;
		
		public Commercial () : base() {}
		
		public Commercial (string nom, string dateDeNaissance, double SalaireBase, double ChiffreAffaire) : base(nom, dateDeNaissance)
		{
			this.salaire= SalaireBase + ChiffreAffaire*(pourcentChiffreAffaire/100);
		}
		
		static Commercial ()
		{
			pourcentChiffreAffaire= 2.0;
		}
		
		public override string ToString()
		{
			return base.ToString() + "\tCommercial";
		}	
	}
}