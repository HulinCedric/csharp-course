using System;

namespace Exercice1
{
	//Context 
    public class Avion
    {
        private State etat;
        
        public Avion(State etat)
        {
            this.etat = etat;
        }
        
        public State Etat
        {
            get { return etat; }
            set { etat = value; }
        }

        //Gestion des requêtes, plusieurs eventuellement
        public void SortirDuGarage()
        {
			try 
			{
				etat.SortirDuGarage(this);
			}
			catch (ExceptionTransitionInvalide e)
			{
				Console.WriteLine(e.Message);	
			}
        }
		
		public void EntrerAuGarage()
        {
			try 
			{
				etat.EntrerAuGarage(this);
			}
			catch (ExceptionTransitionInvalide e)
			{
				Console.WriteLine(e.Message);	
			}
        }
		
		public void Decoller()
        {
			try 
			{
				etat.Decoller(this);
			}
			catch (ExceptionTransitionInvalide e)
			{
				Console.WriteLine(e.Message);	
			}
        }
		
		public void Atterrir()
        {
			try 
			{
			 	etat.Atterrir(this);
			}
			catch (ExceptionTransitionInvalide e)
			{
				Console.WriteLine(e.Message);	
			}
        }
    }
}
