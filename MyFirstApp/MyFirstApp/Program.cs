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
            Fruit[] fruits = new Fruit[15];
        
            string nev;
            string szarmazasihely;
            int mennyiseg;
            int gyszam;

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
                //konstruktor hivasa
                fruits[i] =new Fruit(nev, szarmazasihely, mennyiseg);

            }

                Console.ReadKey();

             
        }
    }
}
