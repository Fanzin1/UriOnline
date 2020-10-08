using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1095
{
    class Program
    {
        static void Main(string[] args)
        {
            int I, J;

            J = 60;
            I = 1;

            for(J = 60; J > -1; J--)
            {
                Console.WriteLine("I={0} J={1}", I, J);
                J = J - 4;
                I = I + 3;
            }

        }
    }
}
