using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1096
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, J;

            for(I = 1; I < 10; I++)
            {
                Console.WriteLine("I={0} J=7", I);
                Console.WriteLine("I={0} J=6", I);
                Console.WriteLine("I={0} J=5", I);
                I = I + 1;
            }
        }
    }
}
