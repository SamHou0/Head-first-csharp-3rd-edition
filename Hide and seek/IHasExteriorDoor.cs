using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_and_seek
{
     interface IHasExteriorDoor
    {
        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }
    }
}
