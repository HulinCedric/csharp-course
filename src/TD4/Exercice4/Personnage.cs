// Pattern Abstract Factory Method
using System;

namespace Exercice3
{
	public abstract class Personnage
	{
		private string nom;
		
		public Personnage (string nom)
		{
			this.nom= nom;
		}
		
		public string Nom
		{
			get { return nom; }
			set { nom= value; }
		}
		
		public abstract void Animer();
	}
	
	public class Humain : Personnage
	{
		private 	string oeil;
		
		public Humain(string nom, string oeil) : base(nom)
		{
			this.oeil= oeil;	
		}
		
		public override void Animer()
		{
			Console.WriteLine("Humain : "+ Nom + "\tOeil : " + oeil);	
		}
	}
	
	public class Troll : Personnage
	{
		private 	string biere;
		
		public Troll(string nom, string biere) : base(nom)
		{
			this.biere= biere;	
		}
		
		public override void Animer()
		{
			Console.WriteLine("Troll : "+ Nom + "\tBiere : " + biere);	
		}
	}
	
	public class Orc : Personnage
	{
		private 	string tailleOreilles;
		
		public Orc(string nom, string tailleOreilles) : base(nom)
		{
			this.tailleOreilles= tailleOreilles;	
		}
		
		public override void Animer()
		{
			Console.WriteLine("Orc : "+ Nom + "\tTaille des oreilles : " + tailleOreilles);	
		}
	}
	
	public class Tauren : Personnage
	{
		private 	string tailleCorne;
		
		public Tauren(string nom, string tailleCorne) : base(nom)
		{
			this.tailleCorne= tailleCorne;
		}
		
		public override void Animer()
		{
			Console.WriteLine("Tauren : "+ Nom + "\tTaille Corne : " + tailleCorne);	
		}
	}

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
			return new Humain (nom, tailleOreilles);
		}
	}
	
	public class SimulateurOrc : Simulateur
	{
		public SimulateurOrc(string nom, string tailleCorne) : base(nom, tailleCorne) {}
		
		protected override Personnage GetPersonnage (string nom, string tailleCorne)
		{
			return new Humain (nom, tailleCorne);
		}
	}
}