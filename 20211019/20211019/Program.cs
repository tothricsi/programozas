using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211019
{
    class Program
    {
        static void Main(string[] args)
        {
            elsofeladat();
            masodikfeladat();
            harmadikfeladat();
            negyedikfeladat();

            Console.ReadLine();
        }
        static void elsofeladat() {
            Console.WriteLine("kerem az A hosszát:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("kerem a B hosszát:");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("kerem a C hosszát:");
            int c = int.Parse(Console.ReadLine());
            Console.Write("V=");
            Console.WriteLine(a*b*c);
            Console.Write("A=");
            Console.WriteLine(2*a*b + 2*a*c + 2*b*c);
           
            Console.ReadLine();
        }
        static void masodikfeladat() {
            Console.WriteLine("kerek egy szamot 1-tol 7-ig");
            int szam = int.Parse(Console.ReadLine());
            if (szam == 1)
            {
                Console.WriteLine( "1 - hetfo");
            }
            if (szam == 2)
            {
                Console.WriteLine("2 - kedd");
            }
            if (szam == 3)
            {
                Console.WriteLine("3 - szerda");
            }
            if (szam == 4)
            {
                Console.WriteLine("4 - csutortok");
            }
            if (szam == 5)
            {
                Console.WriteLine("5 - pentek");
            }
            if (szam == 6)
            {
                Console.WriteLine("6 - szombat");
            }
            if (szam == 7)
            {
                Console.WriteLine("7 - vasarnap");
            }
            if (szam < 1 || szam > 7)
            {
                    Console.WriteLine("a szam nem jo");
            }
          
        }
        static void harmadikfeladat() {
            Console.WriteLine("kerek egy szamot");
            int szam = int.Parse(Console.ReadLine()); ;
            if (szam >-50 && szam < 70)
            {
                Console.WriteLine("a szam -50 es 70 kozott van ");
            }
            else
            {
                Console.WriteLine("a szam nem -50 es 70 kozott van ");
            }
        }
        static void negyedikfeladat() {
            for (int i = 120; i > 39; i=i-15)
            {
                Console.WriteLine(i);
            }
        }
        static void otodikfeladat() {

        }
    }
}
