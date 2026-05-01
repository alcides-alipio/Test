using EaseStay.Core;
using EaseStay.Core.Database;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace EaseStay.Features.Auth.Presentation
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();

            PBoxLogin.Click += ClearFocus;

            SetControlEvents(this, true);
        }

        protected override void OnLoad(EventArgs e)
        {
            ClearFocus(null, null);
            base.OnLoad(e);
        }

        private void Cleanup(bool disposing)
        {
            if (disposing)
            {
                PBoxLogin.Click -= ClearFocus;
                SetControlEvents(this, false);
            }
        }

        private void SetControlEvents(Control parent, bool enabled)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is TableLayoutPanel panel)
                {
                    if (enabled)
                        panel.Click += ClearFocus;
                    else
                        panel.Click += ClearFocus;
                }

                if (control.HasChildren)
                {
                    SetControlEvents(control, enabled);
                }
            }
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
        }

        private void LbBtnRegister_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(new UserControl());
        }

        private void LbBtnRecoverAccount_Click(object sender, EventArgs e)
        {
            MainForm.Instance.SetControl(new UserControl());
        }
    }
}
