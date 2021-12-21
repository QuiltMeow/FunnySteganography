using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace SimplePayload
{
    public class RoundButton : Button
    {
        public static GraphicsPath getRoundPath(RectangleF rectangle, int radius)
        {
            float divRadius = radius / 2F;
            GraphicsPath ret = new GraphicsPath();
            ret.AddArc(rectangle.X, rectangle.Y, radius, radius, 180, 90);
            ret.AddLine(rectangle.X + divRadius, rectangle.Y, rectangle.Width - divRadius, rectangle.Y);

            ret.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y, radius, radius, 270, 90);
            ret.AddLine(rectangle.Width, rectangle.Y + divRadius, rectangle.Width, rectangle.Height - divRadius);

            ret.AddArc(rectangle.X + rectangle.Width - radius, rectangle.Y + rectangle.Height - radius, radius, radius, 0, 90);
            ret.AddLine(rectangle.Width - divRadius, rectangle.Height, rectangle.X + divRadius, rectangle.Height);

            ret.AddArc(rectangle.X, rectangle.Y + rectangle.Height - radius, radius, radius, 90, 90);
            ret.AddLine(rectangle.X, rectangle.Height - divRadius, rectangle.X, rectangle.Y + divRadius);
            ret.CloseFigure();
            return ret;
        }

        protected override void OnPaint(PaintEventArgs paintEvent)
        {
            base.OnPaint(paintEvent);
            RectangleF rectangle = new RectangleF(0, 0, Width, Height);
            using (GraphicsPath graphPath = getRoundPath(rectangle, 25))
            {
                Region = new Region(graphPath);
                using (Pen pen = new Pen(Color.CadetBlue, 3))
                {
                    pen.Alignment = PenAlignment.Inset;
                    paintEvent.Graphics.DrawPath(pen, graphPath);
                }
            }
        }
    }
}