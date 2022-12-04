﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab4
{
    public partial class Form1 : Form
    {
        Color white = Color.FromArgb(0, 0, 0, 0);
        Color black = Color.FromArgb(255, 0, 0, 0);

        public Form1()
        {
            InitializeComponent();
            Graphics g = pictureBox1.CreateGraphics();
            g.FillRectangle(new SolidBrush(white), 0, 0, 400, 400);
        }

        List<Bitmap> figures = new List<Bitmap>();
        private void addSquare_Click(object sender, EventArgs e)
        {
            string stringX = squareX.Text;
            int x = parser(stringX);
            string stringY = squareY.Text;
            int y = parser(stringY);
            string stringR = squareR.Text;
            int r = parser(stringR);

            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g1 = Graphics.FromImage(btm))
            {
                Random rnd = new Random();
                g1.FillRectangle(new SolidBrush(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))), x, y, r, r);
            }
            figures.Add(btm);
            figureCounter.Text = figures.Count.ToString();
        }

        private void addTriangle_Click(object sender, EventArgs e)
        {
            string stringX = triangleX.Text;
            int x = parser(stringX);
            string stringY = triangleY.Text;
            int y = parser(stringY);
            string stringR = triangleR.Text;
            int r = parser(stringR);

            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g1 = Graphics.FromImage(btm))
            {
                g1.FillRectangle(new SolidBrush(white), 0, 0, 400, 400);
                Point[] points = { new Point(x, y + r), new Point(x + r, y + r), new Point(x + (r / 2), y) };
                Random rnd = new Random();
                g1.FillPolygon(new SolidBrush(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))), points);
            }
            figures.Add(btm);
            figureCounter.Text = figures.Count.ToString();
        }

        private void addCircle_Click(object sender, EventArgs e)
        {
            string stringX = circleX.Text;
            int x = parser(stringX);
            string stringY = circleY.Text;
            int y = parser(stringY);
            string stringR = circleR.Text;
            int r = parser(stringR);

            Bitmap btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g1 = Graphics.FromImage(btm))
            {
                Random rnd = new Random();
                g1.FillEllipse(new SolidBrush(Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255))), x, y, r, r);
            }
            figures.Add(btm);
            figureCounter.Text = figures.Count.ToString();
        }

        private int parser(string toParse)
        {
            int res = 0;
            for (int i = 0; i < toParse.Length; i++)
            {
                int add = toParse[i] - 48;
                if (add < 10 && add >= 0)
                {
                    res += add;
                    res *= 10;
                }
            }
            return res /= 10;
        }

        private void drawFigure()
        {
            if (figures.Count > 0)
            {
                Bitmap now = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                // Bitmap now = new Bitmap(pictureBox1.Image);
                if (pictureBox1.Image == null)
                {
                    Graphics g = Graphics.FromImage(now);
                    g.FillRectangle(new SolidBrush(white), 0, 0, 400, 400);
                } else
                {
                    now = new Bitmap(pictureBox1.Image);
                }
                Bitmap first = figures[0];

                if (figures.Count() < 2)
                {
                    for (int i = 0; i < now.Height; i++)
                    {
                        for (int j = 0; j < now.Height; j++)
                        {
                            if (first.GetPixel(i, j) != white)
                            {
                                now.SetPixel(i, j, first.GetPixel(i, j));
                            }
                        }
                    }
                }
                else
                {
                    Bitmap second = figures[1];
                    for (int i = 0; i < now.Height; i++)
                    {
                        for (int j = 0; j < now.Height; j++)
                        {
                            if (second.GetPixel(i, j) != white)
                            {
                                now.SetPixel(i, j, white);
                            } else if (first.GetPixel(i, j) != white)
                            {
                                now.SetPixel(i, j, first.GetPixel(i, j));
                            }
                        }
                    }
                }

                figures.RemoveAt(0);
                figureCounter.Text = figures.Count.ToString();
                pictureBox1.Image = now;
            }
        }

        private void drawOne_Click(object sender, EventArgs e)
        {
            drawFigure();
        }

        private void drawAll_Click(object sender, EventArgs e)
        {
            while (figures.Count > 0)
            {
                drawFigure();
            }
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Bitmap clear = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(clear);
            g.FillRectangle(new SolidBrush(white), 0, 0, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = clear;
        }
    }
}