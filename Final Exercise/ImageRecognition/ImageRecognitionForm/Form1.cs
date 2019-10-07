using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageRecognition;
using System.IO;
using Log;

namespace ImageRecognitionForm
{
    public partial class Form1 : Form
    {
        public SimpleLogger logger = new SimpleLogger();

        public Form1()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new object[] { "Triangles search", "Circles search", ("Quadrilaterals search") });
            logger.Info("Program started.");            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                ImageRecognitor imageRecognitor = new ImageRecognitor(pictureBox1.Image);
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        int res = imageRecognitor.FindTriangles(g);
                        pictureBox1.Refresh();
                        label1.Text = "Found " + res + " triangles.";
                        break;
                    case 1:
                        int res1 = imageRecognitor.FindCircles(g);
                        pictureBox1.Refresh();
                        label1.Text = "Found " + res1 + " circles.";
                        break;
                    case 2:
                        int res2 = imageRecognitor.FindQuadrilateral(g);
                        pictureBox1.Refresh();
                        label1.Text = "Found " + res2 + " quadrilaterals.";
                        break;
                }
            }
            catch(NullReferenceException nRE)
            {
                logger.Error(nRE.Message);
                MessageBox.Show("Select an image first!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Path.GetFullPath(@".\Demo Images");
            openFileDialog1.Filter = "File immagine(*.png;*.jpg)|*.png;*.jpg|Tutti i file(*.*)|*.*";
            openFileDialog1.Title = "Select an image file";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    Image image = Image.FromStream(openFileDialog1.OpenFile());
                    pictureBox1.Image = image;
                    logger.Trace("Opened a new image: \"" + openFileDialog1.FileName + "\".");
                }
                catch(ArgumentException aE)
                {
                    logger.Error(aE.Message);
                    MessageBox.Show("Invalid file.");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logger.Info("Program closed.");
        }
    }
}
