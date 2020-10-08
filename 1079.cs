using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent;
            double n1, n2, n3, conta;

            ent = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < ent; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                n1 = Convert.ToDouble(entrada[0]);
                n2 = Convert.ToDouble(entrada[1]);
                n3 = Convert.ToDouble(entrada[2]);

                conta = ((n1*2) + (n2*3) + (n3*5)) / 10 ;
                Console.WriteLine("{0:F1}",conta);
            }
        }
    }
}
