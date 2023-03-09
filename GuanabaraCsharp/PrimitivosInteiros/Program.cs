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
            Console.Write("NUMEROS INTEIROS\n");
            Console.WriteLine("O tipo byte vai de " + byte.MinValue + " até " + byte.MaxValue + "\n");
            // de 0 até 255 || Usa 1 byte (8 bits)
            Console.WriteLine("O tipo sbyte vai de " + sbyte.MinValue + " até " + sbyte.MaxValue + "\n");
            // de -128 até 127 || Usa 1 byte (8 bits)

            Console.Write("------------------------------------------------\n");
            Console.WriteLine("O tipo short vai de " + short.MinValue + " até " + short.MaxValue + "\n");
            // de -32758 até 32767 || Usa 2 byte (16 bits)
            Console.WriteLine("O tipo ushort vai de " + ushort.MinValue + " até " + ushort.MaxValue + "\n");
            // de 0 até 65535 || Usa 2 byte (16 bits)

            Console.Write("------------------------------------------------\n");
            Console.WriteLine("O tipo int vai de " + int.MinValue + " até " + int.MaxValue + "\n");
            // de -2147483648 até 2147483647 || Usa 4 bytes (32 bits)
            Console.WriteLine("O tipo uint vai de " + uint.MinValue + " até " + uint.MaxValue + "\n");
            // 0 até 4294967295 || Usa 4 bytes (32 bits)

            Console.Write("------------------------------------------------\n");
            Console.WriteLine("O tipo long vai de " + long.MinValue + " até " + long.MaxValue + "\n");
            // -9223372036854775808 até 9223372036854775807 || Usa 8 bytes (128 bits)
            Console.WriteLine("O tipo ulong vai de " + ulong.MinValue + " até " + ulong.MaxValue + "\n");
            // O tipo ulong vai de 0 até 18446744073709551615 || Usa 8 bytes (128 bits)

            Console.Write("NUMEROS REAIS\n");
            Console.WriteLine("O tipo float vai de " + float.MinValue + " até " + float.MaxValue + "\n");
            // -3,402823E+38 até 3,402823E+38 || Usa 4 bytes (32 bits)
            Console.WriteLine("O tipo double vai de " + double.MinValue + " até " + double.MaxValue + "\n");
            // -1,79769313486232E+308 até 1,79769313486232E+308 || Usa 8 bytes (64 bits)
            Console.WriteLine("O tipo decimal vai de " + decimal.MinValue + " até " + decimal.MaxValue + "\n");
            // -79228162514264337593543950335 até 79228162514264337593543950335 || Usa 16 bytes (128 bits)

            Console.WriteLine("O tipo bool tem dois valores " + bool.FalseString + " e " + bool.TrueString + "\n");
            // True e False || Usa 1 bit
            Console.ReadKey();
        }
    }
}
