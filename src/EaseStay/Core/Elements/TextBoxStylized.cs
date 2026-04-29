using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EaseStay.Core.Elements
{
    public class TextBoxStylized : UserControl
    {
        private TextBox _textBox;
        private bool _isPlaceholderActive = false;

        private Color _borderColor = Color.Gray;
        private int _borderRadius = 8;
        private float _borderWidth = 2f;
        private string _placeholder = string.Empty;
        private Color _placeholderColor = Color.DarkGray;


        [Category("Appearance")]
        [Description("Cor da borda")]
        [DefaultValue(typeof(Color), "Gray")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (value != _borderColor)
                {
                    _borderColor = value;
                    UpdateLayout();
                    Invalidate();
                }
            }
        }

        [Category("Appearance")]
        [Description("Raio dos cantos")]
        [DefaultValue(8)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                if (value != _borderRadius)
                {
                    _borderRadius = value;
                    UpdateLayout();
                    Invalidate();
                }
            }
        }

        [Category("Appearance")]
        [Description("Espessura da borda")]
        [DefaultValue(2f)]
        public float BorderWidth
        {
            get => _borderWidth;
            set
            {
                if (value != _borderWidth)
                {
                    _borderWidth = value;
                    UpdateLayout();
                    Invalidate();
                }
            }
        }

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Appearance")]
        public override string Text
        {
            get => _isPlaceholderActive ? string.Empty : _textBox.Text;
            set
            {
                if (value != base.Text)
                {
                    UnsetPlaceholder();
                    _textBox.Text = value;
                    base.Text = value;
                    Invalidate();
                }
            }
        }

        [Category("Appearance")]
        [Description("")]
        [DefaultValue("")]
        public string Placeholder
        {
            get => _placeholder;
            set
            {
                if (value != _placeholder)
                {
                    _placeholder = value;
                    SetPlaceholder();
                    Invalidate();
                }
            }
        }

        [Category("Appearance")]
        [Description("")]
        [DefaultValue("")]
        public Color PlaceholderColor
        {
            get => _placeholderColor;
            set
            {
                if (value != _placeholderColor)
                {
                    _placeholderColor = value;
                    SetPlaceholder();
                    Invalidate();
                }
            }
        }

        public TextBoxStylized()
        {
            DoubleBuffered = true;

            base.BackColor = SystemColors.Window;

            _textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Multiline = true,
                Text = string.Empty
            };
            Controls.Add(_textBox);

            Cursor = Cursors.IBeam;
            Text = string.Empty;

            Resize += (s, e) => UpdateLayout();
            BackColorChanged += (s, e) => UpdateLayout();
            ForeColorChanged += (s, e) => UpdateLayout();
            Click += (s, e) => _textBox.Focus();
            Load += (s, e) => SetPlaceholder();

            _textBox.Enter += (s, e) => UnsetPlaceholder();
            _textBox.Leave += (s, e) => SetPlaceholder();

            UpdateLayout();
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.PixelOffsetMode = PixelOffsetMode.None;
            g.CompositingQuality = CompositingQuality.HighSpeed;

            int diameter = _borderRadius * 2;
            Rectangle rect = new Rectangle(1, 1, Width - 3, Height - 3);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                path.CloseFigure();

                using (SolidBrush brush = new SolidBrush(BackColor))
                {
                    g.FillPath(brush, path);
                }

                using (Pen pen = new Pen(_borderColor, _borderWidth))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            if (Parent != null)
            {
                Graphics g = e.Graphics;
                var state = g.Save();

                g.TranslateTransform(-Left, -Top);
                PaintEventArgs pea = new PaintEventArgs(g, Parent.ClientRectangle);
                InvokePaintBackground(Parent, pea);
                InvokePaint(Parent, pea);

                g.Restore(state);
            }
        }

        private void UpdateLayout()
        {
            int border = (int)Math.Ceiling(_borderWidth);
            int cornerInset = (int)Math.Ceiling(_borderRadius / 2f);
            int inset = border + cornerInset;

            int x = inset;
            int y = inset;
            int w = Math.Max(0, ClientSize.Width - (inset * 2));
            int h = Math.Max(0, ClientSize.Height - (inset * 2));

            _textBox.Bounds = new Rectangle(x, y, w, h);
            _textBox.BackColor = BackColor;
            _textBox.ForeColor = _isPlaceholderActive ? _placeholderColor : ForeColor;
        }

        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(_textBox.Text) || _isPlaceholderActive)
            {
                _isPlaceholderActive = true;
                _textBox.Text = _placeholder;
                base.Text = string.Empty;
                _textBox.ForeColor = _placeholderColor;
            }
        }

        private void UnsetPlaceholder()
        {
            if (_isPlaceholderActive)
            {
                _isPlaceholderActive = false;
                _textBox.Text = string.Empty;
                _textBox.ForeColor = ForeColor;
            }
        }
    }
}
