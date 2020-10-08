using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1043
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, maior, somados, area;

            string[] entrada = Console.ReadLine().Split(' ');

            A = Convert.ToDouble(entrada[0]);
            B = Convert.ToDouble(entrada[1]);
            C = Convert.ToDouble(entrada[2]);

            
            if(B > A)
            {
                if(C > B)
                {
                    maior = C;
                    somados = A + B;
                }
                else
                {
                    maior = B;
                    somados = A + C;
                }

                if (somados == maior)
                {
                    area = ((A + B) * C) / 2;
                    Console.WriteLine("Area = {0:F1}", area);
                }
                else
                {
                    area = A + B + C;
                    Console.WriteLine("Perimetro = {0:F1}", area);
                }
            }
            else if(C > A)
            {
                if(B > C)
                {
                    maior = B;
                    somados = A + C;
                }
                else
                {
                    maior = C;
                    somados = A + B;
                }

                if (somados == maior)
                {
                    area = ((A + B) * C) / 2;
                    Console.WriteLine("Area = {0:F1}", area);
                }
                else
                {
                    area = A + B + C;
                    Console.WriteLine("Perimetro = {0:F1}", area);
                }
            }
            else
            {
                maior = A;
                somados = B + C;

                if(somados == maior)
                {
                    area = ((A + B) * C) / 2;
                    Console.WriteLine("Area = {0:F1}", area);
                }
                else
                {
                    area = A + B + C;
                    Console.WriteLine("Perimetro = {0:F1}", area);
                }
            }
        }
    }
}
