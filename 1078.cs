using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, cont;

            a = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i < 11; i++)
            {
                cont = i * a;
                Console.WriteLine(i + " x " + a + " = " + cont);
            }
        }
    }
}
