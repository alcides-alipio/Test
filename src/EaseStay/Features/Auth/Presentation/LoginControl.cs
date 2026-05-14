using EaseStay.Core;
using EaseStay.Features.Auth.Data.Repositories;
using EaseStay.Features.Auth.Domain.Entities;
using EaseStay.Features.Auth.Domain.Repositories;
using EaseStay.Features.Auth.Domain.UseCases;
using EaseStay.Features.Dashboard.Presentation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace EaseStay.Features.Auth.Presentation
{
    [ToolboxItem(false)]
    public partial class LoginControl : UserControl
    {
        private readonly Action<TableLayoutPanel> _subscribe;
        private readonly Action<TableLayoutPanel> _unsubscribe;

        public LoginControl()
        {
            InitializeComponent();

            _subscribe = b => b.Click += ClearFocus;
            _unsubscribe = b => b.Click -= ClearFocus;

            PBoxLogin.Click += ClearFocus;

            Utils.SetControlEvents<TableLayoutPanel>(
                this,
                _subscribe,
                _unsubscribe,
                true
            );
        }

        protected override void OnLoad(EventArgs e)
        {
            ClearFocus(null, null);
            base.OnLoad(e);
        }

        private void Cleanup(bool disposing)
        {
            if (!disposing)
                return;

            PBoxLogin.Click -= ClearFocus;

            Utils.SetControlEvents<TableLayoutPanel>(
                this,
                _subscribe,
                _unsubscribe,
                false
            );
        }

        private void ClearFocus(object s, EventArgs e)
        {
            ActiveControl = TblImageLayout;
        }

        private void BtnLogin_Click(object s, EventArgs e)
        {
            List<dynamic> invalidControls = new List<dynamic>();

            if (string.IsNullOrWhiteSpace(TBoxEmail.Text))
                invalidControls.Add(TBoxEmail);

            if (string.IsNullOrWhiteSpace(TBoxPassword.Text))
                invalidControls.Add(TBoxPassword);

            if (invalidControls.Count > 0)
            {
                Utils.FlashBorders(invalidControls.ToArray());
                return;
            }

            IUserRepository repo = new UserRepository();
            LoginUseCase login = new LoginUseCase(repo);

            User user = login.Execute(
                TBoxEmail.Text,
                TBoxPassword.Text,
                CBoxRememberMe.Checked
            );

            if (user == null)
            {
                MessageBox.Show("Credenciais Invalidas", "Erro de Login");
                return;
            }

            MainForm.Instance.SetControl(new DashboardControl());
        }

        private void LbBtnRegister_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(new RegisterControl());
        }

        private void LbBtnRecoverAccount_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(new RecoverAccount_FindAccount());
        }
    }
}
