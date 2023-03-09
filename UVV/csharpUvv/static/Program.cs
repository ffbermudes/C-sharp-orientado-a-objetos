using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace membroEstatico
{
    internal class Program
    {
        /// <summary>
        /// Classe para testar o funcionamento da variável estática count.
        /// </summary>
        class Pessoas{
            public static int count = 0;
            public Pessoas(){ 
            count++;
            }
        }
        static void Main(string[] args)
        {
            Pessoas p1 = new Pessoas(); //Tentei exibir pela instância de classe porém não foi possível.
            Console.WriteLine(Pessoas.count); // Esse contador só é exibido pela classe.
            Console.ReadKey();
            //Console.WriteLine(p1);
        }
    }
}
