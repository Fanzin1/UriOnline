using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1098
{
    class Program
    {
        static void Main(string[] args)
        {
            double I, J;
            J = 1;
            for (I = 0; I < 2 ; I++)
            {
                if(I < 0.1 )
                {
                    Console.WriteLine("I={0} J=1", I);
                    Console.WriteLine("I={0} J=2", I);
                    Console.WriteLine("I={0} J=3", I);
                }
                else
                {
                    J = J + I;
                    Console.WriteLine("I={0} J={1}", I, J);
                    J = J + 1;
                    Console.WriteLine("I={0} J={1}", I, J);
                    J = J + 1;
                    Console.WriteLine("I={0} J={1}", I, J);

                }

                J = 1;
                I = (I + 0.2) - 1;
            }
        }
    }
}
