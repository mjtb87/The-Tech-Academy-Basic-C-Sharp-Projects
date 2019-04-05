using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_3
{
    class Calculator_3
    {
        public void DoubleNum(int num_1)
        {
            Console.WriteLine("Result of equation: " + num_1 * 2);
        }
        public void Floor(double num_1)
        {
            Console.WriteLine("Result of equation: " + Math.Floor(num_1));
        }
        public void ConvertAndSquare(string num_1)
        {
            int num_2 = Convert.ToInt32(num_1);
            Console.WriteLine("Result of equation: " + num_2 * num_2);
        }
    }
}
