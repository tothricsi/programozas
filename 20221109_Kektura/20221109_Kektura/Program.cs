using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20221109_Kektura
{
    class Szakasz
    {
            public string kezd;
            public string vegso;
            public double hossz;
            public int emelkedes;
            public int lejtes;
            public char pecset;

        public Szakasz(string egysor)
        {
            string[] darabok = egysor.Split(';');
            kezd = darabok[0];
            vegso = darabok[1];
            hossz = double.Parse(darabok[2]);
            emelkedes = int.Parse(darabok[3]);
            lejtes = int.Parse(darabok[4]);
            pecset = char.Parse(darabok[5]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("kektura.csv");
            int tengerszint = int.Parse(beolvas[0]);
            Szakasz[] szakaszok = new Szakasz[beolvas.Length - 1];
            for (int i = 0; i < szakaszok.Length; i++)
            {
                szakaszok[i] = new Szakasz(beolvas[i + 1]);
            }

            Console.WriteLine("\t");
            Console.WriteLine( "3.feladat" ); 
            Console.WriteLine(beolvas[1].Length);

            Console.WriteLine("\t");
            Console.WriteLine( "4.feladat" ); 
            double teljeshossz = 0;
            foreach (var item in szakaszok)
            {
                teljeshossz = teljeshossz + item.hossz;
            }
            Console.WriteLine(teljeshossz);

            Console.WriteLine("\t");
            Console.WriteLine("5. feladat");
            List<double> hosszok = new List<double>();
            foreach (var item in szakaszok)
            {
                hosszok.Add(item.hossz);
            }
            double minhossz = hosszok.Min();
            int minindex = hosszok.IndexOf(minhossz);
            Console.WriteLine("{0} kezdete:", szakaszok[minindex].kezd);
            Console.WriteLine("{0} vegso:", szakaszok[minindex].vegso);
            Console.WriteLine("{0} hossza", szakaszok[minindex].hossz);
            Console.WriteLine("{0} emelkedese", szakaszok[minindex].emelkedes);
            Console.WriteLine("{0} lejtese", szakaszok[minindex].lejtes);
            Console.WriteLine("{0} pecsethely", szakaszok[minindex].pecset);

            Console.WriteLine("\t");
            Console.WriteLine("8.feladat");
            

            Console.WriteLine("enter");
            Console.ReadLine();
        }
        
    }
}
