using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice2
{
	public class ExceptionTransitionInvalide : Exception
    {
        public ExceptionTransitionInvalide(Calculette calculette) : base("erreur changement d'etat impossible la calculette reste " + calculette.Etat.GetType().Name) { }
    }

    //Context 
    public class Calculette
    {
        private float valeur;
        private float valeurOperation;
        private float resultat;
        private State etat;

        public Calculette(State etat)
        {
            this.etat = etat;
            this.valeur = 0.0f;
            this.valeurOperation = 0.0f;
            this.resultat = 0.0f;
        }

        public State Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        public float Valeur
        {
            get { return valeur; }
            set { valeur = value; }
        }

        public float ValeurOperation
        {
            get { return valeurOperation; }
            set { valeurOperation = value; }
        }

        public float Resultat
        {
            get { return resultat; }
            set { resultat = value; }
        }

        //Gestion des requêtes, plusieurs eventuellement
        public void Ajout(float chiffre)
        {
            try
            {
                etat.Ajout(this, chiffre);
            }
            catch (ExceptionTransitionInvalide e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //Gestion des requêtes, plusieurs eventuellement
        public void Operation()
        {
            try
            {
                etat.Operation(this);
            }
            catch (ExceptionTransitionInvalide e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
	
    // State // peut-être une interface
    public abstract class State
    {
        //Getsion des transitions, plusieurs transtions possibles
        public abstract void Ajout(Calculette context, float chiffre);
        public abstract void Operation(Calculette context);
    }

    // ConcreteStateA
    public class ModeTape : State
    {
        public override void Ajout(Calculette context, float chiffre)
        {
            context.Resultat = 0.0f;
            context.Valeur *= 10;
            context.Valeur += chiffre;
            Console.WriteLine("Ajout : " + context.Valeur);
            Console.WriteLine();
        }

        public override void Operation(Calculette context)
        {
            Console.WriteLine("Mode tape erreur : ");
        }
    }

    //ConcreteStateB 
    public class ModeAddition : State
    {
        public override void Ajout(Calculette context, float chiffre)
        {
            context.ValeurOperation *= 10;
            context.ValeurOperation += chiffre;
            Console.WriteLine("Addition : " + context.ValeurOperation);
        }

        public override void Operation(Calculette context)
        {
            if (context.Resultat != 0.0f)
                context.Valeur = context.Resultat;
            context.Resultat = context.Valeur + context.ValeurOperation;
            Console.WriteLine("Addition resultat : " + context.Resultat);
            Console.WriteLine();
            context.Valeur = 0.0f;
            context.ValeurOperation = 0.0f;
            context.Etat = new ModeTape();
        }
    }

    //ConcreteStateC
    public class ModeSoustraction : State
    {
        public override void Ajout(Calculette context, float chiffre)
        {
            context.ValeurOperation *= 10;
            context.ValeurOperation += chiffre;
            Console.WriteLine("Soustraction : " + context.ValeurOperation);
        }

        public override void Operation(Calculette context)
        {
            if (context.Resultat != 0.0f)
                context.Valeur = context.Resultat;
            context.Resultat = context.Valeur - context.ValeurOperation;
            Console.WriteLine("Soustraction resultat : " + context.Resultat);
            Console.WriteLine();
            context.Valeur = 0.0f;
            context.ValeurOperation = 0.0f;
            context.Etat = new ModeTape();
        }
    }

    //ConcreteStateD
    public class ModeMultiplication : State
    {
        public override void Ajout(Calculette context, float chiffre)
        {
            context.ValeurOperation *= 10;
            context.ValeurOperation += chiffre;
            Console.WriteLine("Multiplier : " + context.Valeur);
        }

        public override void Operation(Calculette context)
        {
            if (context.Resultat != 0.0f)
                context.Valeur = context.Resultat;
            context.Resultat = context.Valeur * context.ValeurOperation;
            Console.WriteLine("Multiplier resultat : " + context.Resultat);
            Console.WriteLine();
            context.Valeur = 0.0f;
            context.ValeurOperation = 0.0f;
            context.Etat = new ModeTape();
        }
    }

    //ConcreteStateE
    public class ModeDivision : State
    {
        public override void Ajout(Calculette context, float chiffre)
        {
            context.ValeurOperation *= 10;
            context.ValeurOperation += chiffre;
            Console.WriteLine("Diviser : " + context.Valeur);
        }

        public override void Operation(Calculette context)
        {
            if (context.Resultat != 0.0f)
                context.Valeur = context.Resultat;
            context.Resultat = context.Valeur / context.ValeurOperation;
            Console.WriteLine("Diviser resultat : " + context.Resultat);
            Console.WriteLine();
            context.Valeur = 0.0f;
            context.ValeurOperation = 0.0f;
            context.Etat = new ModeTape();
        }
    }
}
