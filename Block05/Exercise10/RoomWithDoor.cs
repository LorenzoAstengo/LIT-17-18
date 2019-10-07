using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise09;

namespace Exercise10
{
    public class RoomWithDoor : RoomWithHidingPlace,IHasExteriorDoors
    {
        public string DoorDescription { get; private set; }

        public RoomWithDoor(string name, string decoration, string hidingPlaceName, string doorDescription) : base(name, decoration, hidingPlaceName)
        {
            DoorDescription = doorDescription;
        }

        public Location DoorLocation { get; set; }
    }
}
