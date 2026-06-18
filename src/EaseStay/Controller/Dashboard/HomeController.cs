using EaseStay.Core.Domain.Enums;
using EaseStay.Core.Managers;
using EaseStay.View.Dashboard;
using System.Windows.Forms;

namespace EaseStay.Controller.Dashboard
{
    internal class HomeController : INavigableController
    {
        public UserControl View { get => _view; }

        private readonly DashboardView _view;
        private Navigator _navigator;

        public HomeController()
        {
            _view = new(DashboardNavButtons.HOME)
            {
                Dock = DockStyle.Fill,
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            _navigator = navigator;
        }

        public void OnDestroy()
        {
            throw new System.NotImplementedException();
        }
    }
}
