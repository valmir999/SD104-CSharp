//https://docs.microsoft.com/en-us/visualstudio/ide/visual-csharp-code-snippets?view=vs-2015 
//(Links to an external site.)
//This code below is a great utility for asking the user for a response to a question 
//and getting back a string GetInput or a number GetNumber

class Utils
{
    public static string GetInput(string prompt)
    {
        Console.WriteLine(prompt);
        return Console.ReadLine();
    }

    public static int GetNumber(string prompt)
    {
        int num;
        Console.WriteLine(prompt);
        do
        {
            if (Int32.TryParse(Console.ReadLine(), out num))
            {
                break;
            }
            else
            {
                Console.WriteLine("Bad input. Try again");
            }
        } while (true);
        return num;
    }

    public static int GetNumber(string prompt, int max)
    {
        int num;
        do
        {
            num = GetNumber(prompt);
            if (num > max)
            {
                Console.WriteLine("Number too large");
            }
        } while (num > max);
        return num;
    }
}