using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaAlapok
{
    class ListaAlapok
    {
        static void Main()
        {
            int db, min, max;
            List<int> Lista1;
            List<int> Lista2;


            Console.Write("Add meg a lista darabszámát: ");
            db = int.Parse(Console.ReadLine());
            Console.Write("Add meg a generálás alsó értékét: ");
            min = int.Parse(Console.ReadLine());
            Console.Write("Add meg a generálás felső értékét: ");
            max = int.Parse(Console.ReadLine());

            Lista1 = ListaFeltolt(db, min, max);
            ListaKiir(Lista1);
            Lista2 = ListaBeolvas(min, max);
            ListaKiir(Lista2);

            Console.WriteLine("\nAz első lista elemei füzérben: ");
            Console.WriteLine(string.Join("; ", Lista1));
        }
        static List<int> ListaFeltolt(int n, int also, int felso)
        {
            List<int> szamok = new List<int>();
            Random rnd = new Random();
            int i, ujszam, csere;
            
            if (also>felso)
            {
                csere = also;
                also = felso;
                felso = csere;
            }
            
            for (i = 0; i < n; i++)
            {
                ujszam = rnd.Next(also, felso + 1);
                szamok.Add(ujszam);
            }
            return szamok;
        }
        static void ListaKiir(List<int> szamok)
        {
            int i;
            Console.WriteLine();
            Console.WriteLine("A lista elemei:");
            for (i = 0; i < szamok.Count; i++)
            {
                Console.Write(szamok[i] + "  ");

            }

        }
        static List<int> ListaBeolvas(int also, int felso)
        {
            List<int> szamok = new List<int>();
            int i = 0, ujszam;

            Console.WriteLine("Kérem a lista elemeit a megadott intervallumból: ");
            Console.Write("0. elem = ");
            ujszam = int.Parse(Console.ReadLine());
            while (ujszam <= felso && ujszam >= also)
            {
                szamok.Add(ujszam);
                i++;
                Console.Write(i + ". elem = ");
                ujszam = int.Parse(Console.ReadLine());

            }
            return szamok;
        }
    }
}
