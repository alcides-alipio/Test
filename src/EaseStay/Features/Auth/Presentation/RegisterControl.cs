using EaseStay.Core;
using EaseStay.Core.Database;
using EaseStay.Core.Elements;
using EaseStay.Features.Auth.Data.Repositories;
using EaseStay.Features.Auth.Domain.Entities;
using EaseStay.Features.Auth.Domain.Repositories;
using EaseStay.Features.Auth.Domain.UseCases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace EaseStay.Features.Auth.Presentation
{
    public partial class RegisterControl : UserControl
    {
        private readonly Action<TableLayoutPanel> _subscribe;
        private readonly Action<TableLayoutPanel> _unsubscribe;

        public RegisterControl()
        {
            InitializeComponent();

            _subscribe = b => b.Click += ClearFocus;
            _unsubscribe = b => b.Click -= ClearFocus;

            PBoxRegister.Click += ClearFocus;

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

            PBoxRegister.Click -= ClearFocus;

            Utils.SetControlEvents<TableLayoutPanel>(
                this,
                _subscribe,
                _unsubscribe,
                false
            );
        }

        private void ClearFocus(object sender, EventArgs e)
        {
            ActiveControl = TblImageLayout;
        }
        private void LbBtnLogin_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(new LoginControl());
        }

        private void ValidateControls(Control parent, List<dynamic> invalidControls)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TextBoxStylized tbox)
                {
                    if (string.IsNullOrWhiteSpace(tbox.Text))
                        invalidControls.Add(tbox);
                }

                if (control.HasChildren)
                    ValidateControls(control, invalidControls);
            }
        }

        private void BtnRegister_Click(object sender, EventArgs e)
        {
            List<dynamic> invalidControls = new List<dynamic>();

            ValidateControls(this, invalidControls);

            if (invalidControls.Count > 0)
            {
                Utils.FlashBorders(invalidControls.ToArray());
                return;
            }

            if (TBoxPassword.Text != TBoxConfirmPassword.Text)
            {
                Utils.FlashBorders(TBoxPassword, TBoxConfirmPassword);
                MessageBox.Show("As passwords não coincidem", "Erro de Registro");
                return;
            }

            IUserRepository repo = new UserRepository();
            RegisterUseCase register = new RegisterUseCase(repo);

            User user = register.Execute(
                TBoxEmail.Text,
                TBoxFirstName.Text,
                TBoxLastName.Text,
                TBoxPassword.Text
            );

            if (user == null)
            {
                MessageBox.Show("O utilizador já existe!", "Erro de Registro");
                return;
            }

            MainForm.Instance.SetControl(new LoginControl());
        }
    }
}
