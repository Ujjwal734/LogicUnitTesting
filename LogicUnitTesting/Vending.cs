using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicUnitTesting
{
    public class Vending
    {
        public void Machine()
        {
            int amount = Convert.ToInt32(Console.ReadLine());
            int[] notes = { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCounter = new int[8];
            for (int i = 0; i < 8; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount - noteCounter[i] * notes[i];
                }
            }
            Console.WriteLine("Currency Count ->");
            for (int i = 0; i < 8; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine(notes[i] + " : "
                        + noteCounter[i]);
                }
            }
        }
    }
}
