using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FaktorialisSzamit
{
    class Program
    {
        static long Faktorialis(int szam)
        {
            long fact = 1;
            for (int i = 1; i <= szam; i++)
            {
                fact *= i; 
            }
            return fact;
        }
        static void Main(string[] args)
        {
            Console.Write("kérek egy számot: ");
            int szam = int.Parse(Console.ReadLine());
            Console.WriteLine($"{szam}! = {Faktorialis(szam)}");

            Console.ReadKey();
        }
    }
}
