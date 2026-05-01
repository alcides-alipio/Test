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
            Load += ClearFocus;

            WireUpControlEvents(this);
        }

        private void WireUpControlEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is Label label && label.Name.StartsWith("LbBtn"))
                {
                    var normalFont = label.Font;
                    var underlineFont = new Font(normalFont, normalFont.Style | FontStyle.Underline);

                    label.MouseEnter += (s, e) =>
                    {
                        label.Font = underlineFont;
                    };

                    label.MouseLeave += (s, e) =>
                    {
                        label.Font = normalFont;
                    };
                }
                else if (control is TableLayoutPanel panel)
                {
                    panel.Click += ClearFocus;
                }

                if (control.HasChildren)
                {
                    WireUpControlEvents(control);
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

        }
    }
}
