using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD4_EXO3_AbstractFactory
{
    
    
   
    // PRODUCT

    abstract class Personnage
    {
      
       //CORRESPOND ICI AU CLIENT
       
       Sac monSac;          //AbstractProductA
       Arme monArme;    //AbstractProductB
       Costume monCostume;  // AbstractProductC;


       public Personnage(FabriqueEquipement factory)
        {
            monSac = factory.CreateSac();
            monArme = factory.CreateArme();
            monCostume = factory.CreateCostume();
        }

       public Personnage() { }
       
       public abstract void Animer();

       public override string ToString()
        {
            return monCostume.ToString() + '\t'+monSac.ToString()+'\t'+ monArme.ToString()+'\n' ;
        }

        
    }

    class Humain : Personnage
    {
      
        public Humain() : base() { }
        public Humain(FabriqueDeLuxe f) : base(f) { }
       
        public override void Animer() { Console.WriteLine("Je m'anime comme un humain\n"); }
        
    }

    

    class Orc : Personnage
    {
       
        public Orc() : base() { }
        public Orc(FabriqueDeBase f) : base(f) { }
       
        public override void Animer() {Console.WriteLine("Je m'anime comme un orc\n");}
        
    }

   

    class Troll : Personnage
    {
       
        public Troll():base() { }
        public Troll(FabriqueDeBase f) : base(f) { }
        
        public override void Animer() {Console.WriteLine("Je m'anime comme un troll\n");}
        
    }


}


