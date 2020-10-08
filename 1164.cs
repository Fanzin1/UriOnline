using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace _1164
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < x; i++)
            {
                int l = Convert.ToInt32(Console.ReadLine());

                int soma = 0;
                int g = 0;

                for (int f = 1; g < l; f++)
                {
                    if(l % f == 0 && f != l)
                    {
                        soma = soma + f;
                    }
                    g = g + 1;
                }           
                if(soma == l && soma != 1)
                {
                    Console.WriteLine("{0} eh perfeito", l);
                }
                else
                {
                    Console.WriteLine("{0} nao eh perfeito", l);
                }
            }
        }
    }
}
