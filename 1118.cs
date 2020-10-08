using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1118
{
    class Program
    {
        static void Main(string[] args)
        {

            int Y, Z, X;
            double media, A;

            Z = 0;
            X = 1;

            List<double> lista = new List<double>();

            Y = 0;

            do
            {
                A = Convert.ToDouble(Console.ReadLine());

                if (A >= 0 && A <= 10)
                {
                    lista.Add(A);

                    Z = Z + 1;

                    if (Z == 2)
                    {
                        if (lista[1] >= 0 && lista[1] <= 10)
                        {
                            media = (lista[0] + lista[1]) / 2;
                            Console.WriteLine("media = {0:F2}", media);
                            Z = 0;
                            X = 1;

                            for(int i = 0; X == 1; i++)
                            {
                                Console.WriteLine("novo calculo (1-sim 2-nao)");
                                Y = Convert.ToInt32(Console.ReadLine());

                                if(Y == 1 || Y == 2)
                                {
                                    lista.Clear();
                                    X = 0;
                                }
                                else
                                {
                                    X = 1;
                                }
                            }        
                        }
                    }
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            } while (Y != 2);
        }
    }
}
