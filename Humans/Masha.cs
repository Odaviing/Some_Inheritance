using System;
using System.Collections.Generic;
using System.Text;

namespace Humans
{
    class Masha : Women
    {
        public override string GiveBirth()
        {
            Random rand = new Random();
            return "You have " + rand.Next(5) + " babies";
        }

        public override string Pregnancy()
        {
            return "Congratulations! You are pregnant!";
        }

        public override string Run(int distance)
        {
            if (distance > 100)
            {
                return "You are tired";
            }
            else
            {
                return "You are not tired";
            }
        }

        public override string Talk()
        {
            return "Yes";
        }

        public string ListenToMusic()
        {
            return "Let's rock!";
        }

        public string ReadBooks()
        {
            return "One Ring to rule them all...";
        }
    }
}
