using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hide_and_seek
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location location)
        {
            random = new Random();
            myLocation = location;
        }

        public void Move()
        {
            do
            {
                if (myLocation is IHasExteriorDoor)
                {
                    if (random.Next(2) == 1)
                    {
                        IHasExteriorDoor hasExteriorDoor = myLocation as IHasExteriorDoor;
                        myLocation = hasExteriorDoor.DoorLocation;
                    }
                }
                int MoveIndex = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[MoveIndex];
            }
            while (myLocation is IHidingPlace == false);
        }
        public bool Check(Location checkLocation)
        {
            if (myLocation==checkLocation)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}