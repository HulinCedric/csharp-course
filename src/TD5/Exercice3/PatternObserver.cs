using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice3
{
    // Subject 
  	public abstract class Subject
    {
        private List<Observer> observers =new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (Observer o in observers)
                o.Update();
        }
    }

    // ConcreteSubject 
    public class StationMeteo : Subject
    {
        //Plusieurs attributs
        private float temperature=18.0f;
		private float humidite=56.0f;
		private float pressionAtmospherique=180.0f;

        // Property 
        public float Temperature
        {
            get { return temperature; }
            set { temperature = value; Notify(); }
        }
		
		public float Humidite
        {
            get { return humidite; }
            set { humidite = value; Notify(); }
        }
		
		public float PressionAtmospherique
        {
            get { return pressionAtmospherique; }
            set { pressionAtmospherique = value; Notify(); }
        }
    }

    // Observer 
   	public interface Observer
    {
        void Update();
    }

    // ConcreteObserver 
	public class EcranAnalogique : Observer
    {        
        // L'observé
        private StationMeteo stationMeteo;
        
        public EcranAnalogique(StationMeteo stationMeteo)
        {
            this.stationMeteo = stationMeteo;
            stationMeteo.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("Ecran Analogique nouvelle temperature {0}", stationMeteo.Temperature);
			Console.WriteLine("Ecran Analogique nouvelle humidite {0}", stationMeteo.Humidite);
			Console.WriteLine("Ecran Analogique nouvelle pression atmospherique {0}", stationMeteo.PressionAtmospherique);
        	Console.WriteLine();
		}

        public StationMeteo StationMeteo
        {
            get { return stationMeteo; }
            set { stationMeteo = value; }
        }
    }
	
	// ConcreteObserver 
    public class EcranNumerique : Observer
    {        
        // L'observé
        private StationMeteo stationMeteo;
        
        public EcranNumerique(StationMeteo stationMeteo)
        {
            this.stationMeteo = stationMeteo;
            stationMeteo.Attach(this);
        }

        public void Update()
        {
            Console.WriteLine("Ecran Numerique nouvelle temperature {0}", stationMeteo.Temperature);
			Console.WriteLine("Ecran Numerique nouvelle humidite {0}", stationMeteo.Humidite);
			Console.WriteLine("Ecran Numerique nouvelle pression atmospherique {0}", stationMeteo.PressionAtmospherique);
        	Console.WriteLine();
		}

        public StationMeteo StationMeteo
        {
            get { return stationMeteo; }
            set { stationMeteo = value; }
        }
    }
}