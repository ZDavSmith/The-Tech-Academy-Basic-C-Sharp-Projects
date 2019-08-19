using System;

namespace While_And_Do_While_Statements_Tech_Proj
{
    class Program
    {
        static void Main(string[] args)
        {

            //First while statement 
            Console.WriteLine("Type in a number between 1 and 10");
            int mainNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number total = " + mainNum);


            while (mainNum < 30)
            {
            Console.WriteLine("Now type in another number between 1 and 10. Continue doing so until your number surpasses 30");
            int changingNum = Convert.ToInt32(Console.ReadLine());
            mainNum = changingNum + mainNum;
            Console.WriteLine("Your number total = " + mainNum);
            }
            Console.WriteLine("Congratulations, your number is now equal to or greater than the value of 30");

            Console.WriteLine("Now, I am thinking of a number between 1 and 10. Please guess a number: ");
            int numGuessed = Convert.ToInt32(Console.ReadLine());
            bool correctAnswer = numGuessed == 7;
            do
            {
            switch(numGuessed)
                {
                    case 7:
                        Console.WriteLine("That is the correct answer! Congratulations");
                        correctAnswer = true;
                        break;

                    default:
                        Console.WriteLine("Whoops, sorry! That is incorrect. Please guess again: ");
                        numGuessed = Convert.ToInt32(Console.ReadLine());
                   break;
                }
            }
            while (!correctAnswer);
            Console.Read();
        }
    }
}
