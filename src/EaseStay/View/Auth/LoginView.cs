using EaseStay.Core;
using EaseStay.Core.UI.Effects;
using StylizedComponents.Controls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EaseStay.View.Auth
{
    public partial class LoginView : UserControl
    {
        public event EventHandler LoginButtonClicked;
        public event EventHandler RegisterButtonClicked;
        public event EventHandler RecoverButtonClicked;

        public string Email => TBoxEmail.Text;
        public string Password => TBoxPassword.Text;

        private List<object> _invalidControls;

        public LoginView()
        {
            InitializeComponent();

            _invalidControls = new List<object>();
        }

        private void BtnLogin_Click(object sender, EventArgs e) =>
            LoginButtonClicked?.Invoke(this, EventArgs.Empty);

        private void LkLbRegister_Click(object sender, EventArgs e) =>
            RegisterButtonClicked?.Invoke(this, EventArgs.Empty);

        private void LkLbRecoverAccount_Click(object sender, EventArgs e) =>
            RecoverButtonClicked?.Invoke(this, EventArgs.Empty);

        public void MarkInvalidEmail() =>
            _invalidControls.Add(TBoxEmail);
        public void MarkInvalidPassword() =>
            _invalidControls.Add(TBoxPassword);

        public void FlashInvalidControls() =>
            new BorderFlashEffect(_invalidControls).Start();

        public void ClearInvalidControls() =>
            _invalidControls.Clear();

        public bool HasInvalidControls() =>
            _invalidControls.Count > 0;
    }
}
