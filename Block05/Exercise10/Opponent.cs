using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercise09;

namespace Exercise10
{
    public class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location location)
        {
            myLocation = location;
            random = new Random();
        }

        public void Move()
        {
            if (myLocation is IHasExteriorDoors)
            {
                IHasExteriorDoors locationWithDoor = myLocation as IHasExteriorDoors;
                if (random.Next(2) == 1)
                    myLocation = locationWithDoor.DoorLocation;
                int rand = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];
                if (myLocation is IHidingPlace)
                {                    
                }                    
                else
                    Move();
            }
        }

        public bool Check(Location locationToCheck)
        {
            if (locationToCheck != myLocation)
                return false;
            else
                return true;
        }
    }
}
