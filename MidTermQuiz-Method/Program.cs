//    Create a method --
// When do you eat a meal?
// The method will receive the meal to be consumed(dinner, lunch, breakfast, brunch, snacks...) 
// and return the time(the hour of the day) you should be eating that meal.
// In Main request the user to enter the meal. Save the result to an appropriate variable.
// Call the method you created using the above variable
// save the result to an appropriately typed variable
// Print a message indicating the meal and when it should be eaten.Spacing and grammar counts.

using System;

namespace MidTermQuiz_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //variable declarations
            string meal = "dinner";
            string eatMeal;

            //prompt user to input type of meal
            do
            {
                Console.WriteLine();
                Console.Write("Type quit to exit, or enter your meal type (options are: dinner, lunch, breakfast, brunch, snacks): ");

                meal =Console.ReadLine();
                meal = meal.ToLower();

            } while (meal != "dinner" && meal != "lunch" && meal != "breakfast" && meal != "brunch" && meal != "snacks" && meal != "quit"); // only allow correct input

            // user wants to know when to eat meal
            if (meal != "quit")
            {
                // call method to speciy time and date to eat meal
                eatMeal = MealTime(meal);

                // display message on screen
                Console.WriteLine();
                Console.WriteLine(eatMeal);

                Console.WriteLine();
                Console.Write("Type any key to exit...");
                Console.ReadLine();
            }
        }

        static public string MealTime(string mtype)
        {
            //return variable declaration
            string retMsg = mtype;

            // identify what type of meal to eat
            switch (mtype)
            {
                case "dinner":
                    retMsg = "Meal served at 7pm on 09/05/2019 time and day you should be eating your dinner.";
                    break;
                case "lunch":
                    retMsg = "Meal served at 11am on 09/06/2019 time and day you should be eating your lunch.";
                    break;
                case "breakfast":
                    retMsg = "Meal served at 8am on 09/07/2019 time and day you should be eating your breakfast.";
                    break;
                case "brunch":
                    retMsg = "Meal served at 1pm on 09/08/2019 time and day you should be eating your brunch.";
                    break;
                case "snacks":
                    retMsg = "Meal served at 4pm on 09/09/2019 time and day you should be eating your snacks.";
                    break;
                default:
                    Console.WriteLine("No meal to be served.");
                    break;
            }
            return retMsg;
        }
    }
}
