using System;
using System.IO;

namespace CommandPrompt
{
    class CommandPrompt
    {
        ConsoleColor backgroundColor;
        ConsoleColor foregroundColor;
        string[] screenText;
        int height;
        int columns;
        public CommandPrompt(int height, int columns)
        {
            // set the backgroundColor to some default
            backgroundColor = ConsoleColor.Blue;   // or whatever you like
            // set the foregroundColor to some default
            foregroundColor = ConsoleColor.White; // or whatever you like
            // create the screen to hold the number of rows passed in with the height parameter
            screenText = new string[height];

            // we will use the C# object to set the size of our window.
            Console.SetWindowSize(columns, height + 7);

            // let's set the initial screen rows to all blank lines
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        }   // end of CommandPrompt constructor

        public void Display()
        {
            // set the foreground and background colors

            Console.BackgroundColor = backgroundColor;
            Console.ForegroundColor = foregroundColor;

            Console.Clear();             //  the Console object is available to us to control aspects of our terminal window. The Clear method will blank our window
                                         // The Clear method has blanked the screen and left the cursor at the top of the window.
                                         // We will now loop through the screenText array to put out text on the screen.
            for (int i = 0; i < screenText.Length; i++)
            {
                Console.WriteLine(screenText[i]);
            }
        }   // end of Display method

        public void SetScreenText(int lineNumber, string lineOfText)
        {
            screenText[lineNumber] = lineOfText;
        }   // end of SetScreenText method

        public void SetBackgroundColor(string color)
        {
            backgroundColor = ConvertColor(color);
        }   // end of SetBackgroundColor

        public void SetForegroundColor(string color)
        {
            foregroundColor = ConvertColor(color);
        }   // end of SetForegroundColor

        public static ConsoleColor ConvertColor(string strColor)
        {
            ConsoleColor color;
            switch (strColor.ToLower())
            {
                case "black": color = ConsoleColor.Black; break;
                case "blue": color = ConsoleColor.Blue; break;
                case "cyan": color = ConsoleColor.Cyan; break;
                case "darkblue": color = ConsoleColor.DarkBlue; break;
                case "darkcyan": color = ConsoleColor.DarkCyan; break;
                case "darkgray": color = ConsoleColor.DarkGray; break;
                case "darkgreen": color = ConsoleColor.DarkGreen; break;
                case "darkmagenta": color = ConsoleColor.DarkMagenta; break;
                case "darkred": color = ConsoleColor.DarkRed; break;
                case "darkyellow": color = ConsoleColor.DarkYellow; break;
                case "gray": color = ConsoleColor.Gray; break;
                case "green": color = ConsoleColor.Green; break;
                case "magenta": color = ConsoleColor.Magenta; break;
                case "red": color = ConsoleColor.Red; break;
                case "white": color = ConsoleColor.White; break;
                case "yellow": color = ConsoleColor.Yellow; break;
                default: color = ConsoleColor.DarkGray; break;
            }
            return color;
        }   // end of ConvertColor method

        public void SaveScreen(string fileName)
        {
            FileStream stream;
            StreamWriter textOut = null;
            try
            {
                stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                textOut = new StreamWriter(stream);

                textOut.WriteLine(backgroundColor.ToString());
                textOut.WriteLine(foregroundColor.ToString());

                for (int i = 0; i < screenText.Length; i++)
                {
                    textOut.WriteLine(screenText[i]);
                }
                textOut.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textOut != null)
                    textOut.Close();
            }
        }   // of of SaveScreen method

        public void ReloadScreen(string fileName)
        {
            FileStream stream;
            StreamReader textIn = null;
            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                textIn = new StreamReader(stream);

                //                Console.WriteLine(textIn.ReadToEnd());

                int i = 0, cnt = 0;
                while (!textIn.EndOfStream)
                {
                    cnt++;
                    if (cnt == 1)
                    {
                        SetBackgroundColor(textIn.ReadLine());
                    }
                    else if (cnt == 2)
                    {
                        SetForegroundColor(textIn.ReadLine());
                    }
                    else
                    { 
                        screenText[i] = textIn.ReadLine();
                        i++;
                    }
                }
                textIn.Close();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Creating file: ");
                Console.WriteLine(ex.ToString());
                return;
            }
            finally
            {
                if (textIn != null)
                    textIn.Close();
            }
        } // of of ReloadScreen method

        public void ClearScreen()
        {
            for (int i = 0; i < screenText.Length; i++)
            {
                screenText[i] = "";
            }
        } // of of ClearScreen method

    }   // end of CommandPrompt class
}
