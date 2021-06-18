using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PatternObserver
{
    class Prog
    {
        static void Main()
        {
            
            ConcreteSubject s = new ConcreteSubject();
            ConcreteObserver o1=new ConcreteObserver(s,"X");
            ConcreteObserver o2=new ConcreteObserver(s,"Y");
            ConcreteObserver o3=new ConcreteObserver(s,"Z");
            
            // Changement d'état  
            s.SubjectState = "ABC";
           

           
        }
    }

    // Subject 
  abstract class  Subject
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
            {
                o.Update();
            }
        }
    }

    // ConcreteSubject 
    class ConcreteSubject : Subject
    {
        //Plusieurs attributs
        private string subjectState;

        // Property 
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; Notify(); }
        }
    }

    // Observer 
    interface  Observer
    {
        void Update();
    }

    // ConcreteObserver 
    class ConcreteObserver : Observer
    {
        //Attributs de l'observer
        private string name;
        
        //l'observé
        private ConcreteSubject subject;

        
        public ConcreteObserver(ConcreteSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
            subject.Attach(this);
        }

        public void Update()
        {
           
            Console.WriteLine("Observer {0} nouvel etat {1}", name, subject.SubjectState);
        }

       
        public ConcreteSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
