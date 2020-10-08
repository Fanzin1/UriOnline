using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, sal;

            a = Convert.ToInt32(Console.ReadLine());

            List<int> nums = new List<int>();

            for(int i = 0; i < a; i++)
            {
                sal = Convert.ToInt32(Console.ReadLine());
                nums.Add(sal);
            }

            for(int i = 0; i < nums.Count; i++)
            {
                if(nums[i] % 2 == 0 && nums[i] > 0){
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if(nums[i] % 2 == 0 && nums[i] < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if(nums[i] % 2 != 0 && nums[i] > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (nums[i] % 2 != 0 && nums[i] < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
