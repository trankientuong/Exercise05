using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5a
{
    class Program
    {
        static void Main(string[] args)
        {           
            //Print_a_2_z_v1();
            //while (true)
            //{
              //  char c = Console.ReadKey().KeyChar;
               // Console.WriteLine(" "+Char2Code(c));
            //}
            
            Console.WriteLine(" "+isUpper('A'));
            Console.WriteLine(toUpper('a'));
            Console.WriteLine(" "+isLower('A'));
            Console.WriteLine(toLower('A'));

        }
        public static void Print_a_2_z_v1()
        {
            for (int i = 97; i <= 122; i++)
            {
                Console.Write((char)i);
               // Console.WriteLine((int)i);
            }
            //Console.WriteLine();
            //for (int i = 122; i >= 97; i--)
            //{
            //    Console.Write((char)i+" ");
            //}
            //Console.WriteLine();
            //for (int i = 65; i <= 90; i++)
            //{
            //    Console.Write((char)i + " ");
            //    Console.WriteLine((int)i);
            //}
            //char a = 'A';
            //char c = 'Z';
            //for (int i = 0; i < 26; i++)
            //{
            //    Console.WriteLine(a);
            //    a++;                
            //}
            //for ( a = 'A'; a < c; a++)
            //{
            //    Console.WriteLine(a);
            //}
        }
        public static void Print_a_2_z_v2()
        {
            string s = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);
            }
        }
        public static int Char2Code(char a)
        {
            
            return a;
        }
        public static bool isUpper(char a)
        {
            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)a);
                if (a.Equals((char)i))
                    return true;
                if (a != (char)i)
                    return false;
            }
            return false;
        }
        public static bool isLower(char a)
        {
            for (int i = 65; i <= 90; i++)
            {
                Console.Write((char)a);
                if (a.Equals((char)i))
                    return false;
                if (a != (char)i)
                    return true;
            }
            return true;
        }
        public static char toUpper(char a)
        {
            int c = Char2Code(a);
            c = c - 32;
            a = (char)c;           
            return a;
            
        }
        public static char toLower(char a)
        {
             int c = Char2Code(a);
            c = c + 32;
            a = (char)c;
            return a;
        }
    }
}
