using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            X = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= X; i++)
            {
                Y = i;
                Console.Write(Y + " ");
                Y = Y * i;
                Console.Write(Y + " ");
                Y = Y * i;
                Console.Write(Y);
                Console.WriteLine();
            }
        }
    }
}
