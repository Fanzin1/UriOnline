using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, maior, meio, menor;

            string[] entrada = Console.ReadLine().Split(' ');

            A = Convert.ToDouble(entrada[0]);
            B = Convert.ToDouble(entrada[1]);
            C = Convert.ToDouble(entrada[2]);

            if(A > B)
            {
                if(C > A)
                {
                    maior = C;
                    meio = A;
                    menor = B;

                    A = maior;
                    B = meio;
                    C = menor;
                }
                else
                {
                    maior = A;
                    meio = C;
                    menor = B;

                    A = maior;
                    B = meio;
                    C = menor;
                }
                if (A >= B + C)
                {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                else if ((B * B) + (C * C) == (A * A))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if ((A * A) > (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if ((A * A) < (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (A == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }

            }
            else if(B > A)
            {
                if(C > B)
                {
                    maior = C;
                    meio = B;
                    menor = A;

                    A = maior;
                    B = meio;
                    C = menor;
                }
                else
                {
                    maior = B;
                    meio = A;
                    menor =C;

                    A = maior;
                    B = meio;
                    C = menor;
                }
                if (A >= B + C)
                {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                else if ((B * B) + (C * C) == (A * A))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if ((A * A) > (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if ((A * A) < (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (A == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }

            }
            else if(C > A)
            {
                if(B > C)
                {
                    maior = B;
                    meio = C;
                    menor = A;

                    A = maior;
                    B = meio;
                    C = menor;
                }
                else
                {
                    maior = C;
                    meio = A;
                    menor = B;

                    A = maior;
                    B = meio;
                    C = menor;
                }
                if (A >= B + C)
                {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                else if((B * B) + (C * C) == (A * A))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if((A * A) > (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if((A * A ) < (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if(A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (A == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
            else
            {
                if (A >= B + C)
                {
                    Console.WriteLine("NAO FORMA TRIANGULO");
                }
                else if ((B * B) + (C * C) == (A * A))
                {
                    Console.WriteLine("TRIANGULO RETANGULO");
                }
                else if ((A * A) > (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO OBTUSANGULO");
                }
                else if ((A * A) < (B * B) + (C * C))
                {
                    Console.WriteLine("TRIANGULO ACUTANGULO");
                }
                if (A == B && B == C)
                {
                    Console.WriteLine("TRIANGULO EQUILATERO");
                }
                else if (A == B)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (A == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
                else if (B == C)
                {
                    Console.WriteLine("TRIANGULO ISOSCELES");
                }
            }
        }
    }
}
