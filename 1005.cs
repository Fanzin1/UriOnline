using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, res;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());

            res = (A*3.5 + B*7.5) / 11;

            Console.WriteLine("MEDIA = {0:f5}", res);
        }
    }
}
