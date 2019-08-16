using System;

namespace Shipping_Quote_Tech_Acad_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            Console.WriteLine("How many pounds does your package weigh?");
            float packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
                {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                }
            else
            {
                Console.WriteLine("What is the package width in feet?");
                float packageWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height in feet?");
                float packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package length in feet?");
                float packageLength = Convert.ToInt32(Console.ReadLine());

                if (packageWidth + packageHeight + packageLength > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    float packageTotal = ((packageWidth + packageHeight + packageLength) * (packageWeight) / 100);
                    Console.WriteLine("Your estimated total for shipping this package is: $" + packageTotal);
                }
            }
        }
    }
}
