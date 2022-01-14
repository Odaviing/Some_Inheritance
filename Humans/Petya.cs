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
    }
}
