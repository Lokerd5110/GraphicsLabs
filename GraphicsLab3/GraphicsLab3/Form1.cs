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

            int a = int.Parse(aValue.Text);
            int b = int.Parse(bValue.Text);
            if (a > b)
            {
                int h = a;
                a = b;
                b = h;
            }
            int smileR = int.Parse(rValue.Text);
            int smileX1 = (int)(Math.Cos(Math.PI * -a / 180) * (Double)(smileR));
            int smileY1 = (int)(Math.Sin(Math.PI * -a / 180) * (Double)(smileR));
            int smileX2 = (int)(Math.Cos(Math.PI * (-b - a) / 360) * (Double)(smileR));
            int smileY2 = (int)(Math.Sin(Math.PI * (-b - a) / 360) * (Double)(smileR));
            int smileX3 = (int)(Math.Cos(Math.PI * -b / 180) * (Double)(smileR));
            int smileY3 = (int)(Math.Sin(Math.PI * -b / 180) * (Double)(smileR));
            int maxX = smileX1, maxY = smileY1, minX = smileX1, minY = smileY1;
            if (smileX2 > maxX) maxX = smileX2;
            if (smileX3 > maxX) maxX = smileX3;
            if (smileY2 > maxY) maxY = smileY2;
            if (smileY3 > maxY) maxY = smileY3;
            if (smileX2 < minX) minX = smileX2;
            if (smileX3 < minX) minX = smileX3;
            if (smileY2 < minY) minY = smileY2;
            if (smileY3 < minY) minY = smileY3;
            int addX = 200 - (maxX + minX) / 2;
            int addY = 300 - (maxY + minY) / 2;

            smileX1 += addX;
            smileX2 += addX;
            smileX3 += addX;
            smileY1 += addY;
            smileY2 += addY;
            smileY3 += addY;


            Color mouthColor = Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
            drawCurve(smileX1, smileY1, (int)smileX2, (int)smileY2, smileX3, smileY3, mouthColor);
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

        private void drawCurve(int x1, int y1, int x2, int y2, int x3, int y3, Color color)
        {
            Bitmap btm = new Bitmap(pictureBox1.Image);
            List<Point> smile = new List<Point>();

            for (double i = 0; i < 1; i += 0.01)
            {
                // The Green Line
                int xa = (int)getPt(x1, x2, i);
                int ya = (int)getPt(y1, y2, i);
                int xb = (int)getPt(x2, x3, i);
                int yb = (int)getPt(y2, y3, i);

                // The Black Dot
                int x = (int)getPt(xa, xb, i);
                int y = (int)getPt(ya, yb, i);

                if (x > 0 && x < pictureBox1.Width && y > 0 && y < pictureBox1.Height)
                smile.Add(new Point(x, y));
            }

            for(int i = 0; i < smile.Count - 1; i++)
            {
                btm = drawLine(smile[i].X, smile[i].Y, smile[i + 1].X, smile[i + 1].Y, btm, color);
            }

            pictureBox1.Image = btm;
        }

        private Bitmap drawLine (int x1, int y1, int x2, int y2, Bitmap btm, Color color)
        {
            int deltaX = Math.Abs(x2 - x1);
            int deltaY = Math.Abs(y2 - y1);
            int signX = x1 < x2 ? 1 : -1;
            int signY = y1 < y2 ? 1 : -1;
            int error = deltaX - deltaY;

            btm.SetPixel(x2, y2 - 2, color);
            btm.SetPixel(x2, y2 - 1, color);
            btm.SetPixel(x2, y2, color);
            btm.SetPixel(x2, y2 + 1, color);
            btm.SetPixel(x2, y2 + 2, color);
            while (x1 != x2 || y1 != y2)
            {
                btm.SetPixel(x1, y1 - 2, color);
                btm.SetPixel(x1, y1 - 1, color);
                btm.SetPixel(x1, y1, color);
                btm.SetPixel(x1, y1 + 1, color);
                btm.SetPixel(x1, y1 + 2, color);
                int error2 = error * 2;
                if (error2 > -deltaY)
                {
                    error -= deltaY;
                    x1 += signX;
                }
                if (error2 < deltaX)
                {
                    error += deltaX;
                    y1 += signY;
                }
            }

            return btm;
        }

        private double getPt(int n1, int n2, double perc)
        {
            double diff = n2 - n1;

            return n1 + (diff * perc);
        }
    }
}
