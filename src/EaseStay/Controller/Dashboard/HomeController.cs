using EaseStay.Core.Managers;
using EaseStay.View.Dashboard;
using System.Windows.Forms;

namespace EaseStay.Controller.Dashboard
{
    internal class HomeController : INavigableController
    {
        public UserControl View { get => _view; }

        private readonly DashboardView _view;

        public HomeController()
        {
            _view = new()
            {
                Dock = DockStyle.Fill,
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
        }

        public void OnDestroy()
        {
            throw new System.NotImplementedException();
        }
    }
}
