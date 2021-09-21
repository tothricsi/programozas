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
            harmadikfeladat();
            negyedikfeladat();
            otodikfeladat();
            hatodikfeladat(); 
            hetedikfeladat();
            nyolcadikfeladat();
            kilencedikfeladat();
            tizedikfeladat();
            tizenegyfeladat();

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
            if (szamok<16)
            {
                Console.WriteLine(szamok * 10  ); 
            }
            else
            {
                Console.WriteLine(szamok/3);
            }
        }
        static void hatodikfeladat()
        {
            Console.WriteLine("kerek egy szamot 10 es 50 kozott");
            int alma = int.Parse(Console.ReadLine());
            int ujszam = 0;
            ujszam = alma / 10;
            if(ujszam == 1)
            {
                Console.WriteLine("tizes");
            }
            else if (ujszam == 2)
            {
                Console.WriteLine("huszas");
            }
            else if (ujszam == 3)
            {
                Console.WriteLine("harmas");
            }
            else if (ujszam == 4)
            {
                Console.WriteLine("negyes");
            }
            else if (ujszam == 5)
            {
                Console.WriteLine("otos");
            }
            Console.ReadLine();
        }
        static void hetedikfeladat()
        {
            Console.WriteLine("kerek egy szamot");
            int bela = int.Parse(Console.ReadLine());
            if (12 < bela || bela< 25 && bela%2==0)
            {
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("nem pozitiv");
            }
            Console.ReadLine();
        }
        static void nyolcadikfeladat()
        {
            Console.WriteLine("kerek egy homersekletet");
            int kecskebelbolkeszultrantotthus = int.Parse(Console.ReadLine());
            if (kecskebelbolkeszultrantotthus < 0)
            {
                Console.WriteLine("halmazallapot: szilard");
            }
            else
            {
                Console.WriteLine("hamazallapot: folyadek");
            }
        }
        static void kilencedikfeladat()
        {
            Console.WriteLine("kerek egy szamot");
            int migraante = int.Parse(Console.ReadLine());
            if (migraante%3==0)
            {
                Console.WriteLine("oszthato 3 al");
            }
            else if (migraante%4==0)
            {
                Console.WriteLine("oszthato 4 el");
            }
            else
            {
                Console.WriteLine("oszthato 9 el");
            }
        }
        static void tizedikfeladat()
        {
            Console.WriteLine("kerek egy szamot");
            int h = int.Parse(Console.ReadLine());
            if (h%4==0)
            {
                Console.WriteLine("szokoev");
            }
        }
        static void tizenegyfeladat()
        {
            Console.WriteLine("kerek 3 szamot");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
        }
    
    }
}
