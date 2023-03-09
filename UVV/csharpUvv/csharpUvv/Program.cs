using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{

    internal class Program
    {
        class Pessoa
        {   private string nome;
            public Pessoa(string x)
            {
                nome = x;
            Console.WriteLine(this.nome);
            Console.ReadKey();
            }
        }
        static void Main(string[] args)
        {
            Pessoa p1 = new Pessoa("Filipe");
        }
    }
}
