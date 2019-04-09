using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_drill
{
    class Program
    {
        static void Main(string[] args)
        {
            Number num = new Number() {Amount = 1.61803m };
            Console.WriteLine(num.Amount);
            Console.ReadKey();
        }

        public struct Number
        {
            public decimal Amount { get; set; }
        }
    }
}
