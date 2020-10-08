using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos, h, m, s;

            segundos = Convert.ToInt32(Console.ReadLine());

            if(segundos > 3600)
            {
                h = segundos / 3600;
                segundos = segundos - (h * 3600);
                m = segundos / 60;
                segundos = segundos - (m * 60);
                s = segundos % 60;
                Console.WriteLine(h + ":" + m + ":" + s);
            }
            else
            {
                m = segundos / 60;
                segundos = segundos - (m * 60);
                s = segundos % 60;
                Console.WriteLine("0:" + m + ":" + s);
            }
        }
    }
}
