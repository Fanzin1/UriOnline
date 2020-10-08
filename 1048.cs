using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1048
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, final;

            x = Convert.ToDouble(Console.ReadLine());

            if(x >= 0 && x <= 400.00)
            {
                final = x + (x * 0.15);
                Console.WriteLine("Novo salario: {0:F2}", final);
                final = final - x;
                Console.WriteLine("Reajuste ganho: {0:F2}", final);
                Console.WriteLine("Em percentual: 15 %");
            }
            else if (x >= 400.01 && x <= 800.00)
            {
                final = x + (x * 0.12);
                Console.WriteLine("Novo salario: {0:F2}", final);
                final = final - x;
                Console.WriteLine("Reajuste ganho: {0:F2}", final);
                Console.WriteLine("Em percentual: 12 %");
            }
            else if (x >= 800.01 && x <= 1200.00)
            {
                final = x + (x * 0.10);
                Console.WriteLine("Novo salario: {0:F2}", final);
                final = final - x;
                Console.WriteLine("Reajuste ganho: {0:F2}", final);
                Console.WriteLine("Em percentual: 10 %");
            }
            else if (x >= 1200.01 && x <= 2000.00)
            {
                final = x + (x * 0.07);
                Console.WriteLine("Novo salario: {0:F2}", final);
                final = final - x;
                Console.WriteLine("Reajuste ganho: {0:F2}", final);
                Console.WriteLine("Em percentual: 7 %");
            }
            else if (x > 2000.00)
            {
                final = x + (x * 0.04);
                Console.WriteLine("Novo salario: {0:F2}", final);
                final = final - x;
                Console.WriteLine("Reajuste ganho: {0:F2}", final);
                Console.WriteLine("Em percentual: 4 %");
            }
        }
    }
}
