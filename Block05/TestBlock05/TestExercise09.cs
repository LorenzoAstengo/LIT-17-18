using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise09;

namespace TestBlock05
{
    [TestClass]
    public class TestExercise09
    {        
        RoomWithDoor livingRoom;
        Room diningRoom;
        RoomWithDoor kitchen;
        OutsideWithDoors frontYard;
        OutsideWithDoors backYard;
        Outside garden;

        [TestInitialize]
        public void TestInitialize()
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
        }

        [TestMethod]
        public void TestLivingRoom()
        {
            Location currentLocation = livingRoom;
            Assert.AreEqual("You're standing in the Living Room. You see exits to the following places:  Dining Room. You see an antique carpet.",
                currentLocation.Description);
        }
        [TestMethod]
        public void TestDiningRoom()
        {
            Location currentLocation = diningRoom;
            Assert.AreEqual("You're standing in the Dining Room. You see exits to the following places:  Living Room, Kitchen. You see a crystal chandelier.",
                currentLocation.Description);
        }
        [TestMethod]
        public void TestBackYard()
        {
            Location currentLocation = backYard;
            Assert.AreEqual("You're standing in the Back Yard. You see exits to the following places:  Front Yard, Garden. It's very hot here. ",
                currentLocation.Description);
        }
        [TestMethod]
        public void TestMoveToLocation()
        {
            Location currentLocation = livingRoom;
            HouseMove houseMove = new HouseMove(currentLocation);
            Assert.AreEqual("Living Room",
                houseMove.CurrentLocation.Name);
            houseMove.MoveToANewLocation(diningRoom);
            Assert.AreEqual("Dining Room",
                houseMove.CurrentLocation.Name);
        }
        [TestMethod]
        public void TestMoveThroughExteriorDoor()
        {
            Location currentLocation = livingRoom;
            HouseMove houseMove = new HouseMove(currentLocation);
            houseMove.GoThroughExteriorDoor();
            Assert.AreEqual("Front Yard",
                houseMove.CurrentLocation.Name);
        }
    }
}
