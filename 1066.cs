using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, n4, n5, par, impar, pos, neg;

            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            n4 = Convert.ToInt32(Console.ReadLine());
            n5 = Convert.ToInt32(Console.ReadLine());

            int[] lista = new int[]{ n1, n2, n3, n4, n5 };

            par = 0;
            impar = 0;
            pos = 0;
            neg = 0;

            for(int i = 0; i < 5; i++)
            {
                if(lista[i] % 2 == 0)
                {
                    par = par + 1;
                }
                else if(lista[i] % 2 != 0)
                {
                    impar = impar + 1;
                }
                if(lista[i] > 0)
                {
                    pos = pos + 1;
                }
                else if(lista[i] < 0)
                {
                    neg = neg + 1;
                }
            }

            Console.WriteLine($"{par} valor(es) par(es)");
            Console.WriteLine($"{impar} valor(es) impar(es)");
            Console.WriteLine($"{pos} valor(es) positivo(s)");
            Console.WriteLine($"{neg} valor(es) negativo(s)");
        }
    }
}
