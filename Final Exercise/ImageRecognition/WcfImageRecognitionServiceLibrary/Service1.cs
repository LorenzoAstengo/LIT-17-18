using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Drawing;
using System.IO;
using ImageRecognition;
using Accord;
using Accord.Imaging.Filters;
using Accord.Math.Geometry;

namespace WcfImageRecognitionServiceLibrary
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di classe "Service1" nel codice e nel file di configurazione contemporaneamente.
    public class ImageRecognitorService : IRecognitor
    {
        public int GetTriangles(Byte[] img)
        {
            MemoryStream ms = new MemoryStream(img, 0, img.Length);
            Image image = Image.FromStream(ms);
            ImageRecognitor imageRecognitor = new ImageRecognitor(image);
            int res = imageRecognitor.FindTriangles();
            return res;
        }

        public int GetBlobs(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img, 0, img.Length);
            Image image = Image.FromStream(ms);
            ImageRecognitor imageRecognitor = new ImageRecognitor(image);
            int res = imageRecognitor.Blobs.Length;
            return res;
        }

        public int GetCircles(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img, 0, img.Length);
            Image image = Image.FromStream(ms);
            ImageRecognitor imageRecognitor = new ImageRecognitor(image);
            int res = imageRecognitor.FindCircles();
            return res;
        }

        public int GetQuadrilaterals(byte[] img)
        {
            MemoryStream ms = new MemoryStream(img, 0, img.Length);
            Image image = Image.FromStream(ms);
            ImageRecognitor imageRecognitor = new ImageRecognitor(image);
            int res = imageRecognitor.FindQuadrilateral();
            return res;
        }
    }
}
