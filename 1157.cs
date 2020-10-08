using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1157
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                if(N % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
