using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Mascota miPerrito = new Mascota(1432456789764531);
            miPerrito.Nombre = "Cachupin";

            Console.WriteLine("Mi mascota se llama " + miPerrito.Nombre);
            Console.WriteLine("Su código es: " + miPerrito.Codigo);

            Console.ReadKey();
        }
    }
}
