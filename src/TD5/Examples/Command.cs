using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternCommand
{
    class Prog
    {
        static void Main()
        {
            // Creation receiver, command, et invoker 
            Receiver receiver = new Receiver();
            Command command = new ConcreteCommand(receiver);
            Invoker invoker = new Invoker();

            // Set et execute command 
            invoker.SetCommand(command);
            invoker.DoCommands();

            
        }
    }

    // Command plusieurs commandes possibles
    abstract class Command
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
    class ConcreteCommand : Command
    {
        // Constructor , on peut ajouter des paramètres
        public ConcreteCommand(Receiver receiver) :
            base(receiver)
        {
        }

        public override void Do()
        {
            receiver.Action();
        }

        public override void UnDo()
        {
           // Action qui annule l'action du Do
        }

    }

    //Receiver 
    class Receiver
    {
        //attributs eventuels
        // Action pas toujours nécessaires pour les operateurs de bases
        public void Action()
        {
            Console.WriteLine("Appel Action");
        }
    }

    // Invoker 
    class Invoker
    {
        // liste de commandes (ici une seule commande traitée)
        private Command command;

        public void SetCommand(Command command)
        {
            //Add en cas de liste
            this.command = command;
        }

        public void DoCommands()
        {
            //boucle sur les commandes si nécessaire
            command.Do();
        }

        public void UnDoCommands()
        {
            //boucle sur les commandes si nécessaire
            command.UnDo();
        }
    }
}
