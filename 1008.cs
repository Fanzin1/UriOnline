using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int funNum, horas;
            double valorHora, res;

            funNum = Convert.ToInt32(Console.ReadLine());
            horas = Convert.ToInt32(Console.ReadLine());
            valorHora = Convert.ToDouble(Console.ReadLine());

            res = horas * valorHora;

            Console.WriteLine("NUMBER = " + funNum);
            Console.WriteLine("SALARY = U$ {0:f2}", res);
        }
    }
}

