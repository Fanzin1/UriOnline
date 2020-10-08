using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, res;

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            res = num1 + num2;

            Console.WriteLine("SOMA = " + res);
        }
    }
}
