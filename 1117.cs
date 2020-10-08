using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1117
{
    class Program
    {
        static void Main(string[] args)
        {
            int Y, Z;
            double media, A;

            Y = 1;
            Z = 0;

            List<double> lista = new List<double>();

            do
            {
                A = Convert.ToDouble(Console.ReadLine());

                if (A >= 0 && A <= 10)
                {
                    lista.Add(A);
                    Z = Z + 1;
                    if(Z == 2)
                    {
                        if (lista[1] >= 0 && lista[1] <= 10)
                        {
                            Y = 0;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("nota invalida");
                }
            } while(Y == 1);

            media = (lista[0] + lista[1]) / 2;

            Console.WriteLine("media = {0:F2}", media);
        }
    }
}
