using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, media, exame, media2;

            string[] entrada = Console.ReadLine().Split(' ');
            n1 = Convert.ToDouble(entrada[0]);
            n2 = Convert.ToDouble(entrada[1]);
            n3 = Convert.ToDouble(entrada[2]);
            n4 = Convert.ToDouble(entrada[3]);

            media = (n1*2 + n2*3 + n3*4 + n4*1) / 10;
            media = Math.Floor(100 * media) / 100;


            if (media >= 7.0)
            {

                Console.WriteLine("Media: " + media.ToString("N1"));
                Console.WriteLine("Aluno aprovado.");
            }

            else if (media < 5.0)
            {
                Console.WriteLine("Media: " + media.ToString("N1"));
                Console.WriteLine("Aluno reprovado.");
            }
            else if (media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Media: " + media.ToString("N1"));
                Console.WriteLine("Aluno em exame.");
                exame = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Nota do exame: {0:F1}", exame);
                media2 = (exame + media) / 2;
                media2 = Math.Floor(100 * media2) / 100;
                if (media2 >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                    Console.WriteLine("Media final: " + media2.ToString("N1"));
                }
                else if(media2 <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                    Console.WriteLine("Media final: " + media2.ToString("N1"));
                }

            }
        }
    }
}
