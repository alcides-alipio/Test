using EaseStay.Controller.Auth;
using EaseStay.Controller.Dashboard;
using EaseStay.Core;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace EaseStay
{
    [DesignerCategory("Code")]
    public partial class MainForm : Form
    {
        private Navigator _navigator;

        public MainForm()
        {
            InitializeComponent();

            ClientSize = new Size(768, 512);
            MinimumSize = Size;

            _navigator = new Navigator(PnRoot);
            _navigator.Register<LoginController>("auth/login");
            _navigator.Register<RegisterController>("auth/register");
            _navigator.Register<FindAccountController>("auth/findAccount");
            _navigator.Register<CheckEmailAccountController>("auth/checkAccount");
            _navigator.Register<ChangePasswordController>("auth/changePassword");
            _navigator.Register<DashboardController>("dashboard");

            _navigator.Navigate("auth/login");
        }
    }
}
