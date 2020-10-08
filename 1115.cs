using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, menor;
            menor = 1;
            do
            {
                string[] ent = Console.ReadLine().Split(' ');

                X = Convert.ToInt32(ent[0]);
                Y = Convert.ToInt32(ent[1]);

                menor = Math.Min(Y, X);

                if(X != 0 && Y != 0)
                {
                    if (X > 0 && Y > 0)
                    {
                        Console.WriteLine("primeiro");
                    }

                    else if (X < 0 && Y > 0)
                    {
                        Console.WriteLine("segundo");
                    }
                    else if (X > 0 && Y < 0)
                    {
                        Console.WriteLine("quarto");
                    }
                    else if (X < 0 && Y < 0)
                    {
                        Console.WriteLine("terceiro");
                    }
                }
            } while (menor != 0);
        }
    }
}
