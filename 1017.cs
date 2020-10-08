using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo, velocidade, kms;

            tempo = Convert.ToDouble(Console.ReadLine());
            velocidade = Convert.ToDouble(Console.ReadLine());

            kms = (tempo * velocidade) / 12;

            Console.WriteLine("{0:f3}", kms);
        }
    }
}
