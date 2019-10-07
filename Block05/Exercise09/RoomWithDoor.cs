using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    public class RoomWithDoor : Room,IHasExteriorDoors
    {
        public string DoorDescription { get; private set; }

        public RoomWithDoor(string name, string decoration, string doorDescription) : base(name, decoration)
        {
            DoorDescription = doorDescription;
        }

        public Location DoorLocation { get; set; }
    }
}
