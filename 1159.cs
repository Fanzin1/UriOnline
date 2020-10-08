using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1159
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 1;


            while(x != 0)
            {
                x = Convert.ToInt32(Console.ReadLine());

                int soma = 0;
                int z = 0;

                if(x != 0)
                {
                    while (z != 5)
                    {
                        if (x % 2 == 0)
                        {
                            soma = soma + x;
                            x = x + 1;
                            z = z + 1;
                        }
                        else
                        {
                            x = x + 1;
                        }
                    }
                    Console.WriteLine(soma);
                }
            }
        }
    }
}
