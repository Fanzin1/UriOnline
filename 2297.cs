using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2297
{
    class Program
    {
        static void Main(string[] args)
        {
            int r;

            r = 1;
            int nt = 0;

            List<int> vencedores = new List<int>();

            while(r != 0)
            {
                r = Convert.ToInt32(Console.ReadLine());
                int AlV = 0;
                int BeV = 0;

                if (r > 0)
                {
                    for (int i = 0; i < r; i++)
                    {
                        string[] entrada = Console.ReadLine().Split(' ');
                        int A = Convert.ToInt32(entrada[0]);
                        int B = Convert.ToInt32(entrada[1]);

                            AlV = AlV + A;
                            BeV = BeV + B;
                    }

                    if(AlV > BeV)
                    {
                        vencedores.Add(1);
                    }
                    else if (AlV < BeV)
                    {
                        vencedores.Add(0);
                    }
                }
            }

            for (int x = 0; x < vencedores.Count; x++)
            {
                ++nt;
                Console.WriteLine("Teste {0}", nt);
                if (vencedores[x] == 1)
                {
                    Console.WriteLine("Aldo");
                }
                else if (vencedores[x] == 0)
                {
                    Console.WriteLine("Beto");
                }
                Console.WriteLine();
            }

        }
    }
}
