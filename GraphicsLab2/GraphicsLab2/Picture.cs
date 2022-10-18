using System.Drawing;

namespace GraphicsLab2
{
    public partial class Form1
    {
        class Picture
        {

            private int width;
            private int height;
            private int[,] pixels;
            private SolidBrush[] pallete;

            // конструктор класса
            public Picture(int picWidth, int picHeight, int[,] picPixels, SolidBrush[] picPallete)
            {
                width = picWidth;
                height = picHeight;
                pixels = picPixels;
                pallete = picPallete;
            }

            // вывод данных
            public int getWidth()
            {
                return width;
            }

            public int getHeight()
            {
                return height;
            }

            public int getPixel(int i, int j)
            {
                return pixels[i, j];
            }

            public SolidBrush[] getPallete()
            {
                return pallete;
            }
        }
    }
}
