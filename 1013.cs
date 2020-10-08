using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1013
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, C, MaiorAB;

            string[] entrada = Console.ReadLine().Split(' ');

            A = int.Parse(entrada[0]);
            B = int.Parse(entrada[1]);
            C = int.Parse(entrada[2]);

            MaiorAB = (A + B + Math.Abs(A - B)) / 2;

            if(MaiorAB > C)
            {
                Console.WriteLine($"{MaiorAB} eh o maior");
            }
            else
            {
                Console.WriteLine($"{C} eh o maior");
            }

            
        }
    }
}
