using System.Windows.Forms;
using System.Drawing;
using System.Linq;

namespace EaseStay.Core
{
    internal class Utils
    {
        public static void FlashBorders(params dynamic[] controls)
        {
            int ticks = 0;

            var states = controls.Select(c => new
            {
                Control = c,
                Original = c.BorderColor
            }).ToList();

            var timer = new Timer();
            timer.Interval = 200;

            timer.Tick += (sender, args) =>
            {
                foreach (var state in states)
                {
                    state.Control.BorderColor =
                        state.Control.BorderColor == Color.LightCoral
                            ? state.Original
                            : Color.LightCoral;
                }

                ticks++;

                if (ticks >= 4)
                {
                    timer.Stop();

                    foreach (var state in states)
                    {
                        state.Control.BorderColor = state.Original;
                    }
                }
            };

            timer.Start();
        }
    }
}
