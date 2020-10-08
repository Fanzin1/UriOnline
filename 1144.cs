using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1144
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;
            Y = 1;
            X = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= X; i++)
            {
                Y = i;

                Console.Write(i + " ");
                Y = Y * i;
                Console.Write(Y + " ");
                Y = Y * i;
                Console.Write(Y);
                Console.WriteLine();

                Y = i;

                Console.Write(i + " ");
                Y = (Y * i) ;
                Console.Write(Y + 1 + " ");
                Y = (Y * i);
                Console.Write(Y + 1);
                Console.WriteLine();
            }
        }
    }
}
