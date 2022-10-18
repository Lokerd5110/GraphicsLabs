using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Graphics g;
        private void Form1_Load(object sender, EventArgs e)
        {
            g = pictureBox1.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public byte[] readPicture (string path)
        {
            // массив для хранения значений
            byte[] res = new byte[0];
            // считывание значений из файла
            try
            {
                using (FileStream fsSource = new FileStream(path,
                    FileMode.Open, FileAccess.Read))
                {
                    byte[] img = new byte[fsSource.Length];
                    int numBytesToRead = (int)fsSource.Length;
                    int numBytesRead = 0;
                    while (numBytesToRead > 0)
                    {
                        int n = fsSource.Read(img, numBytesRead, numBytesToRead);

                        numBytesRead += n;
                        numBytesToRead -= n;
                    }

                    res = img;

                    // запись считанного в новый файл
                    using (FileStream fsNew = new FileStream("C:\\Users\\loker\\source\\repos\\GraphicsLabs\\GraphicsLab2\\GraphicsLab2\\imgs\\new", FileMode.Create, FileAccess.Write))
                    {
                        fsNew.Write(res, 0, numBytesToRead);
                    }
                }
            }
            catch (FileNotFoundException ioEx)
            {
                Console.WriteLine(ioEx.Message);
            }

            return res;
        }

        // Отрисовка фигуры на объекте g
        private void DrawPicture(Picture pic)
        {
            // получение кистей
            SolidBrush[] brushes = pic.getPallete();

            // возвращение полотна в исхожое состояние
            g.ResetTransform();

            // заполнение цветом фона
            SolidBrush back = new SolidBrush(Color.White);
            g.FillRectangle(back, 0, 0, 500, 500);

            // масштабирование изображения под размеры картинки
            g.ScaleTransform(500 / pic.getWidth(), 500 / pic.getHeight());

            // попиксельный вывод изображения
            for (int i = 0; i < pic.getHeight(); i++)
            {
                for (int j = 0; j < pic.getWidth(); j++)
                {
                    g.FillRectangle(brushes[pic.getPixel(i, j)], j, i, 1, 1);
                }
            }
        }


        // вывод n-го изображения
        private void firstBtn_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\loker\source\repos\GraphicsLabs\GraphicsLab2\GraphicsLab2\imgs\first";

            byte[] img = readPicture(path);

            PictureCreator creator = new PictureCreator();

            Picture pic = creator.createPicture(img);

            DrawPicture(pic);
        }

        // вывод n-го изображения
        private void secondBtn_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\loker\source\repos\GraphicsLabs\GraphicsLab2\GraphicsLab2\imgs\second";

            byte[] img = readPicture(path);

            PictureCreator creator = new PictureCreator();

            Picture pic = creator.createPicture(img);

            DrawPicture(pic);
        }

        // вывод n-го изображения
        private void thirdBtn_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\loker\source\repos\GraphicsLabs\GraphicsLab2\GraphicsLab2\imgs\third";

            byte[] img = readPicture(path);

            PictureCreator creator = new PictureCreator();

            Picture pic = creator.createPicture(img);

            DrawPicture(pic);
        }

        // вывод n-го изображения
        private void fourthImg_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\loker\source\repos\GraphicsLabs\GraphicsLab2\GraphicsLab2\imgs\fourth";

            byte[] img = readPicture(path);

            PictureCreator creator = new PictureCreator();

            Picture pic = creator.createPicture(img);

            DrawPicture(pic);
        }
    }
}
