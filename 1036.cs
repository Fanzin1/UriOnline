using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, raiz, R1, R2;

            string[] entrada = Console.ReadLine().Split(' ');
            A = Convert.ToDouble(entrada[0]);
            B = Convert.ToDouble(entrada[1]);
            C = Convert.ToDouble(entrada[2]);

            if(A == 0 || B == 0 || C == 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else if (((B * B) - 4 * (A * C)) < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                R1 = (((B * -1.0) + Math.Sqrt((B * B) - 4 * (A * C))) / (2.0 * A));
                R2 = (((B * -1.0) - Math.Sqrt((B * B) - 4 * (A * C))) / (2.0 * A));

                Console.WriteLine("R1 = {0:F5}", R1);
                Console.WriteLine("R2 = {0:F5}", R2);
            }

        }
    }
}
