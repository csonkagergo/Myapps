using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Kérem adjon meg egy stringet: ");
            string szoveg = Convert.ToString(Console.ReadLine());
            
            
            int i = 1;
            int db;
            while (i < szoveg.Length)
            {
                if (szoveg.Contains(szoveg[i]));                                         //(Convert.ToString(szoveg[i]) ==szoveg) db++;i++;
                i++;
            }
            db = szoveg.Length;
            Console.WriteLine("A stringben {0} darab keresni kívánt karakter található.", db); 
   
            Console.ReadLine();

        }
    }
}
