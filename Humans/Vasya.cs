using System;
using System.Collections.Generic;
using System.Text;

namespace Humans
{
    class Vasya : Men
    {
        public override string Fertilize()
        {
            return "You are not the father";
        }

        public override string Run(int distance)
        {
            if (distance > 1000)
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
            return "Maybe";
        }

        public override string ThinkWithThePowerOf200IQ()
        {
            return "2 + 2 = 5";
        }

        public string PlayMTG()
        {
            return "Draw - Mountain - Bolt the bird - Pass";
        }

        public string WatchYoutube()
        {
            return "Those memes are funny";
        }
    }
}
