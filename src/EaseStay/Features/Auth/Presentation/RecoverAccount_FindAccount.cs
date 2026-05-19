using EaseStay.Core;
using EaseStay.Core.Services;
using EaseStay.Features.Auth.Data.Repositories;
using EaseStay.Features.Auth.Domain.Entities;
using EaseStay.Features.Auth.Domain.Repositories;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EaseStay.Features.Auth.Presentation
{
    [ToolboxItem(false)]
    public partial class RecoverAccount_FindAccount : UserControl
    {
        private readonly Action<TableLayoutPanel> _subscribe;
        private readonly Action<TableLayoutPanel> _unsubscribe;

        public RecoverAccount_FindAccount()
        {
            InitializeComponent();

            _subscribe = b => b.Click += ClearFocus;
            _unsubscribe = b => b.Click -= ClearFocus;

            PBoxAuth.Click += ClearFocus;

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

            PBoxAuth.Click -= ClearFocus;

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

        private void BtnFindAccount_Click(object sender, EventArgs e)
        {
            IUserRepository repo = new UserRepository();

            User user = repo.GetByEmail(TBoxEmail.Text);

            if (user == null)
            {
                MessageBox.Show("Email não encontrado");
                return;
            }

            string code = Utils.GenerateCode();

            EmailService.Send("Email validation!", $"Your code is: '{code}'. Don't share!", TBoxEmail.Text);

            MainForm.Instance.SetControl(new RecoverAccount_CheckAccount(code, user));
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(new LoginControl());
        }
    }
}
