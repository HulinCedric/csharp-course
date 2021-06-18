using System;
using System.Collections;

namespace PersonnelDLL
{
    public abstract class Collaborateur: IComparable
    {
        string nom;
        DateTime dateNaissance;
        public Collaborateur(string nom, DateTime date)
        {
            this.nom = nom;
            dateNaissance = date;
        }
        public override string ToString()
        {
            return "Nom : " + nom  + "  Date de naissance :   "+dateNaissance.ToShortDateString() + "   " + "Salaire :   " + CalculerSalaire();
           
        }
        public int Age(int annee)
        {
            int an = dateNaissance.Year;
            return annee - an;
        }

        public string Nom
        {
            get{ return nom;}
        }

        public DateTime DateNaissance
        {
            get { return dateNaissance;}
        }
       
        public abstract float CalculerSalaire();
        public Collaborateur PlusHautSal(Collaborateur i)
        {
            if (i.CalculerSalaire() > CalculerSalaire())
                return i;
            else return this;
        }

        public int CompareTo(object O)
        {
            Collaborateur c = (Collaborateur)O;
            return this.Age(2010).CompareTo(c.Age(2010));
            
        }


    }


    public class TriSalaire : IComparer
    {
        public int Compare(Object o1, Object o2)
        {
            Collaborateur c1 = (Collaborateur)o1;
            Collaborateur c2 = (Collaborateur)o2;
            return c1.CalculerSalaire().CompareTo(c2.CalculerSalaire());
        }
    }

 
  
}
