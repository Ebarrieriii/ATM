using System;

namespace Problems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ********** POWERS *********** // 

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(Math.Pow(i, 2));
            }

            // *********** FIZZBUZZ *********** //

            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i < num; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("Fizzbuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // ********** Fibonacci ********** // 

            int num1 = 0, num2 = 1;
            int num3;
            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{num1} \n {num2}");

            for (int i = 1; i <= userNumber; i++)
            {
                num3 = num1 + num2;
                Console.WriteLine(num3);
                num1 = num2;
                num2 = num3;
            }

            // ********** Interest Calculator ********** //

            Console.WriteLine("Interest Calculator \n \n \n");
            Console.WriteLine("Enter the beginning balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the interest rate percentage: ");
            double interestRate = double.Parse(Console.ReadLine());
            Console.WriteLine("Amount of years: ");
            double time = double.Parse(Console.ReadLine());
            double amount = 0;
            for (int i = 0; i <= time; i++)
            {
                amount = amount * (1 + interestRate);
            }


            Console.Clear();
            Console.WriteLine($"Beginning Balance: {balance} \n" +
                $"Interest Rate: {interestRate} \n" +
                $"Total Time: {time} \n " +
                $"Total Amount: {amount:c}");





        }
    }
}
