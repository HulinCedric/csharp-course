using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD5_EXO1
{
    class Prog
    {
        static void Main()
        {
            // Initialisation Etat
            Avion a = new Avion();

            //requêtes
           /* a.SortirDuGarage();
            Console.WriteLine(a.State);

            a.Decoller();
            Console.WriteLine(a.State);

            a.Atterrir();
            Console.WriteLine(a.State);

            a.EntrerAuGarage();
            Console.WriteLine(a.State);*/

            try
            {
                a.Atterrir();
                Console.WriteLine(a.State);
            }
            catch ( EtatException e)
            {

                Console.WriteLine(e);
            }


        }
    }






    //Exception
    public class EtatException : Exception
    {
        private State state;
        
        public EtatException(State s):base()
        {
            this.state = s;
        }

        public override string ToString()
        {

            return "\n erreur changement d'état impossible l'avion reste " + state.ToString();
        }

    }
        // State 
       public abstract class State
        {
            public abstract void GererSortirDuGarage(Avion context);
            public abstract void GererEntrerGarage(Avion context);
            public abstract void GererDecoller(Avion context);
            public abstract void GererAtterrir(Avion context);
        }

        // ConcreteStateA 
        public class DansLeGarage : State
        {
            public override void GererSortirDuGarage(Avion context)
            {

                context.State = new SurLaPiste();
            }

            public override void GererEntrerGarage(Avion context)
            {

                throw new EtatException(context.State );
            }
            public override void GererDecoller(Avion context)
            {

                throw new EtatException(context.State);
            }
            public override void GererAtterrir(Avion context)
            {

                throw new EtatException(context.State);
            }

            public override string ToString()
            {
                return " Dans le garage ";
            }

        }

        //ConcreteStateB 
       public class SurLaPiste : State
        {
            public override void GererSortirDuGarage(Avion context)
            {

                throw new EtatException(context.State);
            }

            public override void GererEntrerGarage(Avion context)
            {

                context.State = new DansLeGarage();
            }
            public override void GererDecoller(Avion context)
            {

                context.State = new EnLAir();
            }
            public override void GererAtterrir(Avion context)
            {

                throw new EtatException(context.State);
            }

            public override string ToString()
            {
                return " Sur la piste";
            }



        }

        public class EnLAir : State
        {
            public override void GererSortirDuGarage(Avion context)
            {

                throw new EtatException(context.State);
            }

            public override void GererEntrerGarage(Avion context)
            {

                throw new EtatException(context.State);
            }
            public override void GererDecoller(Avion context)
            {

                throw new EtatException(context.State);
            }
            public override void GererAtterrir(Avion context)
            {

                context.State = new SurLaPiste();
            }

            public override string ToString()
            {
                return " En l'air";
            }
        }

        //Context 
        public class Avion
        {
            private State state;


            public Avion()
            {
                this.State = new DansLeGarage();
            }


            public State State
            {
                get { return state; }
                set
                {
                    state = value;
                }
            }

            public void SortirDuGarage()
            {
                state.GererSortirDuGarage(this);
            }

            public void Decoller()
            {
                state.GererDecoller(this);
            }

            public void Atterrir()
            {
                state.GererAtterrir(this);
            }

            public void EntrerAuGarage()
            {
                state.GererEntrerGarage(this);
            }

            public override string ToString()
            {
                return state.ToString();
            }

        }
    }
