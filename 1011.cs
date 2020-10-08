using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, res, pi;

            pi = 3.14159;

            raio = Convert.ToDouble(Console.ReadLine());

            res = (4.0 / 3) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = {0:f3}", res);
        }
    }
}
