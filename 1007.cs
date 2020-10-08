using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, res;

            A = Convert.ToInt32(Console.ReadLine());
            B = Convert.ToInt32(Console.ReadLine());
            C = Convert.ToInt32(Console.ReadLine());
            D = Convert.ToInt32(Console.ReadLine());

            res = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + res);
        }
    }
}
