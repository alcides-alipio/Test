using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace EaseStay.Core
{
    internal class Utils
    {
        public static void FlashBorders(params dynamic[] controls)
        {
            if (controls == null || controls.Length == 0)
                return;

            int ticks = 0;

            var states = controls.Select(c => new
            {
                Control = c,
                Original = c.BorderColor,
                OriginalHover = c.HoverBorderColor
            }).ToList();

            var timer = new Timer
            {
                Interval = 200
            };

            timer.Tick += (sender, args) =>
            {
                bool isFlashing = ticks % 2 == 0;

                foreach (var state in states)
                {
                    if (isFlashing)
                    {
                        state.Control.BorderColor = Color.LightCoral;
                        state.Control.HoverBorderColor = Color.LightCoral;
                    }
                    else
                    {
                        state.Control.BorderColor = state.Original;
                        state.Control.HoverBorderColor = state.Original;
                    }
                }

                ticks++;

                if (ticks >= 6)
                {
                    foreach (var state in states)
                    {
                        state.Control.BorderColor = state.Original;
                        state.Control.HoverBorderColor = state.OriginalHover;
                    }

                    timer.Stop();
                    timer.Dispose();
                } 
            };

            timer.Start();
        }
    }
}
