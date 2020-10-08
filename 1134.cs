using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1134
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Al, Ga, Di;

            Al = 0;
            Ga = 0;
            Di = 0;

            do
            {
                X = Convert.ToInt32(Console.ReadLine());

                if (X == 1)
                {
                    Al = Al + 1;
                }
                else if (X == 2)
                {
                    Ga = Ga + 1;
                }
                else if (X == 3)
                {
                    Di = Di + 1;
                }
            } while (X != 4);

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine("Alcool: {0}", Al);
            Console.WriteLine("Gasolina: {0}", Ga);
            Console.WriteLine("Diesel: {0}", Di);
        }
    }
}
