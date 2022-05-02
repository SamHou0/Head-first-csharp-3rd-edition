using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hide_and_seek
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public OutsideWithHidingPlace(string name, bool hot, string hidePlace) : base(name, hot)
        {
            HidePlace = hidePlace;
        }

        public string HidePlace { get;  set; }
        public override string Description { get { return base.Description; } }
    }
}