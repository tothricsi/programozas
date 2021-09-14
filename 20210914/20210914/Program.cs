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
        }
        static void elsofeladat() {

            Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
        static void masodikfeladat()
        {
            Console.WriteLine("hogy hivnak");
            string nev = Console.ReadLine();
            Console.WriteLine("szia ", nev); 
        }
        static void harmadikfeladat()
        {
            Console.WriteLine("irj egy szamot");
            int szam = Console.Read();
            Console.WriteLine("a szam ketszerese: ", szam * 2);
        }
        static void negyedikfeladat()
        {
            Console.WriteLine("irj egy szamot");
            Console.WriteLine("irj meg egy szamot");
            int szam1 = Console.Read();
            int szam2 = Console.Read();
            Console.WriteLine("a ket szam osszegge: ", szam1 + szam2);
            Console.WriteLine("a ket szam kulonbsege: ", szam1 - szam2);
            Console.WriteLine("a ket szam szorzata: ", szam1 * szam2);
            Console.WriteLine("a ket szam osszegge: ", szam1 / szam2);
            Console.WriteLine("a ket szam osszegge: ", szam1 % szam2);
        }
        static void otodikfeladat()
        {
            Console.WriteLine("negyzet A oldala");
            Console.WriteLine("negyzet B oldala");
            int A = Console.Read();
            int B = Console.Read();
            Console.WriteLine("A szam negyzete: ", A * B);
            Console.WriteLine();
        }
    }
}
