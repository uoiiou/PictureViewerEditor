using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ImageManipulation
{
    public class DrawHandler
    {
        public void toDraw(DrawInfo di, int x, int y, IntPtr pbHandle, int pensize)
        {
            Graphics g = Graphics.FromHwnd(pbHandle);
            SolidBrush brush = new SolidBrush(di.Color);
            Pen pen = new Pen(brush, pensize);
            pen.StartCap = pen.EndCap = LineCap.Round;
            g.DrawLine(pen, new Point(di.OX, di.OY), new Point(x, y));
            g.Dispose();
        }
    }
}