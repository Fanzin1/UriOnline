using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2342
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, res;

            res = 0;

            X = Convert.ToInt32(Console.ReadLine());

            string[] entrada = Console.ReadLine().Split(' ');

            int n1 = Convert.ToInt32(entrada[0]);
            string esc = entrada[1];
            int n2 = Convert.ToInt32(entrada[2]);

            if(esc == "+")
            {
                res = n1 + n2;
            }
            else if(esc == "*")
            {
                res = n1 * n2;
            }

            if(res <= X)
            {
                Console.WriteLine("OK");
            }
            else if(res > X)
            {
                Console.WriteLine("OVERFLOW");
            }
        }
    }
}
