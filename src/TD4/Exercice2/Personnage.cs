using System;

namespace Exercice2
{
	public abstract class Personnage
	{
		private string nom;
		private Arme arme;

		public Personnage (string nom, Arme arme)
		{
			this.nom = nom;
			this.arme = arme;
		}

		public string Nom {
			get { return nom; }
			set { nom = value; }
		}

		public Arme Arme {
			get { return arme; }
			set { 
				arme = value; 
				Console.WriteLine(nom + " change d'arme : " + arme.Afficher());
			}
		}
		
		public abstract void Animer();

		public void seBattre ()
		{
			Console.WriteLine (nom + " combat avec " + arme.Afficher ());
		}
	}

	public class Humain : Personnage
	{
		private string oeil;

		public Humain (string nom, string oeil) : base(nom, new CombatEpee ())
		{
			this.oeil = oeil;
		}

		public string Oeil {
			get { return oeil; }
			set { oeil = value; }
		}

		public override void Animer ()
		{
			Console.WriteLine(Nom + "\tRace : Humain\tArme : " + Arme.Afficher () + "\tOeil : " + oeil);
		}
	}

	public class Troll : Personnage
	{
		private string biere;

		public Troll (string nom, string biere) : base(nom, new CombatDague ())
		{
			this.biere = biere;
		}
		
		public string Biere {
			get { return biere; }
			set { biere = value; }
		}

		public override void Animer ()
		{
			Console.WriteLine(Nom + "\tRace : Troll\tArme : " + Arme.Afficher () + "\tBiere : " + biere);
		}
	}

	public class Orc : Personnage
	{
		private string tailleOreilles;

		public Orc (string nom, string tailleOreilles) : base(nom, new CombatEpee ())
		{
			this.tailleOreilles = tailleOreilles;
		}
		
		public string TailleOreilles
		{
			get { return tailleOreilles; }
			set { tailleOreilles = value; }
		}

		public override void Animer ()
		{
			Console.WriteLine(Nom + "\tRace : Orc\tArme : " + Arme.Afficher () + "\tTaille des oreilles : " + tailleOreilles);
		}
	}

	public class Tauren : Personnage
	{
		private string tailleCorne;

		public Tauren (string nom, string tailleCorne) : base(nom, new CombatBouclier ())
		{
			this.tailleCorne = tailleCorne;
		}

		public string TailleCorne
		{
			get { return tailleCorne; }
			set { tailleCorne = value; }
		}
		
		public override void Animer ()
		{
			Console.WriteLine(Nom + "\tRace : Tauren\tArme : " + Arme.Afficher () + "\tTaille Corne : " + tailleCorne);
		}
	}
}