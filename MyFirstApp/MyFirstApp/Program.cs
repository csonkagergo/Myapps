using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class program 
    {
        static void Main(string[] args)
        {
            var fruits = new List<Fruit>();
        
            string nev;
            string szarmazasihely;
            int mennyiseg;
            int gyszam;
            int osszmenny = 0;

            Console.Write("kérem a gyszam számát");
                gyszam = int.Parse(Console.ReadLine());

            for (int i = 0; i < gyszam; i++)
            {

                Console.Write("kérem a(z) {0}. gyumolcs nevet:", i + 1);
                nev = Console.ReadLine();
                Console.Write("kérem a(z) {0}. szarmazasihelyet:", i + 1);
                szarmazasihely = Console.ReadLine();
                Console.Write("kérem a(z) {0}. mennyiseg számát;", i + 1);
                mennyiseg = int.Parse(Console.ReadLine());

                osszmenny += mennyiseg;
                //konstruktor hivasa
                fruits.Add(new Fruit(nev, szarmazasihely, mennyiseg));

            }
            Console.WriteLine("gyumolcsok osszes mennyisege:" + osszmenny);
                Console.ReadKey();

             
        }
    }
}
