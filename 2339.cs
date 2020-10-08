using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2339
{
    class Program
    {
        static void Main(string[] args)
        {
            int nc, nf, qf, quant;

            string[] entrada = Console.ReadLine().Split(' ');
            nc = Convert.ToInt32(entrada[0]);
            nf = Convert.ToInt32(entrada[1]);
            qf = Convert.ToInt32(entrada[2]);

            quant = nc * qf;

            if(quant <= nf)
            {
                Console.WriteLine("S");
            }
            else
            {
                Console.WriteLine("N");
            }
        }
    }
}
