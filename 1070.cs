using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent, quant;

            ent = Convert.ToInt32(Console.ReadLine());
            quant = 0;

            for(var i = ent; quant < 6; i++)
            {
                if(ent % 2 != 0)
                {
                    Console.WriteLine(ent);
                    ent = ent + 1;
                    quant = quant + 1;
                }
                else
                {
                    ent = ent + 1;
                }
            }
        }
    }
}
