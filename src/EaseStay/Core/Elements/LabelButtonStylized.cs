using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;

namespace EaseStay.Core.Elements
{
    internal class LabelButtonStylized : Label
    {
        private Font normalFont;
        private Font underlineFont;

        [DefaultValue(typeof(Color), "Blue")]
        public new Color ForeColor
        {
            get => base.ForeColor;
            set => base.ForeColor = value;
        }

        [DefaultValue(typeof(Color), "3, 3, 3, 3")]
        public new Padding Margin
        {
            get => base.Margin;
            set => base.Margin = value;
        }

        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;

                normalFont = value;

                underlineFont?.Dispose();
                underlineFont = new Font(value, value.Style | FontStyle.Underline);
            }
        }


        public LabelButtonStylized()
        {
            ForeColor = Color.Blue;
            Margin = new Padding(3);

            normalFont = Font;
            underlineFont = new Font(Font, Font.Style | FontStyle.Underline);
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            base.Font = underlineFont;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            base.Font = normalFont;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                underlineFont?.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}