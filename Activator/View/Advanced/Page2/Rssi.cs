namespace Activator.View
{
    public partial class AdvancedForm
    {
        private void RssiInput_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);
        public event EventHandler? RssiButton_Click;

        public bool RssiInputEnabled
        {
            set { RssiInput.Enabled = value; }
        }

        public int RssiInputIndex
        {
            get { return RssiInput.SelectedIndex; }
            set { RssiInput.SelectedIndex = value; }
        }

        public bool RssiButtonEnabled
        {
            set { RssiButton.Enabled = value; }
        }

        private void SetRssiUI()
        {
            RssiButton.Click += delegate { RssiButton_Click?.Invoke(this, EventArgs.Empty); };

            RssiContainer.Text = Lang.Advanced.RssiContainer;
            RssiButton.Text = Lang.Advanced.Button;
        }

        public void SetRssiInputItems(object[] items)
        {
            RssiInput.BeginUpdate();
            foreach (var item in items) RssiInput.Items.Add(item);
            RssiInput.EndUpdate();
        }
    }
}
