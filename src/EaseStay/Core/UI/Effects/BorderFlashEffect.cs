using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace EaseStay.Core.UI.Effects
{
    internal class BorderFlashEffect
    {
        private readonly List<FlashState> _states;
        private readonly Timer _timer;
        private int _ticks;

        private class FlashState
        {
            public object Control { get; set; }
            public PropertyInfo BorderColorProperty { get; set; }
            public PropertyInfo HoverBorderColorProperty { get; set; }
            public Color OriginalColor { get; set; }
            public Color OriginalHoverColor { get; set; }
        }

        public BorderFlashEffect(List<object> controls)
        {
            if (controls == null || controls.Count <= 0)
                return;

            _states = new List<FlashState>();
            _timer = new Timer
            {
                Interval = 200
            };
            _timer.Tick += Tick_Timer;

            foreach (var control in controls)
            {
                var type = control.GetType();

                var borderProperty = type.GetProperty("BorderColor");
                var hoverProperty = type.GetProperty("HoverBorderColor");

                if (borderProperty == null || hoverProperty == null)
                    continue;

                _states.Add(new FlashState
                {
                    Control = control,
                    BorderColorProperty = borderProperty,
                    HoverBorderColorProperty = hoverProperty,
                    OriginalColor = (Color)borderProperty.GetValue(control),
                    OriginalHoverColor = (Color)hoverProperty.GetValue(control)
                });
            }
        }

        public void Start()
        {
            if (_states.Count <= 0)
                return;

            _ticks = 0;
            _timer.Start();
        }

        private void Tick_Timer(object sender, EventArgs e)
        {
            bool isFlashing = _ticks % 2 == 0;

            foreach (var state in _states)
            {
                Color targetColor = isFlashing ? Color.LightCoral : state.OriginalColor;

                state.BorderColorProperty.SetValue(state.Control, targetColor);
                state.HoverBorderColorProperty.SetValue(state.Control, targetColor);
            }

            _ticks++;

            if (_ticks >= 6)
            {
                foreach (var state in _states)
                {
                    state.BorderColorProperty.SetValue(state.Control, state.OriginalColor);
                    state.HoverBorderColorProperty.SetValue(state.Control, state.OriginalHoverColor);
                }

                _timer.Stop();
                _timer.Tick -= Tick_Timer;
                _timer.Dispose();
            }
        }
    }
}
