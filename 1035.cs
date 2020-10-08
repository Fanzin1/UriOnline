using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D;

            string[] entrada = Console.ReadLine().Split(' ');
            A = int.Parse(entrada[0]);
            B = int.Parse(entrada[1]);
            C = int.Parse(entrada[2]);
            D = int.Parse(entrada[3]);

            if(B > C && D > A && C + D > A + B && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
        }
    }
}
