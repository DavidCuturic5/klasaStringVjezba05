using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaStringVjezba05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedan cijeli i jedan decimalni broj odvojeni razmakom:");

            string unos = Console.ReadLine();

            string[] brojevi=unos.Split(' ');
            int cijeli=int.Parse(brojevi[0]);
            double decimalni=double.Parse(brojevi[1]);

            int x = cijeli * 2;
            double y = decimalni * 2;

            Console.WriteLine($"Dvostruke vrijednosti unešenih brojeva su: {x} i {y}" );
            Console.ReadKey(); 
        }
    }
}
