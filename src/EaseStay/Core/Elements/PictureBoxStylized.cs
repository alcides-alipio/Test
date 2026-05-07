using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace EaseStay.Core.Elements
{
    public class PictureBoxStylized : PictureBox
    {
        private Bitmap _backgroundCache;
        private bool _requiresRebuild = true;

        private Control _currentParent;

        private readonly EventHandler _onLayoutChanged;

        public PictureBoxStylized()
        {
            SetStyle(
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);

            BackColor = Color.Transparent;

            _onLayoutChanged = (s, e) =>
            {
                _requiresRebuild = true;
                Invalidate();
            };
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                UnsubscribeParentEvents();

                _backgroundCache?.Dispose();
                _backgroundCache = null;
            }

            base.Dispose(disposing);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            UnsubscribeParentEvents();

            base.OnParentChanged(e);

            if (Parent != null)
            {
                SubscribeParentEvents(Parent);

                _requiresRebuild = true;
                Invalidate();
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            if (Parent == null)
            {
                base.OnPaintBackground(pevent);
                return;
            }

            if (
                _backgroundCache == null ||
                _requiresRebuild ||
                _backgroundCache.Width != Parent.Width ||
                _backgroundCache.Height != Parent.Height
            )
            {
                BuildBackgroundCache();
                _requiresRebuild = false;
            }

            Graphics g = pevent.Graphics;

            GraphicsState state = g.Save();

            g.TranslateTransform(-Left, -Top);

            if (_backgroundCache != null)
                g.DrawImage(_backgroundCache, Parent.ClientRectangle);

            g.Restore(state);
        }

        private void SubscribeParentEvents(Control parent)
        {
            _currentParent = parent;

            HookControlTree(parent);
        }

        private void UnsubscribeParentEvents()
        {
            if (_currentParent == null)
                return;

            UnhookControlTree(_currentParent);

            _currentParent = null;
        }

        private void HookControlTree(Control control)
        {
            if (control == this)
                return;

            control.LocationChanged += _onLayoutChanged;
            control.SizeChanged += _onLayoutChanged;
            control.VisibleChanged += _onLayoutChanged;
            control.ControlAdded += OnControlAdded;
            control.ControlRemoved += OnControlRemoved;

            foreach (Control child in control.Controls)
                HookControlTree(child);
        }

        private void UnhookControlTree(Control control)
        {
            if (control == this)
                return;

            control.LocationChanged -= _onLayoutChanged;
            control.SizeChanged -= _onLayoutChanged;
            control.VisibleChanged -= _onLayoutChanged;
            control.ControlAdded -= OnControlAdded;
            control.ControlRemoved -= OnControlRemoved;

            foreach (Control child in control.Controls)
                UnhookControlTree(child);
        }

        private void OnControlAdded(object sender, ControlEventArgs e)
        {
            HookControlTree(e.Control);

            _requiresRebuild = true;
            Invalidate();
        }

        private void OnControlRemoved(object sender, ControlEventArgs e)
        {
            UnhookControlTree(e.Control);

            _requiresRebuild = true;
            Invalidate();
        }

        private void BuildBackgroundCache()
        {
            _backgroundCache?.Dispose();

            _backgroundCache = new Bitmap(Parent.Width, Parent.Height);

            using (Graphics g = Graphics.FromImage(_backgroundCache))
            {
                g.Clear(Parent.BackColor);

                int zIndex = Parent.Controls.GetChildIndex(this);

                for (int i = Parent.Controls.Count - 1; i > zIndex; i--)
                {
                    Control control = Parent.Controls[i];

                    if (!control.Visible)
                        continue;

                    using (Bitmap controlBitmap = new Bitmap(control.Width, control.Height))
                    {
                        control.DrawToBitmap(
                            controlBitmap,
                            new Rectangle(0, 0, control.Width, control.Height)
                        );

                        g.DrawImage(
                            controlBitmap,
                            control.Left,
                            control.Top
                        );
                    }
                }
            }
        }
    }
}