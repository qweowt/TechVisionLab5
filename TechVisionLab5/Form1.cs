using OpenCvSharp;
using OpenCvSharp.Extensions;
using System;
using System.IO;

namespace TechVisionLab5
{
    public partial class Form1 : Form
    {
        VideoCapture videoCapture;
        bool camIsOn = false;
        Mat frame;

        Bitmap buffer;
        Bitmap filtered;


        public Form1()
        {
            InitializeComponent();
        }

        private void OpenOrEnableVideoBtn_Click(object sender, EventArgs e)
        {
            if (EnableRb.Checked)
            {
                pictureBox1.Image = null;
                OnOffCam();
            }
            else if (OpenVideoRb.Checked)
            {
                pictureBox1.Image = null;
                OpenVideo();
            } else if (OpenImageRb.Checked)
            {
                pictureBox1.Image = null;
                OpenImage();
            }
        }

        private void OpenImage()
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = openFileDialog1.FileName;
                buffer = new Bitmap(a);
                filtered = buffer;
                pictureBox1.Image = buffer;
            }
        }

        private void OpenVideo()
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string a = openFileDialog1.FileName;
                videoCapture = new VideoCapture(a);
                FrameTick.Start();
            }
            
        }

        private void OnOffCam()
        {
            if (camIsOn == false)
            {
                videoCapture = new VideoCapture(0);
                FrameTick.Start();
                camIsOn = true;
            }
            else
            {
                FrameTick.Stop();
                videoCapture?.Dispose();
                frame?.Dispose();
                camIsOn = false;
            }
        }

        private void EnableRb_CheckedChanged(object sender, EventArgs e)
        {
            videoCapture = null;
            FrameTick.Stop();
        }

        private void OpenVideoRb_CheckedChanged(object sender, EventArgs e)
        {
            videoCapture = null;
            FrameTick.Stop();
        }

        private void FrameTick_Tick(object sender, EventArgs e)
        {
            try
            {
                frame = new Mat();
                videoCapture.Read(frame);

                if (!frame.Empty())
                {
                    pictureBox1.Image = BitmapConverter.ToBitmap(frame);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                FrameTick.Stop();
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FrameTick.Stop();
            videoCapture?.Dispose();
            frame?.Dispose();
        }
    }
}
