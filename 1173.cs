using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1173
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("N[{0}] = {1}", i, x);
                x = x * 2;
            }
        }
    }
}
