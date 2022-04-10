using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_and_seek
{
     class Room : Location
    {
        private string decoration;
        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }
        public override string Description
        {
            get
            {
                return base.Description + " You see " + decoration + " here.";//直接使用基类的避免重复
            }
        }
    }
}
