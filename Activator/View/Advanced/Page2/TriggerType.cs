namespace Activator.View
{
    public partial class AdvancedForm
    {
        private void TriggerTypeInput_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);
        public event EventHandler? TriggerTypeButton_Click;

        public bool TriggerTypeInputEnabled
        {
            set { TriggerTypeInput.Enabled = value; }
        }

        public int TriggerTypeInputIndex
        {
            get { return TriggerTypeInput.SelectedIndex; }
            set { TriggerTypeInput.SelectedIndex = value; }
        }

        public bool TriggerTypeButtonEnabled
        {
            set { TriggerTypeButton.Enabled = value; }
        }

        private void SetTriggerTypeUI()
        {
            TriggerTypeButton.Click += delegate { TriggerTypeButton_Click?.Invoke(this, EventArgs.Empty); };

            TriggerTypeContainer.Text = Lang.Advanced.TriggerTypeContainer;
            TriggerTypeButton.Text = Lang.Advanced.Button;
        }

        public void SetTriggerTypeInputItems(object[] items)
        {
            TriggerTypeInput.BeginUpdate();
            foreach (var item in items) TriggerTypeInput.Items.Add(item);
            TriggerTypeInput.EndUpdate();
        }
    }
}
