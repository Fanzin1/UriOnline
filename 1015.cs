using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ponto1 = Console.ReadLine().Split(' ');
            double x1 = double.Parse(ponto1[0]);
            double y1 = double.Parse(ponto1[1]);
            string[] ponto2 = Console.ReadLine().Split(' ');
            double x2 = double.Parse(ponto2[0]);
            double y2 = double.Parse(ponto2[1]);

            double final = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));

            Console.WriteLine("{0:f4}", final);
        }
    }
}
