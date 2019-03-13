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
            while(v>0)
            {
                Console.WriteLine("while ciklus");
                v--;
                   
            }
            do
            {

                Console.WriteLine("Do while ciklus");
                v--;
            } while (v > 0);



            Console.ReadKey();

             
        }
    }
}
