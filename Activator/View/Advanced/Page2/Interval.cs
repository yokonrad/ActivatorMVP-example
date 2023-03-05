namespace Activator.View
{
    public partial class AdvancedForm
    {
        private void IntervalInput_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);
        public event EventHandler? IntervalButton_Click;

        public bool IntervalInputEnabled
        {
            set { IntervalInput.Enabled = value; }
        }

        public int IntervalInputIndex
        {
            get { return IntervalInput.SelectedIndex; }
            set { IntervalInput.SelectedIndex = value; }
        }

        public bool IntervalButtonEnabled
        {
            set { IntervalButton.Enabled = value; }
        }

        private void SetIntervalUI()
        {
            IntervalButton.Click += delegate { IntervalButton_Click?.Invoke(this, EventArgs.Empty); };

            IntervalContainer.Text = Lang.Advanced.IntervalContainer;
            IntervalButton.Text = Lang.Advanced.Button;
        }

        public void SetIntervalInputItems(object[] items)
        {
            IntervalInput.BeginUpdate();
            foreach (var item in items) IntervalInput.Items.Add(item);
            IntervalInput.EndUpdate();
        }
    }
}
