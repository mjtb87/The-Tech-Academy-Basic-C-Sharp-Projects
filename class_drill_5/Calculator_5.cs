using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_drill_5
{
    class Calculator_5
    {
        public void HalfNum(double num_1)
        {
            Console.WriteLine("Result of equation: " + num_1 / 2);
        }
        public void HalfNum(double num_1, out double numberLog)
        {
            Console.WriteLine("Result of equation: " + num_1 / 2);
            numberLog = num_1;
        }
    }
}
