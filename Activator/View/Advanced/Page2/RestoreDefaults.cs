namespace Activator.View
{
    public partial class AdvancedForm
    {
        public event EventHandler? RestoreDefaultsButton_Click;

        public bool RestoreDefaultsButtonEnabled
        {
            set { RestoreDefaultsButton.Enabled = value; }
        }

        private void SetRestoreDefaultsUI()
        {
            RestoreDefaultsButton.Click += delegate { RestoreDefaultsButton_Click?.Invoke(this, EventArgs.Empty); };

            RestoreDefaultsContainer.Text = Lang.Advanced.RestoreDefaultsContainer;
            RestoreDefaultsButton.Text = Lang.Advanced.Button;
        }

        public bool OpenRestoreDefaultsMessageBox()
        {
            if (MessageBox.Show($"{Lang.Advanced.RestoreDefaultsContainer}?", string.Empty, MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return true;
            }

            return false;
        }
    }
}
