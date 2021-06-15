using System;

namespace Exercice3
{
	public abstract class Simulateur
	{
		private Personnage personnage;
		
		public void Simuler ()
		{
			personnage.Animer();
		}
		
		protected abstract Personnage GetPersonnage(string nom, string caracteristique);
		
		public Simulateur (string nom, string caracteristique)
		{
			personnage = GetPersonnage (nom, caracteristique);
		}
	}

	public class SimulateurTroll : Simulateur
	{
		public SimulateurTroll(string nom, string biere) : base(nom, biere) {}
		
		protected override Personnage GetPersonnage (string nom, string biere)
		{
			return new Troll(nom, biere);
		}
	}

	public class SimulateurHumain : Simulateur
	{
		public SimulateurHumain(string nom, string oeil) : base(nom, oeil) {}
		
		protected override Personnage GetPersonnage (string nom, string oeil)
		{
			return new Humain (nom, oeil);
		}
	}
	
	public class SimulateurTauren : Simulateur
	{
		public SimulateurTauren(string nom, string tailleOreilles) : base(nom, tailleOreilles) {}
		
		protected override Personnage GetPersonnage (string nom, string tailleOreilles)
		{
			return new Tauren (nom, tailleOreilles);
		}
	}
	
	public class SimulateurOrc : Simulateur
	{
		public SimulateurOrc(string nom, string tailleCorne) : base(nom, tailleCorne) {}
		
		protected override Personnage GetPersonnage (string nom, string tailleCorne)
		{
			return new Orc (nom, tailleCorne);
		}
	}
}