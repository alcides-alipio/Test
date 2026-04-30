using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace EaseStay.Core.Elements
{
    [Designer(typeof(TextBoxStylizedDesigner))]
    public class TextBoxStylized : UserControl
    {
        private TextBox _textBox;
        private Panel _clientArea;
        private bool _isPlaceholderActive = false;

        #region Private variables for atributes

        private Color _borderColor = Color.FromArgb(213, 218, 223);
        private int _borderRadius = 0;
        private float _borderWidth = 2f;
        private string _placeholder = string.Empty;
        private Color _placeholderColor = Color.FromArgb(193, 200, 207);

        #endregion

        #region Border Attributes

        [Category("Appearance")]
        [Description("Cor da borda")]
        [DefaultValue(typeof(Color), "213; 218; 223")]
        public Color BorderColor
        {
            get => _borderColor;
            set
            {
                if (value != _borderColor)
                {
                    _borderColor = value;
                    UpdateColors();
                }
            }
        }

        [Category("Appearance")]
        [Description("Raio dos cantos")]
        [DefaultValue(0)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                if (value != _borderRadius)
                {
                    _borderRadius = value;
                    UpdateBorder();
                    Invalidate();
                }
            }
        }

        [Category("Appearance")]
        [Description("Espessura da borda")]
        [DefaultValue(1f)]
        public float BorderWidth
        {
            get => _borderWidth;
            set
            {
                if (value != _borderWidth)
                {
                    _borderWidth = value;
                    UpdateBorder();
                    Invalidate();
                }
            }
        }

        #endregion
        #region Text Attributes

        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Category("Appearance")]
        [DefaultValue("")]
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
        [DefaultValue(typeof(Color), "193; 200; 207")]
        public Color PlaceholderColor
        {
            get => _placeholderColor;
            set
            {
                if (value != _placeholderColor)
                {
                    _placeholderColor = value;
                    UpdateColors();
                }
            }
        }

        #endregion

        public TextBoxStylized()
        {
            DoubleBuffered = true;

            base.BackColor = SystemColors.Window;
            Cursor = Cursors.IBeam;

            _clientArea = new Panel
            {
                Margin = Padding.Empty
            };
            _textBox = new TextBox
            {
                BorderStyle = BorderStyle.None,
                Margin = Padding.Empty,
                Text = string.Empty
            };
            Controls.Add(_clientArea);
            _clientArea.Controls.Add(_textBox);

            Resize += (s, e) => UpdateAll();
            BackColorChanged += (s, e) => UpdateColors();
            ForeColorChanged += (s, e) => UpdateColors();
            Click += (s, e) => _textBox.Focus();
            Load += (s, e) => SetPlaceholder();

            _clientArea.Click += (s, e) => _textBox.Focus();

            _textBox.Enter += (s, e) => UnsetPlaceholder();
            _textBox.Leave += (s, e) => SetPlaceholder();
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
                if (diameter <= 0)
                    path.AddRectangle(rect);
                else
                {
                    path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
                    path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
                    path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
                }

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

        private void UpdateAll()
        {
            UpdateBorder();
            UpdateTextBox();
        }

        private void UpdateColors()
        {
            _textBox.BackColor = BackColor;

            if (_isPlaceholderActive)
                _textBox.ForeColor = PlaceholderColor;
            else
                _textBox.ForeColor = ForeColor;

            Invalidate();
        }

        private void UpdateBorder()
        {
            UpdateTextBox();
            Invalidate();
        }

        private void UpdateTextBox()
        {
            int border = (int)Math.Ceiling(_borderWidth);
            int cornerInset = (int)Math.Ceiling(_borderRadius / 2f);
            int inset = border + cornerInset;

            int x = inset;
            int y = inset;
            int w = Math.Max(0, ClientSize.Width - (inset * 2));
            int h = Math.Max(0, ClientSize.Height - (inset * 2));

            _clientArea.Bounds = new Rectangle(x, y, w, h);
            _textBox.Location = new Point(
                _textBox.Location.X,
                (_textBox.Parent.ClientSize.Height - _textBox.ClientSize.Height) / 2
            );


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

    public class TextBoxStylizedDesigner : ControlDesigner
    {
        public override DesignerActionListCollection ActionLists
        {
            get
            {
                return new DesignerActionListCollection
                {
                    new TextBoxStylizedActionList(Component)
                };
            }
        }
    }

    public class TextBoxStylizedActionList : DesignerActionList
    {
        private TextBoxStylized _control;
        private DesignerActionUIService _service;

        public TextBoxStylizedActionList(IComponent component)
            : base(component)
        {
            _control = (TextBoxStylized)component;
            _service = GetService(typeof(DesignerActionUIService)) as DesignerActionUIService;
        }

        public override DesignerActionItemCollection GetSortedActionItems()
        {
            var items = new DesignerActionItemCollection
            {
                new DesignerActionPropertyItem("Font", "Font", "TextStyle"),
                new DesignerActionPropertyItem("Text", "Text", "TextStyle"),
                new DesignerActionPropertyItem("PlaceholderText", "PlaceholderText", "TextStyle"),

                new DesignerActionPropertyItem("BorderRadius", "BorderRadius", "Details"),
                new DesignerActionPropertyItem("BorderWidth", "BorderWidth", "Details"),
                new DesignerActionPropertyItem("BorderColor", "BorderColor", "Details"),
                new DesignerActionPropertyItem("ForeColor", "ForeColor", "Details"),
                new DesignerActionPropertyItem("PlaceholderColor", "PlaceholderColor", "Details"),
            };

            return items;
        }

        #region TextStyle Attributes

        private void SetProperty(string name, object value)
        {
            TypeDescriptor.GetProperties(_control)[name]
                .SetValue(_control, value);

            _service?.Refresh(_control);
        }

        public Font Font
        {
            get => _control.Font;
            set => SetProperty(nameof(_control.Font), value);
        }

        public string Text
        {
            get => _control.Text;
            set => SetProperty(nameof(_control.Text), value);
        }

        public string PlaceholderText
        {
            get => _control.Placeholder;
            set => SetProperty(nameof(_control.Placeholder), value);
        }

        #endregion

        #region Details Attributes

        public Color BorderColor
        {
            get => _control.BorderColor;
            set => SetProperty(nameof(_control.BorderColor), value);
        }

        public Color ForeColor
        {
            get => _control.ForeColor;
            set => SetProperty(nameof(_control.ForeColor), value);
        }

        public int BorderRadius
        {
            get => _control.BorderRadius;
            set => SetProperty(nameof(_control.BorderRadius), value);
        }

        public float BorderWidth
        {
            get => _control.BorderWidth;
            set => SetProperty(nameof(_control.BorderWidth), value);
        }

        public Color PlaceholderColor
        {
            get => _control.PlaceholderColor;
            set => SetProperty(nameof(_control.PlaceholderColor), value);
        }

        #endregion

    }
}