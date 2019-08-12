using System;

namespace variablesanddatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is a simple program
            //ctrl kc to comment, ku to uncomment


            //Console.WriteLine("What is your name?");
            //string yourname = Console.ReadLine();
            //Console.WriteLine("Your name is: " + yourname);
            //Console.ReadLine();

            //Casting 


            //Console.WriteLine("What is your favorite number?");
            //string favoriteNumber = Console.ReadLine();
            //int faveNum = Convert.ToInt32(favoriteNumber);
            //int total = faveNum + 5;
            //Console.WriteLine("Your favorite number plus 5 is: " + total);
            //Console.ReadLine();

            //Data Types
            bool isStudying = false;
            byte hoursWorked = 42;
            sbyte currentTemp = -23;
            char questionMark = '\u2103'; //unicode
            decimal moneyInBank = 100.5m; //have to put m for decimals (Really only used for finacial transactions
            double heightInCentimeters = 211.30202092; //Any number 15 -16 digits in length
            float secondsLeft = 2.62f; //(f) for float
            short temperatureOnMars = -341;
            string myName = "Zach";

            //Casting
            int currentAge = 22;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(rainingStatus);
            Console.ReadLine();



        }
    }
}
