using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_and_seek
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription, string hidePlace) : base(name, decoration, hidePlace)
        {
            DoorDescription = doorDescription;
        }
        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }
    }
}
