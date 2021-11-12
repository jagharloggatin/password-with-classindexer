using System;
using System.Linq;

namespace password2
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonAccount personAccount = new PersonAccount();
            AccountChecking accountChecking = new AccountChecking();

            bool userNamePass;
            bool passWordPass;
            string accountPin;
            string accountName;
            string userInput;

            // gör om accountPin till string och kolla om den är .Valid också, annars kasta om i loopen

            do
            {
                userNamePass = UserNameCreation(out accountName);

                if (!accountChecking.NameIsValid(accountName) || !userNamePass)      //checkar om accountName är valid, gör nya metoder för det
                {
                    Console.WriteLine("Your accountname is not valid, generation has failed");
                    Console.ReadKey();
                    continue;
                }
            } while ((!accountChecking.NameIsValid(accountName) || !userNamePass));
            
            do 
            { 
                passWordPass = PasswordCreation(out accountPin);

                if (!accountChecking.PassWordIsValid(accountPin) || !passWordPass)      //checkar om password är valid
                {
                    Console.WriteLine("Your accountpassword is not valid, generation has failed");
                    Console.ReadKey();
                    continue;
                }
                accountChecking.Add(personAccount.GenerateAccount(accountName, accountPin));
                Console.WriteLine("Account generated!");
                Console.ReadKey();
            } while ((!accountChecking.PassWordIsValid(accountPin)) || !passWordPass);

            int counter = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Type in your username (write \"Q\" to Quit)");
                userInput = Console.ReadLine();

                for (int i = 0; i < accountChecking.Count(accountChecking); i++)
                {
                    if(accountChecking.NameLogin(userInput))
                        Console.WriteLine("username is true!");
                    if (!accountChecking.NameLogin(userInput)) 
                    {
                        Console.WriteLine($"{counter+1} number of tries");
                        counter++;
                        if (counter == 3)
                        {
                            Console.WriteLine("too many tries");
                            Console.ReadKey();
                            return;
                        }
                    }
                }
            } while (userInput != "q" || userInput != "Q");
            
            counter = 0;
            do
            {
                for (int i = 0; i < accountChecking.Count(accountChecking); i++)
                {
                    if (accountChecking.PassWordLogin(userInput))
                        Console.WriteLine("username is true!");
                    if (!accountChecking.PassWordLogin(userInput))
                    {
                        Console.WriteLine($"{counter + 1} number of tries");
                        counter++;
                        if (counter == 3)
                        {
                            Console.WriteLine("too many tries");
                            Console.ReadKey();
                            return;
                        }
                    }
                }

            } while (userInput != "q" || userInput != "Q");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You made it!");
            Console.ReadKey();
        }
        private static bool UserNameCreation(out string accountName) //creates a card and returns cardnr and cardpin and created account
        {
            string userInput;
            do
            {
                Console.WriteLine("Type in an accountname, it has to be atleast 3 letters long! (press \"Q\" to Quit)");
                userInput = Console.ReadLine();

                accountName = userInput;
                return true;

            } while (userInput != "q" || userInput != "Q");
        }
        private static bool PasswordCreation(out string accountPin)
        {
            string userInput;
            do
            {
                Console.WriteLine("Please insert your password number (press \"Q\" to Quit)");
                userInput = Console.ReadLine();

                accountPin = userInput;
                return true;
            } while (userInput != "q" || userInput != "Q");
        }
    }
}


/*
 *                 if (int.TryParse(userEntry, out accountPin) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong input, {userEntry} is not a valid input! Try again!");
                    continue;
                } */

/* 
 *             private static bool PasswordCreation()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Please insert your pin number");
                userEntry = Console.ReadLine();
                Console.WriteLine();

                if (userEntry.Length != 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong input, {userEntry} is not a valid input! Try again!");
                    continue;

                }
                if (int.TryParse(userEntry, out accountPin) == false)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Wrong input, {userEntry} is not a valid input! Try again!");
                    continue;
                }
                else
                {
                    return true;
                }
            } while ((userEntry != "Q" && userEntry != "q")) ; */