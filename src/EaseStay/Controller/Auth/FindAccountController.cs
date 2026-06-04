using EaseStay.Core;
using EaseStay.Core.Services;
using EaseStay.View.Auth;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace EaseStay.Controller.Auth
{
    internal class FindAccountController : INavigableController
    {
        public UserControl View { get; }
        private Navigator _navigator;

        public FindAccountController()
        {
            View = new FindAccountView
            {
                Dock = DockStyle.Fill
            };
        }

        public void OnCreate(Navigator navigator, object[] args)
        {
            var view = (FindAccountView)View;

            view.FindButtonClicked += FindButtonClicked;
            view.CancelButtonClicked += CancelButtonClicked;

            _navigator = navigator;
        }

        public void OnDestroy()
        {
            var view = (FindAccountView)View;

            view.FindButtonClicked -= FindButtonClicked;
            view.CancelButtonClicked -= CancelButtonClicked;
        }

        #region Event Funcs

        private void CancelButtonClicked(object sender, EventArgs e)
        {
            _navigator.Navigate("auth/login");
        }

        private void FindButtonClicked(object sender, EventArgs e)
        {
            if (!IsValidInputs())
                return;

            var view = (FindAccountView)View;

            var user = AuthService.GetUserByEmail(view.Email);
            if (user == null)
            {
                MessageBox.Show("Utilizador não existe!");
                return;
            }

            string code = new Random().Next(100000, 999999).ToString();

            EmailService.SendRecoveryEmail(code, view.Email);

            _navigator.Navigate("auth/checkAccount", code, user.UUID);
        }

        #endregion

        #region Validation Funcs

        private bool IsValidInputs()
        {
            var view = (FindAccountView)View;

            if (!EmailService.IsValidEmail(view.Email))
                view.MarkInvalidEmail();

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
