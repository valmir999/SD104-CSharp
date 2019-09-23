using System;
using System.Globalization;

namespace HW4_TheMontyHallGameShowProblem
{
    class Program
    {
        static public int Seq = 0;
        static void Main(string[] args)
        {
            DisplayHeader();
            PlayGame();
            Console.ReadLine();
        }
        static void DisplayHeader()
        {
            Console.WriteLine("         Monty Hall Game Show 10,000 times in a For loop");
            Console.WriteLine("         -----------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("Seq #        Door 1            Door2              Door2");
            Console.WriteLine("------       ------            -----              -----");
        }
        static void PlayGame()
        {
            Random random = new Random();
            bool[] doors;
            int wins = 0;
            int losses = 0;
            int winDoor, playersDoor, removedDoor, holdDoor, winsWithSwap = 0, winsWithoutSwap = 0;
            const int seqLimit = 10000;

            for (int i = 0; i < seqLimit; i++)
            {
                //initial car placement and player pic                
                doors = new bool[] { false, false, false };
                winDoor = random.Next(3);
                doors[winDoor] = true;
                holdDoor = playersDoor = i % 3; // player's door first choice
                Seq++;

                //remove door other than winning and players door
                removedDoor = removeDoor(doors, winDoor, playersDoor);

                //player swaps door on even numbers
                if (i % 2 == 0) { playersDoor = PlayerSwapDoor(doors, playersDoor, removedDoor); }

                bool result = checkIfPlayerWon(doors, winDoor, playersDoor);

                Console.WriteLine(PlaySequence(Seq) + "  " + displayDoorMsg(playersDoor, result));
                if (result)
                {
                    if (holdDoor != playersDoor) { winsWithSwap++; }
                    else { winsWithoutSwap++; }
                }
                else losses++; // count losses
                System.Threading.Thread.Sleep(50);
            }

            // Total wins
            wins = winsWithSwap + winsWithoutSwap;

            Console.WriteLine();
            Console.WriteLine("Summary");
            Console.WriteLine("-------");

            double winsWithSwapPerc = (double)winsWithSwap / wins;
            double winsWithoutSwapPerc = (double)winsWithoutSwap / wins;
            double winsPerc = (double)wins / seqLimit;
            double lossesPerc = (double)losses / seqLimit;

            Console.WriteLine("Wins with swaps.....: {0}", winsWithSwap);
            Console.WriteLine("Wins without swaps..: {0}", winsWithoutSwap);
            Console.WriteLine("                      ----");
            Console.WriteLine("Total number of wins: {0}", wins);
            Console.WriteLine();
            Console.WriteLine("Percentage of wins with swaps...: {0}", winsWithSwapPerc.ToString("P", CultureInfo.InvariantCulture));
            Console.WriteLine("Percentage of wins without swaps: {0}", winsWithoutSwapPerc.ToString("P", CultureInfo.InvariantCulture));
            Console.WriteLine();
            Console.WriteLine("Overall total of wins..........: {0}", wins);
            Console.WriteLine("Overall total of losses........: {0}", losses);
            Console.WriteLine("Grand total of number of plays.: {0}", wins + losses);
            Console.WriteLine();
            Console.WriteLine("Overall wins percentage..: {0}", winsPerc.ToString("P", CultureInfo.InvariantCulture));
            Console.WriteLine("Overall losses percentage: {0}", lossesPerc.ToString("P", CultureInfo.InvariantCulture));

            Console.WriteLine();
            Console.WriteLine("Hit any key to exit...");
        }

        public static int removeDoor(bool[] drs, int wDoor, int pDoor)
        {
            int rDoor = 0;

            for (int i = 0; i < drs.Length; i++)
            {
                if (i != wDoor && i != pDoor)
                {
                    rDoor = i;
                    break;
                }
            }
            return rDoor;
        }
        public static int PlayerSwapDoor(bool[] d, int pDoor, int rDoor)
        {
            int newDoor = pDoor;

            for (int i = 0; i < d.Length; i++)
            {
                if (i != pDoor && i != rDoor)
                {
                    newDoor = i;
                    break;
                }
            }
            return newDoor;
        }
        public static bool checkIfPlayerWon(bool[] d, int wDoor, int pDoor)
        {
            bool win = false;

            if (pDoor == wDoor) { win = true; }
            return win;
        }
        public static string displayDoorMsg(int pDoor, bool w)
        {
            int x = pDoor + 1; // Doors are: door #1, #2 or #3
            string displayResult = "";
            string displaydoor1Win = "     win              -----              -----";
            string displaydoor1Loose = "    loose             -----              -----";
            string displaydoor2Win = "    -----              win               -----";
            string displaydoor2Loose = "    -----             loose              -----";
            string displaydoor3Win = "    -----             -----               win ";
            string displaydoor3Loose = "    -----             -----              loose";


            if (x == 1)
            {
                if (w) { displayResult = displaydoor1Win; }
                else displayResult = displaydoor1Loose;
            }
            else if (x == 2)
            {
                if (w) { displayResult = displaydoor2Win; }
                else displayResult = displaydoor2Loose;
            }
            else
            {
                if (w) { displayResult = displaydoor3Win; }
                else displayResult = displaydoor3Loose;
            }
            return displayResult;
        }
        public static string PlaySequence(int num)
        {
            return num.ToString("D7");
        }
    }
}