using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _20211004
{
    class magassag
    {
        public string orszag, hegy;
        public int magas;
        public magassag(string egysor)
        {
            string[]darabok = egysor.Split('\t');
            orszag = darabok[0];
            hegy = darabok[1];
            magas = int.Parse(darabok[2]);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            string[] beolvas = File.ReadAllLines("tengerszint.txt");
            magassag[] magassagok = new magassag[beolvas.Length];
            for (int i = 0; i < magassagok.Length; i++)
            {
                magassagok[i] = new magassag(beolvas[i]);
            }



            Console.WriteLine(  "enter");
            Console.ReadLine();

        }
    }
}
