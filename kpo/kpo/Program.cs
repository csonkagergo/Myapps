using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpo
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            ///program: kő papír olló játék leprogramozása
            ///adott: számítógép -véletlenszerűen választ kpo
            ///írta:Csonka Gergő /2019.03.06
            ///játékos: billentyűzet választ
            ///megoldandó feladat 1:
            ///ciklus programfutás ,amíg a felhasználó szeretne játszani
            bool moreGame = true;
            Console.WriteLine(" kő,papír,olló");
            do
            {
                Console.Write("akarsz még játszani? i/n");
                if (Console.ReadKey(true).KeyChar == 'n')
                {
                    moreGame = false;
                }

                }while (moreGame);


            Console.ReadKey();

             
        }
    }
}