using System;
using System.Drawing;

namespace GraphicsLab2
{
    public partial class Form1
    {
        class PictureCreator
        {
            private byte pixelMask(int pixelLength, int pos)
            {
                byte res = 0;
                for(int i = 0; i < pixelLength; i++)
                {
                    res = (byte)(res >> 1);
                    res += 128;
                }
                for(int i = 0; i < pos; i++)
                {
                    res >>= 1;
                }
                return res;
            }

            public Picture createPicture(byte[] pictureDatas)
            {

                int width = pictureDatas[0] * 256 + pictureDatas[1];
                int height = pictureDatas[2] * 256 + pictureDatas[3];
                int pixelLenght = pictureDatas[4];
                int paletteLength = pictureDatas[5] * 256 + pictureDatas[6];

                SolidBrush[] brushes = new SolidBrush[paletteLength];

                for(int i = 0; i < paletteLength; i++)
                {
                    brushes[i] = new SolidBrush(Color.FromArgb(pictureDatas[7 + i*4], pictureDatas[7 + i * 4 + 1], pictureDatas[7 + i * 4 + 2], pictureDatas[7 + i * 4 + 3]));
                }

                int pos = 0;
                int[,] pixelArray = new int[height, width];
                for(int i = 0; i < height; i++)
                {
                    for(int j = 0; j < width; j++)
                    {
                        if (pos % 8 + pixelLenght > 8)
                        {
                            byte mask = pixelMask(8 - pos % 8, pos % 8);
                            int firstPart;
                            firstPart = (pictureDatas[7 + paletteLength * 4 + pos / 8] & mask);
                            firstPart <<= pixelLenght - (8 - pos % 8);
                            mask = pixelMask(pixelLenght - (8 - pos % 8), 0);
                            int secondPart = (pictureDatas[7 + paletteLength * 4 + pos / 8 + 1] & mask);
                            secondPart >>= 8 - (pixelLenght - (8 - pos % 8));
                            pixelArray[i, j] = firstPart + secondPart;
                        } else
                        {
                            byte mask = pixelMask(pixelLenght, pos%8);
                            pixelArray[i, j] = (pictureDatas[7 + paletteLength * 4 + pos / 8] & mask);
                            pixelArray[i, j] >>= 8 - (pos % 8 + pixelLenght);
                        }
                        pos += pixelLenght;
                        Console.WriteLine(pixelArray[i, j] + " ");
                    }
                    Console.WriteLine("\n");
                }

                return new Picture(width, height, pixelArray, brushes);
            }
        }
    }
}
