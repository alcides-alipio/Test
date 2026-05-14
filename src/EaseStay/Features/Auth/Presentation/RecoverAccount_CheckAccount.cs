using EaseStay.Core;
using EaseStay.Features.Auth.Domain.Entities;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EaseStay.Features.Auth.Presentation
{
    [ToolboxItem(false)]
    public partial class RecoverAccount_CheckAccount : UserControl
    {
        private string _code;
        private User _user;

        private readonly Action<TableLayoutPanel> _subscribe;
        private readonly Action<TableLayoutPanel> _unsubscribe;

        public RecoverAccount_CheckAccount(string code, User user)
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

            _code = code;
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

        private void BtnFindAccount_Click(object sender, EventArgs e)
        {
            if (TBoxCode.Text != _code)
            {
                MessageBox.Show("Codigo invalido!");
                return;
            }

            MainForm.Instance.SetControl(new RecoverAccount_RecoverAccount(_user));
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(new LoginControl());
        }
    }
}
