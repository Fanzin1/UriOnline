using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;

            string[] entrada = Console.ReadLine().Split(' ');
            x = Convert.ToDouble(entrada[0]);
            y = Convert.ToDouble(entrada[1]);

            if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if(x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else if(x > 0 && y < 0)
            {
                Console.WriteLine("Q4");
            }
            else if(x != 0 && y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x == 0 && y != 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}
