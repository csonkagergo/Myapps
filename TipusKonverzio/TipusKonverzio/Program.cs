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
            Console.WriteLine(x ==5 ? "x==5" : "x !=5");

            for (char ch = 'a';ch <= 'z'; ++ch)
            {
                Console.Write(int)ch + "-> " (int)ch + " ");
            }

            Console.ReadKey();
        }
    }
}
