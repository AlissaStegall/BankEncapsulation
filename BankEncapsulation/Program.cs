﻿namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("How much would you like to deposit?");

            var amountDeposited = double.Parse(Console.ReadLine());

            account.Deposit(amountDeposited);

            Console.WriteLine($"Your balance is now {account.GetBalance()}");
        }
    }
}
