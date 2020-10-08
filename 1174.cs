using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1174
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                double x = Convert.ToDouble(Console.ReadLine());

                if(x <= 10)
                {
                    Console.WriteLine("A[{0}] = {1:F1}", i, x);
                }
            }
        }
    }
}
