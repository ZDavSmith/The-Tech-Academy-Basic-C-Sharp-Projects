using System;
using System.Text;

namespace String_Practice_Tech_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Jesse";
            string quote = "The man said, \"Hello\", Jesse. \n Hello on a new line.";
            // string fileName = @"C:\Users\Jesse"; //The @ tells the compilers that everything between the quotes is a part of the main string. No escapes

            // bool trueOrFalse = name.Contains("s");// both of these are helpful when looking for a specific character
            // trueOrFalse = name.EndsWith("s");

            //int length = name.Length; // Finds the number of characters

            // name = name.ToUpper(); //Converts everything to uppercase..
            // name = name.ToLower(); // Converts everything to lower

            //Console.WriteLine(length);
            //Console.ReadLine();



            //Strings are immutable. Once you create them, you cant change them

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");

            Console.WriteLine(sb);
            Console.ReadLine();

        }
    }
}
