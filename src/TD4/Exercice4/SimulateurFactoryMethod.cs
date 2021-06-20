using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;




namespace TD4_EXO3_AbstractFactory
{ 


// FICHIERS PERSONNAGE.CS POUR LES PRODUCTS!!!!!!


/*abstract class Product {}

class ConcreteProductA : Product 
{
}



class ConcreteProductB : Product
{
}*/



//CLASSES POUR LE CREATOR

abstract class Simulateur 

{
    Personnage monPersonnage;
    protected abstract Personnage GetPersonnage();
    public Simulateur() { monPersonnage = GetPersonnage(); }
    public void Simuler(){monPersonnage.Animer();}
    public override string ToString(){return monPersonnage.ToString();}

} 



class SimulateurHumain : Simulateur 

{ 

   protected override Personnage GetPersonnage() 

    { 

        return new Humain(new FabriqueDeLuxe()); 
    }  

} 




class SimulateurTroll : Simulateur

{ 

        protected  override Personnage GetPersonnage()  

        {  

            return new Troll (new FabriqueDeBase()); 
        }  

}

class SimulateurOrc : Simulateur
{

    protected override Personnage GetPersonnage()
    {

        return new Orc(new FabriqueDeBase());
    }

}  

}  
 

