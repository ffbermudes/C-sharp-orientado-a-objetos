using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace conversoesTipo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /// Conversão Implicita
            /// Conversão explícita (typecast)
            /// Conversão por classes auxiliares

            //IMPLICITA
                int a =  7;
                float b = a;
            // b vai valer 7.0 FUNCIONA. Porém o contrário não funciona.
            //EXPLÍCITA
                float num1 = 8.9f;
                int num2 = (int)num1;
            //vai sair 8 no terminal
            //CLASSES AUXILIARES
                float num3 = 8.7f;
                int num4 = Convert.ToInt16(num3); // Retorna 9.
                Console.WriteLine(num4);
                Console.ReadKey();
            //A classe Convert.ToInt16(); Vai arredondar e trazer uma inteligência.
        }

    }
}
