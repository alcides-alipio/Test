using EaseStay.Core;
using EaseStay.Features.Auth.Data.Repositories;
using EaseStay.Features.Auth.Domain.Entities;
using EaseStay.Features.Auth.Domain.Repositories;
using EaseStay.Features.Auth.Domain.UseCases;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EaseStay.Features.Auth.Presentation
{
    [ToolboxItem(false)]
    public partial class RecoverAccount_RecoverAccount : UserControl
    {
        private User _user;

        private readonly Action<TableLayoutPanel> _subscribe;
        private readonly Action<TableLayoutPanel> _unsubscribe;

        public RecoverAccount_RecoverAccount(User user)
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

            _user = user;
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

        private void BtnChange_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                Console.WriteLine("Erro desconhecido nas etapas anteriores!");
                return;
            }

            if (TBoxPassword.Text != TBoxConfirmPassword.Text)
            {
                Utils.FlashBorders(TBoxPassword, TBoxConfirmPassword);
                MessageBox.Show("As passwords não coincidem", "Erro de Recuperação de Conta");
                return;
            }

            IUserRepository repo = new UserRepository();
            var recover = new RecoverUseCase(repo);

            User user = recover.Execute(_user, TBoxConfirmPassword.Text);

            if (user == null)
            {
                MessageBox.Show("O utilizador não existe!", "Erro de Recuperação de Conta");
                return;
            }

            MainForm.Instance.SetControl(new LoginControl());
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(new LoginControl());
        }
    }
}
