namespace Activator.View
{
    public partial class AdvancedForm
    {
        private void BitRateInput_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);
        public event EventHandler? BitRateButton_Click;

        public bool BitRateInputEnabled
        {
            set { BitRateInput.Enabled = value; }
        }

        public int BitRateInputIndex
        {
            get { return BitRateInput.SelectedIndex; }
            set { BitRateInput.SelectedIndex = value; }
        }

        public bool BitRateButtonEnabled
        {
            set { BitRateButton.Enabled = value; }
        }

        private void SetBitRateUI()
        {
            BitRateButton.Click += delegate { BitRateButton_Click?.Invoke(this, EventArgs.Empty); };

            BitRateContainer.Text = Lang.Advanced.BitRateContainer;
            BitRateButton.Text = Lang.Advanced.Button;
        }

        public void SetBitRateInputItems(object[] items)
        {
            BitRateInput.BeginUpdate();
            foreach (var item in items) BitRateInput.Items.Add(item);
            BitRateInput.EndUpdate();
        }
    }
}
