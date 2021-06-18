using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD4_EXO2_Stategy
{
    class Prog
    {
     static void Main()
        {
            Personnage p1;
            Personnage p2;
            Personnage p3;
            Personnage p4;
            

            // Contexte de stratégies différentes
            p1 = new Orc("Azag",5);
            p1.Combat();
            Console.WriteLine(p1);
            Console.WriteLine();


            p2 = new Tauren("Diablon",15);
            p2.Combat();
            Console.WriteLine(p2);
            Console.WriteLine();

            p3 = new Troll("Arkor","Heinken");
            p3.Combat();
            Console.WriteLine(p3);
            Console.WriteLine();

            p4 = new Humain("Kir","Bleu");
            p4.Combat();
            Console.WriteLine(p4);
            Console.WriteLine();

            p2.Stategy = new AvecEpéé();
            p2.Combat();
            Console.WriteLine(p2);
            Console.WriteLine();
            

           
        }
    }
    
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
    /* // ConcreteStrategyC 
    class AvecBaton : ComportementSeBattre
    {
        public override void SeBattre()
        {
            Console.WriteLine("Appel comportement se battre avec BATON ");
              
        }

        public override string ToString() { return "Baton"; }
    }*/

    // Context 
    abstract class Personnage
    {
       protected ComportementSeBattre strategy;
       string nom;
      
        // Constructeur prévu dans le pattern Stategy, ici comportement par défaut à la création
       public Personnage(string nom)
       {
           this.nom = nom;
       }
            


        /* public Personnage(string nom, ComportementSeBattre strategy)
        {
            this.strategy = strategy;
            this.nom=nom;
            
        }*/


        // les personnages peuvent par contre changer d'arme

       public ComportementSeBattre Stategy
       {
           get { return strategy; }
           set { strategy = value; }
       }
        
       

        public  void Combat(){strategy.SeBattre();}

        public override string ToString()
        {
            return nom + '\t' + strategy.ToString();
        }

        
    }

    class Humain : Personnage
    {
        string couleur;
        public Humain(string nom, string couleur) : base(nom) { strategy = new AvecEpéé(); this.couleur = couleur; }
        
    }

    

    class Orc : Personnage
    {
        int taille_Or;
        public Orc(string nom, int taille_Or) : base(nom) { strategy = new AvecEpéé(); this.taille_Or = taille_Or; }
        
    }

    class Tauren : Personnage
    {
        int taille_Cor;
        public Tauren(string nom, int taille_Cor) : base(nom) { strategy = new AvecBouclier(); this.taille_Cor = taille_Cor; }
        
    }


    class Troll : Personnage
    {
        string nom_Biere;
        public Troll(string nom, string nom_Biere) : base(nom) { strategy = new AvecDague(); this.nom_Biere = nom_Biere; }
        
    }


}


