using System;

namespace Tech_Acad_Loop_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Practicing Switch Satements
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12; //If number == 12, then its true, else, isGuessed is false


            do //The do makes sure the loop itterates through at least once. (Also, the do and while are connected
            {
                switch (number)
                {
                    // Revolves around cases -- Ex: Did this happen? Did this Happen?
                    case 62:
                        Console.WriteLine("You guessed 62. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed the number 12. That is correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You're wrong!");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed); // ! means the same as -- is false. So "while isGuessed = false"
            Console.Read();
        }
    }
}
