using EaseStay.Core;
using EaseStay.Core.Services;
using EaseStay.Core.UI.Dialogs;
using EaseStay.View.Auth;
using System;
using System.Windows.Forms;

namespace EaseStay.Controller.Auth
{
    internal class ChangePasswordController : INavigableController
    {
        public UserControl View { get => _view; }

        private Navigator _navigator;
        private readonly ChangePasswordView _view;
        private Guid _userUUID;

        public ChangePasswordController()
        {
            _view = new ChangePasswordView
            {
                Dock = DockStyle.Fill
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            if (args.Length != 1)
                throw new ArgumentException("Expected only one element", nameof(args));

            if (!(args[0] is Guid userUUID))
                throw new ArgumentException("Expected a Guid as the first element", nameof(args));

            _view.ChangePasswordButtonClick += View_ChangePasswordButtonClick;
            _view.CancelButtonClick += View_CancelButtonClick;

            _userUUID = userUUID;
            _navigator = navigator;
        }

        public void OnDestroy()
        {
            _view.ChangePasswordButtonClick -= View_ChangePasswordButtonClick;
            _view.CancelButtonClick -= View_CancelButtonClick;

            _userUUID = Guid.Empty;
            _navigator = null;
        }

        #region Event Funcs

        private void View_ChangePasswordButtonClick(object sender, EventArgs e)
        {
            if (!IsValidInputs())
                return;

            var user = AuthService.GetUserByUUID(_userUUID);
            if (user == null)
            {
                MessageDialog.Error("Utilizador não encontrado", "Erro");
                return;
            }

            AuthService.ChangePassword(user, _view.NewPassword);

            _navigator.Navigate("auth/login");
        }

        private void View_CancelButtonClick(object sender, EventArgs e) =>
            _navigator.Navigate("auth/login");

        #endregion

        #region Validation Funcs

        private bool IsValidInputs()
        {
            if (_view.NewPassword != _view.ConfirmPassword)
            {
                _view.MarkInvalidNewPassword();
                _view.MarkInvalidConfirmPassword();
            }

            if (!AuthService.IsValidPassword(_view.NewPassword))
                _view.MarkInvalidNewPassword();

            if (!AuthService.IsValidPassword(_view.ConfirmPassword))
                _view.MarkInvalidConfirmPassword();

            if (_view.HasInvalidControls())
            {
                _view.FlashInvalidControls();
                _view.ClearInvalidControls();
            }

            return true;
        }

        #endregion
    }
}
