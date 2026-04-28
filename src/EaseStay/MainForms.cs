using System;
using System.Windows.Forms;

namespace EaseStay
{
    public partial class MainForm : Form
    {
        private static MainForm _instance;
        private UserControl _currentControl;

        public static MainForm Instance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                    _instance = new MainForm();

                return _instance;
            }
        }

        private MainForm()
        {
            InitializeComponent();
            SetControl(new UserControl());
        }

        public void SetControl(UserControl control)
        {
            if (_currentControl != null)
            {
                Controls.Remove(_currentControl);
                _currentControl.Dispose();

                GC.Collect();
                GC.WaitForPendingFinalizers();
                GC.Collect();
            }

            _currentControl = control;
            _currentControl.Dock = DockStyle.Fill;
            Controls.Add(_currentControl);

            GC.Collect();
            GC.WaitForPendingFinalizers();
            GC.Collect();
        }
    }
}
