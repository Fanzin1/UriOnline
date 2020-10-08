using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent;

            ent = Convert.ToInt32(Console.ReadLine());

            ent = ent + 1;

            for(int i = 1; i < ent; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
