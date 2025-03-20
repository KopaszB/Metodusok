using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace osztalyok
{
    class Program
    {
        static void Main(string[] args)
        {
            int szam;
            Console.Write("szam = ");

            bool res = int.TryParse(Console.ReadLine(), out szam);
            Console.WriteLine(szam);

            //Console.WriteLine(res?$"{szam}":"Formátum hiba!");
            Console.ReadKey();
        }
    }
}
