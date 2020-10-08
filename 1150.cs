using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Z, soma, quant;

            soma = 0;
            quant = 0;

            X = Convert.ToInt32(Console.ReadLine());
            Z = Convert.ToInt32(Console.ReadLine());

            while(Z <= X)
            {
                Z = Convert.ToInt32(Console.ReadLine());
            }

            for(int i = X; soma <= Z; i++)
            {
                soma = soma + i;
                quant = quant + 1;
            }

            Console.WriteLine(quant);
        }
    }
}
