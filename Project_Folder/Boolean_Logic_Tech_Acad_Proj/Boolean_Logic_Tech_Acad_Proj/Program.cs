using System;

namespace Boolean_Logic_Tech_Acad_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Basic Approval for Car Insurance");
            Console.WriteLine("What is your age?");
            string ageStr = Console.ReadLine();
            byte age = Convert.ToByte(ageStr);
            Console.WriteLine("Have you ever had a DUI? Please answer true if yes or false if no:");
            string duiCheckStr = Console.ReadLine();
            bool duiCheck = Convert.ToBoolean(duiCheckStr);
            byte dui = Convert.ToByte(duiCheck);
            Console.WriteLine("How many speeding tickets have you aquired?");
            string ticketCheckStr = Console.ReadLine();
            byte ticketAmount = Convert.ToByte(ticketCheckStr);
            //Check for Qualifications
            bool pass = age > 15 && ticketAmount < 3 && dui == 0;
            Console.WriteLine("Do you qualify for insurance?: " + pass);




        }
    }
}
