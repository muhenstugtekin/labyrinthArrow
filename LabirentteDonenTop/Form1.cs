using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabirentteDonenTop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            
            if(pictureBox1.Left >= 650)
            {
                timer1.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                timer2.Start();
                
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if(pictureBox1.Top <= 150)
            {
                timer2.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                timer3.Start();
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 455)
            {
                timer3.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                timer4.Start();
            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 275)
            {
                timer4.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                timer5.Start();
            }
        }

        private void timer5_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 295)
            {
                timer5.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                timer6.Start();
            }
        }

        private void timer6_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 150)
            {
                timer6.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                timer7.Start();
            }
        }

        private void timer7_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 155)
            {
                timer7.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                timer8.Start();
            }
        }

        private void timer8_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 275)
            {
                timer8.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                timer9.Start();
            }
        }

        private void timer9_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += 5;
            if (pictureBox1.Left >= 775)
            {
                timer9.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                timer10.Start();
            }
        }

        private void timer10_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top -= 5;
            if (pictureBox1.Top <= 25)
            {
                timer10.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                timer11.Start();
            }
        }

        private void timer11_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left -= 5;
            if (pictureBox1.Left <= 40)
            {
                timer11.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipY);
                timer12.Start();
            }
        }

        private void timer12_Tick(object sender, EventArgs e)
        {
            pictureBox1.Top += 5;
            if (pictureBox1.Top >= 385)
            {
                timer12.Stop();
                pictureBox1.Image.RotateFlip(RotateFlipType.Rotate90FlipX);
                timer1.Start();
            }
        }
    }
}
