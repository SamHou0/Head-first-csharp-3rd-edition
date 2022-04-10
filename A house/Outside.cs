using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_house
{
    internal class Outside : Location
    {
        private bool hot;
        public Outside(string name,bool hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Description { get
            {
                string newDescription=base.Description;
                if (hot)
                {
                    newDescription += " It's very hot here.";
                }
                return newDescription;

            } }

    }
}
