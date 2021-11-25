using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211123_Hotellift
{
    class Hotel {
        public string datum;
        public int sorszam, induloszint , celszint;

        public Hotel(string egysor)
        {
            string[] darabok = egysor.Split(' ');
            datum = darabok[0];
            sorszam = int.Parse(darabok[1]);
            induloszint = int.Parse(darabok[2]);
            celszint = int.Parse(darabok[3]);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("lift.txt");
            string lift = (beolvas[0]);
            Hotel[] lepcso = new Hotel[beolvas.Length - 1];
            for (int i = 0; i < lepcso.Length; i++)
            {
                lepcso[i] = new Hotel(beolvas[i + 1]);
            }

            Console.WriteLine("3.feladat");
            Console.WriteLine(beolvas.Length);

            string datumok = new string[lift.Length];
            for (int i = 0; i < datumok.Length; i++)
            {
                datumok[i]= lift[i].
            }





            Console.ReadLine();
        }
    }
}
