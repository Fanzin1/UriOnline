using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, encontrados, res, taman;

            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            n4 = Convert.ToDouble(Console.ReadLine());
            n5 = Convert.ToDouble(Console.ReadLine());
            n6 = Convert.ToDouble(Console.ReadLine());

            double[] lista = new double[]{ n1, n2, n3, n4, n5, n6 };

            encontrados = 0;
            taman = 0;

            for (int i = 0; i < 6; i++)
            {
                if(lista[i] > 0)
                {
                    encontrados = encontrados + 1;
                    taman = taman + lista[i];
                    Console.WriteLine(taman);
                }
            }
            res = taman / encontrados;


            Console.WriteLine($"{encontrados} valores positivos");
            Console.WriteLine("{0:F1}", res);
        }
    }
}
