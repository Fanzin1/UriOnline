using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double renda, imposto, imposto2, imposto3, imposto4;

            renda = Convert.ToDouble(Console.ReadLine());

            if(renda >= 0 && renda <= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if(renda >= 2000.01 && renda <= 3000.00)
            {
                renda = renda - 2000;

                imposto = (renda * 0.08);
                Console.WriteLine("R$ {0:F2}", imposto);
            }
            else if (renda >= 3000.01 && renda <= 4500.00)
            {
                imposto2 = renda - 3000;
                renda = renda - 2000;

                if(imposto2 > renda)
                {
                    imposto3 = imposto2 - renda;
                }
                else
                {
                    imposto3 = renda - imposto2;
                }

                imposto = (imposto3 * 0.08) + (imposto2 * 0.18);
                Console.WriteLine("R$ {0:F2}", imposto);
            }
            else if(renda > 4500.00)
            {
                imposto4 = renda - 4500;
                imposto2 = (renda - 3000) - imposto4;
                renda = renda - 2000;

                if (imposto2 > renda)
                {
                        imposto3 = (imposto2 + imposto4) - renda;
                }
                else
                {
                    imposto3 = renda - (imposto2 + imposto4);
                }

                imposto = (imposto3 * 0.08) + (imposto2 * 0.18) + (imposto4 * 0.28);
                Console.WriteLine("R$ {0:F2}", imposto);
            }
        }
    }
}
