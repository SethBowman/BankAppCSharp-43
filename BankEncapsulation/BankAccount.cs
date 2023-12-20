using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
    public class BankAccount
    {
        public BankAccount(string accountHolder)
        {
            AccountHolder = accountHolder;
        }
        public string AccountHolder { get; set; }
        private double _balance = 0;

        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void ATM()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("___  ____ _  _ _  _ _ _  _ ____    ____ ___  ___ ");
            Console.WriteLine("|__] |__| |\\ | |_/  | |\\ | | __    |__| |__] |__]");
            Console.WriteLine("|__] |  | | \\| | \\_ | | \\| |__]    |  | |    |   ");
            Console.WriteLine($"\nWelcome, {AccountHolder}!");

            while (true)
            {
                Console.WriteLine("\nPlease select an option:");
                Console.WriteLine("1: Deposit money");
                Console.WriteLine("2: Check balance");
                Console.WriteLine("3: Exit");

                int option;
                if (!int.TryParse(Console.ReadLine(), out option))
                {
                    Console.WriteLine("Invalid input. Please enter a valid option.");
                    continue;
                }

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter the amount to deposit:");
                        double amount;
                        if (!double.TryParse(Console.ReadLine(), out amount))
                        {
                            Console.WriteLine("Invalid input. Please enter a valid amount.");
                            continue;
                        }

                        Deposit(amount);
                        Console.WriteLine("Deposit success!");
                        break;
                    case 2:
                        Console.WriteLine($"Current balance: {GetBalance()}");
                        break;
                    case 3:
                        Console.WriteLine("Thank you for using our Banking App!");
                        Console.ResetColor();
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }

        }
    }
}
