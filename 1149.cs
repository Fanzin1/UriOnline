using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1149
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, N, i, soma;

            string[] entrada = Console.ReadLine().Split(' ');

            A = Convert.ToInt32(entrada[0]);
            N = Convert.ToInt32(entrada[1]);

            i = 1;
            while( N <= 0)
            {
                i = i + 1;
                N = Convert.ToInt32(entrada[i]);
            }

            soma = 0;
            for(int z = 0; z < N; z++)
            {
                soma = soma + A + z;
            }

            Console.WriteLine(soma);
        }
    }
}
