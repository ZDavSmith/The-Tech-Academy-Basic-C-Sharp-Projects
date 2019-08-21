using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        //    int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //    for (int i = 0; i < testScores.Length; i++)
        //    {
        //        if (testScores[i] > 85)
        //            Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //    Console.ReadLine();


        //string[] names = { "Jesse", "Eric", "Daniel", "Adam"};
        //for (int j = 0; j < names.Length; j++)
        //{   
        //Console.WriteLine(names[j]);

        //Console.Read();
        //}

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(81);
        //testScores.Add(72);
        //testScores.Add(70);
        //testScores.Add(100);

        ////============
        ////For Each Loop
        ////=============

        //foreach (int score in testScores) //score is a var created and then the place it is found in
        //{
        //    if (score > 85)
        //    {
        //        Console.WriteLine("Passing test score:" + score);
        //    }

        //}
        //Console.ReadLine();

        //List<string> names = new List<string>() { "Jesse", "Erik", "Adam", "Daniel" };

        //foreach (string name in names)
        //{
        //Console.WriteLine(name);
        //}
        //Console.ReadLine();

        List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }

        Console.WriteLine(passingScores.Count);
        foreach (int score in passingScores)
            {
            Console.WriteLine(score);
            }

        }
    }    

