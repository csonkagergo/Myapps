using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace esf
{
    class Program
    {
        static void Main(string[] args)
        {
            int v = 0;
            string S;

            bool moreBook = true;

            int iPage;
            string sAuthor, sName;
            Exercise ex = new Exercise("Csonka Gergő");

            //ex.Name = "Csonka Gergő";
            ///


            ex.PrintName();


            Console.WriteLine(ex.getName());
            ///ciklusok

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("ciklus:<váltoizó hivatkozás I.>" + i);
                Console.WriteLine("ciklus:<Változó hivatkozás II.>{0}", i);
            }
            v = 2;
            while (v > 0)
            {
                Console.WriteLine("while ciklus");
                v--;

            }
            do
            {

                Console.WriteLine("Do while ciklus");
                v--;
            } while (v > 0);

            //elágazások
            v = 2;
            if (v == 2)
            {
                Console.WriteLine("A v értéke egyenlő 2 al");
            }
            else if (v == 3)
            {
                Console.WriteLine("A v értéke egyenlő 3 al");
            }
            else
            {
                Console.WriteLine(" v nem és nem 3, hanem" + v);
            }
            v = 5;
            switch (v)
            {
                case 0:
                    Console.WriteLine("switch:" + v);
                    break;



                case 5:
                    Console.WriteLine("switch:" + v);
                    break;

                default:
                    Console.WriteLine("switch default:" + v);
                    break;
                    //beolvasás konzolról

            }
            S = Console.ReadLine();
            Console.ReadKey();
            Console.WriteLine("beolvasás konzolról" + S);
            int[] szamok = new int[5];
            string[] szövegek = new string[10];

            int[] iNums = new int[] { 1, 2, 3, 4, 5, 6 };
            ///deklaráció
            string[] sFruit = new string[] { "alma", "körte", "banán", "narancs" };
            Console.WriteLine("iNums első eleme:{0} sFruit első eleme {1}", iNums[0], sFruit[0]);
            Console.WriteLine("iNums első eleme:" + iNums[0] + "sFruit első eleme: ", sFruit[0]);

            ///Tipusos listák
            var Lista = new List<Book>();
            ///új elemek hozzá adása a listához
            ///ctr-"." ot hívjuk segítségül
            Lista.Add(new Book() { Name = "Oroszlánkölykök", Author = "Irwin Shaw", Page = 100 });
            Lista.Add(new Book() { Name = "Megkergetve", Author = "Margó István", Page = 200 });
            Lista.Add(new Book() { Name = "Egri Csillagok", Author = "Gárdonyi Géza", Page = 1000 });
            ///Lista kiiratása
            foreach (Book book in Lista)
            {
                ///lista elemének törlése
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }

            Console.WriteLine("**********************************************************************");

            foreach (Book book in Lista)
            {
                ///lista elemének törlése
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            Console.WriteLine("**********************************************************************");

            Lista.Remove(Lista.Find(x => x.Name.Contains("Oroszlánkölykök")));
            foreach (Book book in Lista)
            {
                ///lista elemének törlése
                Console.WriteLine(book.Name + " " + book.Author + " " + book.Page);
            }
            //Console.WriteLine("keressük az Oroszlánkölyköket:" + Lista.Find(x => x.Name.Contains("Oroszlánkölykök")).Name);

            //feladat:egészítsuk ki ugy a programot hogy a felhasználó lehetőséget kapjon interaktív modon a könyvtár elemeire modositasara.
            // u betuvel bekeri a konyv cimet és oldalszamat t betuvel torles , l lista.
        
             
            do
            { 
            Console.WriteLine("**********************************************************");
            Console.WriteLine("lehetőség [u]:új könyv [l]listázás [t]:könyv törlése [k]:kilépés");
            Console.WriteLine("**********************************************************");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'u':
                        Console.Write("kérem a könyv címét:");
                        sName = Console.ReadLine();
                        Console.Write("kérem a könyv szerzőjét:");
                        sAuthor = Console.ReadLine();
                        Console.Write("kérem a lapszámot");
                        iPage = int.Parse(Console.ReadLine());
                        Lista.Add(new Book { Name = sName, Author = sAuthor, Page = iPage });
                        break;
                    case 'k':
                        moreBook = false;
                        break;
                    case 't':
                        Console.Write("kérem a könyv címét:");
                        sName = Console.ReadLine();
                        Lista.Remove(Lista.Find(x => x.Name.Contains(sName)));
                        break;
                    case '1':
                        Console.WriteLine("könyvtár tartalma:");
                        foreach (Book book in Lista)
                        {
                            Console.WriteLine("->" + book.Name + " " + book.Author + " " + book.Page);
                        }
                        break;
                    
            






        }while (moreBook) ;
    } 
}
