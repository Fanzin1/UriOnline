using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2780
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            if(x <= 800)
            {
                Console.WriteLine("1");
            }
            else if(x <= 1400)
            {
                Console.WriteLine("2");
            }
            else if(x <= 2000)
            {
                Console.WriteLine("3");
            }
        }
    }
}
