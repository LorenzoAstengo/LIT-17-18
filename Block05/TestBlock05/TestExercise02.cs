using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;
using System.Collections.Generic;

namespace TestBlock05
{
    [TestClass]
    public class TestExercise02
    {
        [TestMethod]
        public void TestArrayAndSorting()
        {
            Die a = new Die();
            a.Toss();
            Die b = new Die();
            b.Toss();
            Die c = new Die();
            c.Toss();
            Die d = new Die();
            d.Toss();
            Die e = new Die();
            e.Toss();

            Die[] arr = new Die[5];
            arr[0] = a;
            arr[1] = b;
            arr[2] = c;
            arr[3] = d;
            arr[4] = e;
            Array.Sort(arr);

            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1].CompareTo(arr[i]) == -1)
                    Assert.Fail();
            }
        }

        [TestMethod]
        public void TestTwoSixeInARow()
        {
            Die a = new Die();
            bool twoSixes = false;
            int counter = 0;

            a.twoSixesInARow += delegate
            {
                twoSixes = true;
            };
            a.twoSixesInARow += delegate
            {
                counter++;
            };

            for (int i = 0; i < 1000; i++)
            {
                a.Toss();
            }

            Assert.IsTrue(twoSixes);
            Assert.IsTrue(counter != 0);
        }

        [TestMethod]
        public void TestFullHouse()
        {
            Die a = new Die();
            bool fullHouse = false;

            a.fullHouse += delegate ()
            {
                fullHouse = true;
            };

            for (int i = 1; i < 1000; i++)
            {
                a.Toss();
            }

            Assert.IsTrue(fullHouse);
        }
    }
}
