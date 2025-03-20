using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MelyikNagyobb
{
    class Program
    {
        static string Maximum(int a, int b)
        {
            if (a==b) return "A két szám egyenlő";
            else if (a>b) return $"{a} a nagyobb";
            else return $"{b} a nagyobb";
        }
        /*
        static int Maximum(int a, int b)
        {
            int max;
            if (a>b)
            {
                max = a;
            }
            else
            {
                max = b;
            }
            return max;
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Adj meg két számot!");
            Console.Write("a = ");
            int szam1 = int.Parse(Console.ReadLine());
            Console.Write("a = ");
            int szam2 = int.Parse(Console.ReadLine());
            Console.WriteLine(Maximum(szam1,szam2));
            /*
            if (szam1==szam2)
            {
                Console.WriteLine("A két szám egyenlő!");
            }
            else
            {
                Console.WriteLine($"A {Maximum(szam1, szam2)} a nagyobb.");
            }
            */
            Console.ReadKey();
        }
    }
}
