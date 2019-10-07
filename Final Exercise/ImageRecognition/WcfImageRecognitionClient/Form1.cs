using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ServiceModel;
using WcfImageRecognitionClient.ServiceReference1;
using Log;
using System.IO;

namespace WcfImageRecognitionClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\ImageRecognition\Demo Images");
            openFileDialog1.Filter = "File immagine(*.png;*.jpg)|*.png;*.jpg|Tutti i file(*.*)|*.*";
            openFileDialog1.Title = "Select an image file";
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromStream(openFileDialog1.OpenFile());
                    byte[] img = ImageToByteArray(image);
                    RecognitorClient client = new RecognitorClient();
                    try
                    {
                        int res = client.GetTriangles(img);
                        int blobs = client.GetBlobs(img);
                        label1.Text = "In this image there are " + blobs + " objects.\n" + Convert.ToString(res) + " are triangles";
                        label1.Visible = true;
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Invalid file.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\ImageRecognition\Demo Images");
            openFileDialog1.Filter = "File immagine(*.png;*.jpg)|*.png;*.jpg|Tutti i file(*.*)|*.*";
            openFileDialog1.Title = "Select an image file";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromStream(openFileDialog1.OpenFile());
                    byte[] img = ImageToByteArray(image);
                    RecognitorClient client = new RecognitorClient();
                    try
                    {
                        int blobs = client.GetBlobs(img);
                        int res = client.GetCircles(img);
                        label1.Text = "In this image there are " + blobs + " objects.\n" + Convert.ToString(res) + " are circles";
                        label1.Visible = true;
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Invalid file.");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Path.GetFullPath(@"..\ImageRecognition\Demo Images");
            openFileDialog1.Filter = "File immagine(*.png;*.jpg)|*.png;*.jpg|Tutti i file(*.*)|*.*";
            openFileDialog1.Title = "Select an image file";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromStream(openFileDialog1.OpenFile());
                    byte[] img = ImageToByteArray(image);
                    RecognitorClient client = new RecognitorClient();
                    try
                    {
                        int blobs = client.GetBlobs(img);
                        int res = client.GetCircles(img);
                        label1.Text = "In this image there are " + blobs + " objects.\n" + Convert.ToString(res) + " are quadrilaterals";
                        label1.Visible = true;
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                }
                catch (ArgumentException)
                {
                    MessageBox.Show("Invalid file.");
                }
            }
        }

        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
                return ms.ToArray();
            }
        }
    }
}
