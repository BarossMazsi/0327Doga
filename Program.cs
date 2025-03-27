using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Eutazas
{
     class Program
    {
        static void Main(string[] args)
        {
            string[] f = File.ReadAllLines("utasadat.txt");
            List<utasadat> utasadatok = new List<utasadat>();

            for (int i = 0; i < f.Length; i++)
            {
                utasadatok.Add(new utasadat(f[i]));
            }


            Console.WriteLine("2.Feladat.");
            Console.WriteLine($"A buszra {utasadatok.Count} ember szeretett volna felszállni.");


            Console.WriteLine("3.Feladat.");
            
           
            Console.WriteLine("4.Feladat.");
            var felszallas = utasadatok.GroupBy(x => x.megallo).OrderByDescending(x => x.Count()).ToList();
            Console.WriteLine($"A legtőbb utas a {felszallas[0].Count()} megállóban próbált meg felszállni.");


            Console.WriteLine("5.Feladat.");
            var ingyen = utasadatok.Where(x=>x.tipus =="RVS" || x.tipus == "GYK" || x.tipus == "NYP").Count();
            var kedvezmenyes = utasadatok.Where(x => x.tipus == "TAB" || x.tipus == "NYB").Count();
            Console.WriteLine($"Ingyenesen utaztók száma :{ingyen}");
            Console.WriteLine($"Kedvezményesen utazók száma : {kedvezmenyes}");




            Console.ReadKey();

        }
    }
}
