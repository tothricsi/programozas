using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211102
{
    class Elethossz
    {
        private int Tol { get; set; }
        private int Ig { get; set; }
        public int ElethosszEvekben => Tol == -1 || Ig == -1 ? -1 : Ig - Tol;

        public bool IsmertAzElethossz => ElethosszEvekben != -1;

        public Elethossz(string SzuletesHalalozas)
        {
            string[] m = SzuletesHalalozas.Split('-');
            try
            {
                Tol = int.Parse(m[0]);
            }
            catch (Exception)
            {
                Tol = -1;
            }
            try
            {
                Ig = int.Parse(m[1]);
            }
            catch (Exception)
            {
                Ig = -1;
            }
        }
    }
    class nobel {
        public int ev;
        public string nev;
        public int eletkor;
        public string orszagkod;
        public nobel(string egysor)
        {
            string[] darabok = egysor.Split(' ; ');
            ev = int.Parse(darabok[0]);
            nev = darabok[1];
            eletkor =new Elethossz(darabok[2]).ElethosszEvekben;
            orszagkod = darabok[3];
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("orvosi_nobeldijak.txt");
            nobel[] dijazottak = new nobel[beolvas.Length - 1];
            for (int i = 0; i < dijazottak.Length; i++)
            {
                dijazottak[i] = new nobel(beolvas[i + i]);
            }
            // 3. feladat
            Console.WriteLine( "harmadik feladat. dijazottak szama {0} fo", dijazottak.Length);

            // 4. feladat
            int[] evszamok = new int[dijazottak.Length];
            for (int i = 0; i < dijazottak.Length; i++)
            {
                evszamok[i] = dijazottak[i].ev;
            }
            Console.WriteLine(" negyedik feladat. dijazottaknak a negnagyobb dijazasi eve: {0}" , evszamok.Max());

            // 5. feladat

            Console.WriteLine("kerem az orszag kodjat");
            string kod =Console.ReadLine();
            int db_5 = 0;
            for (int i = 0; i < dijazottak.Length; i++)
            {
                if (dijazottak[i].orszagkod==kod)
                {
                    db_5++;
                }
            }
            switch (db_5)
            {
                case 0:
                    Console.WriteLine("A megadott országból nem volt díjazott!");
                    break;
                case 1:
                    Console.WriteLine("\tA megadott orszag dijazottja");
                    Console.WriteLine("\tNev {0}" , dijazottak[]);
                default:
                    
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
