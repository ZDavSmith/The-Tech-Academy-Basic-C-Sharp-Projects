using System;
using System.Collections.Generic;


    class Program
    {
    static void Main(string[] args)
    {
        Console.WriteLine("Here is an array of names");
        string[] nameArray = { "Zach", "Jane", "Mary", "Jim", "Kate" };
        //Console.WriteLine(nameArray[0] + ", " + nameArray[1] + ", " + nameArray[2] + ", " + nameArray[3] + ", " + nameArray[4]);
        Array.ForEach(nameArray, Console.WriteLine);
        Console.WriteLine("Please select a number inbetween 0-4");
        int indexNum = Convert.ToInt32(Console.ReadLine());
        bool check = true;
        do
        {
            switch (indexNum)
            {
                case 0:
                    Console.WriteLine(nameArray[0]);
                    check = false;
                    break;

                case 1:
                    Console.WriteLine(nameArray[1]);
                    check = false;
                    break;

                case 2:
                    Console.WriteLine(nameArray[2]);
                    check = false;
                    break;

                case 3:
                    Console.WriteLine(nameArray[3]);
                    check = false;
                    break;

                case 4:
                    Console.WriteLine(nameArray[4]);
                    check = false;
                    break;

                default:
                    Console.WriteLine("That is not a number inbetween 1 and 4, try again:");
                    indexNum = Convert.ToInt32(Console.ReadLine());
                    check = true;
                    break;
            }
        } while (check == true);


        //INTEGER ARRAY
        Console.WriteLine("And now, here is an array of numbers: ");
        int[] numberArray = { 1, 321, 1111, 5902, 3902 };
        Array.ForEach(numberArray, Console.WriteLine);
        Console.WriteLine("Please select a number inbetween 0-4");
        int indexNumInt = Convert.ToInt32(Console.ReadLine());
        bool numCheck = true;
        do
        {
            switch (indexNumInt)
            {
                case 0:
                    Console.WriteLine(numberArray[0]);
                    numCheck = false;
                    break;

                case 1:
                    Console.WriteLine(numberArray[1]);
                    numCheck = false;
                    break;

                case 2:
                    Console.WriteLine(numberArray[2]);
                    numCheck = false;
                    break;

                case 3:
                    Console.WriteLine(numberArray[3]);
                    numCheck = false;
                    break;

                case 4:
                    Console.WriteLine(numberArray[4]);
                    numCheck = false;
                    break;

                default:
                    Console.WriteLine("That is not a number inbetween 1 and 4, try again:");
                    indexNumInt = Convert.ToInt32(Console.ReadLine());
                    numCheck = true;
                    break;
            }
        } while (numCheck == true);

        Console.WriteLine("Now, here is a List of strings: ");
        List<string> strList = new List<string>();
        strList.Add("Hello!");
        strList.Add("How");
        strList.Add("Are");
        strList.Add("You");
        strList.Add("?");
        foreach (var word in strList)
        {
            Console.WriteLine(word);
        }

        Console.WriteLine("Pick a number inbetween 1 and 4");
        int listCheck = Convert.ToInt32(Console.ReadLine());
        bool numCheckT = true;
        do
        {
            switch (listCheck)
            {
                case 0:
                    Console.WriteLine(strList[0]);
                    numCheckT = false;
                    break;

                case 1:
                    Console.WriteLine(strList[1]);
                    numCheckT = false;
                    break;

                case 2:
                    Console.WriteLine(strList[2]);
                    numCheckT = false;
                    break;

                case 3:
                    Console.WriteLine(strList[3]);
                    numCheckT = false;
                    break;

                case 4:
                    Console.WriteLine(strList[4]);
                    numCheckT = false;
                    break;

                default:
                    Console.WriteLine("That is not a number inbetween 1 and 4, try again:");
                    listCheck = Convert.ToInt32(Console.ReadLine());
                    numCheckT = true;
                    break;
            }
        } while (numCheckT == true);
        Console.Read();


    }
    }

