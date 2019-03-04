using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Fruit
    {
        public string nev;
        public string szarmazasihely;
        public int mennyiseg;

        public Fruit(string anev, string aszarmazasihely, int amennyiseg)
        {
            nev = anev;
            szarmazasihely = aszarmazasihely;
            mennyiseg = amennyiseg;
            Console.WriteLine("DEBUG:fruit()konstruktor meghivas");

        }
    }
}
