using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exercise09;

namespace Exercise09
{
    public partial class Exercise09Form : Form
    {

        HouseMove houseMove;
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoors frontYard;
        OutsideWithDoors backYard;
        Outside garden;

        private void MoveToANewLocation(Location location)
        {
            houseMove.MoveToANewLocation(location);
            exits.Items.Clear();
            foreach (Location l in houseMove.CurrentLocation.Exits)
                exits.Items.Add(l.Name);
            exits.SelectedIndex = 0;

            description.Text = houseMove.CurrentLocation.Description;
            if (houseMove.CurrentLocation is IHasExteriorDoors)
                goThroughTheDoor.Visible = true;
            else
                goThroughTheDoor.Visible = false;
        }

        private void CreateLocations()
        {
            livingRoom = new RoomWithDoor("Living Room", "an antique carpet", "an oak door with a brass knob");
            diningRoom = new Room("Dining Room", "a crystal chandelier");
            kitchen = new RoomWithDoor("Kitchen", "stainless steel appliances", "a screen door");
            frontYard = new OutsideWithDoors("Front Yard", false, "an oak door with a brass knob");
            backYard = new OutsideWithDoors("Back Yard", true, "a screen door");
            garden = new Outside("Garden", false);
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
            houseMove = new HouseMove(livingRoom);
        }

        public Exercise09Form()
        {
            InitializeComponent();
            CreateLocations();
            MoveToANewLocation(livingRoom);
        }

        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoors hasDoor = (IHasExteriorDoors)houseMove.CurrentLocation;
            MoveToANewLocation(hasDoor.DoorLocation);
        }

        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(houseMove.CurrentLocation.Exits[exits.SelectedIndex]);
        }
    }
}
