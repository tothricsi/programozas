using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20211012
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            harmincegy();
            harminkilenc();
            Console.ReadLine();
            negyvenkilenc();
            Console.ReadLine();
            negyvennyolc();
            Console.ReadLine();
            negyvenkilenc();
            Console.ReadLine();
        }
        static void cegy() {

        }
        static void harminkilenc()
        {
            Console.WriteLine("kerek egy szamot");
            int szam = int.Parse(Console.ReadLine());
            List<int> szamok = new List<int>();
            while (szam%2==0)
            {
                szamok.Add(2);
                szam = szam / 2;
            }
            szamok.Add(szam);
            Console.WriteLine("{0}=", szam);
            foreach (var item in szamok)
            {
                if (item==szamok.Last())
                {
                    Console.WriteLine("{0}*", item);
                }
                else
                {
                       Console.Write("{0}*", item);
                }
                
            }

        }
        static void negyven() {
            Console.WriteLine("kerek egy szamot");
            int eredeti = int.Parse(Console.ReadLine());
            int valtozik = eredeti;
            while (valtozik>=3 )
            {
                Console.Write("{0} ", valtozik );
                valtozik = valtozik - 3;
            }
            Console.WriteLine(valtozik);
            Console.WriteLine("{0}={1}/3+{2}" , eredeti, eredeti/3, valtozik);
        }
        static void negyvennyolc() {
            int gen = rnd.Next(10, 51);
            Console.Write(gen);
            while (gen != 25)
            {
                gen = rnd.Next(10, 51);
                Console.Write("{0} ", gen);
            }
            Console.WriteLine();
            do
            {
                gen = rnd.Next(10, 51);
                Console.Write("{0} ", gen);
            } while (gen != 25);
        }
        static void negyvenkilenc(){
            string szo = "keresztul-kasul";
            int hossz = szo.Length;
            for (int i = 1; i < 6; i++)
            {
                Console.Write(szo[rnd.Next(0,hossz)]);
            }
            Console.WriteLine();
        }
    }
}
