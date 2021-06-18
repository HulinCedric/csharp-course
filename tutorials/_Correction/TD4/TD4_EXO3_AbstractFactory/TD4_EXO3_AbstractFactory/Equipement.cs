using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD4_EXO3_AbstractFactory
{
     // AbstractProductA 
    abstract class Sac //AbstractProductA
    {
         public override string  ToString()
        {
 	         return GetType().Name;
        }
    }

    // "AbstractProductB" 
   public abstract class Arme //AbstractProductB
    {
         public override string  ToString()
        {
 	         return GetType().Name;
        }
        //public abstract void Interact(AbstractProductA a);
    }

     abstract class Costume //AbstractProductC
    {
        //public abstract void Interact(AbstractProductA a);
         public override string  ToString()
        {
 	         return GetType().Name;
        }
    }

    // ProductA1 
    class Besace : Sac
    {

    }
    
    
    // ProductA2 
    class SacADos : Sac
    {
    }


    // ProductB1 
    class Baton : Arme
    {
        /*public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " est créé en même temps que " + a.GetType().Name);
        }*/
    }

    

    // ProductB2 
    class Epée : Arme
    {
       /* public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " est créé en même temps que " + a.GetType().Name);
        }*/
    }

    // ProductB3 
    class Dague : Arme
    {
       /* public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " est créé en même temps que " + a.GetType().Name);
        }*/
    }



     // ProductC1 
    class Robe : Costume
    {
        /*public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " est créé en même temps que " + a.GetType().Name);
        }*/
    }

    

    // ProductC2 
    class Uniforme : Costume
    {
       /* public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " est créé en même temps que " + a.GetType().Name);
        }*/
    }

    

    

}
