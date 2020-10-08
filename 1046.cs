using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1046S
{
    class Program
    {
        static void Main(string[] args)
        {

            int A, B, Z;

            string[] entrada = Console.ReadLine().Split(' ');
            A = Convert.ToInt32(entrada[0]);
            B = Convert.ToInt32(entrada[1]);
            Z = 24;

            if(A > B)
            {
                Z = Z - A + B;
                Console.WriteLine($"O JOGO DUROU {Z} HORA(S)");
            }
            else if(A < B)
            {
                Z = B - Z + Z - A;
                Console.WriteLine($"O JOGO DUROU {Z} HORA(S)");
            }
            else
            {
                Console.WriteLine($"O JOGO DUROU {Z} HORA(S)");
            }

        }
    }
}
