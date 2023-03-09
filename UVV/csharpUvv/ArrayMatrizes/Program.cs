using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMatrizes1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int [] numero = new int[3];
            /// Dessa forma eu coloco um inteiro dentro do vetor com ReadLine
            /// e utilizando o Parse um método aparentemente de objeto eu transformo a string
            /// em inteiro.
            for(byte i=0; i < numero.Length; i++)
            {
                int cache = int.Parse(Console.ReadLine());
                numero[i] = cache;
            }
            Console.WriteLine(numero);
            Console.ReadKey();*/

            //Forma interessante para inserir dados no array ao declara-lo.
            int[] numeros = new int[3] { 23, 39, 67 };
            int soma = 0;

            foreach (int k in numeros)
            {
                soma += k;
                Console.WriteLine(k);
            }
            Console.WriteLine(soma);
            Console.ReadKey();
        }
    }
}
