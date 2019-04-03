using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {

            Cat myCat = new Cat("cirmi", true);
            Dog myDog = new Dog("buksi",false);
            Cat sonCat = new Cat("kormi", false);

            myCat.Sleep();
            myCat.Hunt();
            myDog.Sleep();

            myCat.Sound();
            myDog.Sound();

            myCat.Born(4);
            myCat.Child();

            myDog.Born(2);
            myDog.Child();

            Console.ReadKey();

        }
    }
}