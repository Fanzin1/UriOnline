using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string e1, e2, e3;

            e1 = Console.ReadLine();
            e2 = Console.ReadLine();
            e3 = Console.ReadLine();

            if(e1 == "vertebrado")
            {
                if(e2 == "ave")
                {
                    if(e3 == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    
                    else if(e3 == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                
                else if(e2 == "mamifero")
                {
                    if(e3 == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }

                    else if(e3 == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }

            else if(e1 == "invertebrado")
            {
                if(e2 == "inseto")
                {
                    if(e3 == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }

                    else if(e3 == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }

                else if(e2 == "anelideo")
                {
                    if (e3 == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }

                    else if (e3 == "onivoro") 
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}
