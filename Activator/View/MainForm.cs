namespace Activator.View
{
    public interface IMainForm
    {
        bool ConnectionComBaudRateEnabled { set; }
        int ConnectionComBaudRateIndex { get; set; }
        string ConnectionComBaudRateText { get; }
        bool ConnectionComBusAddressEnabled { set; }
        int ConnectionComBusAddressIndex { get; set; }
        string ConnectionComBusAddressText { get; }
        bool ConnectionComComNumberEnabled { set; }
        int ConnectionComComNumberIndex { get; set; }
        string ConnectionComComNumberText { get; }
        bool ConnectionComConnectEnabled { set; }
        bool ConnectionComDisconnectEnabled { set; }
        bool ConnectionComIdEnabled { set; }
        int ConnectionComIdIndex { get; }
        bool SettingHwAdvancedEnabled { set; }
        bool SettingHwIntervalEnabled { set; }
        int SettingHwIntervalIndex { get; set; }
        int SettingHwIntervalPrevIndex { get; set; }
        bool SettingHwPowerEnabled { set; }
        int SettingHwPowerIndex { get; set; }
        int SettingHwPowerPrevIndex { get; set; }
        bool SettingHwRssiEnabled { set; }
        int SettingHwRssiIndex { get; set; }
        int SettingHwRssiPrevIndex { get; set; }

        event EventHandler? Load;
        event FormClosedEventHandler? FormClosed;
        event EventHandler? ConnectionComConnect_Click;
        event EventHandler? ConnectionComDisconnect_Click;
        event EventHandler? ConnectionComId_SelectedIndexChanged;
        event EventHandler? SettingHwAdvanced_Click;
        event EventHandler? SettingHwInterval_SelectedIndexChanged;
        event EventHandler? SettingHwPower_SelectedIndexChanged;
        event EventHandler? SettingHwRssi_SelectedIndexChanged;

        void LogDevice_Add(string value, bool error = false);
        void OpenSettingHwAdvanced();
        void SetConnectionComBaudRateItems(object[] items);
        void SetConnectionComBusAddressItems(object[] items);
        void SetConnectionComComNumberItems(object[] items);
        void SetConnectionComIdItems(object[] items);
        void SetSettingHwIntervalItems(object[] items);
        void SetSettingHwPowerItems(object[] items);
        void SetSettingHwRssiItems(object[] items);
    }

    public partial class MainForm : Form, IMainForm
    {
        public MainForm()
        {
            InitializeComponent();

            MainFormUI();
            ConnectionComUI();
            SettingHwUI();
            LogDeviceUI();
        }

        private void MainFormUI()
        {
            Text = Lang.Main.FormName;
        }
    }
}
