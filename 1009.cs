using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, vendido, final;

            nome = Console.ReadLine();
            salario = Convert.ToDouble(Console.ReadLine());
            vendido = Convert.ToDouble(Console.ReadLine());

            final = salario + (vendido * 0.15);

            Console.WriteLine("TOTAL = R$ {0:f2}", final);
        }
    }
}
