using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab0520
{
    class Program
    {
        static void Main(string[] args)
        {
            //hozzumk l�tre egy 15 elem� int t�mb�t,aminek a neve iArray

            int[] iArray = new int[15];
            //hozzunk l�tre 5 elemu szoveg tarolasara egy tombot
            string[] sArray = new string[5];
            //hozzunk letre egy int t�mb�t,amit felt�lt�nk 3db elemmel(5,8,9)
            int[] iT = new int[] { 5, 8, 9 };
            //hozzunk l�tre k�t dimenzios tombot egesz szamoknak ((4,5)(2,3)(6,8))
            int[,] iT3 = new int[,] { { 4, 5 }, { 2, 3 }, { 6, 8 } };
            try
            {
                Console.WriteLine(iT3[2, 1]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //h�rom dimenzios tomb
            int[,,] iT4 = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6, }},
                                    {{ 7, 8, 9 }, { 10, 11, 12 } } };

            try
            {
                Console.WriteLine(iT4[1, 1, 0]);
            }
             
            
            
            catch (Exception e)
            { 
            Console.WriteLine(e.Message);

            }
            for(int i=0; i<50; i++ )
            {
            if ((i%3)==0)
               {
                Console.WriteLine(i);
                }
            }  
            Console.ReadKey();
        
                
            
            

             
        }
    }
}
