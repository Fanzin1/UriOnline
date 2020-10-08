using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1042
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, maior, meio, menor;

            string[] entrada = Console.ReadLine().Split(' ');
            a = Convert.ToInt32(entrada[0]);
            b = Convert.ToInt32(entrada[1]);
            c = Convert.ToInt32(entrada[2]);

            maior = a;

            if(b > a)
            {
                if(c > b)
                {
                    maior = c;
                    meio = b;
                    menor = a;
                }
                else if(a > c)
                {
                    maior = b;
                    meio = a;
                    menor = c;
                }
                else
                {
                    maior = b;
                    meio = c;
                    menor = a;
                }

                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);

                Console.WriteLine();

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            }
            else if (c > a)
            {
                if(b > c)
                {
                    maior = c;
                    meio = b;
                    menor = a;
                }
                else if(a > b)
                {
                    maior = c;
                    meio = a;
                    menor = b;
                }
                else
                {
                    maior = c;
                    meio = b;
                    menor = a;
                }

                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);

                Console.WriteLine();

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            }
            else if(a > c)
            {

                if(c > b)
                {
                    maior = a;
                    meio = c;
                    menor = b;
                }
                else
                {
                    maior = a;
                    meio = b;
                    menor = c;
                }

                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);

                Console.WriteLine();

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            }
            else if (a > b)
            {
                if(b > c)
                {
                    maior = a;
                    meio = b;
                    menor = c;
                }
                else
                {
                    maior = a;
                    meio = c;
                    menor = b;

                }

                Console.WriteLine(menor);
                Console.WriteLine(meio);
                Console.WriteLine(maior);

                Console.WriteLine();

                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);

            }



        }
    }
}
