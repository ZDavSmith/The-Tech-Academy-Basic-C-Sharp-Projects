using System;

namespace Tech_Branching_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number";

            Console.WriteLine(result);
            Console.ReadLine();


            //Branching method with user input

            //int roomTemp = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemp = Convert.ToInt32(Console.ReadLine());

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exacty room temperature");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}
            //else
            //{
            //    Console.WriteLine("Uhhhhh something went wrong!");
            //}






            //ShortHand Method

            //int currentTemp = 70;
            //int roomTemp = 70;

            //string comparisonResult = currentTemp == roomTemp ? "It is room temp." : "It is not room temp."; //This is a shorthand if/else statement. 
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();


            //First Method of Branching

            //if (currentTemp == roomTemp)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemp > roomTemp)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (roomTemp > currentTemp)
            //{
            //    Console.WriteLine("Room temperature is warmer than current temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}
            Console.ReadLine();
        }
    }
}
