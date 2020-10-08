using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int ent, sal, dentro, fora, ini;

            ent = Convert.ToInt32(Console.ReadLine());

            List<int> nums = new List<int>();

            dentro = 0;
            fora = 0;

            for (int i = 0; i < ent; i++)
            {
                sal = Convert.ToInt32(Console.ReadLine());
                nums.Add(sal);
            }

            for(int z = 0; z < nums.Count; z++)
            {
                ini = nums[z];

                if(ini >= 10 && ini <= 20)
                {
                    dentro = dentro + 1;
                }
                else
                {
                    fora = fora + 1;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
        }
    }
}
