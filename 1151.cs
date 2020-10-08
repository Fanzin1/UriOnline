using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, A, B, C, Z, m, n, u;

            N = Convert.ToInt32(Console.ReadLine());

            List<int> lista = new List<int>();

            A = 0;
            B = 0;
            Z = 0;
            C = 0;

            n = 0;
            m = 1;

            if(N > 0 && N < 46)
            {
                for(int i = 0; i < N; i++)
                {
                    u = N - 1;
                    if(Z < 2)
                    {
                        Console.Write(C + " ");
                        lista.Add(C);
                        C = C + 1;
                        Z = Z + 1;

                    }
                    else
                    {
                        A = lista[n];
                        B = lista[m];

                        C = A + B;
                        lista.Add(C);

                        if (i == u)
                        {
                            Console.Write(C);
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.Write(C + " ");
                        }

                        n = n + 1;
                        m = m + 1;

                    }
                }
            }
        }
    }
}
