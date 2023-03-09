using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatrizes2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] minhaMatriz = new int[3, 4];
            int valor = 0;
            int[,] colocaValoresNaMatriz()
            {
                for (int i = 0; i < 3; i++)
                {
                    for(int c=0; c<4; c++)
                    {
                        minhaMatriz[i, c] = valor;
                    }
                        valor++;
                }
                return minhaMatriz;
            }
            int[,] Matriz = colocaValoresNaMatriz();

            /// 

            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(Matriz[i, c]);
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
