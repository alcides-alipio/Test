using EaseStay.Core;
using EaseStay.Core.UI.Dialogs;
using EaseStay.View.Auth;
using System;
using System.Windows.Forms;

namespace EaseStay.Controller.Auth
{
    internal class CheckEmailAccountController : INavigableController
    {
        public UserControl View { get => _view; }

        private Navigator _navigator;
        private readonly CheckEmailAccountView _view;
        private Guid _userUUID;
        private string _code;

        public CheckEmailAccountController()
        {
            _view = new CheckEmailAccountView
            {
                Dock = DockStyle.Fill,
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            if (args == null)
                throw new ArgumentNullException(nameof(args));

            if (args.Length != 2)
                throw new ArgumentException("Expected only two elements", nameof(args));

            if (!(args[0] is string code))
                throw new ArgumentException("Expected a string as the first element", nameof(args));

            if (!(args[1] is Guid userUUID))
                throw new ArgumentException("Expected a Guid as the secound element", nameof(args));

            _view.FindButtonClicked += View_FindButtonClicked;
            _view.CancelButtonClicked += View_CancelButtonClicked;

            _code = code;
            _userUUID = userUUID;
            _navigator = navigator;
        }

        public void OnDestroy()
        {
            _view.FindButtonClicked -= View_FindButtonClicked;
            _view.CancelButtonClicked -= View_CancelButtonClicked;

            _code = null;
            _userUUID = Guid.Empty;
            _navigator = null;
        }

        #region Event Funcs

        private void View_FindButtonClicked(object sender, EventArgs e)
        {
            if (_code != _view.Code)
            {
                MessageDialog.Error("O código que inseriu esta incorrecto. Por favor verifique o seu email e tente de novo.", "Codigo Invalido");

                _view.MarkInvalidCode();
                _view.FlashInvalidControls();
                _view.ClearInvalidControls();
                return;
            }

            _navigator.Navigate("auth/changePassword", _userUUID);
        }

        private void View_CancelButtonClicked(object sender, EventArgs e) =>
            _navigator.Navigate("auth/login");

        #endregion
    }
}
