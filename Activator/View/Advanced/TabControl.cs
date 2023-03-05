namespace Activator.View
{
    public partial class AdvancedForm
    {
        public event EventHandler? TabControl_IndexChanged;

        public bool TabControlEnabled
        {
            set { TabControl.Enabled = value; }
        }

        public int TabControlIndex
        {
            get { return TabControl.SelectedIndex; }
        }

        private void SetTabControlUI()
        {
            TabControl.SelectedIndexChanged += delegate { TabControl_IndexChanged?.Invoke(this, EventArgs.Empty); };

            TabControlPage1.Text = Lang.Advanced.TabControlPage1;
            TabControlPage2.Text = Lang.Advanced.TabControlPage2;
        }

        private void SetTabControlPage1UI()
        {
            SetNameUI();
            SetSerialNumberUI();
            SetBusAddressUI();
            SetRebootUI();
        }

        private void SetTabControlPage2UI()
        {
            SetVerifyCodeUI();
            SetWorkTypeUI();
            SetBitRateUI();
            SetTriggerTypeUI();
            SetRssiUI();
            SetFrequencyUI();
            SetIntervalUI();
            SetPowerUI();
            SetBaudRateUI();
            SetRestoreDefaultsUI();
        }
    }
}
