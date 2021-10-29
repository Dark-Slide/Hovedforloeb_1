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


            // Welcome Message
            Console.WriteLine("Welcome. To continue, you must enter your username and password: \n\n");


            // Ask for Username Input

            // Send UsernameInput to Checker Method
            while (true)
            {

                Console.WriteLine("Please Enter your username!");

                UsernameInput = Console.ReadLine().ToString();

                UserID = User.UsernameMatch(UsernameInput);

                if (User.UsernameMatch(UsernameInput) != 404)
                {

                }
            }


            // Ask for Password Input

            Console.WriteLine($"Hello {UsernameInput} please enter your Password:");
        }
    }
}