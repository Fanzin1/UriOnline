﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1059
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 2; i < 102; i++)
            {
                if(i % 2 == 0){
                    Console.WriteLine(i);
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
