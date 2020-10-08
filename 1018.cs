using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade, nota100, nota50, nota20, nota10, nota5, nota2, nota1, inicial; 

            quantidade = Convert.ToInt32(Console.ReadLine());
            inicial = quantidade;

            nota100 = quantidade / 100;
            quantidade = quantidade - (nota100 * 100);
            nota50 = quantidade / 50;
            quantidade = quantidade - (nota50 * 50);
            nota20 = quantidade / 20;
            quantidade = quantidade - (nota20 * 20);
            nota10 = quantidade / 10;
            quantidade = quantidade - (nota10 * 10);
            nota5 = quantidade / 5;
            quantidade = quantidade - (nota5 * 5);
            nota2 = quantidade / 2;
            quantidade = quantidade - (nota2 * 2);
            nota1= quantidade / 1;
            quantidade = quantidade - (nota1 * 1);

            Console.WriteLine(inicial);
            Console.WriteLine($"{nota100} nota(s) de R$ 100,00");
            Console.WriteLine($"{nota50} nota(s) de R$ 50,00");
            Console.WriteLine($"{nota20} nota(s) de R$ 20,00");
            Console.WriteLine($"{nota10} nota(s) de R$ 10,00");
            Console.WriteLine($"{nota5} nota(s) de R$ 5,00");
            Console.WriteLine($"{nota2} nota(s) de R$ 2,00");
            Console.WriteLine($"{nota1} nota(s) de R$ 1,00");

        }
    }
}
