using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, menor, maior, res;

            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            menor = num1;
            maior = num2;
            res = 0;

            if(num2 < num1)
            {
                menor = num2;
                maior = num1;
            }

            if(menor < 0)
            {
                menor = menor + 1;
            }

            for (int i = menor; i < maior; i++)
            {
                if (i % 2 != 0)
                {
                    res = res + i;
                }
            }

            Console.WriteLine(res);
        }
    }
}
