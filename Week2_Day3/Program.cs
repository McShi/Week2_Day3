using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int answer = Add(72, 45);
            //Console.WriteLine(answer);

            //Console.WriteLine("Please enter your name.");
            //string name = Console.ReadLine().ToLower();
            //Console.WriteLine("What's your favorite food?");
            //string favoriteFood = Console.ReadLine().ToLower();

            //FavoriteFood(name, favoriteFood);

            //FavoriteFood("Aisha", "pizza");

            //RetirementCalculator(17);
            //RetirementCalculator(42);
            //RetirementCalculator(63);
            //RetirementCalculator(71);

            //WageCalculator(72, 25);
            //WageCalculator(81, 17);
            //WageCalculator(66, 38);

            MonthlySales(1253, 4768, 8923, 3402);
            Console.WriteLine("Your monthly sales average is " + MonthlySales(1253, 4768, 8923, 3402));

            DogNames("Sheila", "Captain");
            DogNames("Matt", "Theodore Baron Von Pooch");
            DogNames("Yolanda", "Ashanti");

        }

        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        public static void FavoriteFood(string name, string favoriteFood)
        {
            Console.WriteLine("My name is " + name + ", and my favorite food is " + favoriteFood);
        }

        public static void RetirementCalculator(int userAge)
        {
            int sum = Math.Max(0, 65 - userAge);

            //int sum = 65 - userAge;
            Console.WriteLine("The user will retire in " + sum + "years.");
        }

        public static double WageCalculator(int hoursWorked, int hourlyWage)
        {
            double sum = hoursWorked * hourlyWage;
            Console.WriteLine("Your monthly wage is " + sum);
            return sum;
        }

        public static double MonthlySales(int weeklySales1, int weeklySales2, int weeklySales3, int weeklySales4)
        {
            double sum = (weeklySales1 + weeklySales2 + weeklySales3 + weeklySales4) / 4;
            return sum;
        }

        public static void DogNames(string name, string dogName)
        {
            Console.WriteLine(name + " has a dog named " + dogName + ".");
        }
    }
}
