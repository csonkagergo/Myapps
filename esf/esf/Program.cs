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

            //elágazások
            v = 2;
            if (v==2)
            {
                Console.WriteLine("A v értéke egyenlő 2 al");
            }
             else if(v==3)
            {
                Console.WriteLine("A v értéke egyenlő 3 al");
            }
            else
            {
                Console.WriteLine(" v nem és nem 3, hanem"+ v );
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

            
        }
            Console.ReadKey();

             
        }
    }
}
