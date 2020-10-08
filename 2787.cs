using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2787
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if(x == 1 && b == 1)
            {
                Console.WriteLine("1");
            }

            else if(x % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("1");
            }
            else if(x % 2 != 0 && b % 2 != 0)
            {
                Console.WriteLine("1");
            }
            else if(x % 2 == 0 && b % 2 != 0 || x % 2 != 0 && b % 2 == 0)
            {
                Console.WriteLine("0");
            }


        }
    }
}
