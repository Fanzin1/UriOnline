using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, maior, menor;

            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());

            maior = Math.Max(X, Y);
            menor = Math.Min(X, Y);

            menor = menor + 1;

            for(int i = menor; i < maior; i++)
            {
                if(i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
