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
        public UserControl View { get; }
        private Navigator _navigator;

        public LoginController()
        {
            View = new LoginView
            {
                Dock = DockStyle.Fill
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            if (SessionManager.HavePresistentUser())
            {
                SessionManager.LoadPresistentUser();
                navigator.Navigate("dashboard");
                return;
            }

            var view = (LoginView)View;

            view.LoginButtonClicked += LoginButtonClicked;
            view.RegisterButtonClicked += RegisterButtonClicked;
            view.RecoverButtonClicked += RecoverAccountButtonClicked;

            _navigator = navigator;
        }

        public void OnDestroy()
        {
            var view = (LoginView)View;

            view.LoginButtonClicked -= LoginButtonClicked;
            view.RegisterButtonClicked -= RegisterButtonClicked;
            view.RecoverButtonClicked -= RecoverAccountButtonClicked;

            _navigator = null;
        }

        #region Event Funcs

        private void LoginButtonClicked(object sender, System.EventArgs e)
        {
            if (!ValidateInputs())
                return;

            var view = (LoginView)View;

            User user = AuthService.GetUserByEmail(view.Email);
            if (user == null)
            {
                MessageBox.Show("Email ou password inválidos.");
                return;
            }

            if (!AuthService.CheckPassword(view.Password, user.PasswordHash))
            {
                MessageBox.Show("Email ou password inválidos.");
                return;
            }

            SessionManager.SetCurrentUser(user);

            if (view.RememberMe)
                SessionManager.SavePersistentUser();

            _navigator.Navigate("dashboard");
        }

        private void RegisterButtonClicked(object sender, System.EventArgs e)
        {
            _navigator.Navigate("auth/register");
        }

        private void RecoverAccountButtonClicked(object sender, System.EventArgs e)
        {
            _navigator.Navigate("auth/findAccount");
        }

        #endregion

        #region Validation Funcs

        private bool ValidateInputs()
        {
            var view = (LoginView)View;

            if (!EmailService.IsValidEmail(view.Email))
                view.MarkInvalidEmail();

            if (!AuthService.IsValidPassword(view.Password))
                view.MarkInvalidPassword();

            if (view.HasInvalidControls())
            {
                view.FlashInvalidControls();
                view.ClearInvalidControls();
                return false;
            }

            return true;
        }

        #endregion
    }
}
