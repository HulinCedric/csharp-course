using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD5_EXO3
{
    public abstract class Subject
    {
        protected List<Observer> observers = new List<Observer>();

        public void Attach(Observer observer)
        {
            observers.Add(observer);
        }

        public void Detach(Observer observer)
        {
            observers.Remove(observer);
        }

        public abstract void Notify();
        
    }




    public interface Observer
    {
         void Update( );
    }

    public class StationMeteo :Subject
    {
       
        private float temperature;
        private float humidite;
        private float pression;
        public  StationMeteo(): base(){}
        

        public override void Notify() 
        {
            foreach( Observer o in observers)
            {
                
                o.Update();
            }
        }

       

        public float Temperature
        {
            get{ return temperature;}
            set{ temperature=value; Notify();}
        }

        public float Humidite
        {
            get{ return humidite;}
            set{ humidite=value;Notify();}
        }

         public float Pression
        {
            get{ return pression;}
            set{ pression=value;Notify();}
        }


    }

 public class EcranNumerique :Observer
 {

    private StationMeteo stationMeteo;
    public EcranNumerique(StationMeteo s)
    {
        stationMeteo = s;
        s.Attach(this);
    }

    public void Update() 
    {               
        display();
    }

    public void display()
    {
        Console.WriteLine("Affichage  nouvelle temperature sur ecran numérique{0}",stationMeteo.Temperature);
    }
 }

 public class AppareilAnalogique:Observer
 {

    private StationMeteo stationMeteo;
    public AppareilAnalogique(StationMeteo s)
    {
        stationMeteo = s;
        s.Attach(this);
    }
    
    public void Update() 
    {               
        display();
    }

    public void display()
    {
        Console.WriteLine("Affichage  nouvelle temperature sur ecran analogique {0}",stationMeteo.Temperature);
    }

  }

   


}



    


