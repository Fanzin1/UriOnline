using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, anos, meses;

            dias = Convert.ToInt32(Console.ReadLine());

            if(dias >= 365)
            {
                anos = dias / 365;
                dias = dias - (anos * 365);
                meses = dias / 30;
                dias = dias - (meses * 30);

                Console.WriteLine($"{anos} ano(s)");
                Console.WriteLine($"{meses} mes(es)");
                Console.WriteLine($"{dias} dia(s)");
            }
            else
            {
                meses = dias / 30;
                dias = dias - (meses * 30);

                Console.WriteLine("0 ano(s)");
                Console.WriteLine($"{meses} mes(es)");
                Console.WriteLine($"{dias} dia(s)");
            }
        }
    }
}
