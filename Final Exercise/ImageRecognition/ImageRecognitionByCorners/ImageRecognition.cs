using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord;
using Accord.Imaging;
using Accord.Imaging.Filters;
using System.Drawing;
using Accord.Math.Geometry;
using Log;

namespace ImageRecognition
{
    public class ImageRecognitor
    {
        public Bitmap Image { get; set; }
        public Blob[] Blobs { get; set; }
        public SimpleLogger logger = new SimpleLogger();

        public ImageRecognitor(System.Drawing.Image obj)
        {            
            Image = new Bitmap(obj);
            logger.Trace("Image converted to Bitmap and saved as attribute.");
            Image = ChangeBackGroundColor(Image);           
            logger.Trace("Image processed to have black background.");
            // create instance of blob counter
            BlobCounter blobCounter = new BlobCounter();
            // process input image
            blobCounter.ProcessImage(Image);
            // get information about detected objects
            Blob[] blobs = blobCounter.GetObjectsInformation();
            Blobs = blobs;
            logger.Trace("Counted objects in image.");            
        }

        public int FindTriangles()
        {
            int triangles = 0;

            for (int i = 0, n = Blobs.Length; i < n; i++)
            {
                // create instance of blob counter
                BlobCounter blobCounter = new BlobCounter();
                // process input image
                blobCounter.ProcessImage(Image);
                SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(Blobs[i]);
                List<IntPoint> corners;

                if (shapeChecker.IsTriangle(edgePoints, out corners))
                {
                    triangles++;
                }
            }
            return triangles;
        }

        public int FindTriangles(Graphics graphics)
        {
            logger.Trace("Searching for triangles");
            int triangles = 0;
            Pen redPen = new Pen(Color.IndianRed, 5);

            for (int i = 0, n = Blobs.Length; i < n; i++)
            {                
                // create instance of blob counter
                BlobCounter blobCounter = new BlobCounter();
                // process input image
                blobCounter.ProcessImage(Image);
                SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(Blobs[i]);
                List<IntPoint> corners;

                if (shapeChecker.IsTriangle(edgePoints, out corners))
                {
                    triangles++;
                    PointF[] pointF = ToPointF(corners);
                    logger.Trace("Found a triangle.");
                    graphics.DrawPolygon(redPen, pointF);
                }                
            }
            logger.Trace("Found "+triangles+" triangles.");
            logger.Trace("End of search.");
            return triangles;
        }

        public int FindCircles(Graphics graphics)
        {
            logger.Trace("Searching for circles.");
            Pen redPen = new Pen(Color.Yellow, 5);
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            int circles = 0;

            // create instance of blob counter
            BlobCounter blobCounter = new BlobCounter();
            // process input image
            blobCounter.ProcessImage(this.Image);

            for (int i = 0, n = Blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(Blobs[i]);

                Accord.Point center;
                float radius;

                if (shapeChecker.IsCircle(edgePoints, out center, out radius))
                {
                    logger.Trace("Found a circle.");
                    circles++;
                    graphics.DrawEllipse(redPen,
                        (int)(center.X - radius),
                        (int)(center.Y - radius),
                        (int)(radius * 2),
                        (int)(radius * 2));
                }
            }
            logger.Trace("Found " + circles + " circles.");
            logger.Trace("End of search");
            return circles;
        }

        public int FindCircles()
        {
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            int circles = 0;

            // create instance of blob counter
            BlobCounter blobCounter = new BlobCounter();
            // process input image
            blobCounter.ProcessImage(this.Image);

            for (int i = 0, n = Blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(Blobs[i]);

                Accord.Point center;
                float radius;

                if (shapeChecker.IsCircle(edgePoints, out center, out radius))
                {
                    circles++;
                }
            }
            return circles;
        }

        public int FindQuadrilateral(Graphics graphics)
        {
            logger.Trace("Searching for quadrilaterals.");
            Pen redPen = new Pen(Color.Green, 5);
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            int quadrilateral = 0;

            // create instance of blob counter
            BlobCounter blobCounter = new BlobCounter();
            // process input image
            blobCounter.ProcessImage(this.Image);

            for (int i = 0, n = Blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(Blobs[i]);
                List<IntPoint> corners;

                if (shapeChecker.IsQuadrilateral(edgePoints, out corners))
                {
                    logger.Trace("Found a quadrilateral.");
                    quadrilateral++;
                    graphics.DrawPolygon(redPen, ToPointF(corners));
                }
            }
            logger.Trace("Found " + quadrilateral + " quadrilaterals.");
            logger.Trace("End of search.");
            return quadrilateral;
        }

        public int FindQuadrilateral()
        {
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();
            int quadrilateral = 0;

            // create instance of blob counter
            BlobCounter blobCounter = new BlobCounter();
            // process input image
            blobCounter.ProcessImage(this.Image);

            for (int i = 0, n = Blobs.Length; i < n; i++)
            {
                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(Blobs[i]);
                List<IntPoint> corners;

                if (shapeChecker.IsQuadrilateral(edgePoints, out corners))
                {
                    quadrilateral++;
                }
            }
            return quadrilateral;
        }

        public PointF[] ToPointF(List<IntPoint> points)
        {
            PointF[] res = new PointF[points.Count];
            for(int i = 0; i < points.Count; i++)
            {
                PointF point = new PointF(Convert.ToSingle(points[i].X), Convert.ToSingle(points[i].Y));
                res[i] = point;
            }
            return res;
        }

        /*public Bitmap PreProcess(Bitmap bmp)
        {
            Grayscale gfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            Invert ifilter = new Invert();
            BradleyLocalThresholding thfilter = new BradleyLocalThresholding();
            bmp = gfilter.Apply(bmp);
            thfilter.ApplyInPlace(bmp);
            ifilter.ApplyInPlace(bmp);
            return bmp;
        }*/

        /*public bool IsBackgroundWhite(Bitmap theImageBitmap)
        {
            Bitmap bmp = new Bitmap(theImageBitmap);
            int weight = 0;

            for (int x = 0; x < bmp.Width; x++)
            {
                weight += GetWeight(bmp.GetPixel(x, 0));
                weight += GetWeight(bmp.GetPixel(x, bmp.Height - 1));
            }

            for (int y = 0; y < bmp.Height; y++)
            {
                weight += GetWeight(bmp.GetPixel(0, y));
                weight += GetWeight(bmp.GetPixel(bmp.Width - 1, y));
            }

            if (weight > 255)
                return true;
            return false;
        }*/

        public Bitmap ChangeBackGroundColor(Bitmap bitmap)
        {
            for (int x = 0; x < bitmap.Width; x++)
            {
                for (int y = 0; y < bitmap.Height; y++)
                {
                    int weight = (bitmap.GetPixel(x, y).R + bitmap.GetPixel(x, y).G + bitmap.GetPixel(x, y).B) / 3;
                    if (weight >= 240)
                        bitmap.SetPixel(x, y, Color.Black);
                }
            }
            return bitmap;
        }

        /*private int GetWeight(Color c)
        {
            int res = 0;
            if (c.R >= 200 && c.B >= 200 && c.G >= 200)
            {
                int n1 = 255 - c.R;
                int n2 = 255 - c.G;
                int n3 = 255 - c.B;

                res = (int)((n1 + n2 + n3) / 3);
            }
            return res;
        }*/
    }
}
