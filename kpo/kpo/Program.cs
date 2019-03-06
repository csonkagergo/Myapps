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
            Random r = new Random();
            /// feladat2:változók létrehozása



            string compChoice = "";
            string playerChoice = "";

            int compScore=0;
            int playerScore = 0;


             
            Console.WriteLine(" kő,papír,olló");
            do
            {
                ///feladat 3:
                ///játékos választsának megkérdezése és tárolása
                Console.WriteLine("te mit választasz?k-p-o");

                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'k':
                        playerChoice = "kő";
                        break;
                    case 'p':
                        playerChoice = "papír";
                        break;
                    case 'o':
                        playerChoice = "olló";
                        break;
                }
                ///feladat 4:
                ///számítógép választásának kérdése:Random()
                switch (r.Next(0, 3))
                {
                    case 0:
                        compChoice = "kő";
                        break;
                    case 1:
                        compChoice = " papír";
                        break;
                    case 2:
                        compChoice = "olló";
                        break;
                }
                ///Feladat 5: értékeljük ki a compChoice es a playerChoice
                ///változókat
                ///
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
