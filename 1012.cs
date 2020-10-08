using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double resT, resC, resTP, resQ, resR;

            string[] entrada = Console.ReadLine().Split(' ');

            double A = double.Parse(entrada[0]);
            double B = double.Parse(entrada[1]);
            double C = double.Parse(entrada[2]);

            resT = (A * C) / 2;
            resC = 3.14159 * Math.Pow(C, 2);
            resTP = C * (A + B) / 2;
            resQ = B * B;
            resR = A * B;

            Console.WriteLine("TRIANGULO: {0:f3}", resT);
            Console.WriteLine("CIRCULO: {0:f3}", resC);
            Console.WriteLine("TRAPEZIO: {0:f3}", resTP);
            Console.WriteLine("QUADRADO: {0:f3}", resQ);
            Console.WriteLine("RETANGULO: {0:f3}", resR);

        }
    }
}
