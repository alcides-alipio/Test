using EaseStay.Core.UI.Effects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace EaseStay.View.Auth
{
    [ToolboxItem(false)]
    public partial class ChangePasswordView : UserControl
    {
        public event EventHandler ChangePasswordButtonClick;
        public event EventHandler CancelButtonClick;

        public string NewPassword { get => TBoxPassword.Text; }
        public string ConfirmPassword { get => TBoxConfirmPassword.Text; }

        private readonly List<object> _invalidControls;

        public ChangePasswordView()
        {
            InitializeComponent();

            _invalidControls = new List<object>();
        }

        private void BtnChangePassword_Click(object sender, EventArgs e) =>
            ChangePasswordButtonClick?.Invoke(this, EventArgs.Empty);

        private void BtnCancel_Click(object sender, EventArgs e) =>
            CancelButtonClick?.Invoke(this, EventArgs.Empty);

        public void MarkInvalidNewPassword() =>
            _invalidControls.Add(TBoxPassword);

        public void MarkInvalidConfirmPassword() =>
            _invalidControls.Add(TBoxConfirmPassword);

        public bool HasInvalidControls() =>
            _invalidControls.Count > 0;

        public void FlashInvalidControls() =>
            new BorderFlashEffect(_invalidControls).Start();

        public void ClearInvalidControls() =>
            _invalidControls.Clear();
    }
}
