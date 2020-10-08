using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double A;

            A = Convert.ToDouble(Console.ReadLine());

            if(A >= 0 && A <= 25)
            {
                Console.WriteLine("Intervalo [0,25]");
            }
            else if(A >= 25.00001 && A <= 50)
            {
                Console.WriteLine("Intervalo (25,50]");
            }
            else if (A >= 50.00001 && A <= 75)
            {
                Console.WriteLine("Intervalo (50,75]");
            }
            else if (A >= 75.00001 && A <= 100)
            {
                Console.WriteLine("Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine("Fora de intervalo");
            }
        }
    }
}
