using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, n6, res;

            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            n3 = Convert.ToDouble(Console.ReadLine());
            n4 = Convert.ToDouble(Console.ReadLine());
            n5 = Convert.ToDouble(Console.ReadLine());
            n6 = Convert.ToDouble(Console.ReadLine());

            double[] lista = new double[6] {n1, n2, n3, n4, n5, n6};

            res = 0;
            for (int i = 0; i < 6; i++)
            {
                if (lista[i] > 0)
                {
                    res = res + 1;

                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"{res} valores positivos");
        }
    }
}
    