using System;
using System.Collections.Generic;
using System.Text;

namespace PersonnelDLL
{
    public class Commercial : Collaborateur
    {
        static float tauxCom;
        float salB;
        float cAff;

        /*
         static Commercial()
        {
            Console.WriteLine("Saisir taux sur le CA des commerciaux");
            string s = Console.ReadLine();
            tauxCom = float.Parse(s);
            Console.WriteLine();
        }
        */
        public Commercial(string nom, DateTime date, float salB, float cAff)
            : base(nom, date)
        {
            this.salB = salB; this.cAff = cAff;
        }


        public override string ToString()
        {
            string retour;
            retour = "Commercial :   " + base.ToString() + "\n\n";
            return retour;
        }

        public override float CalculerSalaire()
        {

            return salB + cAff * tauxCom;
        }

        public static float TauxCom
        {
            get { return tauxCom; }
            set { tauxCom = value; }
        }

    }
}
