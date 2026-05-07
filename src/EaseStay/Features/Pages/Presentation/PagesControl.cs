using EaseStay.Core;
using EaseStay.Features.Auth.Domain.Entities;
using EaseStay.Features.Auth.Presentation;
using System;
using System.Windows.Forms;

namespace EaseStay.Features.Pages.Presentation
{
    public partial class PagesControl : UserControl
    {
        public PagesControl()
        {
            InitializeComponent();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);

            if (TblDashboardLayout.Width * .3 > 340)
            { 
                TblDashboardLayout.ColumnStyles[0].Width = 340;
                TblDashboardLayout.ColumnStyles[0].SizeType = SizeType.Absolute;
            }
            else
            {
                TblDashboardLayout.ColumnStyles[0].Width = 30;
                TblDashboardLayout.ColumnStyles[0].SizeType = SizeType.Percent;
            }
        }

        private void LbBtnLogout_Click(object sender, EventArgs e)
        {
            Settings.UserUUID = Guid.Empty;
            Settings.UserFirstName = string.Empty;
            Settings.UserLastName = string.Empty;
            Settings.UserEmail = string.Empty;

            Settings.DeletePersistentSession();

            MainForm.Instance.SetControl(new LoginControl());
        }
    }
}
