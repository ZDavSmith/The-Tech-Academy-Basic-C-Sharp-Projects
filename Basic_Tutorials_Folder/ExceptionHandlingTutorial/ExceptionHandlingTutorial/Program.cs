using System;

    class Program
    {
        static void Main(string[] args)
        {
        //==============================================================================================
        //When something goes wrong in the code, Exception Handling, that checks and responds to errors
        //===============================================================================================
        try
        {
            Console.WriteLine("Pick a number.");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick a second number.");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dividing the two...");
            int numberThree = numberOne / numberTwo;
            Console.WriteLine(numberOne + " divided by " + numberTwo + " equals " + numberThree);
            Console.ReadLine();

        }
        catch( FormatException ex)
        {
            Console.WriteLine("Please type a whole number."); //Format Exception
            return; //Brings User to different Page
        }
        catch(DivideByZeroException ex)
        {
            Console.WriteLine("Please don't divide by 0"); //DividebyZero
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message); //General
        }
        finally //Will run no matter what, whether or not there is an exception. Prevents the stop in exe. Usually you'll have a database log in your finally
        {
            Console.ReadLine();
        }
       




        }
    }

