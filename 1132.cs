using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, maior, menor, soma;

            soma = 0;

            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());

            maior = Math.Max(X, Y);
            menor = Math.Min(X, Y);

            for(int i = menor; i <= maior; i++)
            {
                if(i % 13 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}
