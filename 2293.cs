using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2293
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas, colunas, soma;


            string[] entrada = Console.ReadLine().Split(' ');
            linhas = Convert.ToInt32(entrada[0]);
            colunas = Convert.ToInt32(entrada[1]);

            int z = 0;
            int f = 0;
            int u = 0;
            int g = 0;
            soma = 0;
            
            List<int> lista = new List<int>();
            List<int> somaColunas = new List<int>();
            List<int> somaLinhas = new List<int>();

            while(z < linhas)
            {
                string[] entLinha = Console.ReadLine().Split(' ');

                for(int x = 0; x < colunas; x++)
                {
                    int n1 = Convert.ToInt32(entLinha[x]);

                    lista.Add(n1);
                }
                z++;
            }

            while (f < colunas)
            {
                for(int m = 0; m < colunas; m++)
                {
                    u = m;
                    for (int a = 0; a < linhas; a++)
                    {
                        soma = soma + lista[u];
                        u = u + colunas;
                    }
                    somaColunas.Add(soma);
                    soma = 0;
                    f++;
                }
            }
            while(g < linhas)
            {
                for(int v = 0; v < linhas; v++)
                {
                    u = v * colunas;
                    for (int p = 0; p < colunas; p++)
                    {
                        soma = soma + lista[u];
                        u = u + 1;
                    }
                    somaLinhas.Add(soma);
                    soma = 0;
                    g++;
                }
            }

            int maior = somaColunas.Concat(somaLinhas).Max();
            Console.WriteLine(maior);
        }
    }
}
