using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20210914
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
        }
        static void elsofeladat()
        {

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        static void masodikfeladat()
        {
            Console.WriteLine("hogy hivnak");
            string nev = Console.ReadLine();
            Console.WriteLine("szia {0}", nev);
        }
        static void harmadikfeladat()
        {
            Console.WriteLine("irj egy szamot");
            int szam = Console.Read();
            Console.WriteLine("a szam ketszerese: {0}", szam * 2);

        }
        static void negyedikfeladat()
        {
            Console.WriteLine("irj egy szamot");
            Console.WriteLine("irj meg egy szamot");
            int szam1 = Console.Read();
            int szam2 = Console.Read();
            Console.WriteLine("a ket szam osszegge: {0} ", szam1 + szam2);
            Console.WriteLine("a ket szam kulonbsege: {0}", szam1 - szam2);
            Console.WriteLine("a ket szam szorzata: {0}", szam1 * szam2);
            Console.WriteLine("a ket szam osszegge: {0}", szam1 / szam2);
            Console.WriteLine("a ket szam osszegge: {0}", szam1 % szam2);
        }
        static void otodikfeladat()
        {
            Console.WriteLine("negyzet A oldala");
            int A = Console.Read();
            Console.WriteLine("A szam negyzete: {0}", A * A);
            Console.WriteLine("A szam kerulete: {0}", A + A);
        }
        static void hatodikfeladat()
        {
            Console.WriteLine("kerem a teglalap 2 oldalat:");
            int a, b = Console.ReadLine();
            Console.WriteLine("A teglalap terulete: {0},{1}", a * b);
            Console.WriteLine("A teglalap kerulete: {0},{1}", a + a + b + b);
        }
        static void hetedikfeladat()
        {
            Console.WriteLine("add meg az elso egesz szamot");
            int a = Console.ReadLine();
            Console.WriteLine("add meg a masodik egesz szamot");
            int b = Console.ReadLine();
            if (a > b)
            {
                Console.WriteLine("a szam a {0} nagyobb mint b {1}", a, b);
            }
            else
            {
                Console.WriteLine("a szam b {0} nagyobb mint a {1}", b, a);
            }
        }
        static void nyolcadikfeladat()
        {
            Console.WriteLine("add meg az elso egesz szamot");
            int a = Console.ReadLine();
            Console.WriteLine("add meg a masodik egesz szamot");
            int b = Console.ReadLine();
            Console.WriteLine("add meg a harmadik egesz szamot");
            int c = Console.ReadLine();
            if (a < b & a < c)
            {
                Console.WriteLine("a szam a {0} kissebb mint b {1} es kissebb min c {2}", a, b, c);
            }
            if (b < a & b < c)
            {
                Console.WriteLine("a szam a {0} nagyobb mint b {1} es kissebb min c {2}", a, b, c);
            }
            else (c < a & c < b);
            {
                Console.WriteLine("a szam a {0} nagyobb mint b {1} es kissebb min c {2}", a, b, c);
            }
        }
        static void kilencedikfeladat()
        {
            Console.WriteLine("add meg az elso szamot");
            int a = Console.ReadLine();
            Console.WriteLine("add meg a masodik szamot");
            int b = Console.ReadLine();
            Console.WriteLine("add meg a harmadik szamot");
            int c = Console.ReadLine();
            if (a + b < c)
            {
                Console.WriteLine("a haromszog nem megvalosithato");
            }
            if (a + c < b)
            {
                Console.WriteLine("a haromszog nem megvalosithato");
            }
            else (b + c < a);
            {
                Console.WriteLine("a haromszog nem megvalosithato");
            }
        }
        static void tizedikfeladat()
        {
        }
    }
}
    

