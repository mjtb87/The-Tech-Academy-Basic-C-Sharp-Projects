using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_3
{
    class Calculator_3
    {
        public void HalfNumber(int num_1)
        {
            Console.WriteLine("Result of equation: " + num_1 / 2);
        }
        public void HalfNumber(double num_1)
        {
            Console.WriteLine("Result of equation: " + num_1 / 2);
        }
        public void HalfNumber(string num_1)
        {
            double num_2 = Convert.ToDouble(num_1);
            Console.WriteLine("Result of equation: " + num_2 / 2);
        }
    }
}
