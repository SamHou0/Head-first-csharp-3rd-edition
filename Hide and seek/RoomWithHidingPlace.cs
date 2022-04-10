using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hide_and_seek
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public RoomWithHidingPlace(string name, string decoration, string hidePlace) : base(name, decoration)
        {
            HidePlace = hidePlace;
        }

        public string HidePlace { get; }
    }
}