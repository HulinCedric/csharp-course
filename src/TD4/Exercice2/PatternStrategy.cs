using System;

namespace Exercice2
{
	// Strategy
	public abstract class Arme
	{
		public abstract string Afficher ();
	}

	// ConcreteStrategyA 
	public class CombatEpee : Arme
	{
		public override string Afficher ()
		{
			return "Epee";
		}
	}

	// ConcreteStrategyB 
	public class CombatDague : Arme
	{
		public override string Afficher ()
		{
			return "Dague";
		}
	}

	// ConcreteStrategyC 
	public class CombatBouclier : Arme
	{
		public override string Afficher ()
		{
			return "Bouclier";
		}
	}
}
