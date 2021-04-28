using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            CasioBusiness B = new CasioBusiness();
            B.Sum(50, 5);
            B.Sub(50, 5);
            B.Multiplication(50, 5);
            B.Division(50, 5);

            CasioScientific S = new CasioScientific();
            S.Sin_value(145.45);
            S.Absolute(-45);
            S.X_to_power_y(2, 3);
        }
    }
}
