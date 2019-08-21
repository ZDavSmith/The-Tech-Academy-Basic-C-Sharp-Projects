using System;
using System.Collections.Generic;


namespace ArraysAndListsAdvancedProj
{
    class Program
    {
        static void Main(string[] args)
        {
            //=======================================================================
            //This Loop satisfies 1 through 4 on the Tech Acad Project Requirements
            //=======================================================================

            Console.WriteLine("This is a one dimensional array");
            string[] placeArray = { "Hawaii", "Maine", "NewYork", "Kentucky" };
            Console.WriteLine("Type in an adjective to describe a place");
            string adj = Console.ReadLine();
            for (int j = 0; j < placeArray.Length; j++)
            {
                Console.WriteLine(adj + " " + placeArray[j]);
            }

            //=====================
            //This loop covers 5
            //=====================
            int[] numArray = new int[5];
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Type in a number");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\nHere is the array of numbers you've created");
            foreach (int num in numArray)
            {
                Console.WriteLine(num);
            }


            //=============================
            //Adding to the Nums for fun
            //=============================


            Console.WriteLine("\nNow, we shall add to the numbers.");
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine("Please type in a number to add to " + numArray[i]);
                int addNum = Convert.ToInt32(Console.ReadLine());
                int newerNum = numArray[i] + addNum;
                numArray[i] = newerNum;
                Console.WriteLine("\nYour new number is " + newerNum);
            }
            Console.WriteLine("\nHere is your new array!");
            foreach (int num in numArray)
            {
                Console.WriteLine(num);
            }

            //====================================================================================================================
            //This loop covers 6-8.... It's not the most efficient so advice on how to improve it and condense it would be great. 
            //====================================================================================================================

            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            List<string> Citys = new List<string> { "NewYork", "Boston", "Atlanta", "Washington DC", "Tokyo", };
            Console.WriteLine("I've created a random list of cities. Please type in NewYork, Boston, Atlanta, Washington DC, or Tokyo");
            string selectedCity = Console.ReadLine();
            int validCity = 0;
            bool keepIterating = true;
            while (keepIterating == true)
            {
                for (int i = 0; i < Citys.Count; i++)
                {
                    if (selectedCity == Citys[i])
                    {
                        Console.WriteLine("Here is the matching text found in the array: " + Citys[i]);
                        string index = Citys[i];
                        int indexx = Citys.IndexOf(index);
                        Console.WriteLine("The index of the string is: " + indexx);
                        validCity = 0;
                    }
                    //Fail Check
                    else
                    {
                        validCity = validCity + 1;
                    }

                }

                if (validCity == Citys.Count)
                {
                    Console.WriteLine("You done messed up. That was not what I wanted");
                    keepIterating = true;
                    Console.WriteLine("Try Again: Please type in NewYork, Boston, Atlanta, Washington DC, or Tokyo");
                    selectedCity = Console.ReadLine();
                    validCity = 0; //Resets the fail count

                }
                //Exits the loop if x amount of fails haven't been met, meaning a hit
                else
                {
                    keepIterating = false;
                }
            }



            //==========================
            //This loop covers 9 - 10
            //==========================

            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            List<string> Names = new List<string> { "Sam", "Jackson", "Peter", "Loui", "Sam", };
            Console.WriteLine("\nI've created a random list of names. Select Sam, Jackson, Peter, or Loui. (Sam should appear twice in the index of 0 and 4)");
            string selectedName = Console.ReadLine();
            int validName = 0;
            bool keepIteratingName = true;
            while (keepIteratingName == true)
            {
                for (int i = 0; i < Names.Count; i++)
                {
                    if (selectedName == Names[i])
                    {
                        Console.WriteLine("Here is the matching text found in the array: " + Names[i]);
                        int index = i;
                        Console.WriteLine("The index of the string is: " + index);
                        validName = 0;
                    }
                    //Fail Check
                    else
                    {
                        validName = validName + 1;
                    }

                }

                if (validName == Names.Count)
                {
                    Console.WriteLine("You done messed up. That was not what I wanted");
                    keepIteratingName = true;
                    Console.WriteLine("Try Again: Please type in NewYork, Boston, Atlanta, Washington DC, or Tokyo");
                    selectedName = Console.ReadLine();
                    validName = 0; //Resets the fail count

                }
                //Exits the loop if x amount of fails haven't been met, meaning a hit
                else
                {
                    keepIteratingName = false;
                }
            }

            //========================================================================================================
            //Final Loop 11 ----- I'm not happy with this one, I feel like there's a better way to do this one too.
            //=======================================================================================================
            Console.WriteLine("\nFood List - Press Enter to Continue");
            Console.ReadLine();
            List<string> foodTypes = new List<string> { "Meat", "Fruit", "Vegetable", "Sweets", "Fruit" };
            int meatDupe = 0;
            int fruitDupe = 0;
            int vegDupe = 0;
            int sweetDupe = 0;
                foreach (string food in foodTypes)
                {
                        switch(food)
                        {
                            case "Meat":
                                Console.WriteLine(food);
                                meatDupe += 1;
                                break;

                            case "Fruit":
                                Console.WriteLine(food);
                                fruitDupe += 1;
                                break;
                            case "Vegetable":
                                Console.WriteLine(food);
                                vegDupe += 1;
                                break;
                            case "Sweets":
                                Console.WriteLine(food);
                                sweetDupe += 1;
                                break;
                        }
                

                    if (fruitDupe > 1)
                    {
                    
                    Console.WriteLine("\nFruits Duplicated");
                    }
                    if (meatDupe > 1)
                    {
                        Console.WriteLine("\nMeat Duplicated");
                    }
                    if (vegDupe > 1)
                    {
                        Console.WriteLine("\nVegetable Duplicated");
                    }
                    if (sweetDupe > 1)
                    {
                        Console.WriteLine("\nSweets Duplicated");
                    }

            }










        }
    }
}
