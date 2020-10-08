using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio, area;

            raio = Convert.ToDouble(Console.ReadLine());

            area = 3.14159 * Math.Pow(raio, 2);

            Console.WriteLine("A={0:F4}", area);
        }
    }
}
