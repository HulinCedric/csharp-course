using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System; 


namespace PatternFactory
{ 
    class Prog

    { 
        public static void Main() 

        { 

             // Un tableau de créator

            Creator [] creators = new Creator [2]; 


            creators[0] = new ConcreteCreatorA ();  

            creators[1] = new ConcreteCreatorB (); 


        

            foreach ( Creator creator in creators)  

            {

                creator.Methode();
        
                Console.WriteLine( "Created {0}" ,creator.GetType().Name); 

            } 
        }
    }





abstract class Product
{
   
    public abstract void  MethodePourProduct();
}

class ConcreteProductA : Product 
{
    public override void MethodePourProduct() { Console.WriteLine("Application  méthode pour A\n"); }

}



class ConcreteProductB : Product
{
    public override void MethodePourProduct() { Console.WriteLine("Application  méthode pour B\n"); }
}



abstract class Creator 

{
    Product monProduct;
    public void Methode() { monProduct.MethodePourProduct(); }
    protected abstract Product FactoryMethod();
    public Creator()
    {
        monProduct = FactoryMethod();
    }

} 



class ConcreteCreatorA : Creator 

{ 

   protected override Product FactoryMethod() 

    { 

        return new ConcreteProductA (); 
    }  

} 




class ConcreteCreatorB : Creator 

{ 

       protected override Product FactoryMethod()  

        {  

            return new ConcreteProductB (); 
        }  

}  

}  
 

