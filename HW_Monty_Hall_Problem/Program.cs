using System;

class Program
{
    static Random _random = new Random();

    static void Main()
    {
        int winsWithSwitch = 0;
        int winsWithoutSwitch = 0;
        int simulations = 0;
        // Run simulations.
        while (true)
        {
            // Add to wins without switching.
            winsWithoutSwitch += Game(false) ? 1 : 0;
            // Add to wins with switching.
            winsWithSwitch += Game(true) ? 1 : 0;
            simulations++;
            // After one million simulations, print results.
            if ((simulations % 1000000) == 0)
            {
                Console.WriteLine("Simulations: " + simulations);
                Console.WriteLine("Wins without switch: " +
                    winsWithoutSwitch);
                Console.WriteLine("Percentage:          " +
                    ((double)winsWithoutSwitch / simulations) * 100);
                Console.WriteLine("Wins with switch:    " +
                    winsWithSwitch);
                Console.WriteLine("Percentage:          " +
                    ((double)winsWithSwitch / simulations) * 100);
                Console.ReadLine();
            }
        }
    }

    static bool Game(bool switchDoor)
    {
        // Generate car position.
        int car = GenerateGoatsandCar();
        // Choose a random door.
        int firstDoor = GenerateFirstDoorChoice();
        // Host shows random goat.
        int randomGoat = GenerateRandomGoat(firstDoor, car);
        int finalChoice;
        if (switchDoor)
        {
            // Switch to different door after host shows goat.
            finalChoice = SwitchDoor(firstDoor, randomGoat);
        }
        else
        {
            // Do not switch.
            finalChoice = firstDoor;
        }
        // True if we got the car.
        return finalChoice == car;
    }

    static int GenerateFirstDoorChoice()
    {
        // Choice can be 0, 1 or 2.
        int choice = _random.Next(3);
        return choice;
    }

    static int GenerateGoatsandCar()
    {
        // Assume all goats except car.
        // ... Car can be 0, 1 or 2.
        int car = _random.Next(3);
        return car;
    }

    static int GenerateRandomGoat(int firstDoorChoice,
        int carPosition)
    {
        while (true)
        {
            // Random goat can be 0, 1 or 2.
            int randomGoat = _random.Next(3);
            // Random goat cannot be the current choice or a car.
            if (randomGoat == firstDoorChoice ||
                randomGoat == carPosition)
            {
                continue;
            }
            // Return random goat.
            return randomGoat;
        }
    }

    static int SwitchDoor(int firstDoorChoice,
        int randomGoat)
    {
        int switchDoorResult = 0;
        while (true)
        {
            // Never switch to the goat or to the first door.
            if (switchDoorResult == firstDoorChoice ||
                switchDoorResult == randomGoat)
            {
                // Try next door.
                switchDoorResult++;
                continue;
            }
            // Switch to this door.
            return switchDoorResult;
        }
    }
}