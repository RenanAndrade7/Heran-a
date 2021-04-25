using System;
using System.Globalization;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");

            BusinessAccount account = new BusinessAccount(8010, "Bob Brown", 100.00, 500.00);

            Console.WriteLine(account.Balance.ToString("F2",CultureInfo.InvariantCulture));

        }
    }
}
