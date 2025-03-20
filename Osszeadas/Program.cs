using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Osszeadas
{
    class Program
    {
        static int Osszead(int a, int b) 
        {
            return a+b;
        }
        static string Megfordit(string szoveg)
        {
            
            return new string(szoveg.Reverse().ToArray());
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine(Osszead(5, 5));
            Console.WriteLine(Kivon(4,2));
            Console.WriteLine(Megfordit("Gézakékazég")); 
            Console.ReadKey();
        }

        private static int Kivon(int a, int b)
        {
            return a-b;
        }
    }
}
