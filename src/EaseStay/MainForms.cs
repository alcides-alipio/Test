using EaseStay.Core;
using EaseStay.Features.Auth.Data.Repositories;
using EaseStay.Features.Auth.Domain.Repositories;
using EaseStay.Features.Auth.Domain.UseCases;
using EaseStay.Features.Auth.Presentation;
using EaseStay.Features.Pages.Presentation;
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
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            var press = Settings.GetPersistentSession();

            if (press != Guid.Empty)
            {
                IUserRepository repo = new UserRepository();

                var user = repo.GetByUUID(press);

                Settings.UserUUID = user.UUID;
                Settings.UserFirstName = user.FirstName;
                Settings.UserLastName = user.LastName;
                Settings.UserEmail = user.Email;

                SetControl(new PagesControl());
            }
            else
                SetControl(new LoginControl());
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
