namespace Activator.View
{
    public partial class AdvancedForm
    {
        private void WorkTypeInput_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);
        public event EventHandler? WorkTypeButton_Click;

        public bool WorkTypeInputEnabled
        {
            set { WorkTypeInput.Enabled = value; }
        }

        public int WorkTypeInputIndex
        {
            get { return WorkTypeInput.SelectedIndex; }
            set { WorkTypeInput.SelectedIndex = value; }
        }

        public bool WorkTypeButtonEnabled
        {
            set { WorkTypeButton.Enabled = value; }
        }

        private void SetWorkTypeUI()
        {
            WorkTypeButton.Click += delegate { WorkTypeButton_Click?.Invoke(this, EventArgs.Empty); };

            WorkTypeContainer.Text = Lang.Advanced.WorkTypeContainer;
            WorkTypeButton.Text = Lang.Advanced.Button;
        }

        public void SetWorkTypeInputItems(object[] items)
        {
            WorkTypeInput.BeginUpdate();
            foreach (var item in items) WorkTypeInput.Items.Add(item);
            WorkTypeInput.EndUpdate();
        }
    }
}
