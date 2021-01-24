using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageManipulation
{
    public class RotateHandler
    {
        private int updateAngle(int angle)
        {
            angle %= 360;

            if (angle < 0)
                angle += 360;

            return angle;
        }

        public Image toRotate(Image image, int value)
        {
            double toRad = 0.01745;
            value = updateAngle(value);

            if (value % 90 == 0)
                switch (value)
                {
                    case 0:
                        return image;
                    case 90:
                        image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                        return image;
                    case 180:
                        image.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        return image;
                    case 270:
                        image.RotateFlip(RotateFlipType.Rotate270FlipNone);
                        return image;
                }


            float sin = (float)Math.Sin(value % 90 * toRad), cos = (float)Math.Cos(value % 90 * toRad);
            float owidth = image.Width, oheight = image.Height, nwidth = 0f, nheight = 0f;
            float originX = 0f, originY = 0f;

            if ((value > 0 && value < 90) || (value > 180 && value < 270))
            {
                nwidth = sin * oheight + cos * owidth;
                nheight = sin * owidth + cos * oheight;

                if (value < 90)
                {
                    originX = sin * oheight;
                    originY = 0f;
                }
                else
                {
                    originX = cos * owidth;
                    originY = nheight;
                }
            }
            else if ((value > 90 && value < 180) || (value > 270 && value < 360))
            {
                nheight = sin * oheight + cos * owidth;
                nwidth = sin * owidth + cos * oheight;
                if (value < 180)
                {
                    originX = nwidth;
                    originY = sin * oheight;
                }
                else
                {
                    originX = 0f;
                    originY = cos * owidth;
                }
            }

            Bitmap bmp = new Bitmap((int)nwidth, (int)nheight);
            bmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);
            Graphics gr = Graphics.FromImage(bmp);

            gr.TranslateTransform(originX, originY);
            gr.RotateTransform(value);
            gr.InterpolationMode = InterpolationMode.HighQualityBicubic;
            gr.DrawImage(image, new Point(0, 0));
            gr.Dispose();

            return bmp;
        }
    }
}
