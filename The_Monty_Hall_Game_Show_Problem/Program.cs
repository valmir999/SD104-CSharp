using System;
namespace The_Monty_Hall_Game_Show_Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] doors;
            int nSwapped = 0, nStayed = 0;
            int nPlayer = 0;
            int nEliminated = 0;
            bool didSwap;
            Random rand = new Random();
            for (int n = 0; n < 10000; n++)
            {
                doors = new bool[] { false, false, false };               
                
                //initial car placement and player pic                
                doors[rand.Next( 0, 2 )] = true;
                nPlayer = n % 3;
                didSwap = false;                //find door to eliminate               
                for ( int m = 0; m < doors.Length; m++ )
                {
                    if ( !doors[m] && m != nPlayer )
                    {
                        nEliminated = m;
                        break;
                    }
                }
                //player swaps on even                
                if ( n % 2 == 0 )
                {
                    //find other door to switch to                    
                    for ( int s = 0; s < doors.Length; s++ )
                    {
                        if ( s != nEliminated && s != nPlayer )
                        {
                            nPlayer = s;
                            break;
                        }
                    }
                    didSwap = true;
                }
                //see if player won or lost                
                if ( doors[nPlayer] && didSwap )
                {
                    nSwapped++;
                }
                else if ( doors[nPlayer] && !didSwap )
                {
                    nStayed++;
                }
            }
            Console.WriteLine("The player won {0} times when swapping and {1} times when not swapping out of 10,000 turns.", nSwapped, nStayed); Console.ReadLine();
        }
    }
}
