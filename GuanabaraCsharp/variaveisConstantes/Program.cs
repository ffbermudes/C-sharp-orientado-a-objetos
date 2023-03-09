using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variaveisConstantes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float numeroDecimal = 2.3f;
            const string nome = "Filipe Freitas";
            Console.Write(nome + " " + System.Math.PI.GetType());
            Console.Write(numeroDecimal.GetType());
            Console.ReadKey();
        }
    }
}
