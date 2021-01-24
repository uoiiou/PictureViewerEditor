using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace ImageManipulation
{
    public class ContrastHandler
    {
        public Bitmap toContrast(Image image, float value)
        {
            Bitmap sourceBitmap = (Bitmap)image;
            double b, g, r, contrastLevel = Math.Pow((100.0 + value) / 100.0, 2);
            BitmapData bitmapData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);
            byte[] pixelBuffer = new byte[bitmapData.Stride * bitmapData.Height];

            Marshal.Copy(bitmapData.Scan0, pixelBuffer, 0, pixelBuffer.Length);
            sourceBitmap.UnlockBits(bitmapData);

            for (int k = 0; k + 4 < pixelBuffer.Length; k += 4)
            {
                b = ((((pixelBuffer[k] / 255.0) - 0.5) * contrastLevel) + 0.5) * 255.0;
                g = ((((pixelBuffer[k + 1] / 255.0) - 0.5) * contrastLevel) + 0.5) * 255.0;
                r = ((((pixelBuffer[k + 2] / 255.0) - 0.5) * contrastLevel) + 0.5) * 255.0;

                if (b > 255) { b = 255; }
                else
                    if (b < 0) { b = 0; }

                if (g > 255) { g = 255; }
                else
                    if (g < 0) { g = 0; }

                if (r > 255) { r = 255; }
                else
                    if (r < 0) { r = 0; }

                pixelBuffer[k] = (byte)b;
                pixelBuffer[k + 1] = (byte)g;
                pixelBuffer[k + 2] = (byte)r;
            }

            Bitmap resultBitmap = new Bitmap(sourceBitmap.Width, sourceBitmap.Height);
            bitmapData = resultBitmap.LockBits(new Rectangle(0, 0, resultBitmap.Width, resultBitmap.Height), ImageLockMode.WriteOnly, PixelFormat.Format32bppArgb);
            Marshal.Copy(pixelBuffer, 0, bitmapData.Scan0, pixelBuffer.Length);
            resultBitmap.UnlockBits(bitmapData);

            return resultBitmap;
        }
    }
}
