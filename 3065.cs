using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _3065S
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            List<int> result = new List<int>();

            int soma = 0;

            while (x != 0)
            {
                x = Convert.ToInt32(Console.ReadLine());

                if (x > 0)
                {

                    List<string> operadores = new List<string>();
                    List<int> numeros = new List<int>();

                    int z = x + (x - 1);

                    string entrada = Console.ReadLine();

                    string[] parts = Regex.Split(entrada, @"([\+\-])");

                    soma = 0;

                    for (int i = 0; i < z; i++)
                    {
                            string l1 = parts[i];
                            operadores.Add(l1);
                    }

                    for (int f = 0; f < operadores.Count; f++)
                    {
                        if (operadores[f] == "+")
                        {
                            soma = soma + Convert.ToInt32(operadores[f + 1]);
                            f++;
                        }
                        else if (operadores[f] == "-")
                        {
                            soma = soma - Convert.ToInt32(operadores[f + 1]);
                            f++;
                        }
                        else
                        {
                            soma = soma + Convert.ToInt32(operadores[f]);
                        }
                    }
                    result.Add(soma);
                }
            }

            int pf = 1;
            for (int f = 0; f < result.Count; f++)
            {
                Console.WriteLine("Teste {0}", pf);
                pf += 1;
                Console.WriteLine(result[f]);
                Console.WriteLine();
            }
        }
    }
}
