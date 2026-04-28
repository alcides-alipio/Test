using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EaseStay.Core.Elements
{
    public class TextBoxStylized : UserControl
    {
        private BorderAttributes _border;

        [Browsable(true)]
        [Category("Appearance")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public BorderAttributes Border
        {
            get => _border;
            set
            {
                if (_border != null)
                    _border.Changed -= BorderChanged;

                _border = value;

                if (_border != null)
                    _border.Changed += BorderChanged;

                Invalidate();
            }
        }

        public TextBoxStylized()
        {
            Border = new BorderAttributes();

            DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.None;
            g.CompositingQuality = CompositingQuality.HighSpeed;

            int diameter = _border.Radius * 2;
            Rectangle rect = new Rectangle(3, 3, Width - 6, Height - 6);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(_border.Color, _border.Stroke))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private void BorderChanged(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
