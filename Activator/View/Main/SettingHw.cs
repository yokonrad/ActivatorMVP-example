using Activator.Model.Advanced;
using Activator.Presenter;

namespace Activator.View
{
    public partial class MainForm
    {
        private void SettingHwRssi_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);
        private void SettingHwInterval_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);
        private void SettingHwPower_DrawItem(object sender, DrawItemEventArgs e) => Helper.ComboBox_DrawItem(sender, e);

        public event EventHandler? SettingHwRssi_SelectedIndexChanged;
        public event EventHandler? SettingHwInterval_SelectedIndexChanged;
        public event EventHandler? SettingHwPower_SelectedIndexChanged;
        public event EventHandler? SettingHwAdvanced_Click;

        private int _settingHwRssiPrevIndex = -1;
        private int _settingHwIntervalPrevIndex = -1;
        private int _settingHwPowerPrevIndex = -1;

        public bool SettingHwRssiEnabled
        {
            set { SettingHwRssi.Enabled = value; }
        }

        public int SettingHwRssiIndex
        {
            get { return SettingHwRssi.SelectedIndex; }
            set { SettingHwRssi.SelectedIndex = value; }
        }

        public int SettingHwRssiPrevIndex
        {
            get { return _settingHwRssiPrevIndex; }
            set { _settingHwRssiPrevIndex = value; }
        }

        public bool SettingHwIntervalEnabled
        {
            set { SettingHwInterval.Enabled = value; }
        }

        public int SettingHwIntervalIndex
        {
            get { return SettingHwInterval.SelectedIndex; }
            set { SettingHwInterval.SelectedIndex = value; }
        }

        public int SettingHwIntervalPrevIndex
        {
            get { return _settingHwIntervalPrevIndex; }
            set { _settingHwIntervalPrevIndex = value; }
        }

        public bool SettingHwPowerEnabled
        {
            set { SettingHwPower.Enabled = value; }
        }

        public int SettingHwPowerIndex
        {
            get { return SettingHwPower.SelectedIndex; }
            set { SettingHwPower.SelectedIndex = value; }
        }

        public int SettingHwPowerPrevIndex
        {
            get { return _settingHwPowerPrevIndex; }
            set { _settingHwPowerPrevIndex = value; }
        }

        public bool SettingHwAdvancedEnabled
        {
            set { SettingHwAdvanced.Enabled = value; }
        }

        private void SettingHwUI()
        {
            SettingHwRssi.SelectedIndexChanged += delegate { SettingHwRssi_SelectedIndexChanged?.Invoke(this, EventArgs.Empty); };
            SettingHwInterval.SelectedIndexChanged += delegate { SettingHwInterval_SelectedIndexChanged?.Invoke(this, EventArgs.Empty); };
            SettingHwPower.SelectedIndexChanged += delegate { SettingHwPower_SelectedIndexChanged?.Invoke(this, EventArgs.Empty); };
            SettingHwAdvanced.Click += delegate { SettingHwAdvanced_Click?.Invoke(this, EventArgs.Empty); };

            SettingHwContainer.Text = Lang.Main.SettingsHwContainer;
            SettingHwAdvanced.Text = Lang.Main.SettingsHwAdvanced;
        }

        public void SetSettingHwRssiItems(object[] items)
        {
            SettingHwRssi.BeginUpdate();
            foreach (var item in items) SettingHwRssi.Items.Add(item);
            SettingHwRssi.EndUpdate();
        }

        public void SetSettingHwIntervalItems(object[] items)
        {
            SettingHwInterval.BeginUpdate();
            foreach (var item in items) SettingHwInterval.Items.Add(item);
            SettingHwInterval.EndUpdate();
        }

        public void SetSettingHwPowerItems(object[] items)
        {
            SettingHwPower.BeginUpdate();
            foreach (var item in items) SettingHwPower.Items.Add(item);
            SettingHwPower.EndUpdate();
        }

        public void OpenSettingHwAdvanced()
        {
            using AdvancedForm view = new(this);
            var validateModel = new ValidateModel();
            _ = new AdvancedPresenter(this, view, validateModel);

            view.Location = new Point(Left + Width, Top);
            view.ShowDialog();
        }
    }
}
