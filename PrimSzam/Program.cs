using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimSzam
{
    class Program
    {
        static bool PrimE(int szam)
        {
            int osztokSzama = 0;
            for (int i = 1; i <= szam; i++)
            {
                if (szam%i==0) osztokSzama++;
            }
            if (osztokSzama == 2) return true;
            else return false;
        }
        static void Main(string[] args)
        {
            Console.Write("Adj meg egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            /*
            if (PrimE(szam))
            {
                Console.WriteLine("Prímszám");
            }
            else
            {
                Console.WriteLine("Nem prímszám");
            }
            */
            Console.WriteLine(PrimE(szam)? "Prímszám":"Nem prímszám");

            Console.ReadKey();
        }
    }
}
