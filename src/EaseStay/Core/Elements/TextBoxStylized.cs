using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EaseStay.Core.Elements
{
    internal class TextBoxStylized : UserControl
    {
        public TextBoxStylized()
        {
            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.HighQuality;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;
            g.CompositingQuality = CompositingQuality.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;

            g.TranslateTransform(0.5f, 0.5f);

            int diameter = 8 * 2;

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(Color.Black, 1f))
                {
                    pen.Alignment = PenAlignment.Inset;
                    g.DrawPath(pen, path);
                }
            }
        }
    }
}
