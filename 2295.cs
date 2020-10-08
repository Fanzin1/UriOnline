using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2295
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, G, PA, PG;

            string[] entrada = Console.ReadLine().Split(' ');
            A = Convert.ToDouble(entrada[0]);
            G = Convert.ToDouble(entrada[1]);
            PA = Convert.ToDouble(entrada[2]);
            PG = Convert.ToDouble(entrada[3]);

            double mediaA = (100 / PA) * A;
            double mediaG = (100 / PG) * G;

            if(mediaA < mediaG)
            {
                Console.WriteLine("A");
            }
            else
            {
                Console.WriteLine("G");
            }
        }
    }
}
