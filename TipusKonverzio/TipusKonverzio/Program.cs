using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipusKonverzio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Is operátor kiprobálása
            // int x = 10;
            //if (x is int )//ha x egy int 
            {
                // Console.WriteLine("x tipusa int");
            }
            object a = "123";
            object b = "Hello";
            object c = 10;

            string aa = a as string;
            //expr1 ?v1 : v2;
            Console.WriteLine(aa == null ? "NULL" : aa); // 123 

            string bb = b as string;
            Console.WriteLine(bb == null ? "NULL" : bb); // Hello 

            string cc = c as string;
            Console.WriteLine(cc == null ? "NULL" : cc); // NULL 

            int x = 5;
            Console.WriteLine(x == 5 ? "x==5" : "x !=5");

            for (char ch = 'a'; ch <= 'z'; ++ch)
            {
                //Console.Write(int)ch + "-> " (int)ch + " ");
            }

            int[] iTomb = new int[10];

            Random r = new Random();
            for (int i = 0; i < iTomb.Length; ++i)
            {
                Console.Write("kérem az {0}. számot", i);
                //Console.Write("kérem az" + i +". számot", i);
                // A kivétel keletkezési helye(exception)
                try
                {
                    iTomb[i] = int.Parse(Console.ReadLine());
                   // iPrev = i;
                }
                catch (Exception e)
                {
                    Console.WriteLine("hiba." + e.Message);
                   // i = iPrev;
                }
                // iTomb[i] = r.Next();
                //konzolról kérje be a számot

            }

            //kiiratni az iTomb elemeit
            for (int i = 0; i < iTomb.Length; ++i)
            {
                Console.Write(iTomb[i] + " ");
            }

            //tömb kezdeti értékének megadása
            int[] iArr = new int[]{1,2,3,4,};
            string[] sArr = new string[] { "banan","mango","alma","korte" };

            Array.Sort(sArr);
            for (int i=0;i< iArr.Length)

                //tobb dimenzios tomb


                Console.ReadKey();
        }
    }
}
