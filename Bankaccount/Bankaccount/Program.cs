using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankaccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Account Sami = new Saving("Sami", "513", 8500.0f);
            Account Akil = new Fixed("Akil", "625", 9500f,2020, 15);
            Account Shimul = new Current("Shimul", "753", 6000f);
            Sami.ShowInfo();
            Akil.ShowInfo();
            Shimul.ShowInfo();

        }
    }
}
