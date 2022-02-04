using System;

namespace CSharp_Practice
{
    internal class ATM
    {
        static void Main(string[] args)
        {
            bool login = true;
            int loginError = 0;
            int passwordAttempt = 0;
            double balance = 0;

            do
            {
                Console.WriteLine("Please enter your account number: \n");
                string username = Console.ReadLine();
                if (username.ToLower() == "64052")
                {
                    Console.Clear();

                    do
                    {
                        Console.WriteLine("Please enter your password: \n");
                        string password = Console.ReadLine();
                        if (password.ToLower() == "ebarrier11")
                        {
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("Welcome, Edward! \n \n");
                                Console.WriteLine("Please select an option: \n" +
                                    "a) Deposit \n" +
                                    "b) Withdrawal \n" +
                                    "c) View Balance \n" +
                                    "d) Exit");
                                string menu = Console.ReadLine();
                                menu.ToLower();
                                switch (menu)
                                {
                                    case "a":
                                        Console.WriteLine("How much would you like to deposit?");
                                        double addAmount = double.Parse(Console.ReadLine());
                                        balance += addAmount;
                                        Console.WriteLine($"You deposited {addAmount:c}. Press any key continue.");
                                        Console.WriteLine($"New Balance: {balance:c}");
                                        Console.ReadKey();
                                        break;
                                    case "b":
                                        Console.WriteLine("How much would you like to withdrawal?");
                                        double minusAmount = double.Parse(Console.ReadLine());
                                        if (minusAmount > balance)
                                        {
                                            Console.WriteLine($"You may not withdraw {minusAmount:c}, as you only have {balance:c}.");
                                        } else
                                        {
                                            balance -= minusAmount;
                                            Console.WriteLine($"You withdraw {minusAmount:c}");
                                            Console.WriteLine($"New Balance: {balance:c}");
                                        }
                                        Console.ReadKey();
                                        break;
                                    case "c":
                                        Console.WriteLine($"Your balance is {balance:c}. Press any key to continue.");
                                        Console.ReadKey();
                                        break;
                                    case "d":
                                        Console.WriteLine("Goodbye! :)");
                                        Console.ReadKey();
                                        login = false;
                                        break;
                                }

                            } while (login);
                        }
                        else
                        {
                            Console.WriteLine("Password is incorrect. Please try again \n");
                            passwordAttempt++;
                        }
                        if (passwordAttempt >= 3)
                        {
                            login = false;
                        }
                    }
                    while (login == true);



                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("That is not the correct username. Please try again \n");
                    loginError++;
                }
            } while ((login == true) && (loginError < 3));
        }
    }
}
