using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int e, a, b, maior, menor, soma;

            e = Convert.ToInt32(Console.ReadLine());


            List<int> lista = new List<int>();

            for(int i = 0; i < e; i++)
            {
                soma = 0;
                string[] entrada = Console.ReadLine().Split(' ');


                a = Convert.ToInt32(entrada[0]);
                b = Convert.ToInt32(entrada[1]);

                maior = Math.Max(a, b);
                menor = Math.Min(a, b);

                for (int x = menor; x < maior; x++)
                {
                    if(x % 2 != 0 && x != menor && x != maior)
                    {
                        soma = soma + x;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}
