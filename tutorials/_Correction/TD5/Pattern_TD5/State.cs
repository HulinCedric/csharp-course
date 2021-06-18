using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PaaternFactoryMethod
{
    class Prog
    {
        static void Main()
        {
            // Création d'un contexte , l'état peut-être par défaut à initialiser éventuellement dans le constructeur
            Context c = new Context(new ConcreteStateA());

            // Exécution des requetes
            c.Request();
            c.Request();
            c.Request();
            c.Request();

            
        }
    }


    // State // peut-être une interface
    abstract class State
    {
        //Getsion des transitions, plusieurs transtions possibles
        public abstract void Gerer(Context context);
    }

    // ConcreteStateA
    class ConcreteStateA : State
    {
        public override void Gerer(Context context)
        {
            context.State = new ConcreteStateB();
        }
    }

    //ConcreteStateB 
    class ConcreteStateB : State
    {
        public override void Gerer(Context context)
        {
            context.State = new ConcreteStateA();
        }
    }

    //Context 
    class Context
    {
        private State state;

        
        public Context(State state)
        {
            this.State = state;
        }

        
        public State State
        {
            get { return state; }
            set
            {
                state = value;
            }
        }

        //Gestion des requêtes, plusieurs eventuellement
        public void Request()
        {
            state.Gerer(this);
        }
    }
}
