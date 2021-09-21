using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20210921
{
    class Program
    {
        static void Main(string[] args)
        {
            elsofeladat();
            masodikfeladat();

            
            }
                static void elsofeladat()
        {
            Console.WriteLine("kerek egy szamot:");
            int szam = int.Parse( Console.ReadLine());
            if (szam % 2 == 0)
            {
                Console.WriteLine("paros a szam");
            }
            else
            {
                Console.WriteLine("paratlan a szam");
            }
            Console.ReadLine();
        }
                static void masodikfeladat()
            {
            Console.WriteLine("kerek egy szamot:");
            int a = int.Parse(Console.ReadLine());
            if (a < 0)
            {
                Console.WriteLine("szam negativ");
            }
            else
            {
                Console.WriteLine("a szam pozitiv");
            }
             }
        static void harmadikfeladat()
        {
            Console.WriteLine("kerem a homersekletet:");
            int fok = int.Parse(Console.ReadLine());
            if (fok < 0)
            {
                Console.WriteLine("fagy van kint"); 
            }
            else
            {
                Console.WriteLine("nincs fagy kint");
            }
        }
        static void negyedikfeladat()
        {
            Console.WriteLine("kerek egy szamot");
            int kozott = int.Parse(Console.ReadLine());
            if (-30 < kozott ||  kozott < 40)
            {
                Console.WriteLine("a szam -30 es 40 kozott van");
            }
            else
            {
                Console.WriteLine("a szam nem -30 es 40 kozott van");
            }
        }
        static void otodikfeladat()
        {
            Console.WriteLine("kerek egy szamot:");
            int szamok = int.Parse(Console.ReadLine());
            if (szamok<)
            {

            }
        }
    }
}
