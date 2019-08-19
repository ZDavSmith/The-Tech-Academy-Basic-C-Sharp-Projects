using System;
using System.Text;
namespace Concatenate_String_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Concatenate String Practice \nWhat year is it?");
            string year = Console.ReadLine();
            Console.WriteLine("What month is it?");
            string month = Console.ReadLine();
            Console.WriteLine("And the day?");
            string day = Console.ReadLine();
            Console.WriteLine("Excellent, so you're telling me it is " + month.ToUpper() + " " + day + ", " + year + "!");

            StringBuilder paragraph = new StringBuilder();

            paragraph.Append("When this program was written, the date was August 19th, 2019");
            paragraph.Append("The day was just an ordinary Monday for most people and contained nothing innately special. ");
            paragraph.Append("However, for me, this day would soon lead to an eventful and exciting evening. ");
            paragraph.Append("If the day this program is reviewed falls on a day later than August 19th, 2019, I will have had a lovely evening at a baseball game with my closest friend, her father, and my father. ");
            paragraph.Append("I wish the most pleasent day upon the reviwer of this program.");
            Console.WriteLine(paragraph);
        }
    }
}
