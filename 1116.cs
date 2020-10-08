using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X, Y;
            double media;

            N = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                X = Convert.ToInt32(entrada[0]);
                Y = Convert.ToInt32(entrada[1]);

                media = ((double)X / (double)Y);

                if(Y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    Console.WriteLine("{0:F1}", media);
                }
            }
        }
    }
}
