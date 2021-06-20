using System;

namespace Exercice2
{
	

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