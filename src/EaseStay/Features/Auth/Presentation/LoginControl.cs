using EaseStay.Core.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EaseStay.Features.Auth.Presentation
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();

            PBoxLogin.Click += (s, e) =>
            {
                ActiveControl = TblImageLayout;
            };

            Load += (s, e) =>
            {
                ActiveControl = TblImageLayout;
            };
        }
    }
}
