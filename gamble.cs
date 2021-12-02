using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingGame
{
    class gamble
    {
        public static void gambleGame()
        {


            double cash, betAmount;
            Console.WriteLine("Welcome to Gambler Game");
            Console.WriteLine("Please Enter Cash Amount");
            cash = double.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter Bet Amount");
            betAmount = double.Parse(Console.ReadLine());
            WinorLoose.winLoose();
        }
    }
}