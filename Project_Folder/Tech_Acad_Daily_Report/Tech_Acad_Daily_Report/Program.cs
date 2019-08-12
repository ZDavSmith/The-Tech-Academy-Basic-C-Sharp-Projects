using System;

namespace Tech_Acad_Daily_Report
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("What page number?");
            string pageNumString = Console.ReadLine();
            byte pageNumByte = Convert.ToByte(pageNumString);
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false”.");
            string helpString = Console.ReadLine();
            bool helpByte = Convert.ToBoolean(helpString);
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveFeedback = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string moreFeedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursString = Console.ReadLine();
            byte hoursByte = Convert.ToByte(hoursString);

            Console.WriteLine("Thank you for all of the answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
