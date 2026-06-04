using EaseStay.Core.UI.Effects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EaseStay.View.Auth
{
    public partial class CheckEmailAccountView : UserControl
    {
        public event EventHandler FindButtonClicked;
        public event EventHandler CancelButtonClicked;

        public string Code { get => TBoxCode.Text; }

        private List<object> _invalidControls;

        public CheckEmailAccountView()
        {
            InitializeComponent();

            _invalidControls = new List<object>();
        }

        private void BtnFind_Click(object sender, EventArgs e) =>
            FindButtonClicked?.Invoke(this, EventArgs.Empty);

        private void BtnCancel_Click(object sender, EventArgs e) =>
            CancelButtonClicked?.Invoke(this, EventArgs.Empty);

        public void MarkInvalidCode() =>
            _invalidControls.Add(TBoxCode);

        public bool HasInvalidControls() =>
            _invalidControls.Count > 0;

        public void FlashInvalidControls() =>
            new BorderFlashEffect(_invalidControls).Start();

        public void ClearInvalidControls() =>
            _invalidControls.Clear();
    }
}
