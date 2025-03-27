using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_35
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            szamok = Listafeltolt(10);
            ListaKiir(szamok);
            double avg = Atlag(szamok);
            Console.WriteLine("\nÁtlag: " + avg + "\n");
            NagyobMintAtlag(szamok,avg);
            Console.ReadKey();
        }

        static void NagyobMintAtlag(List<int> lista, double atlag)
        {
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i] > atlag)
                {
                    Console.Write(lista[i] + " ");
                }
            }
        }

        static double Atlag(List<int> lista)
        {
            return lista.Average();
        }

        /*static void AtlagNagyobb(List<int> lista)
        {
            double osszeg = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                osszeg += lista[i];
            }
            double atlag = osszeg / lista.Count;
            Console.WriteLine("\nÁtlag: " + atlag);
            Console.Write("A lista átlag fölötti elemei: ");
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i]>atlag)
                {
                    Console.Write(lista[i] + " ");
                }
            }
        }*/

        static void ListaKiir(List<int> lista)
        {
            foreach (var item in lista) Console.Write(item + " ");
           
        }

        static List<int> Listafeltolt(int n)
        {
            //List<int> lista = new List<int>();
            Random rnd = new Random();
            var lista = Enumerable.Range(0, n).Select(_ => rnd.Next(1, 101)).ToList();
            /*
            for (int i = 0; i < n; i++)
            {
                int vszam = rnd.Next(1,101);
                lista.Add(vszam);
            }
            */
            return lista;
        }
    }
}
