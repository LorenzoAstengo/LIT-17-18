using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    public class OutsideWithDoors : Outside,IHasExteriorDoors
    {
        public string DoorDescription { get; private set; }

        public OutsideWithDoors(string name, bool hot, string doorDescription) : base(name,hot)
        {
            DoorDescription = doorDescription;
        }

        public Location DoorLocation { get; set; }
    }
}
