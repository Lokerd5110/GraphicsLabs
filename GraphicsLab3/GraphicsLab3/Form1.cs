using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab3
{
    public partial class Form1 : Form
    {
        Color white = Color.FromArgb(255, 255, 255, 255);

        public Form1()
        {
            InitializeComponent();
        }

        private void drawButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            // drawing face
            Color bigColor = Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            int bigX = pictureBox1.Width / 2;
            int bigY = pictureBox1.Height / 2;
            int bigR = pictureBox1.Width > pictureBox1.Height ? pictureBox1.Height / 2 - 1 : pictureBox1.Width / 2 - 1;
            drawRing(bigX, bigY, bigR, bigColor);
            fillCircle(bigX, bigY, bigR, bigColor);

            // drawing left eye
            Color eyeColor = Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            int eyeR = bigR / 3;
            int leftEyeX = (int)((Double)bigX + Math.Cos(Math.PI * -150/180) * (Double)(bigR / 2));
            int leftEyeY = (int)((Double)bigY + Math.Sin(Math.PI * -150/ 180) * (Double)(bigR / 2));
            drawRing(leftEyeX, leftEyeY, eyeR, eyeColor);
            fillCircle(leftEyeX, leftEyeY, eyeR, eyeColor);
            drawRing(leftEyeX, leftEyeY, eyeR / 2, Color.FromArgb(255, 0, 0, 0));
            fillCircle(leftEyeX, leftEyeY, eyeR / 2, Color.FromArgb(255, 0, 0, 0));

            // drawing right eye
            int rightEyeX = (int)((Double)bigX + Math.Cos(Math.PI * -30 / 180) * (Double)(bigR / 2));
            int rightEyeY = (int)((Double)bigY + Math.Sin(Math.PI * -30 / 180) * (Double)(bigR / 2));
            drawRing(rightEyeX, rightEyeY, eyeR, eyeColor);
            fillCircle(rightEyeX, rightEyeY, eyeR, eyeColor);
            drawRing(rightEyeX, rightEyeY, eyeR / 2, Color.FromArgb(255, 0, 0, 0));
            fillCircle(rightEyeX, rightEyeY, eyeR / 2, Color.FromArgb(255, 0, 0, 0));


        }

        private void plotCircle (int x, int y, int baseX, int baseY, Color color, Bitmap img) {
            img.SetPixel(baseX + x, baseY + y, color);
            img.SetPixel(baseX + x, baseY - y, color);
            img.SetPixel(baseX - x, baseY - y, color);
            img.SetPixel(baseX - x, baseY + y, color);
        }

        private void drawRing(int baseX, int baseY, int r, Color color)
        {
            Bitmap newCircle;
            if (pictureBox1.Image == null)
            {
                newCircle = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics g = Graphics.FromImage(newCircle);
                g.Clear(white);
            } else
            {
                newCircle = new Bitmap(pictureBox1.Image);
            }
            int x = 0;
            int y = r;
            int delta = 3 - 2 * r;
            while (x < y)
            {
                plotCircle(x, y, baseX, baseY, color, newCircle);
                plotCircle(y, x, baseX, baseY, color, newCircle);
                if (delta < 0)
                    delta += 4 * x + 6;
                else
                {
                    delta += 4 * (x - y) + 10;
                    y--;
                }
                x++;
            }

            if (x == y) plotCircle(x, y, baseX, baseY, color, newCircle);

            pictureBox1.Image = newCircle;
        }

        private void fillCircle (int centerX, int centerY, int r, Color color)
        {
            Bitmap btm = new Bitmap(pictureBox1.Image);
            int left = centerX - r;
            int right = centerX + r;
            int top = centerY + r;
            int bottom = centerY - r;

            for (int i = left + 1; i < right; i++) {
                    Boolean draw = btm.GetPixel(i, bottom) == color ? true : false;
                for (int j = bottom; j < top; j++)
                {
                    if(draw)
                        btm.SetPixel(i, j, color);
                    if (btm.GetPixel(i, j + 1) == color)
                    {
                        draw = !draw;
                        if (btm.GetPixel(i, j + 1) == color)
                            while (btm.GetPixel(i, j + 1) == color && j < 398) j++;
                    }
                }
            }

            pictureBox1.Image = btm;
        }


    }
}
