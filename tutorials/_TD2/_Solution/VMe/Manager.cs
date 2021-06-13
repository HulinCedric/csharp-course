using System;

namespace Exercice1
{
	public class Manager : Collaborateur
	{
		public Manager () : base() {}
		
		public Manager (string nom, string dateDeNaissance, double SalaireBase, double Prime) : base(nom, dateDeNaissance)
		{
			this.salaire= SalaireBase + Prime;
		}
		
		public override string ToString()
		{
			return 	base.ToString() + "\tManager";
		}	
	}
}
