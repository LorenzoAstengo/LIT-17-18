using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Accord;
using Accord.Imaging;
using System.Drawing;
using ImageRecognition;
using Log;


namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        System.Drawing.Image image = System.Drawing.Image.FromFile("C:\\Users\\gnaps\\OneDrive\\Università\\A.A.2017-2018\\Laboratorio di informatica e telematica\\ImageRecognition\\Demo Images\\demo.png");
        System.Drawing.Image image2 = System.Drawing.Image.FromFile("C:\\Users\\gnaps\\OneDrive\\Università\\A.A.2017-2018\\Laboratorio di informatica e telematica\\ImageRecognition\\Demo Images\\Pink_triangle.png");
        System.Drawing.Image image3 = System.Drawing.Image.FromFile("C:\\Users\\gnaps\\OneDrive\\Università\\A.A.2017-2018\\Laboratorio di informatica e telematica\\ImageRecognition\\Demo Images\\mixed.png");


        [TestMethod]
        public void TestNumberOfElements2()
        {           
            ImageRecognitor imgRec = new ImageRecognitor(image2);
            Assert.AreEqual(1, imgRec.Blobs.Length);
        }

        [TestMethod]
        public void TestNumberOfElements()
        {
            ImageRecognitor imgRec = new ImageRecognitor(image);
            Assert.AreEqual(28, imgRec.Blobs.Length);
        }

        [TestMethod]
        public void TestNumberOfElements3()
        {
            ImageRecognitor imgRec = new ImageRecognitor(image3);
            Assert.AreEqual(5, imgRec.Blobs.Length);
        }

        [TestMethod]
        public void TestNumberOfTriangles()
        {
            Graphics g = Graphics.FromImage(image);
            ImageRecognitor imgRec = new ImageRecognitor(image);
            int res = imgRec.FindTriangles(g);
            Assert.AreEqual(2, res);
        }

        [TestMethod]
        public void TestNumberOfCircles()
        {
            Graphics g = Graphics.FromImage(image);
            ImageRecognitor imgRec = new ImageRecognitor(image);
            int res = imgRec.FindCircles(g);
            Assert.AreEqual(5, res);
        }

        [TestMethod]
        public void TestNumberOfQuadrilateral()
        {
            Graphics g = Graphics.FromImage(image);
            ImageRecognitor imgRec = new ImageRecognitor(image);
            int res = imgRec.FindQuadrilateral(g);
            Assert.AreEqual(12, res);
        }
    }
}
