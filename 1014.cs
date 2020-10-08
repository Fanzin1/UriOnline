using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int X;
            double Y, res;

            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToDouble(Console.ReadLine());

            res = X / Y;

            Console.WriteLine("{0:f3} km/l", res);
        }
    }
}
