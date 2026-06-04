using EaseStay.Core;
using EaseStay.Core.Managers;
using EaseStay.View.Dashboard;
using System;
using System.Windows.Forms;

namespace EaseStay.Controller.Dashboard
{
    internal class DashboardController : INavigableController
    {
        public UserControl View { get => _view; }

        private Navigator _navigator;
        private readonly DashboardView _view;
        public Timer _timer;

        public DashboardController()
        {
            _view = new DashboardView
            {
                Dock = DockStyle.Fill
            };
            _timer = new Timer();
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            if (args != null)
                throw new ArgumentException("DashboardController does not accept any arguments.");

            _navigator = navigator;
            _timer.Interval = 600;
            _timer.Tick += Timer_Tick;
            _timer.Start();

            _view.Username = SessionManager.CurrentUser.FirstName + " " + SessionManager.CurrentUser.LastName;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            _view.TextTest = _view.SidebarWidth.ToString("F2");
        }

        public void OnDestroy()
        {
            _timer.Stop();
            _timer.Dispose();

            _navigator = null;
            _timer = null;
        }
    }
}
