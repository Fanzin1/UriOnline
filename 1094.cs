using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent, quant, r, s, c, total;
            double mc, mr, ms, nt, nc, ns, nr;

            ent = Convert.ToInt32(Console.ReadLine());

            r = 0;
            s = 0;
            c = 0;
            total = 0;

            for(int i = 0; i < ent; i++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                quant = Convert.ToInt32(entrada[0]);
                string let = entrada[1];
                if(let == "R" || let == "r")
                {
                    r = r + quant;
                    total = total + quant;
                }
                else if(let == "S" || let == "s")
                {
                    s = s + quant;
                    total = total + quant;
                }
                else if(let == "C" || let == "c")
                {
                    c = c + quant;
                    total = total + quant;
                }
            }

            Console.WriteLine("Total: {0} cobaias", total);
            Console.WriteLine("Total de coelhos: {0}", c);
            Console.WriteLine("Total de ratos: {0}", r);
            Console.WriteLine("Total de sapos: {0}", s);
            nc = Convert.ToDouble(c);
            nr = Convert.ToDouble(r);
            ns = Convert.ToDouble(s);
            nt = Convert.ToDouble(total);
            mr = (nr * 100 ) / nt;
            ms = (ns * 100) / nt;
            mc = (nc * 100) / nt;
            Console.WriteLine("Percentual de coelhos: {0:F2} %", mc);
            Console.WriteLine("Percentual de ratos: {0:F2} %", mr);
            Console.WriteLine("Percentual de sapos: {0:F2} %", ms);
        }
    }
}
