using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1172
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                int l1 = Convert.ToInt32(Console.ReadLine());
                lista.Add(l1);
            } 

            for(int x = 0; x < lista.Count; x++)
            {
                if(lista[x] <= 0)
                {
                    Console.WriteLine("X[{0}] = 1", x);
                }
                else
                {
                    Console.WriteLine("X[{0}] = {1}", x, lista[x]);
                }
            }
        }
    }
}
