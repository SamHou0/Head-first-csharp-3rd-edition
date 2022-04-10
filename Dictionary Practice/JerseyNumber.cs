using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Practice
{
    internal class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }
        public JerseyNumber(string Player, int numberRetired)
        {
            this.Player = Player;
            YearRetired = numberRetired;
        }
    }
}
