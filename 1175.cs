using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1175
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            for(int i = 0; i < 20; i++)
            {
                int n1 = Convert.ToInt32(Console.ReadLine());

                lista.Add(n1);
            }

            int y = 19;

            for (int x = 0; x < lista.Count; x++)
            {
                Console.WriteLine("N[{0}] = {1}", x, lista[y]);
                y--;
            }
        }
    }
}
