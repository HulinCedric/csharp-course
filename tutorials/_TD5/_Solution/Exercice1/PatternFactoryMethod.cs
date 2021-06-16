using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice1
{
	public class ExceptionTransitionInvalide : Exception
    {
        public ExceptionTransitionInvalide(Avion avion) : base("erreur changement d'etat impossible l'avion reste "+ avion.Etat.GetType().Name) {}
    }
	
    // State // peut-être une interface
    public abstract class State
    {
        //Getsion des transitions, plusieurs transtions possibles
        public abstract void Atterrir(Avion context);
		public abstract void Decoller(Avion context);
		public abstract void EntrerAuGarage(Avion context);
		public abstract void SortirDuGarage(Avion context);
    }

    // ConcreteStateA
    public class SurLaPiste : State
    {
        public override void EntrerAuGarage(Avion context)
        {
            context.Etat = new DansLeGarage();
			Console.WriteLine("Dans le garage");
			Console.WriteLine();
        }
		
		public override void Decoller(Avion context)
        {
            context.Etat = new EnLAir();
			Console.WriteLine("En l'air");
			Console.WriteLine();
        }
		
		public override void Atterrir(Avion context)
		{
			throw new ExceptionTransitionInvalide(context);
		}
		public override void SortirDuGarage(Avion context)
		{
			throw new ExceptionTransitionInvalide(context);
		}
    }

    //ConcreteStateB 
    public class DansLeGarage : State
    {
        public override void SortirDuGarage(Avion context)
        {
            context.Etat = new SurLaPiste();
			Console.WriteLine("Sur la piste");
			Console.WriteLine();
        }
		
		public override void Atterrir(Avion context) 
		{
			throw new ExceptionTransitionInvalide(context);
		}
		public override void Decoller(Avion context)
		{
			throw new ExceptionTransitionInvalide(context);
		}
		public override void EntrerAuGarage(Avion context)
		{
			throw new ExceptionTransitionInvalide(context);
		}
    }
	
	//ConcreteStateC
    public class EnLAir : State
    {
        public override void Atterrir(Avion context)
        {
            context.Etat = new SurLaPiste();
			Console.WriteLine("Sur la piste");
			Console.WriteLine();
        }

		public override void Decoller(Avion context) 
		{ 
			throw new ExceptionTransitionInvalide(context);
		}
		public override void EntrerAuGarage(Avion context) 
		{
			throw new ExceptionTransitionInvalide(context);
		}
		public override void SortirDuGarage(Avion context) 
		{
			throw new ExceptionTransitionInvalide(context);
		}
    }
}
