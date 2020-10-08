using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent, maior;

            List<int> lista = new List<int>();

            for(int i = 0; i < 100; i++)
            {
                ent = Convert.ToInt32(Console.ReadLine());

                lista.Add(ent);

            }
            maior = lista[0];
            for(int x = 1; x < lista.Count; x++)
            {
                if(lista[x] > maior)
                {
                    maior = lista[x];
                }
            }
            int pos = lista.IndexOf(maior) + 1;
            Console.WriteLine(maior);
            Console.WriteLine(pos);
        }
    }
}
