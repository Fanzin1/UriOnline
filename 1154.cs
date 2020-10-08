using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, soma, quantidade;
            double media;

            soma = 0;
            quantidade = 0;
            idade = 1;

            while(idade > 0)
            {
                idade = Convert.ToInt32(Console.ReadLine());
                if (idade > 0)
                {
                    soma = soma + idade;
                    quantidade = quantidade + 1;
                }
            }

            media = (double)soma / quantidade;

            Console.WriteLine("{0:F2}", media);
        }
    }
}
