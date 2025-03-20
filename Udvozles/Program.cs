using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udvozles
{
    class Program
    {
        static void UdvozlesKiir(string nev)
        {
            Console.WriteLine($"Helló, {nev}!");
        }
        static void Main(string[] args)
        {
            
            UdvozlesKiir("Dani");

            Console.ReadKey();
        }
    }
}
