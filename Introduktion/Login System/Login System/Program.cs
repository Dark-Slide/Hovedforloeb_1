using System;
using System.Collections.Generic;
using System.Linq;
using Login_System;
using static Login_System.UserData;

namespace Login_System // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // Initial Program Load

            // Variables
            string UsernameInput, PasswordInput;
            int UserID;
            bool UserCheck = false; bool PassCheck = false;

            do
            {

                // Welcome Message
                Console.WriteLine("Welcome. To continue, you must enter your username and password: \n\n");

                // Ask for Username Input
                // Send UsernameInput to Checker Method
                while (true)
                {

                    Console.WriteLine("Please Enter your username:");

                    UsernameInput = Console.ReadLine().ToString();

                    int UserChecker = User.UsernameMatch(UsernameInput);

                    Console.WriteLine(UserChecker + UsernameInput);

                    if (UserChecker != 404)
                    {
                        UserCheck = true;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that user is not registered.");
                    }
                }

                // Ask for Password Input

                Console.WriteLine($"Hello {UsernameInput} please enter your Password:");

                while (true)
                {

                    PasswordInput = Console.ReadLine().ToString();

                    if (Password.PassMatch(PasswordInput = Console.ReadLine().ToString()) == true)
                    {
                        PassCheck = true;
                        break;
                    } else 
                    {
                        Console.WriteLine("Sorry, that was not quite right.");
                        break;
                    }
                }

            } while (UserCheck != true && PassCheck != true);

            Console.WriteLine($"Welcome {UsernameInput}, you have logged on");
        }
    }
}