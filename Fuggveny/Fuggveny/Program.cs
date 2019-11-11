using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fuggveny
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;

            str = Console.ReadLine();
           
            Console.WriteLine(" a szoveg visszafele:" +(StrBck(str)));
            //irjunk fuggvenyt ami a beirt szoveg hoszzat beirja
            Console.WriteLine("a szoveg hossza :" + CharCount(str));

            Console.WriteLine(ChangeChar('e', 'x', str));
            Console.ReadKey();
        }

         static string ChangeChar(char v1, char v2, string str)
        {
            string s;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == v1)
                {
                    s = s + v2;
                }
                else
                {
                    s=s+
                }
            }
            }
        }

        static int CharCount(string str)
        {
            return str.Length;
        }

        static string StrBck(string str)
        {
            string s="";
            for ( int i=str.Length-1; i>0;i--)
            {
                s = s + str[i];
            }
            return s;

            
        }
    }
}
