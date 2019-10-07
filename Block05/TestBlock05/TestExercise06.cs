using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise06;

namespace TestBlock05
{
    [TestClass]
    public class TestExercise06
    {
        Point[] points = { new Point(1, 2),
        new Point(1.50, 0.005), new Point(0, 0.00005),
        new Point(0.25,0.395), new Point(2.95, 4.50) };
        double epsilon = 0.0001;

        public static bool IsCloseToZero(Point point)
        {
            if (Math.Abs(point.X + point.Y) <= 0.0001)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int ComparePoints(Point a, Point b)
        {
            if (a.X == b.X && a.Y == b.Y)
            {
                return 0;
            }
            else if (a.X > b.X && a.Y > b.Y)
            {
                return 1;
            }
            else if (a.X < b.X && a.Y < b.Y)
            {
                return -1;
            }
            else if (a.X + a.Y > b.X + b.Y)
            {
                return 1;
            }
            else
                return -1;
        }

        [TestMethod]
        public void TestFirstInArrayAnonymous()
        {
            Point pointCloseToZero = Array.Find(points, delegate (Point point)
            {
                if (Math.Abs(point.X + point.Y) <= epsilon)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            });

            Assert.AreEqual(points[2].X, pointCloseToZero.X, epsilon);
            Assert.AreEqual(points[2].Y, pointCloseToZero.Y, epsilon);
        }

        [TestMethod]
        public void TestFirstInArrayStatic()
        {
            Point pointCloseToZero = Array.Find(points, IsCloseToZero);
            Assert.AreEqual(points[2].X, pointCloseToZero.X, epsilon);
            Assert.AreEqual(points[2].Y, pointCloseToZero.Y, epsilon);
        }

        [TestMethod]
        public void TestSort()
        {
            Array.Sort(points, ComparePoints);                        //I have to use comparison predicate because it isn't defined a comparison method for Point objects, so I have to define it.
            Point[] exp = { new Point(0, 0.00005), new Point(0.25,0.395),
            new Point(1.50, 0.005), new Point(1, 2),new Point(2.95, 4.50) };
            for (int i = 0; i < points.Length; i++)
            {
                Assert.AreEqual(exp[i].X, points[i].X);
                Assert.AreEqual(exp[i].Y, points[i].Y);
            }
        }
    }
}
