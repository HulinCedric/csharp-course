using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternFactoryMethod
{
    using System;

    class Prog
    {
        public static void Main()
        {
            // Abstract factory #1 
            AbstractFactory factory1 = new ConcreteFactory1();
            Client c1 = new Client(factory1);
           Console.WriteLine(c1);

            // Abstract factory #2 
            AbstractFactory factory2 = new ConcreteFactory2();
            Client c2 = new Client(factory2);
            Console.WriteLine(c2);

            
        }
    }

    // AbstractFactory 
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }

    // ConcreteFactory1 
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }
    }

    // ConcreteFactory2 
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ProductB2();
        }
    }

    // AbstractProductA 
    abstract class AbstractProductA
    {
        public override string ToString()
        {
            return GetType().Name;
        }
    }

    // AbstractProductB 
    abstract class AbstractProductB
    {
        public override string ToString()
        {
            return GetType().Name;
        }
        
    }

    // ProductA1 
    class ProductA1 : AbstractProductA
    {
    }

    // ProductB1 
    class ProductB1 : AbstractProductB
    {
        
    }

    // ProductA2
    class ProductA2 : AbstractProductA
    {
    }

    // ProductB2 
    class ProductB2 : AbstractProductB
    {
        
    }

    // Client  
    class Client
    {
        private AbstractProductA AbstractProductA;
        private AbstractProductB AbstractProductB;

        // Constructor 
        public Client(AbstractFactory factory)
        {
            AbstractProductB = factory.CreateProductB();
            AbstractProductA = factory.CreateProductA();
        }

        public override string  ToString()
        {
            return AbstractProductA.ToString() + '\t' + AbstractProductB.ToString() + '\n';
        }
    }


}
