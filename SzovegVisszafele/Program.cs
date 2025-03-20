using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SzovegVisszafele
{
    class Program
    {
        static void Main(string[] args)
        {
            string szoveg = Console.ReadLine();
            Console.WriteLine(ForditottSzoveg(szoveg));
            Console.ReadKey();
        }

        private static string ForditottSzoveg(string szoveg)
        {
            return new string(szoveg.Reverse().ToArray());
        }
    }
}
