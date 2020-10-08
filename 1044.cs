using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;

            string[] entrada = Console.ReadLine().Split(' ');
            A = Convert.ToInt32(entrada[0]);
            B = Convert.ToInt32(entrada[1]);

            if(A % B == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else if(B % A == 0)
            {
                Console.WriteLine("Sao Multiplos");
            }
            else
            {
                Console.WriteLine("Nao sao Multiplos");
            }
        }
    }
}
