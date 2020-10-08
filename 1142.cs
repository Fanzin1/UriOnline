using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1142
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Z;
            Z = 0;

            X = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < X; i++)
            {
                Z = Z + 1;
                Console.Write(Z + " ");
                Z = Z + 1;
                Console.Write(Z + " ");
                Z = Z + 1;
                Console.Write(Z + " ");
                Z = Z + 1;
                if (Z % 4 == 0)
                {
                    Console.Write("PUM");
                    Console.WriteLine();
                }
            }
        }
    }
}
