using System;
using System.Windows.Forms;

namespace A_day_at_the_races
{
    public class Greyhound
    {
        public int StartingPosition;
        public int RacetrackLength;
        public PictureBox MyPictureBox = null;
        public int Location = 0;
        public Random Randommizer;

        public bool Run()
        {
            Location += Randommizer.Next(4);
            MyPictureBox.Left = StartingPosition + Location;
            if (MyPictureBox.Left >= RacetrackLength)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void TakeStartingPosition()
        {
            Location = 0;
            MyPictureBox.Left = StartingPosition + Location;
        }
    }
}