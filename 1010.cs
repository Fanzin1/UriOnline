using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1010
{
    class Program
    {
        static void Main(string[] args)
        {

            double res, res1, finalres;

            string[] linha1 = Console.ReadLine().Split(' ');
            int valor1 = int.Parse(linha1[0]);
            int valor2 = int.Parse(linha1[1]);
            double preco = double.Parse(linha1[2]);


            string[] linha2 = Console.ReadLine().Split(' ');
            int valor3 = int.Parse(linha2[0]);
            int valor4 = int.Parse(linha2[1]);
            double preco1 = double.Parse(linha2[2]);

            res = valor2 * preco;

            res1 = valor4 * preco1;

            finalres = res + res1;

            Console.WriteLine("VALOR A PAGAR: R$ {0:f2}", finalres);


        }
    }
}
