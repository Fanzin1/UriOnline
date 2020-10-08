using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, media;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());

            media = (A * 2 + B * 3 + C * 5) / 10;

            Console.WriteLine("MEDIA = {0:f1}", media);
        }
    }
}
