using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace kamerka3
{
    public partial class Form1 : Form
        
    {
        string resolution;
       // int resolution2;
        public Form1()
        {
            InitializeComponent();
        }
        private FilterInfoCollection webcam;
        private VideoCaptureDevice cam;

        private void Form1_Load(object sender, EventArgs e)
        {
            webcam = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in webcam)
            {
                comboBox1.Items.Add(VideoCaptureDevice.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cam = new VideoCaptureDevice(webcam[comboBox1.SelectedIndex].MonikerString);
            cam.NewFrame += new NewFrameEventHandler(cam_newFrame);
            cam.Start();
            label2.Text = resolution;    
        }

        private void cam_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            //bit.SetResolution(200, 200);
             resolution = bit.Size.Height.ToString() + ' ' + bit.Size.Width.ToString();
           // resolution = resolution2.ToString();
            pictureBox1.Image = bit;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cam.Stop();
        }
    }
}
