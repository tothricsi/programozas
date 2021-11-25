using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211116
{
    class Prost
    {
        public string datum;
        public string nev;
        public int helyezes;
        public int pontszam;

        public Prost(string egysor)
        {
            string[] darabok = egysor.Split('\t');
            datum = darabok[0];
            nev = darabok[1];
            helyezes =int.Parse(darabok[2]);
            pontszam = int.Parse(darabok[3]);
        }
        class Program
        {
            static void Main(string[] args)
            {
                string[] beolvas = File.ReadAllLines("Prost.csv");
                Prost[] versenyek = new Prost[beolvas.Length - 1];
                for (int i = 0; i < versenyek.Length; i++)
                {
                    versenyek[i] = new Prost(beolvas[i + 1]);
                }
                Console.WriteLine("3.feladat:");
                Console.Write("Ennyi versenyen indult:");
                Console.WriteLine(beolvas.Length);

                Console.WriteLine("4.feladat");
                Console.WriteLine("l988 - ban melyik versenyeken szerzett elsó helyezést:");
                for (int i = 0; i < versenyek.Length; i++)
                {
                    if (versenyek[i].datum.Contains("1988") && versenyek[i].helyezes==1)
                    {
                        Console.WriteLine("\t{0}", versenyek[i].nev);
                    }
                }

                Console.WriteLine("5.feladat");

                Console.ReadLine();
            }
        }
    }
}
