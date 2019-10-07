using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    public class Outside : Location
    {
        private bool Hot;

        public Outside(string name, bool hot) : base(name)
        {
            this.Hot = hot;
        }

        public override string Description
        {
            get
            {
                if (Hot)
                {
                    return base.Description + " It's very hot here. ";
                }
                else
                    return base.Description;               
            }
        }
    }
}
