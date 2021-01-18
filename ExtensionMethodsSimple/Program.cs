using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodsSimple
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Hello from extension method".Print();
            string str = "Hello from extension method, the are realy cool";
            int wordCount = str.GetWordCount();
            Console.WriteLine($"the string {str} has {wordCount} words");
            int nr = 95;
            if(nr.IsEven())
            {
                Console.WriteLine($" the {nr} is eveb number");
            }
            else
            {
                Console.WriteLine($"");
            }
        }
    }

    public static class  IntegerExtensions
    {
        public static bool IsEven(this int i)
        {
            return ((i % 2) == 0);
        }
    }
     public static class ExtensionSimple
    {
        public static void Print(this string message)
        {
            Console.WriteLine(message);
        }  
        public static int GetWordCount(this string input)
        {
            if (!string.IsNullOrEmpty(input))
            {
                string[] strArray = input.Split(' '); // mohima bazaf
                return strArray.Count();
            }
            else
            {
                return 0;
                
            }
        }

     }

 }
