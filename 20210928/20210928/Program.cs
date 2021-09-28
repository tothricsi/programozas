using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20210928
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
           tizenegyedikfeladat();
           tizenkettedikfeladat();
           tizenharmadikfeladat();
           tizennegyedikfeladat();
           tizenotodikfeladat();
           tizenhatodikfeladat();
            }
        static void elsofeladat() {
            for (int i = 1; i < 21; i++)
            {
                Console.Write(i);
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void masodikfeladat() {
            for (int i = 15; i < 93; i++)
            {
                Console.Write(i);
            }
            Console.ReadLine();
        }
        static void harmadikfeladat() {
            for (int i = 2; i < 31 ; i= i+2)
            {
                Console.Write(i);
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void negyedikfeladat() {
            Console.WriteLine("kerek egy szamot");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 0; i < szam; i= i+2)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();

        }
        static void otodikfeladat() {
            Console.WriteLine("kerek egy szamot");
            int szam = int.Parse(Console.ReadLine());
            for (int i = 0; i < szam; i = i + 2)
            {
                Console.Write(i);
            }
            Console.ReadLine();

        }
        static void hatodikfeladat() {
            for (int i = 0; i < 16; i++ )
            {
                Console.WriteLine(Math.Pow(i,2));
            }
            Console.ReadLine();
        }
        static void hetedikfeladat() {
            for (int i = 100; i < 401; i= i+4)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void nyolcadikfeladat() {
            for (int i = 30; i < 101; i= i+9)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void kilencedikfeladat() {
            for (int i = 150; i > 39 ; i= i-12)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        } 
        static void tizedikfeladat() {
            for (int i =99; i > -101; i= i-9)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void tizenegyedikfeladat() {
            for (int i = -30; i < 31; i= i+5)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void tizenkettedikfeladat() {
            for (int i = 3; i < 52; i= i+3)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void tizenharmadikfeladat() {
            for (int i = 2; i < 16; i++)
            {
                Console.WriteLine(Math.Pow(i,2));
            }
            Console.ReadLine();
        }
        static void tizennegyedikfeladat() {
            for (int i = 0; i < 25; i++)
            {
                int szam = i * 7;
                if (szam%4==0)
                {
                        Console.WriteLine();
                }
                Console.ReadLine();
                
            }
        }
        static void tizenotodikfeladat() {
            int szam = 144;
            int oszto = 1;
            bool igaz = true;
            while (igaz)
            {
                if (szam%oszto==0)
                {
                    Console.WriteLine(oszto);
                }
                else if (oszto>szam+1)
                {
                    igaz = false;
                }
                oszto += 1;
            }
            Console.ReadLine();

        }
        static void tizenhatodikfeladat() {
            Console.WriteLine("kerek egy szamot");
            int szam = int.Parse(Console.ReadLine());
            int oszto = 1;
            bool igaz = true;
            while (igaz)
            {
                if (szam % oszto == 0)
                {
                    Console.WriteLine(oszto);
                }
                else if (oszto > szam + 1)
                {
                    igaz = false;
                }
                oszto += 1;
            }
            Console.ReadLine();
        }
    }
}
