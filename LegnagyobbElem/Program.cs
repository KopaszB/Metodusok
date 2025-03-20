using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegnagyobbElem
{
    class Program
    {
        static int[] TombFeltolt(int n)
        {
            Console.WriteLine("Add meg a tömb elemeit!");
            int[] tomb = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{i + 1}. elem = ");
                tomb[i] = int.Parse(Console.ReadLine());

            }
            return tomb;
        }
        static int Legnagyobb(int[] tomb)
        {
            int maximum = tomb[0];
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]>maximum)
                {
                    maximum = tomb[i];
                }
            }
            return maximum;
        }
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Hány elemű legyen a tömb: ");
                int n = int.Parse(Console.ReadLine());
                int[] szamok = TombFeltolt(n);
                Console.WriteLine($"A legnagyobb elem: {Legnagyobb(szamok)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Hiba! {ex.Message}");
            }
            Console.ReadKey();
        }
    }
}
