using System;

namespace Console_Application_Math_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            //Multiply
            Console.WriteLine("Enter a number");
            string numSt = Console.ReadLine();
            long numL = Convert.ToInt64(numSt);
            long numLg = numL * 50;
            Console.WriteLine("Your number * 50 = " + numLg);
            //Adding 
            Console.WriteLine("Enter a number");
            string numAddStr = Console.ReadLine();
            int numAddInt = Convert.ToInt32(numAddStr);
            int numAdded = numAddInt + 25;
            Console.WriteLine(" Your number + 25 = " + numAdded);
            //Divide
            Console.WriteLine("Enter a number");
            string numDivideStr = Console.ReadLine();
            double numDivideInt = Convert.ToInt32(numDivideStr);
            double numDivided = numDivideInt / 12.5;
            Console.WriteLine(" Your number / 12.5 = " + numDivided);
            //Check if Greater than 50
            Console.WriteLine("Enter a number");
            string numCheckStr = Console.ReadLine();
            int numCheck = Convert.ToInt32(numCheckStr);
            int Check = 50;
            bool numCheckBool = numCheck > Check;
            Console.WriteLine("If your number is greater than fifty, the following statement will read true. The statement reads: " + numCheckBool);
            //Remainder 
            Console.WriteLine("Enter a number");
            string numRemainderStr = Console.ReadLine();
            double numRemainderInt = Convert.ToInt32(numRemainderStr);
            double numRemainder = numRemainderInt % 7;
            Console.WriteLine(" Your number / 7 has a remainder of " + numRemainder);
        }
    }
}
