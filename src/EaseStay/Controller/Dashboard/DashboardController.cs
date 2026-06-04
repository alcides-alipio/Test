using EaseStay.Core;
using EaseStay.Core.Managers;
using EaseStay.Model;
using EaseStay.View.Dashboard;
using System;
using System.Windows.Forms;

namespace EaseStay.Controller.Dashboard
{
    internal class DashboardController : INavigableController
    {
        public UserControl View { get; }

        private Navigator _navigator;
        public Timer _timer;

        public DashboardController()
        {
            View = new DashboardView
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
            _timer.Tick += _timer_Tick;
            _timer.Start();

            var view = (DashboardView)View;
            view.Username = SessionManager.CurrentUser.FirstName + " " + SessionManager.CurrentUser.LastName;
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            var view = (DashboardView)View;

            view.TextTest = view.SidebarWidth.ToString("F2");
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
