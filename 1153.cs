using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, fatorial, L, sal, cnt;
            fatorial = 0;
            sal = 0;
            cnt = 0;

            N = Convert.ToInt32(Console.ReadLine());
            L = N;

            for(int i = 0; i <= L; i++)
            {
                if(cnt < 1)
                {
                    fatorial = N * (N - 1);
                    sal = fatorial;
                    N = N - 1;
                    cnt = cnt + 1;
                }
                else
                {
                    N = N - 1;
                    if(N > 0)
                    {
                        fatorial = sal * N;
                        sal = fatorial;
                    }
                }
            }
            Console.WriteLine(fatorial);
        }
    }
}
