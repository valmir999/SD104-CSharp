using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeValidator
{
    class Program
    {
        static void Main(string[] args)
        {

            // Takes user input -- DONE
            // Loops through each letter -- DONE
            // Checks if backwards position letter is the same as current position letter
            // if loop finishes, then you have a palindrome
            // if a letter is different, then it is not a palindrome. HINT: USE A BOOL!!!!!


            while (true)
            {
                Console.Write("Please enter a word: ");
                string word = Console.ReadLine().ToLower();
                bool isPalindrome = true;

                for (int count = 0; count < word.Length; count++)
                {
                    if (word[count] != word[word.Length - 1 - count])
                        isPalindrome = false;
                }

                if (isPalindrome == false)
                    Console.WriteLine("This word is not a palindrome.");
                else
                    Console.WriteLine("This word is a palindrome.");
                Console.ReadLine();
            }
        }
    }
}