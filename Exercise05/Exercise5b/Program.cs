using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5b
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine(checkPalindrome("racecar"));
            //ChangeString();
            //Draw(10);
            
            MaxandMin();
        }
        public static bool checkPalindrome(String text)
        { 
            for(int i = 0; i < text.Length; i++)
            {
                char a = text[i];
               for(int j = text.Length-1; j > i; j--)
                {
                    char b = text[j];
                    if (a == b)
                        return true;
                    else
                        return false;
                }
            }                      
            return true;
        }
        public static void MaxandMin()
        {

            //string[] arr = Console.ReadLine().Split(' ');
            //int a = int.Parse(arr[0]);
            //int b = int.Parse(arr[1]);           
            string[] line = new string[10];
            int i = 0;                      
            while (true)
            {
                line[i] = Console.ReadLine();      
                i++;              
            }            
        }
        
        public static void ChangeString()
        {
            string text = Console.ReadLine();
            char[]arr;
            char kytu;
            int length = text.Length;
            arr = text.ToCharArray(0,length);
            for(int i = 0; i < length; i++)
            {
                kytu = arr[i];
                if (Char.IsLower(kytu))
                    Console.Write(char.ToUpper(kytu));
                else
                    Console.Write(char.ToLower(kytu));
            }            
        }
       public static void Setup(char[,] arr,int n)
        {
            for(int d = 0; d < n; d++)
            {
                for(int c = 0; c < n; c++)
                {
                    arr[d, c] = ' ';
                }
            }
        }
        private static void Print(char[,] arr, int n)
        {
            for (int d = 0; d < n; d++)
            {
                for (int c = 0; c < n; c++)
                    Console.Write(arr[d, c]+"");
                Console.WriteLine();
            }
        }
        public static void Draw(int n)
        {
            char[,] arr = new char[n * 3, n * 3];
            Setup(arr, n * 3);
            for (int i = 0; i < n; i++)
            {
                arr[0,0] = '+';
                arr[i, 0] = '|';                
                arr[0, i ] = '-';
                arr[i, n - 1 -i ] = 'x';
                arr[n - 1, 0] = '+';
                arr[0, n-1] = '+';
                arr[i, n-1] = '|';
                arr[i, i] = 'x';
                arr[n - 1, i] = '-';
                arr[n - 1, n - 1] = '+';
               
                
            }
            Print(arr, n * 3);
        }
    }
}
