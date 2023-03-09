using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace destructor
{
    internal class Program
    {
        class LatidoTete{
            public LatidoTete()
            {
                Console.WriteLine("TETE latiu!");
            }

            ~LatidoTete()
            {
                Console.WriteLine("TETE Correu!");
            }

        }

        static void Main(string[] args)
        {
            LatidoTete cachorro1 = new LatidoTete();
        }
    }
}
