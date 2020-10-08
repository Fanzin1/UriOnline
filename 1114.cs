using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = 0;
            do
            {
                int i = Convert.ToInt32(Console.ReadLine());

                x = i;

                if(i != 2002)
                {
                    Console.WriteLine("Senha Invalida");
                }
                if(i == 2002)
                {
                    Console.WriteLine("Acesso Permitido");
                }
            }while(x != 2002);
        }
    }
}
