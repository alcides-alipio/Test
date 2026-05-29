using EaseStay.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EaseStay.View.Auth
{
    public partial class RegisterView : UserControl
    {
        public event EventHandler RegisterButtonClicked;
        public event EventHandler LoginButtonClicked;

        public string Email => TBoxEmail.Text;
        public string FirstName => TBoxFirstName.Text;
        public string LastName => TBoxLastName.Text;
        public string Password => TBoxPassword.Text;
        public string ConfirmPassword => TBoxConfirmPassword.Text;

        private List<Control> _invalidControls;

        public RegisterView()
        {
            InitializeComponent();

            _invalidControls = new List<Control>();
        }

        private void BtnRegister_Click(object sender, EventArgs e) => RegisterButtonClicked?.Invoke(this, EventArgs.Empty);

        private void LkLbLogin_Click(object sender, EventArgs e) => LoginButtonClicked?.Invoke(this, EventArgs.Empty);

        public void MarkInvalidEmail() =>
            _invalidControls.Add(TBoxEmail);

        public void MarkInvalidFirstName() =>
            _invalidControls.Add(TBoxFirstName);

        public void MarkInvalidLastName() =>
            _invalidControls.Add(TBoxLastName);

        public void MarkInvalidPassword() =>
            _invalidControls.Add(TBoxPassword);
        public void MarkInvalidConfirmPassword() =>
            _invalidControls.Add(TBoxConfirmPassword);

        public void FlashInvalidControls() =>
            Utils.FlashBorders(_invalidControls.ToArray());

        public void ClearInvalidControls() =>
            _invalidControls.Clear();

        public bool HasInvalidControls() =>
            _invalidControls.Count > 0;
    }
}
