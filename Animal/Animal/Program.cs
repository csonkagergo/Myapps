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
            Cat myCat = new Cat("cirmi");
            Dog myDog = new Dog("buksi");

            myCat.Sleep();
            myCat.Hunt();
            myDog.Sleep();

            myCat.Sound();
            myDog.Sound();

            myCat.Born(4);
            myCat.Child();

            Console.ReadKey();

        }
    }
}