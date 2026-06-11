using EaseStay.Core;
using EaseStay.Core.Managers;
using EaseStay.Core.Services;
using EaseStay.Model;
using EaseStay.View.Auth;
using System.Windows.Forms;

namespace EaseStay.Controller.Auth
{
    internal class LoginController : INavigableController
    {
        public UserControl View { get => _view; }

        private Navigator _navigator;
        private readonly LoginView _view;

        public LoginController()
        {
            _view = new LoginView
            {
                Dock = DockStyle.Fill
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            if (SessionManager.HasPresistentUser())
            {
                if (SessionManager.LoadPresistentUser())
                {
                    navigator.Navigate("dashboard");
                    return;
                }
            }

            _view.LoginButtonClicked += View_LoginButtonClicked;
            _view.RegisterButtonClicked += View_RegisterButtonClicked;
            _view.RecoverButtonClicked += View_RecoverAccountButtonClicked;

            _navigator = navigator;
        }

        public void OnDestroy()
        {
            _view.LoginButtonClicked -= View_LoginButtonClicked;
            _view.RegisterButtonClicked -= View_RegisterButtonClicked;
            _view.RecoverButtonClicked -= View_RecoverAccountButtonClicked;

            _navigator = null;
        }

        #region Event Funcs

        private void View_LoginButtonClicked(object sender, System.EventArgs e)
        {
            if (!ValidateInputs())
                return;

            User user = AuthService.GetUserByEmail(_view.Email);
            if (user == null)
            {
                MessageBox.Show("Email ou password inválidos.");
                return;
            }

            if (!AuthService.VerifyPassword(_view.Password, user.PasswordHash))
            {
                MessageBox.Show("Email ou password inválidos.");
                return;
            }

            SessionManager.SetCurrentUser(user);

            if (_view.RememberMe)
                SessionManager.SavePersistentUser();

            _navigator.Navigate("dashboard");
        }

        private void View_RegisterButtonClicked(object sender, System.EventArgs e) =>
            _navigator.Navigate("auth/register");

        private void View_RecoverAccountButtonClicked(object sender, System.EventArgs e) =>
            _navigator.Navigate("auth/findAccount");

        #endregion

        #region Validation Funcs

        private bool ValidateInputs()
        {
            if (!EmailService.IsValidEmail(_view.Email))
                _view.MarkInvalidEmail();

            if (!AuthService.IsValidPassword(_view.Password))
                _view.MarkInvalidPassword();

            if (_view.HasInvalidControls())
            {
                _view.FlashInvalidControls();
                _view.ClearInvalidControls();
                return false;
            }

            return true;
        }

        #endregion
    }
}
