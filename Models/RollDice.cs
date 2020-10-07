using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebDiceSimulator.Models
{
    public class RollDice
    {
        public string Die1 { get; set; }
        public string Die2 { get; set; }

        public string[] rollDice()
        {
            string[] dice = new string[2];
            int n1, n2;

            Random rand = new Random();

            n1 = rand.Next(6) + 1;
            n2 = rand.Next(6) + 1;

            switch (n1)
            {
                case 1: dice[0] = "Die1.bmp"; break;
                case 2: dice[0] = "Die2.bmp"; break;
                case 3: dice[0] = "Die3.bmp"; break;
                case 4: dice[0] = "Die4.bmp"; break;
                case 5: dice[0] = "Die5.bmp"; break;
                case 6: dice[0] = "Die6.bmp"; break;
            }

            switch (n2)
            {
                case 1: dice[1] = "Die1.bmp"; break;
                case 2: dice[1] = "Die2.bmp"; break;
                case 3: dice[1] = "Die3.bmp"; break;
                case 4: dice[1] = "Die4.bmp"; break;
                case 5: dice[1] = "Die5.bmp"; break;
                case 6: dice[1] = "Die6.bmp"; break;
            }

            return dice;
        }
    }
}