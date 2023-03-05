namespace Activator.View
{
    public partial class AdvancedForm
    {
        private void VerifyCodeInput_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);
        public event EventHandler? VerifyCodeButton_Click;

        public bool VerifyCodeInputEnabled
        {
            set { VerifyCodeInput.Enabled = value; }
        }

        public int VerifyCodeInputIndex
        {
            get { return VerifyCodeInput.SelectedIndex; }
            set { VerifyCodeInput.SelectedIndex = value; }
        }

        public bool VerifyCodeButtonEnabled
        {
            set { VerifyCodeButton.Enabled = value; }
        }

        private void SetVerifyCodeUI()
        {
            VerifyCodeButton.Click += delegate { VerifyCodeButton_Click?.Invoke(this, EventArgs.Empty); };

            VerifyCodeContainer.Text = Lang.Advanced.VerifyCodeContainer;
            VerifyCodeButton.Text = Lang.Advanced.Button;
        }

        public void SetVerifyCodeInputItems(object[] items)
        {
            VerifyCodeInput.BeginUpdate();
            foreach (var item in items) VerifyCodeInput.Items.Add(item);
            VerifyCodeInput.EndUpdate();
        }
    }
}
