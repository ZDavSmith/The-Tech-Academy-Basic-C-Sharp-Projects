using System;
using System.Collections.Generic;
namespace Debugging_Applications_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<int> integerList = new List<int> { 42, 2, 178, 90, 73 };
                Console.WriteLine("Please type in a number");
                int userNum = Convert.ToInt32(Console.ReadLine());
                foreach (int num in integerList)
                {
                    int dividedNum = num / userNum;
                    Console.WriteLine(num + " divided by your number of " + userNum + " = " + dividedNum);
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please enter a non-zero number");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by 0");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please read the instructions carefully and try again");
            }
            finally
            {
                Console.ReadLine();
            }
            

        }
    }
}
