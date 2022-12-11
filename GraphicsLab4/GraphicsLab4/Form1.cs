using System;
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
        Color red = Color.FromArgb(255, 255, 0, 0);
        Bitmap borderedNow, nonBorderedNow;
        Boolean isBordered = false;

        public Form1()
        {
            InitializeComponent();
            Graphics g = pictureBox1.CreateGraphics();
            g.FillRectangle(new SolidBrush(white), 0, 0, 400, 400);
            borderedNow = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            nonBorderedNow = new Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        List<Figure> figures = new List<Figure>();
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
                int red = rnd.Next(1, 255);
                int green = rnd.Next(1, 255);
                int blue = rnd.Next(1, 255);

                g1.FillRectangle(new SolidBrush(Color.FromArgb(255, red, green, blue)), x, y, r, r);
            }
            figures.Add(new Figure(x, y, r, btm));
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
                int visX = parser(visionX.Text);
                int visY = parser(visionY.Text);
                int visR = parser(visionR.Text) == 0 ? 400 : parser(visionR.Text);
                // Bitmap now = new Bitmap(pictureBox1.Image);
                if (pictureBox1.Image == null)
                {
                    Graphics g = Graphics.FromImage(borderedNow);
                    g.Clear(white);
                    g = Graphics.FromImage(nonBorderedNow);
                    g.Clear(white);
                }
                Bitmap first = figures[0].getBtm();

                if (figures.Count() < 2)
                {
                    for (int i = figures[0].getX() > visX ? figures[0].getX() : visX;
                        i < ((figures[0].getX() + figures[0].getR()) > (borderedNow.Height) ?
                            borderedNow.Height :
                            figures[0].getX() + figures[0].getR()) && i >= visX && i <= visX + visR;
                        i++)
                        {
                            for (int j = figures[0].getY() > visY ? figures[0].getY() : visY;
                                j < ((figures[0].getY() + figures[0].getR()) > (borderedNow.Height) ?
                                    borderedNow.Height :
                                    figures[0].getY() + figures[0].getR()) && j >= visY && j <= visY + visR;
                                j++)
                                {
                                    if (borderedNow.GetPixel(i, j) != red && borderedNow.GetPixel(i, j) != white)
                                    {
                                        Color nowRight = borderedNow.GetPixel(i + 1, j);
                                        Color nowLeft = borderedNow.GetPixel(i - 1, j);
                                        Color nowTop = borderedNow.GetPixel(i, j + 1);
                                        Color nowBottom = borderedNow.GetPixel(i, j - 1);
                                        if (nowTop == white || nowLeft == white || nowBottom == white || nowRight == white)
                                        {
                                            borderedNow.SetPixel(i, j, red);
                                        }

                                        Color firstRight = first.GetPixel(i + 1, j);
                                        Color firstLeft = first.GetPixel(i - 1, j);
                                        Color firstTop = first.GetPixel(i, j + 1);
                                        Color firstBottom = first.GetPixel(i, j - 1);
                                        if (firstTop == white || firstLeft == white || firstBottom == white || firstRight == white)
                                        {
                                            borderedNow.SetPixel(i, j, red);
                                        }
                                    }
                            }
                    }

                    for (int i = figures[0].getX() > visX ? figures[0].getX() : visX; 
                        i < ((figures[0].getX() + figures[0].getR()) > (borderedNow.Height) ? 
                            borderedNow.Height : 
                            figures[0].getX() + figures[0].getR()) && i >= visX && i <= visX + visR; 
                        i++)
                        {
                            for (int j = figures[0].getY() > visY ? figures[0].getY() : visY; 
                                j < ((figures[0].getY() + figures[0].getR()) > (borderedNow.Height) ?
                                    borderedNow.Height : 
                                    figures[0].getY() + figures[0].getR()) && j >= visY && j <= visY + visR; 
                                j++)
                                {
                                    if (first.GetPixel(i, j) != white && borderedNow.GetPixel(i, j) != red) 
                                    {
                                        borderedNow.SetPixel(i, j, first.GetPixel(i, j));
                                    }

                                    nonBorderedNow.SetPixel(i, j, first.GetPixel(i, j));
                        }
                    }
                }
                else
                {
                    Bitmap second = figures[1].getBtm();

                    for (int i = figures[1].getX() > visX ? figures[1].getX() : visX; 
                        i < ((figures[1].getX() + figures[1].getR()) > (borderedNow.Height) ?
                            borderedNow.Height : 
                            figures[1].getX() + figures[1].getR()) && i >= visX && i <= visX + visR; 
                        i++)
                        {
                            for (int j = figures[1].getY() > visY ? figures[1].getY() : visY; 
                                j < ((figures[1].getY() + figures[1].getR()) > (borderedNow.Height) ?
                                    borderedNow.Height : 
                                    figures[1].getY() + figures[1].getR()) && j >= visY && j <= visY + visR; 
                                j++)
                                {
                                    if (borderedNow.GetPixel(i, j) != red && borderedNow.GetPixel(i, j) != white)
                                    {
                                        Color nowRight = borderedNow.GetPixel(i + 1, j);
                                        Color nowLeft = borderedNow.GetPixel(i - 1, j);
                                        Color nowTop = borderedNow.GetPixel(i, j + 1);
                                        Color nowBottom = borderedNow.GetPixel(i, j - 1);
                                        if (nowTop == white || nowLeft == white || nowBottom == white || nowRight == white)
                                        {
                                            borderedNow.SetPixel(i, j, red);
                                        }

                                        Color secondRight = second.GetPixel(i + 1, j);
                                        Color secondLeft = second.GetPixel(i - 1, j);
                                        Color secondTop = second.GetPixel(i, j + 1);
                                        Color secondBottom = second.GetPixel(i, j - 1);
                                        if (secondTop == white || secondLeft == white || secondBottom == white|| secondRight == white)
                                        {
                                            borderedNow.SetPixel(i, j, red);
                                            nonBorderedNow.SetPixel(i, j, white);
                                        } else
                                        {
                                            borderedNow.SetPixel(i, j, white);
                                            nonBorderedNow.SetPixel(i, j, white);
                                        }
                                    }
                            }
                    }

                    for (int i = figures[0].getX() > visX ? figures[0].getX() : visX; 
                        i < ((figures[0].getX() + figures[0].getR()) > (borderedNow.Height) ?
                            borderedNow.Height :
                            figures[0].getX() + figures[0].getR()) && i >= visX && i <= visX + visR;
                        i++)
                        {
                            for (int j = figures[0].getY() > visY ? figures[0].getY() : visY;
                            j < ((figures[0].getY() + figures[0].getR()) > (borderedNow.Height) ?
                                borderedNow.Height :
                                figures[0].getY() + figures[0].getR()) && j >= visY && j <= visY + visR;
                            j++)
                                {
                                    if (second.GetPixel(i, j) != white && borderedNow.GetPixel(i, j) != red)
                                    {
                                        Color firstRight = first.GetPixel(i + 1, j);
                                        Color firstLeft = first.GetPixel(i - 1, j);
                                        Color firstTop = first.GetPixel(i, j + 1);
                                        Color firstBottom = first.GetPixel(i, j - 1);

                                        Color secondRight = second.GetPixel(i + 1, j);
                                        Color secondLeft = second.GetPixel(i - 1, j);
                                        Color secondTop = second.GetPixel(i, j + 1);
                                        Color secondBottom = second.GetPixel(i, j - 1);
                                        if ((firstRight == white || firstLeft == white || firstBottom == white || firstTop == white) || 
                                            (secondRight == white || secondLeft == white || secondBottom == white || secondTop == white))
                                        {
                                            borderedNow.SetPixel(i, j, red);
                                        } else
                                        {
                                            borderedNow.SetPixel(i, j, white);
                                        }
                                    } else if (first.GetPixel(i, j) != white && borderedNow.GetPixel(i, j) != red)
                                    {
                                        borderedNow.SetPixel(i, j, first.GetPixel(i, j));
                                    }

                                    if (second.GetPixel(i, j) == white) 
                                        nonBorderedNow.SetPixel(i, j, first.GetPixel(i, j));
                            }
                    }
                }

                figures.RemoveAt(0);
                figureCounter.Text = figures.Count.ToString();
                if (isBordered)
                {
                    pictureBox1.Image = borderedNow;
                }
                else
                {
                    pictureBox1.Image = nonBorderedNow;
                }
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

        private void nonBordered_Click(object sender, EventArgs e)
        {
            isBordered = false;
            pictureBox1.Image = nonBorderedNow;
        }

        private void bordered_Click(object sender, EventArgs e)
        {
            isBordered = true;
            pictureBox1.Image = borderedNow;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(borderedNow);
            g.Clear(white);
            g = Graphics.FromImage(nonBorderedNow);
            g.Clear(white);
            if (isBordered)
            {
                pictureBox1.Image = borderedNow;
            } else
            {
                pictureBox1.Image = nonBorderedNow;
            }
        }
    }

    public class Figure
    {
        private int x;
        private int y;
        private int r;
        private Bitmap btm;

        public Figure(int newX, int newY, int newR, Bitmap newBtm)
        {
            x = newX;
            y = newY;
            r = newR;
            btm = newBtm;
        }

        public int getX()
        {
            return x;
        }

        public int getY()
        {
            return y;
        }

        public int getR()
        {
            return r;
        }

        public Bitmap getBtm()
        {
            return btm;
        }
    }
}