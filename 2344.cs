using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2344
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if(x == 0)
            {
                Console.WriteLine("E");
            }
            else if(x >= 1 && x <= 35)
            {
                Console.WriteLine("D");
            }
            else if(x >= 36 && x <= 60)
            {
                Console.WriteLine("C");
            }
            else if(x >= 61 && x <= 85)
            {
                Console.WriteLine("B");
            }
            else if(x >= 86 && x <= 100)
            {
                Console.WriteLine("A");
            }
        }
    }
}
