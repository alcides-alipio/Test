using EaseStay.Core;
using EaseStay.Core.Services;
using EaseStay.View.Auth;
using System;
using System.Windows.Forms;

namespace EaseStay.Controller.Auth
{
    internal class FindAccountController : INavigableController
    {
        public UserControl View { get => _view; }
        
        private Navigator _navigator;
        private readonly FindAccountView _view;

        public FindAccountController()
        {
            _view = new FindAccountView
            {
                Dock = DockStyle.Fill
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            _view.FindButtonClicked += View_FindButtonClicked;
            _view.CancelButtonClicked += View_CancelButtonClicked;

            _navigator = navigator;
        }

        public void OnDestroy()
        {
            _view.FindButtonClicked -= View_FindButtonClicked;
            _view.CancelButtonClicked -= View_CancelButtonClicked;
        }

        #region Event Funcs

        private void View_CancelButtonClicked(object sender, EventArgs e) =>
            _navigator.Navigate("auth/login");
        

        private void View_FindButtonClicked(object sender, EventArgs e)
        {
            if (!IsValidInputs())
                return;

            var user = AuthService.GetUserByEmail(_view.Email);
            if (user == null)
            {
                MessageBox.Show("Utilizador não existe!");
                return;
            }

            string code = new Random().Next(100000, 999999).ToString();

            EmailService.SendRecoveryEmail(code, _view.Email);

            _navigator.Navigate("auth/checkAccount", code, user.UUID);
        }

        #endregion

        #region Validation Funcs

        private bool IsValidInputs()
        {
            if (!EmailService.IsValidEmail(_view.Email))
                _view.MarkInvalidEmail();

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
