using System.Drawing;
using System.Drawing.Imaging;

namespace ImageManipulation
{
    public class BrightnessHandler
    {
        public Bitmap toBright(Image image, float value)
        {
            Bitmap newBitmap = new Bitmap(image.Width, image.Height);
            Graphics newGraphics = Graphics.FromImage(newBitmap);
            float newValue = value / 255.0f;

            float[][] ColorMatrix = {
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {newValue, newValue, newValue, 1, 1}};

            ColorMatrix newColorMatrix = new ColorMatrix(ColorMatrix);
            ImageAttributes attributes = new ImageAttributes();

            attributes.SetColorMatrix(newColorMatrix);
            newGraphics.DrawImage((Bitmap)image, new Rectangle(0, 0, image.Width, image.Height), 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, attributes);
            attributes.Dispose();
            newGraphics.Dispose();

            return newBitmap;
        }
    }
}
