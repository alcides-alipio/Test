using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EaseStay.View.Dashboard
{
    [ToolboxItem(false)]
    public partial class DashboardView : UserControl
    {
        public event EventHandler ButtonExitClick;

        public float SidebarWidth
        {
            get => TblColumnsLayout.ColumnStyles[0].Width;
            set
            {
                float newWidth = value;
                newWidth = Math.Min(_sidebarMaxWidth, newWidth);
                newWidth = Math.Max(_sidebarMinWidth, newWidth);
                TblColumnsLayout.ColumnStyles[0].Width = newWidth;
            }
        }

        private float _sidebarMaxWidth = 900f;
        private float _sidebarMinWidth = 130f;

        private bool _isDragging = false;
        private int _startMouseX;
        private float _startNavWidth;

        public DashboardView()
        {
            InitializeComponent();
        }

        private void PnDragResize_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            _isDragging = true;
            _startMouseX = Cursor.Position.X;
            _startNavWidth = TblColumnsLayout.ColumnStyles[0].Width;
        }

        private void PnDragResize_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }

        private void PnDragResize_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDragging)
                return;

            int deltaX = Cursor.Position.X - _startMouseX;
            float newWidth = _startNavWidth + deltaX;

            newWidth = Math.Min(_sidebarMaxWidth, newWidth);
            newWidth = Math.Max(_sidebarMinWidth, newWidth);

            TblColumnsLayout.ColumnStyles[0].Width = newWidth;
        }

        private void BtnExit_Click(object sender, EventArgs e) =>
            ButtonExitClick?.Invoke(this, EventArgs.Empty);

        private void FwPnNavButtonsLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
