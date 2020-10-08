using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1158
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, n1, n2, soma, l;

            X = Convert.ToInt32(Console.ReadLine());

            l = 0;

            for(int i = 0; i < X; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');

                n1 = Convert.ToInt32(entrada[0]);
                n2 = Convert.ToInt32(entrada[1]);

                soma = 0;
                l = 0;
                while (l < n2)
                {
                    if(n1 % 2 != 0)
                    {
                        soma = soma + n1;
                        n1 = n1 + 1;
                        l = l + 1;
                    }
                    else
                    {
                        n1 = n1 + 1;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}
