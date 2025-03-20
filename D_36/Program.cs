using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_36
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> szamok = new List<int>();
            szamok = Listafeltolt(10);
            ListaKiir(szamok);
            HaromLegnagyobb(szamok);
            
            Console.ReadKey();
        }

        static void HaromLegnagyobb(List<int> lista)
        {
            lista.Sort();
            lista.Reverse();
            Console.WriteLine($"\nA lista három legnagyobb eleme: {lista[0]} {lista[1]} {lista[2]}");
        }

        static void ListaKiir(List<int> lista)
        {
            foreach (var item in lista) Console.Write(item + " ");
        }

        static List<int> Listafeltolt(int v)
        {
            List<int> lista = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < v; i++)
            {
                int vszam = rnd.Next(100, 200);
                lista.Add(vszam);
            }
            return lista;
        }
    }
}
