using System;

namespace MontyHall
{
    class Program
    {
        static public int playNum = 0; 
        static void Main(string[] args)
        {
            Random random = new Random();
            int wins = 0;
            int losses = 0;

            Console.WriteLine("     Monty Hall Game Show 10,000 times in a For loop");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("  Play#      Door 1             Door2              Door2");
            Console.WriteLine("             ------             -----              -----");

            for (int i = 0; i < 100; i++)
            {
                int changeDoor = 1;
                playNum++;

                bool result = MontyHallPick(random.Next(3), changeDoor,
                                            random.Next(3), random.Next(1));
                if (result) wins++;
                else losses++;
                System.Threading.Thread.Sleep(100);
            }

            Console.WriteLine();
            Console.WriteLine("SUMMARY");
            Console.WriteLine("-------");

            Console.WriteLine("Wins: {0} Losses: {1}  Total: {2}",
                              wins, losses, wins + losses);
            Console.ReadLine();
        }


        public static string NumberOfPlay(int num)
        {
            return num.ToString("D7");
        }

        public static bool MontyHallPick(int pickedDoor, int changeDoor,
                                      int carDoor, int goatDoorToRemove)
        {
            bool win = false;

            int leftGoat = 0;
            int rightGoat = 2;
            string displayPickedDoorResult;
            string displayPickedDoor1Win;
            string displayPickedDoor1Loose;
            string displayPickedDoor2Win;
            string displayPickedDoor2Loose;
            string displayPickedDoor3Win;
            string displayPickedDoor3Loose;

            switch (pickedDoor)
            {
                case 0: leftGoat = 1; rightGoat = 2; break;
                case 1: leftGoat = 0; rightGoat = 2; break;
                case 2: leftGoat = 0; rightGoat = 1; break;
            }

            int keepGoat = goatDoorToRemove == 0 ? rightGoat : leftGoat;

            if (changeDoor == 0) { win = carDoor == pickedDoor; }
            else { win = carDoor != keepGoat; }

            displayPickedDoor1Win   = "     -win-             -----              -----";
            displayPickedDoor1Loose = "     -----             -win-              -----";
            displayPickedDoor2Win   = "     -----             -----              -win-";
            displayPickedDoor2Loose = "     loose             -----              -----";
            displayPickedDoor3Win   = "     -----             loose              -----";
            displayPickedDoor3Loose = "     -----             -----              loose";


            if (pickedDoor == 1)
            {
                if (win) { displayPickedDoorResult = displayPickedDoor1Win; }
                else displayPickedDoorResult = displayPickedDoor1Loose;
            }
            else if (pickedDoor == 2)
            {
                if (win) { displayPickedDoorResult = displayPickedDoor2Win; }
                else displayPickedDoorResult = displayPickedDoor2Loose;
            }
            else
            {
                if (win) { displayPickedDoorResult = displayPickedDoor3Win; }
                else displayPickedDoorResult = displayPickedDoor3Loose;
            }

            Console.WriteLine(NumberOfPlay(playNum)+ "  " + displayPickedDoorResult);
            return win;
        }

        static void Play1000Loop()
        {
            Random random = new Random();
            int wins = 0;
            int losses = 0;

            for (int i = 0; i < 1000000; i++)
            {
                int changeDoor = 1;

                bool result = PickADoor(random.Next(3), changeDoor,
                                            random.Next(3), random.Next(1));
                if (result) wins++;
                else losses++;
            }

            Console.WriteLine("Wins: {0} Losses: {1}  Total: {2}",
                              wins, losses, wins + losses);
        }
        public static bool PickADoor(int pickedDoor, int changeDoor,
                                      int carDoor, int goatDoorToRemove)
        {
            bool win = false;

            int leftGoat = 0;
            int rightGoat = 2;
            switch (pickedDoor)
            {
                case 0: leftGoat = 1; rightGoat = 2; break;
                case 1: leftGoat = 0; rightGoat = 2; break;
                case 2: leftGoat = 0; rightGoat = 1; break;
            }

            int keepGoat = goatDoorToRemove == 0 ? rightGoat : leftGoat;

            if (changeDoor == 0) { win = carDoor == pickedDoor; }
            else { win = carDoor != keepGoat; }

            return win;
        }
    }
}