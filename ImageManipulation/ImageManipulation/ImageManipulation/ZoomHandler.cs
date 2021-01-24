using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageManipulation
{
    public class ZoomHandler
    {
        public Bitmap toZoom(Image image, float value)
        {
            Bitmap bitmap = new Bitmap((int)(image.Width * value), (int)(image.Height * value));
            Graphics graphics = Graphics.FromImage(bitmap);

            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.DrawImage(image, 0, 0, bitmap.Width, bitmap.Height);

            return bitmap;
        }
    }
}
