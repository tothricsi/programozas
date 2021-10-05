using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211005
{
    class Program
    {
        static void Main(string[] args)
        {
            elso();
            //masodik();
            //harmadik();
            //negyedik();
            //otodik();
            hatodik();
            hetedik();
            nyolcadik();
            kilencedik();
            tizedik();
        }
        static void elso() {
           
        }
        static void masodik() {
            int a = 2;
            int b = 3;
            int c = 5;
            Console.WriteLine(a*b*c);
            a = a + 1;
            b = b + 2;
            c = c + 3;
            Console.WriteLine(a*b*c);
            a = a + 1;
            b = b + 2;
            c = c + 3;
            Console.WriteLine(a * b * c);
            a = a + 1;
            b = b + 2;
            c = c + 3;
            Console.WriteLine(a * b * c);
            a = a + 1;
            b = b + 2;
            c = c + 3;
            Console.WriteLine(a * b * c);
            a = a + 1;
            b = b + 2;
            c = c + 3;
            Console.WriteLine(a * b * c);
            Console.ReadLine();
        }
        static void harmadik() {
            int szam = 5;
            Console.WriteLine(szam);
            szam = szam + 2;
            Console.WriteLine(szam);
            szam = szam + 2;
            Console.WriteLine(szam);
            szam = szam + 2;
            Console.WriteLine(szam);
            szam = szam + 2;
            Console.WriteLine(szam);
            szam = szam + 2;
            Console.WriteLine(szam);
            szam = szam + 2;
            Console.WriteLine(szam);
            szam = szam + 2;
            Console.WriteLine(szam);
            szam = szam + 2;
            Console.WriteLine(szam);
            szam = szam + 2;
            Console.WriteLine(szam);
            Console.ReadLine();

        }
        static void negyedik() {
            Console.WriteLine("kerek egy szamot");
            int szam = int.Parse(Console.ReadLine());
            while (szam != 0)
            {
                Console.WriteLine("Kerek egy szamot");
                szam = int.Parse(Console.ReadLine());
            }
            
        }
        static void otodik() {
            Console.WriteLine("kerek egy szamot");
            int szam = int.Parse(Console.ReadLine());
            while (szam % 2 == 1)
            {
                Console.WriteLine("nem paros");
                szam = int.Parse(Console.ReadLine());
            }
        }
        static void hatodik() {
            List<int> alma = new List<int>();
            Console.WriteLine("kerek egy szamot");
            int szam = int.Parse(Console.ReadLine());
            while (szam > 10)
            {
                Console.WriteLine("a szam nagyobb mint 10");
                szam = int.Parse(Console.ReadLine());
            }
        }
        static void hetedik() {
            Console.WriteLine("kerek egy guymolcsot");
            string gyumolcs = Console.ReadLine();
            while (gyumolcs != alma)
            {
                Console.WriteLine("nem almat irtal");
                gyumolcs = Console.ReadLine();

            }
        }
        static void nyolcadik() {

        }
        static void kilencedik() {

        }
        static void tizedik() {

        }
    }
}
