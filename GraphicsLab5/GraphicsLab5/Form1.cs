using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab5
{
    public partial class Form1 : Form
    {
        private string path = "imgs/";
        public Form1()
        {
            InitializeComponent();
            Directory
                .GetFiles(path, "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => listBox1.Items.Add(Path.GetFileName(f)));
        }

        private void createImg ()
        {
            Bitmap newImg = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics g = Graphics.FromImage(newImg);
            g.Clear(Color.FromArgb(255, 255, 255, 255));
            Random rnd = new Random();

            for (int i = 0; i < rnd.Next(10); i++)
            {
                Color color = Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                int size = rnd.Next(100, pictureBox1.Width / 2 > pictureBox1.Height / 2 ? pictureBox1.Height / 2 : pictureBox1.Width / 2);
                int x = rnd.Next(0, pictureBox1.Height - size);
                int y = rnd.Next(0, pictureBox1.Width - (size * 2) > 0 ? pictureBox1.Height - size * 2 : 0);
                int type = rnd.Next(0, 5);

                switch (type)
                {
                    case 0:
                        g.FillRectangle(new SolidBrush(color), x, y, size, size);
                        break;
                    case 1:
                        g.FillEllipse(new SolidBrush(color), x, y, size, size);
                        break;
                    case 2:
                        string toDraw1 = ((char)('k' + rnd.Next(0, 7))).ToString();
                        g.DrawString(toDraw1, new Font("Times New Roman", size, FontStyle.Regular), new SolidBrush(color), new PointF(x, y));
                    break;
                    case 3:
                        string toDraw2 = ((char)('k' + rnd.Next(0, 7))).ToString();
                        g.DrawString(toDraw2, new Font("Times New Roman", size, FontStyle.Regular), new SolidBrush(color), new PointF(x, y));
                        break;
                    case 4:
                        string toDraw3 = ((char)('k' + rnd.Next(0, 7))).ToString();
                        g.DrawString(toDraw3, new Font("Times New Roman", size, FontStyle.Regular), new SolidBrush(color), new PointF(x, y));
                        break;
                    case 5:
                        string toDraw4 = ((char)('k' + rnd.Next(0, 7))).ToString();
                        g.DrawString(toDraw4, new Font("Times New Roman", size, FontStyle.Regular), new SolidBrush(color), new PointF(x, y));
                        break;
                }
            }

            pictureBox1.Image = newImg;
        }

        private void saveImg()
        {
            Bitmap toSave = new Bitmap(pictureBox1.Image);
            string pathToFIle = "C:/Users/loker/source/repos/GraphicsLabs/GraphicsLab5/GraphicsLab5/bin/Debug/imgs/";
            string fileName = (Directory.GetFiles(path, "*", SearchOption.AllDirectories).ToList().Count() + 1).ToString() + ".bmp";
            toSave.Save(pathToFIle + fileName, ImageFormat.Bmp);
            listBox1.Items.Clear();
            Directory
                .GetFiles(path, "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => listBox1.Items.Add(Path.GetFileName(f)));
        }

        private void byStepButton_Click(object sender, EventArgs e)
        {
            createImg();
        }

        private void allStepsButton_Click(object sender, EventArgs e)
        {
            saveImg();
        }
    }
}
