using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatrizes3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Matriz bidimensional de 4 linhas e 3 colunas.
            //int[,] matrizBi = new int[4,3] { { 1, 2, 3 }, { 1, 2, 3 }, {7, 6, 5 }, {10, 11 ,32 } };
            int[,] matrizBinaria = new int[4, 3];

            matrizBinaria[0, 2] = 66;
            matrizBinaria[3, 2] = 555;
            matrizBinaria[3, 0] = 555;
            matrizBinaria[3, 1] = 666;



            /*
             1 2 3
             1 2 3
             7 6 5
             10 11 32
             */

            for (int i = 0; i < 4; i++)
            {
                for(int c=0; c<3;c++){
                    Console.Write(matrizBinaria[i,c] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
