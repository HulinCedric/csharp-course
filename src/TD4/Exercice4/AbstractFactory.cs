using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD4_EXO3_AbstractFactory
{
   

   
    // AbstractFactory 
    abstract class FabriqueEquipement
    {
        public abstract Arme CreateArme();
        public abstract Costume CreateCostume();
        public abstract Sac CreateSac();
    }

    // ConcreteFactory1 
    class FabriqueDeBase : FabriqueEquipement
    {
        public override Arme CreateArme()
        {
            return new Epée();
        }

        public override Sac CreateSac()
        {
            return new Besace();
        }

        public override Costume CreateCostume()
        {
            return new Robe();
        }

    }

    // ConcreteFactory2 
    class FabriqueDeLuxe : FabriqueEquipement
    {
        public override Arme CreateArme()
        {
            return new Baton();
        }

        public override Sac CreateSac()
        {
            return new SacADos();
        }

        public override Costume CreateCostume()
        {
            return new Uniforme();
        }
    }



    // CORRESPOND DANS CETTE EXEMPLE AU FICHIER Equipement.cs

   /* // "AbstractProductA" 
    abstract class AbstractProductA
    {
    }

    // "AbstractProductB" 
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }

    // "ProductA1" 
    class ProductA1 : AbstractProductA
    {
    }

    // "ProductB1" 
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " est créé en même temps que " + a.GetType().Name);
        }
    }

    // "ProductA2" 
    class ProductA2 : AbstractProductA
    {
    }

    // "ProductB2" 
    class ProductB2 : AbstractProductB
    {
        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " est créé en même temps que " + a.GetType().Name);
        }
    }*/



    //CORRESPOND ICI AU PERSONNAGE
    // Client -  

    /*class Client
    {
        private AbstractProductA AbstractProductA;
        private AbstractProductB AbstractProductB;

        // Constructor 
        public Client(AbstractFactory factory)
        {
            AbstractProductB = factory.CreateProductB();
            AbstractProductA = factory.CreateProductA();
        }

        public void Run()
        {
            AbstractProductB.Interact(AbstractProductA);
        }
    }*/


}
