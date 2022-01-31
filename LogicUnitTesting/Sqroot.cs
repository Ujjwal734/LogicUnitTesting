using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicUnitTesting
{
    public class Sqroot
    {
        public void squareRoot(double num, double num2)
        {
            double x = num;
            double root;
            int count = 0;

            while (true)
            {
                count++;
                root = 0.5 * (x + (num / x));

                if (Math.Abs(root - x) < num2)
                    break;
                x = root;
            }

            Console.WriteLine("Root "+ root);
        }
    }
}
