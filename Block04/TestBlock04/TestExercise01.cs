using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise01
    {
        [TestMethod]
        public void TestReturnToZero()
        {
            Robot robot = new Robot();
            robot.Move(0, 0, 'N', "RALALALA");
            robot.X = 0;
            robot.Y = 0;
        }

        [TestMethod]
        public void Test2()
        {
            Robot robot = new Robot();
            robot.Move(0, 0, 'N', "RAAARAALA");
            robot.X = 4;
            robot.Y = -2;
        }

        [TestMethod]
        public void TestToNegative()
        {
            Robot robot = new Robot();
            robot.Move(0, 0, 'N', "LAAALAALA");
            robot.X = -2;
            robot.Y = -2;
        }

        [TestMethod]
        public void TestRotation()
        {
            Robot robot = new Robot();
            robot.Move(0, 0, 'N', "RRRR");
            robot.Direction = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), noExceptionMessage: "Invalid movement must return argument exception.")] 
        public void TestInvalidMovements()
        {
            Robot robot = new Robot();
            robot.Move(0, 0, 'N', "CIAO");
        }




    }
}
