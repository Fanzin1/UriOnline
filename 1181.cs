using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1181
{
    class Program
    {
        static void Main(string[] args)
        {
            int linha;
            string func;
            double soma, media;

            linha = Convert.ToInt32(Console.ReadLine());
            func = Console.ReadLine();

            int i = 1;

            List<double> lista = new List<double>();

            while(i <= 144)
            {
                double N = Convert.ToDouble(Console.ReadLine());
                lista.Add(N);
                i = i + 1;
            }

            int z = 0;
            soma = 0;
            media = 0;

            int l = 0;

            while(z <= 11)
            {
                if(linha == 0)
                {

                    if(z == 0)
                    {
                        l = 0;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }
                else if(linha == 1)
                {

                    if(z == 0)
                    {
                        l = 12;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 2)
                {

                    if(z == 0)
                    {
                        l = 24;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 3)
                {

                    if (z == 0)
                    {
                        l = 36;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 4)
                {

                    if (z == 0)
                    {
                        l = 48;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 5)
                {

                    if (z == 0)
                    {
                        l = 60;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 6)
                {

                    if (z == 0)
                    {
                        l = 72;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 7)
                {

                    if (z == 0)
                    {
                        l = 84;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 8)
                {

                    if (z == 0)
                    {
                        l = 96;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 9)
                {

                    if (z == 0)
                    {
                        l = 108;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 10)
                {

                    if (z == 0)
                    {
                        l = 120;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }

                else if (linha == 11)
                {

                    if (z == 0)
                    {
                        l = 132;
                    }
                        soma = soma + lista[l];
                        l = l + 1;
                        z = z + 1;
                }
            }

            if(func == "M")
            {
                media = soma / 12;
                Console.WriteLine("{0:F1}", media);
            }
            else
            {
                Console.WriteLine("{0:F1}", soma);
            }
        }
    }
}
