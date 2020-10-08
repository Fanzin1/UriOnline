using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int hinicial, hfinal, minicial, mfinal, horas, minutos;

            string[] entrada = Console.ReadLine().Split(' ');
            hinicial = Convert.ToInt32(entrada[0]);
            minicial = Convert.ToInt32(entrada[1]);
            hfinal = Convert.ToInt32(entrada[2]);
            mfinal = Convert.ToInt32(entrada[3]);
            horas = 24;
            minutos = 60;

            if(hinicial > hfinal)
            {
                if(minicial > mfinal)
                {
                    horas = (horas - hinicial + hfinal) - 1;
                    minutos = minutos - minicial + mfinal;
                    Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
                }
                else if(minicial < mfinal)
                {
                    horas = (horas - hinicial + hinicial) - 1;
                    minutos = mfinal - minutos + minutos - minicial;
                    Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
                }
                else if(minicial == mfinal)
                {
                    horas = horas - hinicial + hinicial;
                    Console.WriteLine("O JOGO DUROU {0} HORA(S) E 0 MINUTO(S)", horas);
                }
            }
            else if(hinicial < hfinal)
            {
                if (minicial > mfinal)
                {
                    horas = (hfinal - horas + horas - hinicial) ;
                    minutos = minutos - minicial + mfinal;
                    if (minutos <= 59)
                    {
                        horas = horas - 1;
                        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)",horas ,minutos);
                    }
                    else
                    {
                        Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
                    }


                }
                else if (minicial < mfinal)
                {
                    horas = hfinal - horas + horas - hinicial;
                    minutos = mfinal - minutos + minutos - minicial;
                    Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
                }
                else if (minicial == mfinal)
                {
                    horas = hfinal - horas + horas - hinicial;
                    Console.WriteLine("O JOGO DUROU {0} HORA(S) E 0 MINUTO(S)", horas);
                }
            }
            else if(hinicial == hfinal)
            {
                if (minicial > mfinal)
                {
                    horas = hfinal - horas + horas - hinicial;
                    minutos = minutos - minicial + mfinal;
                    Console.WriteLine("O JOGO DUROU 23 HORA(S) E {0} MINUTO(S)", minutos);
                }
                else if (minicial < mfinal)
                {
                    horas = hfinal - horas + horas - hinicial;
                    minutos = mfinal - minutos + minutos - minicial;
                    Console.WriteLine("O JOGO DUROU {0} HORA(S) E {1} MINUTO(S)", horas, minutos);
                }
                else if (minicial == mfinal)
                {
                    horas = hfinal - horas + horas - hinicial;
                    Console.WriteLine("O JOGO DUROU 24 HORA(S) E 0 MINUTO(S)", horas);
                }
            }

        }
    }
}
