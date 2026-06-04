using EaseStay.Core;
using EaseStay.Core.UI.Dialogs;
using EaseStay.Model;
using EaseStay.View.Auth;
using System;
using System.Windows.Forms;

namespace EaseStay.Controller.Auth
{
    internal class CheckEmailAccountController : INavigableController
    {
        public UserControl View { get; }

        private Navigator _navigator;
        private Guid _userUUID;
        private string _code;

        public CheckEmailAccountController()
        {
            View = new CheckEmailAccountView
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

            var view = (CheckEmailAccountView)View;

            view.FindButtonClicked += View_FindButtonClicked;
            view.CancelButtonClicked += View_CancelButtonClicked;

            _code = code;
            _userUUID = userUUID;
            _navigator = navigator;
        }

        public void OnDestroy()
        {
            var view = (CheckEmailAccountView)View;

            view.FindButtonClicked -= View_FindButtonClicked;
            view.CancelButtonClicked -= View_CancelButtonClicked;

            _code = null;
            _userUUID = Guid.Empty;
            _navigator = null;
        }

        #region Event Funcs

        private void View_FindButtonClicked(object sender, EventArgs e)
        {
            var view = (CheckEmailAccountView)View;

            if (_code != view.Code)
            {
                MessageDialog.Error("O código que inseriu esta incorrecto. Por favor verifique o seu email e tente de novo.", "Codigo Invalido");

                view.MarkInvalidCode();
                view.FlashInvalidControls();
                view.ClearInvalidControls();
                return;
            }

            _navigator.Navigate("auth/changePassword", _userUUID);
        }

        private void View_CancelButtonClicked(object sender, EventArgs e)
        {
            _navigator.Navigate("auth/login");
        }


        #endregion
    }
}
