using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Z, A, B, inter, gremio, empates, quant;

            inter = 0;
            gremio = 0;
            empates = 0;
            quant = 0;
            Z = 1;
            X = 0;


            do
            {
                string[] entrada = Console.ReadLine().Split(' ');
                A = Convert.ToInt32(entrada[0]);
                B = Convert.ToInt32(entrada[1]);

                if (A > B)
                {
                    inter = inter + 1;
                    Z = 1;
                    quant = quant + 1;

                    for (int i = 0; Z == 1; i++)
                    {
                        Console.WriteLine("Novo grenal (1-sim 2-nao)");
                        X = Convert.ToInt32(Console.ReadLine());

                        if (X == 1 || X == 2)
                        {
                            Z = 0;
                        }

                        else
                        {
                            Z = 1;
                        }
                    }
                }

                else if (B > A)
                {
                    gremio = gremio + 1;
                    Z = 1;
                    quant = quant + 1;

                    for (int i = 0; Z == 1; i++)
                    {
                        Console.WriteLine("Novo grenal (1-sim 2-nao)");
                        X = Convert.ToInt32(Console.ReadLine());

                        if (X == 1 || X == 2)
                        {
                            Z = 0;
                        }

                        else
                        {
                            Z = 1;
                        }
                    }
                }

                else
                {
                    empates = empates + 1;
                    Z = 1;
                    quant = quant + 1;

                    for (int i = 0; Z == 1; i++)
                    {
                        Console.WriteLine("Novo grenal (1-sim 2-nao)");
                        X = Convert.ToInt32(Console.ReadLine());

                        if (X == 1 || X == 2)
                        {
                            Z = 0;
                        }

                        else
                        {
                            Z = 1;
                        }
                    }
                }
            } while (X != 2);

            Console.WriteLine($"{quant} grenais");
            Console.WriteLine("Inter:{0}", inter);
            Console.WriteLine("Gremio:{0}", gremio);
            Console.WriteLine("Empates:{0}", empates);

            if(inter > gremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            else if(gremio > inter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if(gremio == inter)
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}
