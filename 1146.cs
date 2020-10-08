using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1146
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y;

            Y = 1;

            do
            {
                X = Convert.ToInt32(Console.ReadLine());

                for (int i = 1; i <= X; i++)
                {


                    if (i == X)
                    {
                        Console.Write(i);
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.Write(i + " ");
                    }
                }
            } while (X != 0);

        }
    }
}
