using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_interface
{
    class CasioBusiness : BasicCalculator
    {

        public CasioBusiness()
        {

        }

        public double Division(int x, int y)
        {
            double div = x / y;
            Console.WriteLine("{0} / {1} is :{2}", x, y, div);
            return div;
        }

        public int Multiplication(int x, int y)
        {
            int mul = x * y;
            Console.WriteLine("{0} * {1} is :{2}", x, y, mul);
            return mul;
        }

        public int Sub(int x, int y)
        {
            int sub = x - y;
            Console.WriteLine("{0} - {1} is :{2}", x, y, sub);
            return sub;
        }

        public int Sum(int x, int y)
        {
            int sum = x + y;
            Console.WriteLine("{0} + {1} is :{2}", x, y, sum);
            return sum;
        }
    }
}