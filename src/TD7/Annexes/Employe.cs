using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelDLL
{
    public class Employe : Collaborateur
    {
        static float tauxEmp;
        float tarif;
        int nbH;

       /* static Employe()
        {
            Console.WriteLine("Saisir taux des heures supplémentaires employés");
            string s = Console.ReadLine();
            tauxEmp = float.Parse(s);
            Console.WriteLine();
        }*/
        public Employe(string nom, DateTime date, float tarif, int nbH)
            : base(nom, date)
        {
            this.tarif = tarif;
            this.nbH = nbH;
        }

        public override string ToString()
        {
            string retour;
            retour = "Employé :  " + base.ToString() ;
            return retour;
        }


        public override float CalculerSalaire()
        {
            if (nbH > 35) return ((tarif * tauxEmp) + tarif) * (nbH - 35) + 35 * (tarif);
            return tarif * nbH;
        }

        public static float TauxEmp
        {
            get { return tauxEmp; }
            set { tauxEmp = value; }
        }


    }

}
