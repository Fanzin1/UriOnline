using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1065
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, quant;

            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            n5 = Convert.ToInt32(Console.ReadLine());

            int[] nums = new int[] { n1, n2, n3, n4, n5 };

            quant = 0;

            for(int i = 0; i < 5; i++)
            {
                if(nums[i] % 2 == 0)
                {
                    quant = quant + 1;
                }
            }

            Console.WriteLine($"{quant} valores pares");
        }
    }
}
