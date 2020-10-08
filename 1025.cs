using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1025
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] meses = new string[12] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

            int mes;

            mes = Convert.ToInt32(Console.ReadLine());
            mes = mes - 1;

            Console.WriteLine(meses[mes]);
        }
    }
}
