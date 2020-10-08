using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1050
{
    class Program
    {
        static void Main(string[] args)
        {
            int d;

            d = Convert.ToInt32(Console.ReadLine());

            if(d == 11)
            {
                Console.WriteLine("Sao Paulo");
            }
            else if(d == 71)
            {
                Console.WriteLine("Salvador");
            }
            else if (d == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if (d == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (d == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (d == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (d == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (d == 32)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}
