using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int res, distancia;

            distancia = Convert.ToInt32(Console.ReadLine());

            res = distancia * 2;

            Console.WriteLine($"{res} minutos");
        }
    }
}
