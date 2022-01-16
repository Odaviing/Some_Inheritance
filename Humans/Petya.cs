using System;
using System.Collections.Generic;
using System.Text;

namespace Humans
{
    class Petya : Men
    {
        public override string Fertilize()
        {
            return "You are the father";
        }

        public override string Run(int distance)
        {
            if (distance > 500)
            {
                return "You are tired";
            }
            else
            {
                return "You are not tired";
            };
        }

        public override string Talk()
        {
            return "No";
        }

        public override string ThinkWithThePowerOf200IQ()
        {
            return "2 + 2 = 4";
        }

        public string PlayDND()
        {
            Random rand = new Random();
            int dmg = rand.Next(1, 6) + rand.Next(1, 6) + rand.Next(1, 6) + rand.Next(1, 6) + rand.Next(1 ,6);
            return "My fireball damage is " + dmg + " points";
        }

        public string Archery()
        {
            Random rand = new Random();
            return "I made " + rand.Next(5, 10) + " shots. Only " + rand.Next(0, 3) + " was successfull";
        }
    }
}
