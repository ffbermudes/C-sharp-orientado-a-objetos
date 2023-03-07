using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveisCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte n = 255; // valor máximo do tipo primitivo byte
            /*byte n2 = 256;*/ // gera erro ultrapassa a quantidade de mémoria disponível.
            short n3 = 257; // Acima de 255 tem que ser utilizado SHORT.
            Console.WriteLine("A Variável n3 {0} ocupa" + n3.GetType());
            Console.WriteLine("A Variável n3 {0} ocupa" + n3);
            Console.ReadKey();
        }
    }
}
