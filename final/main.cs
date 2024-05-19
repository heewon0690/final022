using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;
using FFmpeg;
using System.Diagnostics;

namespace final
{
    public partial class main : UserControl
    {
       

        public main()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = "rtsp://10.10.32.212:8554/mjpeg/1";
            VideoCapture vc = new VideoCapture();
            vc.Open(path);

            Mat image = new Mat();
            vc.Read(image);

            pictureBoxIpl1.ImageIpl = image;
        }



        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
