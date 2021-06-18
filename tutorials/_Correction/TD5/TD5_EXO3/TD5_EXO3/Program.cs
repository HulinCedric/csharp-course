using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TD5_EXO3
{
    class Program
    {
        static void Main(string[] args)
        {
            StationMeteo maMeteo = new StationMeteo();
            EcranNumerique o1=new EcranNumerique(maMeteo);
            AppareilAnalogique o2 = new AppareilAnalogique(maMeteo);

            maMeteo.Temperature = 20;

        }
    }
}
