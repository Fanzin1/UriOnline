using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1097
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, J;
            J = 7;
            for (I = 1; I < 10; I++)
            {
                Console.WriteLine("I={0} J={1}", I, J);
                J = J - 1;
                Console.WriteLine("I={0} J={1}", I, J);
                J -= 1;
                Console.WriteLine("I={0} J={1}", I, J);
                J = J + 4;
                I = I + 1;
            }
        }
    }
}
