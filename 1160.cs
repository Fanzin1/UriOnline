using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace _1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, PA, PB, anos ;
            double G1, G2, Q1, Q2;
            X = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < X; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');

                PA = Convert.ToInt32(entrada[0]);
                PB = Convert.ToInt32(entrada[1]);
                G1 = Convert.ToDouble(entrada[2]);
                G2 = Convert.ToDouble(entrada[3]);

                Q1 = 0;
                Q2 = 0;
                anos = 0;

                while(PA <= PB)
                {
                    Q1 = (G1 / 100) * PA;
                    PA = PA + (int)Q1;
                    anos = anos + 1;
                    if(G2 != 0)
                    {
                        Q2 = (G2 / 100) * PB;
                        PB = PB + (int)Q2;
                    }
                }
                if(anos > 100)
                {
                    Console.WriteLine("Mais de 1 seculo.");
                }
                else
                {
                    Console.WriteLine($"{anos} anos.");
                }
            }
        }
    }
}
