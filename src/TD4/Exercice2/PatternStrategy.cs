using System;

namespace Exercice2
{
	// Strategy
    abstract class ComportementSeBattre
    {
        public abstract void SeBattre();
    }

    // ConcreteStrategyA 
    class AvecDague : ComportementSeBattre
    {
        public override void SeBattre()
        {
            Console.WriteLine("Appel comportement se battre avec DAGUE ");
        }
        public override string ToString() { return "Dague"; }
    }

    // ConcreteStrategyB
    class AvecEpéé : ComportementSeBattre
    {
        public override void SeBattre()
        {
            Console.WriteLine("Appel comportement se battre avec EPEE ");
              
        }

        public override string ToString() { return "Epée"; }
    }

    // ConcreteStrategyC 
    class AvecBouclier : ComportementSeBattre
    {
        public override void SeBattre()
        {
            Console.WriteLine("Appel comportement se battre avec BOUCLIER ");
              
        }
        public override string ToString() { return "Bouclier"; }
    }


    // Pour cet exemple Pattern strategy mieux illustrer si 2 personnages ont la même strategy
    // ConcreteStrategyD
    class AvecBaton : ComportementSeBattre
    {
        public override void SeBattre()
        {
            Console.WriteLine("Appel comportement se battre avec BATON ");
              
        }

        public override string ToString() { return "Baton"; }
    }
}
