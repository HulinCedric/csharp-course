using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaaternFactoryMethod
{
    using System;

    class Prog
    {
        static void Main()
        {
            Context context;

            // Contexte de stratégies différentes
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

           
        }
    }

    // Strategy 
    abstract class Strategy
    {
        public abstract void AlgorithmeInterface();
    }

    // ConcreteStrategyA 
    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmeInterface()
        {
            Console.WriteLine("Appel comportement ConcreteStrategyA ");
        }
    }

    // ConcreteStrategyB 
    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmeInterface()
        {
            Console.WriteLine("Appel comportement ConcreteStrategyB ");
              
        }
    }

    // ConcreteStrategyC 
    class ConcreteStrategyC : Strategy
    {
        public override void AlgorithmeInterface()
        {
            Console.WriteLine("Appel comportement ConcreteStrategyC ");
              
        }
    }

    // Context 
    class Context
    {
        Strategy strategy;

        
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmeInterface();
        }
    }
}
