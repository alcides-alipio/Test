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

        public DashboardController()
        {
            _view = new DashboardView
            {
                Dock = DockStyle.Fill
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            if (args != null)
                throw new ArgumentException("DashboardController does not accept any arguments.");

            _view.ButtonExitClick += View_ButtonExitClick;

            _navigator = navigator;
        }

        public void OnDestroy()
        {
            _view.ButtonExitClick -= View_ButtonExitClick;

            _navigator = null;
        }

        #region Event Funcs
        
        private void View_ButtonExitClick(object sender, EventArgs e)
        {
            SessionManager.ClearCurrentUser();
            SessionManager.DeletePersistentUser();

            _navigator.Navigate("auth/login");
        }

        #endregion
    }
}
