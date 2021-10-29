using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*
             * 
             * KNOWN BUGS: WILL NOT WORK IF 2 NaN CHARACTERS ARE INPUT! 
             * 
             */


            // Variables
            int rows;
            int[] ynglingstal = new int[3];
            int[] Lotto = new int[7];
            Random rnd = new Random();
            bool NaN = false;



            Console.WriteLine("Velkommen til Martins Lotto! \n Vælg dine 3 ynglingstal mellem 1 og 36: \n Seperer dem venligst med mellemrum (' ')");

            string[] UserInput = Console.ReadLine().ToString().Split(" "); // Accepts user input

            // Loops the parser and checks if any number appears twice.
            do
            {
                ynglingstal[0] = 0;
                ynglingstal[1] = 0;
                ynglingstal[2] = 0;
                var counter = 0; // Keeps track of how many numbers has successfully been parsed.

                foreach (string Input in UserInput) // Takes each individual string from the array, and puts them in Input
                {

                    int convertedvalue; // Used as the TryParse output

                    do // Loops if the number is not between 1 & 36, if the number appears more than once or the parser fails.
                    {
                        if (int.TryParse(Input, out convertedvalue)) // If the parser succeeds
                        {

                            if (convertedvalue < 1 || convertedvalue > 36) // If the number is less than 1 or more than 36
                            {
                                Console.WriteLine(Input + " Is not between 1 and 36 \n Please enter a new number");

                                UserInput[counter] = Console.ReadLine().ToString();
                                break;
                            }

                            if (Input == ynglingstal[0].ToString() || // Checks if a number appears twice
                                Input == ynglingstal[1].ToString() ||
                                Input == ynglingstal[2].ToString())
                            {
                                Console.WriteLine(convertedvalue + " Appears twice, please pick a different number");

                                UserInput[counter] = Console.ReadLine().ToString();

                                break;
                            }

                            ynglingstal[counter] = convertedvalue;
                            counter++; // Increase counter
                            break;
                        }
                        else // If the parser fails, asks the user to input a new number and overrides the current UserInput index
                        {
                            Console.WriteLine(Input + " Is or contains NaN character(s) \n Please enter a new number");

                            UserInput[counter] = Console.ReadLine().ToString();

                            NaN = true;

                            break;
                        }

                    } while (true);

                    // Console.WriteLine(Input); // Bugtracker output
                }

                if (counter >= UserInput.Length) // If all 3 inputs succeeds, the parser loop will exit. If there are more than 3 numbers, they will be skipped.
                    break;
                else if (NaN)
                    NaN = false;

            } while (true);

            // Console.WriteLine(Lotto[0] + " " + Lotto[1] + " " + Lotto[2]); // - Bugtracker

            // Console.ReadKey(); // - Keeps the program from moving ahead

            // Console.Clear(); // - Clears the console



            Console.WriteLine("Hvor mange rækker vil du have? \n OBS: Max 10 rækker!");

            do // Loop to check if the input is a NaN, less than 1 or more than 10
            {
                if (int.TryParse(Console.ReadLine().ToString(), out rows)) // Parses, and outputs in rows
                {
                    if (rows < 1 || rows > 10) // Checks if the number is less than 1 or more than 10
                    {
                        Console.WriteLine("Less than 1 or more than 10! try again:");
                    }
                    else
                        break; // Stops the loop
                }
                else
                    Console.WriteLine("NaN! try again:");


            } while (true);

            for (int i = 0; i < rows; i++) // Runs the random number generator the requested number of times.
            {

                int r = 0;
                foreach (var tal in ynglingstal) // Inserts ynglingstal into Lotto
                {
                    Lotto[r] = ynglingstal[r];
                    r++;
                }
                int counter = UserInput.Length;
                do // Random number generator
                {
                    int Rando = rnd.Next(1, 36); // Creates a random number between 1 and 36

                    int loopcounter = 0; // Keeps track of loops done
                    bool identical = false; // Will be true, if two numbers are the same
                    foreach (var item in Lotto) // Loops through the array
                    {
                        if (Rando != item) // If random number and items is different
                            loopcounter++;
                        else
                        {
                            identical = true;
                            break;
                        }

                        if (loopcounter >= 7) // When the loop has run 7 times
                            break;
                    }

                    if (!identical) // If rando and Lotto are not identical
                    {
                        Lotto[counter] = Rando;
                        counter++;
                    }

                } while (counter != 7);

                Array.Sort(Lotto); // Sorts the Array in ascending order

                Console.WriteLine("\nDine tal er: ");

                foreach (var item in Lotto) // Loops through Lotto, and outputs the numbers
                {
                    Console.Write(item + " ");
                }

            }

            Console.ReadKey(); // Keeps the program open, until a key is pressed.

        }
    }
}