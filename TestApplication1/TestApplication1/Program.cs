using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApplication1
{
    public class Calculator
    {
        public Func<int, int, int> Operation { get; set; }

        public int Calculate(int lhs, int rhs)
        {
            return Operation(lhs, rhs);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();
            calc.Operation = (x, y) => { return x + y; };

            Console.WriteLine(calc.Calculate(10, 20));
            Console.Read();
        }
    }
}
