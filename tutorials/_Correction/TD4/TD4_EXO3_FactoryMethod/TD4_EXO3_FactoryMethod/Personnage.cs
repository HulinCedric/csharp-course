using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD4_EXO3_FactoryMethod
{
    
    
   
    // PRODUCT

    abstract class Personnage
    {
      
       string nom;

       public Personnage() { }
       
       public Personnage(string nom)
       {
           this.nom = nom;
       }

       public abstract void Animer();

       public override string ToString()
        {
            return nom + '\t' ;
        }

        
    }

    class Humain : Personnage
    {
        string couleur;
        public Humain() : base() { }
        public Humain(string nom, string couleur) : base(nom) { this.couleur = couleur; }
        public override void Animer() { Console.WriteLine("Je m'anime comme un humain\n"); }
        
    }

    

    class Orc : Personnage
    {
        int taille_Or;
        public Orc() : base() { }
        public Orc(string nom, int taille_Or) : base(nom) {this.taille_Or = taille_Or; }
        public override void Animer() {Console.WriteLine("Je m'anime comme un orc\n");}
        
    }

   

    class Troll : Personnage
    {
        string nom_Biere;
        public Troll():base() { }
        public Troll(string nom, string nom_Biere) : base(nom) {this.nom_Biere = nom_Biere; }
        public override void Animer() {Console.WriteLine("Je m'anime comme un troll\n");}
        
    }


}


