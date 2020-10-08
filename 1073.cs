using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, res;

            a = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= a; i++)
            {
                if(i % 2 == 0)
                {
                    res = i * i;
                    Console.WriteLine(i + "^2 = " + res);
                }
            }
        }
    }
}
