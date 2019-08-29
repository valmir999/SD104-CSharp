using System;

namespace Lab4GuessMyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number program - C# Lab 4");
            Console.WriteLine("-----------------");

            //Declarations
            int nUser;
            string giveUp = "N";

            //get random number from computer
            Random rand = new Random();
            int hidden;
            do
            {
                while (true)
                {
                    Console.WriteLine("");
                    hidden = rand.Next(100);

                    Console.WriteLine("");

                    do
                    {
                        // ask user for a number
                        do
                        {
                            Console.WriteLine("");
                            Console.Write("Please Guess a number between 0 and 100 to match computer's generated random number: ");
                        } while (!Int32.TryParse(Console.ReadLine(), out nUser));

                        // keep guessing until they guess the number
                        if (nUser > 100)
                        {
                            Console.WriteLine("Your number " + nUser + " is too high. Please Guess a number between 0 and 100 ");
                        }
                        else if (nUser < 0)
                        {
                            Console.WriteLine("Your number " + nUser + " is too low. Please Guess a number between 0 and 100 ");
                        }
                        else if (nUser == hidden)
                        {
                            Console.WriteLine("You are a WINNER !!! Your number " + nUser + " matches computer generated random number = " + hidden);
                        }
                        else
                        {
                            Console.WriteLine("Your number " + nUser + " doesn't match computer's random number.");
                            Console.WriteLine("The correct number was " + hidden);
                            Console.Write("Do you give up, yet? Type Y to quit or any key to keep going...");
                            giveUp = Console.ReadLine();
                            if (giveUp.ToUpper().Trim() != "Y")
                            {
                                break;
                            }
                        }
                        Console.WriteLine("");
                    } while (nUser != hidden) ;
                    break;
                }
                Console.Write("Still here... Would you like to play again? Type Y for Yes or any other key to quit... ");
            } while (Console.ReadLine().ToUpper().Trim() == "Y");
        }
    }
}
