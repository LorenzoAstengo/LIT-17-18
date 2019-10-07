using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    public class HouseMove
    {
        public Location CurrentLocation { get; set; }

        public void MoveToANewLocation(Location newLocation)
        {
            CurrentLocation = newLocation;
        }

        public HouseMove(Location location)
        {
            CurrentLocation = location;
        }

        public void GoThroughExteriorDoor()
        {
            var extDoors = (IHasExteriorDoors)CurrentLocation;
            if (extDoors != null)
                MoveToANewLocation(extDoors.DoorLocation);
            else
                throw new Exception("This location has no doors.");
        }
    }
}
