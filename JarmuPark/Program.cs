using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JarmuPark
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Auto lada = new Auto("piros", "Lada 2112", 11);
            Auto trabant = new Auto("zöld", "Trabant 1.1", 8);

            lada.Tankol(20);
            trabant.Tankol(20);

            lada.Allapot();
            trabant.Allapot();

            Console.Write("Mennyit megy a lada: ");
            int km = int.Parse(Console.ReadLine());
            lada.Megy(km);
            Console.WriteLine($"Maradt: {lada.UZEMANYAG} l - ({lada.MEGTEHETOKM} km)");
            Console.ReadKey();
        }
    }
}
