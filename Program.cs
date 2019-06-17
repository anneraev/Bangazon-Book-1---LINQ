using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // Find the words in the collection that start with the letter 'L'
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };

            IEnumerable<string> LFruits = fruits.Where(fruit => fruit.StartsWith("L"));

            Console.WriteLine("Fruits that Begin with L:");
            LFruits.ToList().ForEach(fruit =>
            {
                Console.WriteLine($"{fruit}");
            });
            Console.WriteLine("-------------------------");

            // Which of the following numbers are multiples of 4 or 6
            List<int> numbers = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };

            IEnumerable<int> fourSixMultiples = numbers.Where(number => number % 4 == 0 || number % 6 == 0);

            Console.WriteLine("Numbers that are multipes of four or six:");
            fourSixMultiples.ToList().ForEach(num =>
            {
                Console.WriteLine($"{num}");
            });
            Console.WriteLine("-------------------------");

            // Order these student names alphabetically, in descending order (Z to A)
            List<string> names = new List<string>()
            {
                "Heather", "James", "Xavier", "Michelle", "Brian", "Nina",
                "Kathleen", "Sophia", "Amir", "Douglas", "Zarley", "Beatrice",
                "Theodora", "William", "Svetlana", "Charisse", "Yolanda",
                "Gregorio", "Jean-Paul", "Evangelina", "Viktor", "Jacqueline",
                "Francisco", "Tre"
            };

            List<string> descend = names.OrderByDescending(n => n).ToList();

            Console.WriteLine("Descending Alphabetical Order:");
            descend.ForEach(name =>
            {
                Console.WriteLine($"{name}");
            });
            Console.WriteLine("-------------------------");

            // Build a collection of( these numbers sorted in ascending order
            List<int> numbersA = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            List<int> ascending = numbersA.OrderBy(n => n).ToList();

            Console.WriteLine("Ascending Number Order:");
            ascending.ForEach(num =>
            {
                Console.WriteLine($"{num}");
            });
            Console.WriteLine("-------------------------");

            // Output how many numbers are in this list
            List<int> numbersB = new List<int>()
            {
                15, 8, 21, 24, 32, 13, 30, 12, 7, 54, 48, 4, 49, 96
            };
            Console.WriteLine($"There are {numbersB.Count} numbers in the numbersB list.");

            // How much money have we made?
            List<double> purchases = new List<double>()
        {
            2340.29, 745.31, 21.76, 34.03, 4786.45, 879.45, 9442.85, 2454.63, 45.65
        };
            double total = purchases.Sum();
            Console.WriteLine($"The purchases total at ${total}");
            // What is our most expensive product?
            List<double> prices = new List<double>()
            {
                879.45, 9442.85, 2454.63, 45.65, 2340.29, 34.03, 4786.45, 745.31, 21.76
            };
            double highest = prices.Max();
            Console.WriteLine($"The highest price is ${highest}.");

            Console.WriteLine("-------------------------");

            /*
        Store each number in the following List until a perfect square
        is detected.

        Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
    */
            List<int> wheresSquaredo = new List<int>()
            {
                66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
            };
            IEnumerable<int> untilPerfectSquare = wheresSquaredo.TakeWhile(num => Math.Sqrt(num) % 1 != 0);

            Console.WriteLine("This list stops before the first perfect square:");

            foreach (int item in untilPerfectSquare)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------");
        }
    }
}
