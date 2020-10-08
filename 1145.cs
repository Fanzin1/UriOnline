using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1145
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, Z;

            string[] entrada = Console.ReadLine().Split(' ');
            A = Convert.ToInt32(entrada[0]);
            B = Convert.ToInt32(entrada[1]);

            Z = 0;

            for(int i = 1; i <= B; i++)
            {
                i = i - 1;
                Z = 0;
                do
                {
                    i = i + 1;
                    if(i <= B)
                    {
                        if(i % A != 0)
                        {
                            Console.Write(i + " ");
                        }
                        if (i % A == 0)
                        {
                            Console.Write(i);
                            Console.WriteLine();
                        }
                    }
                    Z = Z + 1;
                } while (Z <= A);
            }
        }
    }
}
