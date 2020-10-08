using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            a = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 10000; i++)
            {
                if(i % a == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
