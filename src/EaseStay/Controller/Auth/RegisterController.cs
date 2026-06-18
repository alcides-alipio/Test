using EaseStay.Core.Managers;
using EaseStay.Core.Services;
using EaseStay.Core.UI.Dialogs;
using EaseStay.Core.Database.Models;
using EaseStay.View.Auth;
using System;
using System.Windows.Forms;

namespace EaseStay.Controller.Auth
{
    internal class RegisterController : INavigableController
    {
        public UserControl View { get => _view; }

        private Navigator _navigator;
        private readonly RegisterView _view;

        public RegisterController()
        {
            _view = new RegisterView
            {
                Dock = DockStyle.Fill
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            _view.RegisterButtonClicked += View_RegisterButtonClicked;
            _view.LoginButtonClicked += View_LoginButtonClicked;

            _navigator = navigator;
        }

        public void OnDestroy()
        {
            _view.RegisterButtonClicked -= View_RegisterButtonClicked;
            _view.LoginButtonClicked -= View_LoginButtonClicked;

            _navigator = null;
        }

        #region Event Funcs

        private void View_RegisterButtonClicked(object sender, EventArgs e)
        {
            if (!ValidateInputs())
                return;

            UserModel user = AuthService.GetUserByEmail(_view.Email);

            if (user != null)
            {
                MessageDialog.ShowWarning("Email já cadastrado.");
                return;
            }

            string passwordHash = BCrypt.Net.BCrypt.HashPassword(_view.Password);

            user = new UserModel(
                _view.Email,
                _view.FirstName,
                _view.LastName,
                passwordHash
            );

            AuthService.RegisterUser(user);

            _navigator.Navigate("auth/login");
        }

        private void View_LoginButtonClicked(object sender, EventArgs e) =>
            _navigator.Navigate("auth/login");

        #endregion

        #region Validation Funcs

        private bool ValidateInputs()
        {
            if (!EmailService.IsValidEmail(_view.Email))
                _view.MarkInvalidEmail();

            if (string.IsNullOrWhiteSpace(_view.FirstName))
                _view.MarkInvalidFirstName();

            if (string.IsNullOrWhiteSpace(_view.LastName))
                _view.MarkInvalidLastName();

            if (string.IsNullOrWhiteSpace(_view.Password))
                _view.MarkInvalidPassword();

            if (string.IsNullOrWhiteSpace(_view.ConfirmPassword))
                _view.MarkInvalidConfirmPassword();

            if (_view.ConfirmPassword != _view.Password)
            {
                _view.MarkInvalidPassword();
                _view.MarkInvalidConfirmPassword();

                MessageDialog.ShowWarning("As passwords não correspondem!", "Aviso");
            }

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
