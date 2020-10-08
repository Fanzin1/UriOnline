using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2879
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = Convert.ToInt32(Console.ReadLine());

            int s = 0;

            for(int i = 0; i < x; i++)
            {
                int e = Convert.ToInt32(Console.ReadLine());

                if(e != 1)
                {
                    s += 1;
                }
            }

            Console.WriteLine(s);
        }
    }
}
