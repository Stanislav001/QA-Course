using System;

namespace Bank
{
    public class StartUp
    {
        public static void Main()
        {
            decimal balance = 0;

            Console.WriteLine("Enter deposit money: ");
            decimal depositMoney = decimal.Parse(Console.ReadLine());

            if (depositMoney < 0)
            {
                Console.WriteLine("You cannot be add negative money");
            }

            balance += depositMoney;
            Console.WriteLine(balance);
            Console.WriteLine($"You have successfully added {depositMoney}$");

            Console.WriteLine("Enter how much money you want to withdraw: ");
            decimal withdrawMoney = decimal.Parse(Console.ReadLine());

            if (withdrawMoney < 0)
            {
                Console.WriteLine("You withdraw be add negative money");
            }
            
            if (withdrawMoney > balance)
            {
                Console.WriteLine("You don't have enough money");
                return;
            }
            Console.WriteLine($"You have successfully withdraw {withdrawMoney}$");
        }   
    }
}