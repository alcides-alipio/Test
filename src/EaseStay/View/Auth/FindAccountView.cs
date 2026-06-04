using EaseStay.Core.UI.Effects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace EaseStay.View.Auth
{
    [ToolboxItem(false)]
    public partial class FindAccountView : UserControl
    {
        public event EventHandler FindButtonClicked;
        public event EventHandler CancelButtonClicked;

        public string Email { get => TBoxEmail.Text; }

        private readonly List<object> _invalidControls;

        public FindAccountView()
        {
            InitializeComponent();

            _invalidControls = new List<object>();
        }

        private void BtnFind_Click(object sender, EventArgs e) =>
            FindButtonClicked?.Invoke(this, EventArgs.Empty);

        private void BtnCancel_Click(object sender, EventArgs e) =>
            CancelButtonClicked?.Invoke(this, EventArgs.Empty);

        public void MarkInvalidEmail() =>
            _invalidControls.Add(TBoxEmail);

        public bool HasInvalidControls() =>
            _invalidControls.Count > 0;

        public void FlashInvalidControls() =>
            new BorderFlashEffect(_invalidControls).Start();

        public void ClearInvalidControls() =>
            _invalidControls.Clear();
    }
}
