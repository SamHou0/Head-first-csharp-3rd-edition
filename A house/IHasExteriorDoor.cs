using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_house
{
    internal interface IHasExteriorDoor
    {
        public string DoorDescription { get;}
        public Location DoorLocation { get; set;}
    }
}
