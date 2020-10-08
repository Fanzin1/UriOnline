using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int cod, quant;
            double res;

            string[] entrada = Console.ReadLine().Split(' ');
            cod = Convert.ToInt32(entrada[0]);
            quant = Convert.ToInt32(entrada[1]);

            if(cod == 1)
            {
                res = quant * 4.00;
                Console.WriteLine("Total: R$ {0:F2}", res);
            }
            else if (cod == 2)
            {
                res = quant * 4.50;
                Console.WriteLine("Total: R$ {0:F2}", res);
            }
            else if (cod == 3)
            {
                res = quant * 5.00;
                Console.WriteLine("Total: R$ {0:F2}", res);
            }
            else if (cod == 4)
            {
                res = quant * 2.00;
                Console.WriteLine("Total: R$ {0:F2}", res);
            }
            else if (cod == 5)
            {
                res = quant * 1.50;
                Console.WriteLine("Total: R$ {0:F2}", res);
            }
        }
    }
}
