using EaseStay.Core;
using EaseStay.Features.Auth.Presentation;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace EaseStay.Features.Dashboard.Presentation
{
    [ToolboxItem(false)]
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();

            label1.Text = Settings.UserUUID.ToString();
        }

        private void Dashboard_Resize(object sender, EventArgs e)
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

        private void PBoxExit_Click(object sender, EventArgs e) => Logout();
        private void LbBtnExit_Click(object sender, EventArgs e) => Logout();
        private void TblExitButtonLayout_Click(object sender, EventArgs e) => Logout();

        private void Logout()
        {
            Settings.UserEmail = string.Empty;
            Settings.UserFirstName = string.Empty;
            Settings.UserLastName = string.Empty;
            Settings.UserUUID = Guid.Empty;

            Settings.DeletePersistentSession();

            MainForm.Instance.SetControl(new LoginControl());
        }
    }
}
