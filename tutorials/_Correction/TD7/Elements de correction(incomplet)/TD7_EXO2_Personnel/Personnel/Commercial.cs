using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication1
{
    public class Commercial : Collaborateur
    {
        static float taux;
        float salB;
        float cAff;

        static Commercial()
        {
            Console.WriteLine("Saisir taux sur le CA des commerciaux");
            string s = Console.ReadLine();
            taux = float.Parse(s);
            Console.WriteLine();
        }

        public Commercial(string nom, DateTime date, float salB, float cAff)
            : base(nom, date)
        {
            this.salB = salB; this.cAff = cAff;
        }


        public override string ToString()
        {
            string retour;
            retour = "Commercial : \n" + base.ToString() + "\n\n";
            return retour;
        }

        public override float CalculerSalaire()
        {

            return salB + cAff * taux;
        }

    }
}
