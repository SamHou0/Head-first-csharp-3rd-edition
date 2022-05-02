using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farmer
{
    internal class Farmer
    {
        public Farmer(int numberOfCows, int feedMultiplier)
        {
            this.feedMultiplier = feedMultiplier;
            NumbersOfCows = numberOfCows;
        }

        public int BagsOfFeed { get; private set; }
        private int feedMultiplier;
        public int FeedMultiplier { get { return feedMultiplier; } }

        private int numbersOfCows;

        public int NumbersOfCows
        {
            get
            {
                return numbersOfCows;
            }
            set
            {
                numbersOfCows = value;
                BagsOfFeed = numbersOfCows * FeedMultiplier;
            }
        }
    }
}