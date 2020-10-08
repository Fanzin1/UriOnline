using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1156
{
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            double soma, s, z;
            s = 0;
            z = 1;
            c = 0;

            for(int i = 1; i <= 39; i+=2)
            {
                if(i <= 39)
                {
                    soma = i / z;
                    s = s + soma;
                    z = z * 2;
                }
            }
            Console.WriteLine("{0:F2}", s);
        }
    }
}
