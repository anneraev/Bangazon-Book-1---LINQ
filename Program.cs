using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{

    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        public string Bank { get; set; }
    }

    public class Bank
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
    }

    public class ReportItem
    {
        public string CustomerName { get; set; }
        public string BankName { get; set; }
    }


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

            List<Customer> customers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };
            List<Customer> millionaires = customers.Where(customer => customer.Balance >= 1000000).ToList();

            foreach (Customer Millionaire in millionaires)
            {
                Console.WriteLine($"{Millionaire.Name} has a ballance of {Millionaire.Balance} at {Millionaire.Bank}");
            }
            Console.WriteLine("-------------------------");

            Console.WriteLine("Number of Millionaire Customers per bank;");

            List<string> Banklist = millionaires.Select(customer => customer.Bank).Distinct().ToList();

            Dictionary<string, int> BanksAndNumbers = new Dictionary<string, int>();

            foreach (string Bank in Banklist)
            {
                int CustomerCount = millionaires.Where(customer => customer.Bank == Bank).ToList().Count;
                BanksAndNumbers.Add(Bank, CustomerCount);
            }

            foreach (KeyValuePair<string, int> entry in BanksAndNumbers)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.WriteLine("-------------------------");

            /*
    TASK:
    As in the previous exercise, you're going to output the millionaires,
    but you will also display the full name of the bank. You also need
    to sort the millionaires' names, ascending by their LAST name.

    Example output:
        Tina Fey at Citibank
        Joe Landy at Wells Fargo
        Sarah Ng at First Tennessee
        Les Paul at Wells Fargo
        Peg Vale at Bank of America
*/

            // Create some banks and store in a List
            List<Bank> newBanks = new List<Bank>() {
            new Bank(){ Name="First Tennessee", Symbol="FTB"},
            new Bank(){ Name="Wells Fargo", Symbol="WF"},
            new Bank(){ Name="Bank of America", Symbol="BOA"},
            new Bank(){ Name="Citibank", Symbol="CITI"},
        };

            // Create some customers and store in a List
            List<Customer> newCustomers = new List<Customer>() {
            new Customer(){ Name="Bob Lesman", Balance=80345.66, Bank="FTB"},
            new Customer(){ Name="Joe Landy", Balance=9284756.21, Bank="WF"},
            new Customer(){ Name="Meg Ford", Balance=487233.01, Bank="BOA"},
            new Customer(){ Name="Peg Vale", Balance=7001449.92, Bank="BOA"},
            new Customer(){ Name="Mike Johnson", Balance=790872.12, Bank="WF"},
            new Customer(){ Name="Les Paul", Balance=8374892.54, Bank="WF"},
            new Customer(){ Name="Sid Crosby", Balance=957436.39, Bank="FTB"},
            new Customer(){ Name="Sarah Ng", Balance=56562389.85, Bank="FTB"},
            new Customer(){ Name="Tina Fey", Balance=1000000.00, Bank="CITI"},
            new Customer(){ Name="Sid Brown", Balance=49582.68, Bank="CITI"}
        };

            /*
                You will need to use the `Where()`
                and `Select()` methods to generate
                instances of the following class.

                public class ReportItem
                {
                    public string CustomerName { get; set; }
                    public string BankName { get; set; }
                }
            */

            Console.WriteLine("List of millionaires and their bank using LINQ");
            List<ReportItem> millionaireReport = newCustomers.Where(customer => customer.Balance >= 1000000).Select(customer => new ReportItem
            {
                CustomerName = customer.Name,
                BankName = newBanks.Find(bank => bank.Symbol == customer.Bank).Name
            }).ToList();

            foreach (ReportItem item in millionaireReport)
            {
                Console.WriteLine($"{item.CustomerName} at {item.BankName}");
            }
            Console.WriteLine("----------------------------");
            Console.WriteLine("List of millionaires and their bank with join operator");
            var millionaireReportJoin = newCustomers.Where(customer => customer.Balance >= 1000000).Join(newBanks, customer => customer.Bank, bank => bank.Symbol, (customer, bank) => new
            {
                CustomerName = customer.Name,
                BankName = bank.Name
            });

            foreach (var item in millionaireReportJoin)
            {
                Console.WriteLine($"{item.CustomerName} at {item.BankName}");
            }
        }
    }
}

