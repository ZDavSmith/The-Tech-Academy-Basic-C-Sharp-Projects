using System;

namespace Tech_Acad_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("How much income per hour?");
            string amountPerHour = Console.ReadLine();
            double amountHourly = Convert.ToDouble(amountPerHour);
            Console.WriteLine("How many hours per week?");
            string amountPerWeek = Console.ReadLine();
            double amountWeekly = Convert.ToDouble(amountPerWeek);
            Console.WriteLine("Person 2");
            Console.WriteLine("How much income per hour?");
            string amountPerHourTwo = Console.ReadLine();
            double amountHourlyTwo = Convert.ToDouble(amountPerHourTwo);
            Console.WriteLine("How many hours per week?");
            string amountPerWeekTwo = Console.ReadLine();
            double amountWeeklyTwo = Convert.ToDouble(amountPerWeekTwo);
            //Conversions
            double weeklyIncomeOne = amountHourly * amountWeekly;
            Console.WriteLine("Weekly salary of Person 1: $" + weeklyIncomeOne);
            double weeklyIncomeTwo = amountHourlyTwo * amountWeeklyTwo;
            Console.WriteLine("Weekly salary of Person 2: $" + weeklyIncomeTwo);
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool superiorIncome = weeklyIncomeOne > weeklyIncomeTwo;
            Console.WriteLine(superiorIncome);


        }
    }
}

