using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EaseStay.Core.Elements
{
    public class BorderAttributes
    {
        private Color _color = Color.Gray;
        private int _radius = 8;
        private float _stroke = 2f;
        public EventHandler Changed;

        [Category("Border")]
        [Description("Cor da borda")]
        [DefaultValue(typeof(Color), "Gray")]
        public Color Color
        {
            get => _color;
            set
            {
                if (_color != value)
                {
                    _color = value;
                    NotifyChanged();
                }
            }
        }

        [Category("Border")]
        [Description("Espessura da borda")]
        [DefaultValue(2f)]
        public float Stroke
        {
            get => _stroke;
            set
            {
                if (_stroke != value)
                {
                    _stroke = value;
                    NotifyChanged();
                }
            }
        }

        [Category("Border")]
        [Description("Raio dos cantos")]
        [DefaultValue(8)]
        public int Radius
        {
            get => _radius;
            set
            {
                if (_radius != value)
                {
                    _radius = value;
                    NotifyChanged();
                }
            }
        }

        public override string ToString()
        {
            return $"Color: {Color}, Stroke: {Stroke}, Radius: {Radius}";
        }

        private void NotifyChanged()
        {
            Changed?.Invoke(this, EventArgs.Empty);
        }
    }
}
