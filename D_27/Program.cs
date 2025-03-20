using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_27
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> szamok = new List<int>();
                szamok = ListaBeker(5);
                Listakiir(szamok);
                ListaLegnagyobb(szamok);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }

        static void ListaLegnagyobb(List<int> lista)
        {
            int max = lista[0];
            for (int i = 1; i < lista.Count; i++)
            {
                if (lista[i] > max)
                {
                    max = lista[i];
                }
            }
            Console.WriteLine($"\nA lista legnagyobb eleme: {max}");
        }

        static void Listakiir(List<int> lista)
        {
            Console.WriteLine("A lista elemei:");
            foreach (var elem in lista) Console.Write(elem + " ");
        }

        static List<int> ListaBeker(int n)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i+1}. elem =");
                int szam = int.Parse(Console.ReadLine());
                lista.Add(szam);
            }
            return lista;
        }
    }
}
