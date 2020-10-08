using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int DI, HI, MI, SI, DF, HF, MF, SF, S, M, H, D;

            string[] entradaDia = Console.ReadLine().Split(' ');
            DI = Convert.ToInt32(entradaDia[1]);
            string[] entradaHora = Console.ReadLine().Split(' ');
            HI = Convert.ToInt32(entradaHora[0]);
            MI = Convert.ToInt32(entradaHora[2]);
            SI = Convert.ToInt32(entradaHora[4]);
            string[] entradaDiaF = Console.ReadLine().Split(' ');
            DF = Convert.ToInt32(entradaDiaF[1]);
            string[] entradaHoraF = Console.ReadLine().Split(' ');
            HF = Convert.ToInt32(entradaHoraF[0]);
            MF = Convert.ToInt32(entradaHoraF[2]);
            SF = Convert.ToInt32(entradaHoraF[4]);

            if(DI < DF) {
                if (SI < SF || SI == SF)
                {
                    S = SF - 60 + 60 - SI;
                    if(MI < MF || MI == MF)
                    {
                        M = MF - 60 + 60 - MI;
                        if (HI < HF || HI == HF)
                        {
                            H = HF - 24 + 24 - HI;
                        }

                        else
                        {
                            H = 24 - HI + HF;
                        }
                    }
                    else
                    {
                        M = 60 - MI + MF;
                        if (HI < HF || HI == HF)
                        {
                            H = HF - 24 + 24 - HI;
                        }

                        else
                        {
                            H = 24 - HI + HF;
                        }
                    }
                }

                else
                {
                    S = 60 - SI + SF;
                    if (MI < MF || MI == MF)
                    {
                        M = MF - 60 + 60 - MI;
                        if (HI < HF || HI == HF)
                        {
                            H = HF - 24 + 24 - HI;
                        }

                        else
                        {
                            H = 24 - HI + HF;
                        }
                    }

                    else
                    {
                        M = 60 - MI + MF;
                        if (HI < HF || HI == HF)
                        {
                            H = HF - 24 + 24 - HI;
                        }

                        else
                        {
                            H = 24 - HI + HF;
                        }
                    }             
                }
                D = DF - DI;
                if (HF < HI)
                {
                    D = D - 1;
                }
                if(MI == MF && SI > SF)
                {
                    H = H - 1;
                    MF = MF + 1;
                    M = 60 - MF + MI;
                }
                else if(HF - HI == 1 && MI > MF)
                {
                    if (MI - MF <= 2 && SI > SF)
                    {
                        M = M - 1;
                    }
                    H = H - 1;
                }
                else if(HI == HF && MF < MI && SF < SI)
                {
                    D = D - 1;
                    HF = HF + 1;
                    H = 24 - HF + HI;
                    M = M - 1;
                }
                else if (SI > SF)
                {
                    if(HF > HI && MI > MF && H > 1 || HI > HF && MI > MF && H > 1)
                    {
                        H = H - 1;
                    }
                    M = M - 1;
                }
                else if(HF < HI && MF < MI && H > 0)
                {
                    H = H - 1;
                }
                else if (MF < MI && SF < SI)
                {
                    M = M - 1;
                }
                else if(DF - DI == 1 && HI == HF && MI > MF)
                {
                    D = 0;
                    H = 23;
                }
                Console.WriteLine($"{D} dia(s)");
                Console.WriteLine($"{H} hora(s)");
                Console.WriteLine($"{M} minuto(s)");
                Console.WriteLine($"{S} segundo(s)");
            }

            else
            {
                if (SI < SF || SI == SF)
                {
                    S = SF - 60 + 60 - SI;
                    if (MI < MF || MI == MF)
                    {
                        M = MF - 60 + 60 - MI;
                        if (HI < HF || HI == HF)
                        {
                            H = HF - 24 + 24 - HI;
                        }

                        else
                        {
                            H = 24 - HI + HF;
                        }
                    }
                    else
                    {
                        M = 60 - MI + MF;
                        if (HI < HF || HI == HF)
                        {
                            H = HF - 24 + 24 - HI;
                        }

                        else
                        {
                            H = 24 - HI + HF;
                        }
                    }
                }

                else
                {
                    S = 60 - SI + SF;
                    if (MI < MF || MI == MF)
                    {
                        M = MF - 60 + 60 - MI;
                        if (HI < HF || HI == HF)
                        {
                            H = HF - 24 + 24 - HI;
                        }

                        else
                        {
                            H = 24 - HI + HF;
                        }
                    }

                    else
                    {
                        M = 60 - MI + MF;
                        if (HI < HF || HI == HF)
                        {
                            H = HF - 24 + 24 - HI;
                        }

                        else
                        {
                            H = 24 - HI + HF;
                        }
                    }
                }
                D = DF - DI;
                if (HF < HI)
                {
                    D = D - 1;
                }
                if (MI == MF && SI > SF)
                {
                    H = H - 1;
                    MF = MF + 1;
                    M = 60 - MF + MI;
                }
                else if (HF - HI == 1 && MI > MF)
                {
                    if (MI - MF <= 2 && SI > SF)
                    {
                        M = M - 1;
                    }
                    H = H - 1;
                }
                else if (HI == HF && MF < MI && SF < SI)
                {
                    D = D - 1;
                    HF = HF + 1;
                    H = 24 - HF + HI;
                    M = M - 1;
                }
                else if (SI > SF)
                {
                    if (HF > HI && MI > MF && H > 1 || HI > HF && MI > MF && H > 1)
                    {
                        H = H - 1;
                    }
                    M = M - 1;
                }
                else if (HF < HI && MF < MI && H > 0)
                {
                    H = H - 1;
                }
                else if (MF < MI && SF < SI)
                {
                    M = M - 1;
                }
                else if (DF - DI == 1 && HI == HF && MI > MF)
                {
                    D = 0;
                    H = 23;
                }

                Console.WriteLine($"{D} dia(s)");
                Console.WriteLine($"{H} hora(s)");
                Console.WriteLine($"{M} minuto(s)");
                Console.WriteLine($"{S} segundo(s)");

            }
        }
    }
}
