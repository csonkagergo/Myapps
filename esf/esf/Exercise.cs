using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Exercise
    {
        int v = 0;

        ///adattagok létrehozása:public,private,protedted
        /// public :nyilvános elérés
        /// private: csak az osztály számára látszik


        public string Name;

        //konstruktor: inicializálja az adattagjait
        public Exercise(string aName)
        {

            Name = aName;
        }
        public void PrintName()
        {
            Console.WriteLine(Name);
        }


        public string getName()
        {
            return Name;
        }

    }
}
