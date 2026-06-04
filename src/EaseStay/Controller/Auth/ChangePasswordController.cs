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
        public UserControl View { get; }

        private Navigator _navigator;
        private Guid _userUUID;

        public ChangePasswordController()
        {
            View = new ChangePasswordView
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

            var view = (ChangePasswordView)View;

            view.ChangePasswordButtonClick += View_ChangePasswordButtonClick;
            view.CancelButtonClick += View_CancelButtonClick;

            _userUUID = userUUID;
            _navigator = navigator;
        }

        public void OnDestroy()
        {
            var view = (ChangePasswordView)View;

            view.ChangePasswordButtonClick -= View_ChangePasswordButtonClick;
            view.CancelButtonClick -= View_CancelButtonClick;

            _userUUID = Guid.Empty;
            _navigator = null;
        }

        #region Event Funcs

        private void View_ChangePasswordButtonClick(object sender, EventArgs e)
        {
            if (!IsValidInputs())
                return;

            var view = (ChangePasswordView)View;

            var user = AuthService.GetUserByUUID(_userUUID);
            if (user == null)
            {
                MessageDialog.Error("Utilizador não encontrado", "Erro");
                return;
            }

            AuthService.ChangePassword(user, view.NewPassword);

            _navigator.Navigate("auth/login");
        }

        private void View_CancelButtonClick(object sender, EventArgs e)
        {
            _navigator.Navigate("auth/login");
        }

        #endregion

        #region Validation Funcs

        private bool IsValidInputs()
        {
            var view = (ChangePasswordView)View;

            if (view.NewPassword != view.ConfirmPassword)
            {
                view.MarkInvalidNewPassword();
                view.MarkInvalidConfirmPassword();
            }

            if (!AuthService.IsValidPassword(view.NewPassword))
                view.MarkInvalidNewPassword();

            if (!AuthService.IsValidPassword(view.ConfirmPassword))
                view.MarkInvalidConfirmPassword();

            if (view.HasInvalidControls())
            {
                view.FlashInvalidControls();
                view.ClearInvalidControls();
            }

            return true;
        }

        #endregion
    }
}
