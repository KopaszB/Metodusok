using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_37
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            szamok = ListaFeltolt(30);
            ListaKiir(szamok);
            NegativElemek(szamok);
            PozitivElemek(szamok);
            NullElemek(szamok);

            Console.ReadKey();
        }

        private static void NullElemek(List<int> lista)
        {
            int dbNull = 0;
            foreach (var elem in lista)
            {
                if (elem == 0)
                {
                    dbNull++;
                }
            }
            Console.WriteLine($"Nullák száma: {dbNull}");
        }

        private static void PozitivElemek(List<int> lista)
        {
            int dbPoz = 0;
            foreach (var elem in lista)
            {
                if (elem > 0)
                {
                    dbPoz++;
                }
            }
            Console.WriteLine($"Pozitív számok száma: {dbPoz}");
        }

        static void NegativElemek(List<int> lista)
        {
            int dbNeg = 0;
            foreach (var elem in lista)
            {
                if (elem<0)
                {
                    dbNeg++;
                }
            }
            Console.WriteLine($"Negatív számok száma: {dbNeg}");
        }

        static void ListaKiir(List<int> lista)
        {
            Console.WriteLine("A lista elemei:" + string.Join(" ",lista));
        }

        static List<int> ListaFeltolt(int n)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < n; i++)
            {
                lista.Add(rnd.Next(-50,50));
            }
            return lista;
        }
    }
}
