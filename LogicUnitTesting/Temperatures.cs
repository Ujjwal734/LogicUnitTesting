using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicUnitTesting
{
    public class Temperatures
    {
        public int degreeC, faherenhite;
        double result = 0.0;
        public void Celcius()
        {
            result = (degreeC * 9 / 5) + 32;
            Console.WriteLine("Celsicius to faherenhite is :- " + result);
        }
        public void Faheren()
        {
            result = ((faherenhite - 32) * 5 / 9);
            Console.WriteLine("Faherenhite to celsicus is :- " + result);
        }
    }
}
