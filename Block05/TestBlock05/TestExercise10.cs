using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise10;
using Exercise09;

namespace TestBlock05
{
    [TestClass]
    public class TestExercise10
    {
        Exercise10.RoomWithDoor livingRoom;
        RoomWithHidingPlace diningRoom;
        Exercise10.RoomWithDoor kitchen;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;
        OutsideWithDoors frontYard;
        OutsideWithDoors backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveway;
        

        [TestInitialize]
        public void TestInitialize()
        {
            livingRoom = new Exercise10.RoomWithDoor("Living Room", "an antique carpet", "inside the closet", "an oak door with a brass handle");
            diningRoom = new RoomWithHidingPlace("Dining Room", "a crystal chandelier", "in the tall armoire");
            kitchen = new Exercise10.RoomWithDoor("Kitchen", "stainless steel appliances", "in the cabinet", "a screen door");
            stairs = new Room("Stairs", "a wooden bannister");
            hallway = new RoomWithHidingPlace("Upstairs Hallway", "a picture of a dog", "in the closet");
            bathroom = new RoomWithHidingPlace("Bathroom", "a sink and a toilet", "in the shower");
            masterBedroom = new RoomWithHidingPlace("Master Bedroom", "a large bed", "under the bed");
            secondBedroom = new RoomWithHidingPlace("Second Bedroom", "a small bed", "under the bed");
            frontYard = new OutsideWithDoors("Front Yard", false, "a heavy-looking oak door");
            backYard = new OutsideWithDoors("Back Yard", true, "a screen door");
            garden = new OutsideWithHidingPlace("Garden", false, "inside the shed");
            driveway = new OutsideWithHidingPlace("Driveway", true, "in the garage");
            diningRoom.Exits = new Location[] { livingRoom, kitchen };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveway };
            backYard.Exits = new Location[] { frontYard, garden, driveway };
            garden.Exits = new Location[] { backYard, frontYard };
            driveway.Exits = new Location[] { backYard, frontYard };
            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        [TestMethod]
        public void TestKitchen()
        {

            Opponent opponent;
            Location currentLocation = kitchen;
            Assert.AreEqual("You're standing in the Kitchen. You see exits to the following places:  Dining Room. You see stainless steel appliances. Someone could hide in the cabinet.",
                currentLocation.Description);
            opponent = new Opponent(kitchen);
            Assert.IsTrue(opponent.Check(kitchen));
        }
    }
}
