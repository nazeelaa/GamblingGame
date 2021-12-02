using System;
using System.Collections.Generic;
using System.Text;

namespace GamblingGame
{
    class WinorLoose
    {
        
        public static void winLoose()
        {
            double betamount=1;
            Console.WriteLine("Betingt amount is $1");
            if (betamount == 1)
            {
                Console.WriteLine("win");
            }

            else
            {
                Console.WriteLine("loose");
            }

        }
    }
}