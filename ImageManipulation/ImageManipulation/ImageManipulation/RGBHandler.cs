using System.Drawing;

namespace ImageManipulation
{
    public class RGBHandler
    {
        public Bitmap toRGB(Image image, Colors colors)
        {
            Bitmap bitmap = (Bitmap)image;

            for (int j = 0; j < bitmap.Height; j++)
            {
                for (int i = 0; i < bitmap.Width; i++)
                {
                    Color color = bitmap.GetPixel(i, j);

                    if (colors == Colors.RED)
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(color.A, color.R, 0, 0));
                    }
                    else if (colors == Colors.GREEN)
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(color.A, 0, color.B, 0));
                    }
                    else if (colors == Colors.BLUE)
                    {
                        bitmap.SetPixel(i, j, Color.FromArgb(color.A, 0, 0, color.B));
                    }
                }
            }

            return bitmap;
        }
    }
}
