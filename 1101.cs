using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1101
{
    class Program
    {
        static void Main(string[] args)
        {
            int m, n, maior, menor, soma;

            do
            {
                string[] entrada = Console.ReadLine().Split(' ');

                m = Convert.ToInt32(entrada[0]);
                n = Convert.ToInt32(entrada[1]);

                maior = Math.Max(m, n);
                menor = Math.Min(m, n);

                soma = 0;

                if(menor > 0) { 
                   for(int x = menor; x <= maior; x++)
                   {
                       soma = soma + x;
                       if(x == maior)
                       {
                           Console.Write(x + " Sum={0}", soma);
                           Console.WriteLine();
                       }
                       else
                       {
                           Console.Write(x + " ");
                       }
                   }
                }
            } while (menor > 0);
        }
    }
}
