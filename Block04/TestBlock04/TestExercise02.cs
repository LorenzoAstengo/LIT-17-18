using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise02;

namespace TestBlock04
{
    [TestClass]
    public class TestExercise02
    {
        [TestMethod]
        public void TestReverse()
        {
            SimpleLinkedList<int> linkedList = new SimpleLinkedList<int>();
            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            int[] res = linkedList.Reverse().ToArray();
            Assert.AreEqual(1, res[0]);
            Assert.AreEqual(2, res[1]);
            Assert.AreEqual(3, res[2]);
        }

        [TestMethod]
        public void TestToArray()
        {
            SimpleLinkedList<int> linkedList = new SimpleLinkedList<int>();
            linkedList.AddNode(1);
            linkedList.AddNode(2);
            linkedList.AddNode(3);
            int[] res = linkedList.ToArray();
            Assert.AreEqual(3, res[0]);
            Assert.AreEqual(2, res[1]);
            Assert.AreEqual(1, res[2]);
        }

        
    }
}
