using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD4_EXO3_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Simulateur monSim = new SimulateurTroll();
            monSim.Simuler();
        }
    }
}
