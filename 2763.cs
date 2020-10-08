using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2763
{
    class Program
    {
        static void Main(string[] args)
        {
            string fmb = "000";
            string dfmb = "00";
            int n1, n2, n3, n4;
            string[] entrada = Console.ReadLine().Split('.');
            n1 = Convert.ToInt32(entrada[0]);
            n2 = Convert.ToInt32(entrada[1]);
            string[] entrada2 = entrada[2].Split('-');
            n3 = Convert.ToInt32(entrada2[0]);
            n4 = Convert.ToInt32(entrada2[1]);


            Console.WriteLine(n1.ToString(fmb));
            Console.WriteLine(n2.ToString(fmb));
            Console.WriteLine(n3.ToString(fmb));
            Console.WriteLine(n4.ToString(dfmb));
        }
    }
}
