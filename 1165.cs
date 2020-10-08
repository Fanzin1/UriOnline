using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1165
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < x; i++)
            {
                int n1 = Convert.ToInt32(Console.ReadLine());
                int soma = 0;

                for (int z = 1; z <= n1; z++)
                {
                    if(n1 % z == 0)
                    {
                        soma = soma + 1;
                    }
                }
                if(soma == 2)
                {
                    Console.WriteLine("{0} eh primo", n1);
                }
                else
                {
                    Console.WriteLine("{0} nao eh primo", n1);
                }
            }
        }
    }
}
