namespace Activator.View
{
    public partial class AdvancedForm
    {
        private void BaudRateInput_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);
        public event EventHandler? BaudRateButton_Click;

        public bool BaudRateInputEnabled
        {
            set { BaudRateInput.Enabled = value; }
        }

        public int BaudRateInputIndex
        {
            get { return BaudRateInput.SelectedIndex; }
            set { BaudRateInput.SelectedIndex = value; }
        }

        public bool BaudRateButtonEnabled
        {
            set { BaudRateButton.Enabled = value; }
        }

        private void SetBaudRateUI()
        {
            BaudRateButton.Click += delegate { BaudRateButton_Click?.Invoke(this, EventArgs.Empty); };

            BaudRateContainer.Text = Lang.Advanced.BaudRateContainer;
            BaudRateButton.Text = Lang.Advanced.Button;
        }

        public void SetBaudRateInputItems(object[] items)
        {
            BaudRateInput.BeginUpdate();
            foreach (var item in items) BaudRateInput.Items.Add(item);
            BaudRateInput.EndUpdate();
        }
    }
}
