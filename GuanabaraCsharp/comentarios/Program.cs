using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace modulo1
{
    internal class Program
    {
        /// <summary>
        /// Calculadora é uma classe teste.
        /// Esse comentário é para aprender utilizar o comentário com 3 barras.
        /// </summary>
        class Calculadora
        {/*Comentário
          * com 
          * quebra
          * de
          * linhas
          */

            /// <summary>
            /// Função de soma de dois números inteiros.
            /// </summary>
            /// 
            /// <param name="num1">
            ///     input do primeiro número da soma. 
            /// </param>
            /// 
            /// <param name="num3">
            ///     input do segundo número da soma.    
            /// </param>
            /// 
            /// <returns>
            ///     retorna um número inteiro da soma.
            /// </returns>
            public int SomaInt(int num1, int num3)
            {
                return num1 + num3;
            }
        }

        static void Main(string[] args)
        {
            Calculadora Calc = new Calculadora();
            int resultado = Calc.SomaInt(2, 3);
            Console.WriteLine(resultado);
            Console.ReadKey();
            //Console.ReadKey();
            //comentário de uma linha muito bom para poder desativar algum código. Também funciona no visual studio o comando ctrl + k + [uc]
            // CTRL + E, W faz wrap quebra de linha.
        }
    }
}
