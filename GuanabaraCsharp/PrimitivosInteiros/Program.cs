using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPrimitivos
{
    internal class Program
    {
        static void Main(string[] args)
        {                               //tipos primitivos para números inteiros
            Console.WriteLine("O tipo byte vai de " + byte.MinValue + " até " + byte.MaxValue + "\n");
            // de 0 até 255
            Console.WriteLine("O tipo sbyte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue + "\n");
            // de -128 até 127
            Console.Write("------------------------------------------------\n");
            Console.WriteLine("O tipo short vai de " + short.MinValue + " até " + short.MaxValue + "\n");
            // de -32758 até 32767
            Console.WriteLine("O tipo ushort vai de " + ushort.MinValue + " até " + ushort.MaxValue + "\n");
            // de 0 até 65535
            Console.Write("------------------------------------------------\n");
            Console.WriteLine("O tipo int vai de " + int.MinValue + " até " + int.MaxValue + "\n");
            // de -2147483648 até 2147483647
            Console.WriteLine("O tipo uint vai de " + uint.MinValue + " até " + uint.MaxValue + "\n");
            // 0 até 4294967295
            Console.Write("------------------------------------------------\n");
            Console.WriteLine("O tipo long vai de " + long.MinValue + " até " + long.MaxValue + "\n");
            // -9223372036854775808 até 9223372036854775807
            Console.WriteLine("O tipo ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue + "\n");
            // O tipo ulong vai de 0 até 18446744073709551615
            Console.ReadKey();
        }
    }
}
