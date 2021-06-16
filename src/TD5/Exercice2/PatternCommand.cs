using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Exercice2
{
    // Command plusieurs commandes possibles
    public abstract class Command
    {
        protected Receiver receiver;

        // Constructor 
        public Command(Receiver receiver)
        {
            this.receiver = receiver;
        }

        public abstract void Do();
        public abstract void UnDo();
    }

    // ConcreteCommand plusieurs commandes possibles
    public class MultiplierPar : Command
    {
        private int chiffre;

        // Constructor , on peut ajouter des paramètres
        public MultiplierPar(Receiver receiver, int chiffre) :
            base(receiver)
        {
            this.chiffre = chiffre;
        }

        public override void Do()
        {
            receiver.Nombre *= chiffre;
        }

        public override void UnDo()
        {
            receiver.Nombre /= chiffre;
        }
    }
	
	public class AdditionnerAvec : Command
    {
        private int chiffre;

        // Constructor , on peut ajouter des paramètres
        public AdditionnerAvec(Receiver receiver, int chiffre) :
            base(receiver)
        {
            this.chiffre = chiffre;
        }

        public override void Do()
        {
            receiver.Nombre += chiffre;
        }

        public override void UnDo()
        {
            receiver.Nombre -= chiffre;
        }
    }

    public class SoustraireAvec : Command
    {
        private int chiffre;

        // Constructor , on peut ajouter des paramètres
        public SoustraireAvec(Receiver receiver, int chiffre) :
            base(receiver)
        {
            this.chiffre = chiffre;
        }

        public override void Do()
        {
            receiver.Nombre -= chiffre;
        }

        public override void UnDo()
        {
            receiver.Nombre += chiffre;
        }
    }

    //Receiver 
    public class Receiver
    {
        private int nombre;
		
		public Receiver(int nombre)
		{
			this.nombre= nombre;
		}

        public int Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
		
        // attributs eventuels
        // Action pas toujours nécessaires pour les operateurs de bases
    }
	
	// Invoker 
    public class Invoker
    {
        // liste de commandes (ici une seule commande traitée)
        private ArrayList ListeCommandeEnCours ;
        private ArrayList ListeCommandeTotal;
        private int IndiceCommande;
        
		//Pour faire l'undo, cree deux liste une qui contient la liste des commande à executer 
        //et l'autre toute les commandes executer
        // Le do se fait sur les commande à executer
        //le undo se fait sur l'ensemble des commandes
        public Invoker()
        {
            ListeCommandeTotal = new ArrayList();
            ListeCommandeEnCours = new ArrayList();
            IndiceCommande = 0;
        }

        public void SetCommand(Command command)
        {
            ListeCommandeEnCours.Add(command);
        }

        public void DoCommands()
        {
			//boucle sur les commandes si nécessaire
			foreach (Command C in ListeCommandeEnCours)
            {
                IndiceCommande++;
                C.Do();
            }

            ListeCommandeTotal.AddRange(ListeCommandeEnCours);
            ListeCommandeEnCours.Clear();
        }

        public void UnDoCommands()
        {
			//boucle sur les commandes si nécessaire
            ((Command)ListeCommandeTotal[--IndiceCommande]).UnDo();
        }
		
        public void ReDo()
        {
			//boucle sur les commandes si nécessaire
            ((Command)ListeCommandeTotal[IndiceCommande++]).Do();
		}
    }
}