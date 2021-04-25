using System;
using System.Globalization;
using ConsoleApp1.Entities;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc = new Account(1001,"Alex",0.0);
            BusinessAccount bacc = new BusinessAccount(1002,"Maria",0.0,500.00);

            // UpCasting

            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003,"Bob",0.0,200.0);
            Account acc3 = new SavingsAccount(1004,"Anna",0.0,0.01);

            // DownCasting

            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loan(100.0);
        }
    }
}
