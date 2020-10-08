using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1113
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            do
            {
                string[] entrada = Console.ReadLine().Split(' ');

                X = Convert.ToInt32(entrada[0]);
                Y = Convert.ToInt32(entrada[1]);

                if (X > Y)
                {
                    Console.WriteLine("Decrescente");
                }
                else if (Y > X)
                {
                    Console.WriteLine("Crescente");
                }
            } while (X != Y);
        }
    }
}
