using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EaseStay.Features.Dashboard.Presentation
{
    [ToolboxItem(false)]
    public partial class DashboardControl : UserControl
    {
        public DashboardControl()
        {
            InitializeComponent();
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
    }
}
