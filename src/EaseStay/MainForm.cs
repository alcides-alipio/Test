using EaseStay.Controller.Auth;
using EaseStay.Core;
using System;
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
            _navigator.Navigate("auth/login");
        }
    }
}
