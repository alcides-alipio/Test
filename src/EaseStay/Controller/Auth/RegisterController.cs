using EaseStay.Core;
using EaseStay.Core.Services;
using EaseStay.Model;
using EaseStay.Model.Repository;
using EaseStay.View.Auth;
using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace EaseStay.Controller.Auth
{
    internal class RegisterController : INavigableController
    {
        public UserControl View { get; }
        private Navigator _navigator;

        public RegisterController()
        {
            View = new RegisterView
            {
                Dock = DockStyle.Fill
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            var view = (RegisterView)View;

            view.RegisterButtonClicked += RegisterButtonClicked;
            view.LoginButtonClicked += LoginButtonClicked;

            _navigator = navigator;
        }

        public void OnDestroy()
        {
            var view = (RegisterView)View;

            view.RegisterButtonClicked -= RegisterButtonClicked;
            view.LoginButtonClicked -= LoginButtonClicked;

            _navigator = null;
        }

        #region Event Funcs

        private void RegisterButtonClicked(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            var view = (RegisterView)View;

            User user = AuthService.GetUserByEmail(view.Email);

            if (user != null)
            {
                MessageBox.Show(
                    "Email já cadastrado.",
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return;
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(view.Password);

            user = new User(
                view.Email,
                view.FirstName,
                view.LastName,
                passwordHash
            );

            AuthService.RegisterUser(user);

            _navigator.Navigate("auth/login");
        }

        private void LoginButtonClicked(object sender, EventArgs e) => _navigator.Navigate("auth/login");

        #endregion

        #region Validation Funcs

        private bool ValidateInputs()
        {
            var view = (RegisterView)View;

            if (!EmailService.IsValidEmail(view.Email))
                view.MarkInvalidEmail();

            if (string.IsNullOrWhiteSpace(view.FirstName))
                view.MarkInvalidFirstName();

            if (string.IsNullOrWhiteSpace(view.LastName))
                view.MarkInvalidLastName();

            if (string.IsNullOrWhiteSpace(view.Password))
                view.MarkInvalidPassword();

            if (string.IsNullOrWhiteSpace(view.ConfirmPassword))
                view.MarkInvalidConfirmPassword();

            if (view.ConfirmPassword != view.Password)
            {
                view.MarkInvalidPassword();
                view.MarkInvalidConfirmPassword();
            }

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
