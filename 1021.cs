using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _1021S
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] notas = new double[12] {100, 50, 20, 10, 5, 2, 1.00, 0.50, 0.25, 0.10, 0.05, 0.01};
            double[] contas = new double[12];
            double menos, quantidade2;

            double quantidade = Convert.ToDouble(Console.ReadLine());
            quantidade2 = quantidade;

            contas[0] = quantidade / 100;
            quantidade = quantidade % 100;
            contas[1] = quantidade / 50;
            quantidade = quantidade % 50;
            contas[2] = quantidade / 20;
            quantidade = quantidade % 20;
            contas[3] = quantidade / 10;
            quantidade = quantidade % 10;
            contas[4] = quantidade / 5;
            quantidade = quantidade % 5;
            contas[5] = quantidade / 2;
            quantidade = quantidade % 2;

            menos = ((int)contas[0] * 100) + ((int)contas[1] * 50) + ((int)contas[2] * 20) + ((int)contas[3] * 10) + ((int)contas[4] * 5) + ((int)contas[5] * 2);

            quantidade2 = quantidade2 - menos;
            quantidade2 = quantidade2 + 0.00001;

            contas[6] = quantidade2 / 1;
            quantidade2 = quantidade2 % 1;
            contas[7] = quantidade2 / 0.5;
            quantidade2 = quantidade2 % 0.5;
            contas[8] = quantidade2 / 0.25;
            quantidade2 = quantidade2 % 0.25 ;
            contas[9] = quantidade2 / 0.10;
            quantidade2 = quantidade2 % 0.10;
            contas[10] = quantidade2 / 0.05;
            quantidade2 = quantidade2 % 0.05;
            contas[11] = quantidade2 / 0.01;
            quantidade2 = quantidade2 % 0.01;

            Console.WriteLine("NOTAS:");
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine("{0} nota(s) de R$ {1}", (int)contas[i], notas[i].ToString("F2").Replace(',', '.'));
            }

            Console.WriteLine("MOEDAS:");
            for (int i = 6; i < 12; i++)
            {
                Console.WriteLine("{0} moeda(s) de R$ {1}", (int)contas[i], notas[i].ToString("F2").Replace(',', '.'));
            }
        }
    }
}
