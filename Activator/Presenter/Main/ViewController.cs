using Activator.View;
using System.Diagnostics;

namespace Activator.Presenter.Main
{
    public interface IViewController
    {
        bool IsLocked { get; }

        Task Refresh(bool lockUI = false);
    }

    public class ViewController : IViewController
    {
        private readonly IMainForm _mainForm;

        private bool _locked = false;

        public ViewController(IMainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public bool IsLocked => _locked;

        public async Task Refresh(bool lockUI = false)
        {
            _locked = lockUI;

            var connected = await RFID.Api.CheckSwConnection();

            _mainForm.ConnectionComIdEnabled = !_locked && !connected;
            _mainForm.ConnectionComBusAddressEnabled = !_locked && !connected;
            _mainForm.ConnectionComComNumberEnabled = !_locked && !connected;
            _mainForm.ConnectionComBaudRateEnabled = !_locked && !connected;
            _mainForm.ConnectionComConnectEnabled = !_locked && !connected;
            _mainForm.ConnectionComDisconnectEnabled = !_locked && connected;

            _mainForm.SettingHwRssiEnabled = !_locked && connected;
            _mainForm.SettingHwIntervalEnabled = !_locked && connected;
            _mainForm.SettingHwPowerEnabled = !_locked && connected;
            _mainForm.SettingHwAdvancedEnabled = !_locked && connected;

            if (!_locked && !connected)
            {
                _mainForm.SettingHwRssiIndex = -1;
                _mainForm.SettingHwIntervalIndex = -1;
                _mainForm.SettingHwPowerIndex = -1;

                _mainForm.SettingHwRssiPrevIndex = -1;
                _mainForm.SettingHwIntervalPrevIndex = -1;
                _mainForm.SettingHwPowerPrevIndex = -1;
            }

            Debug.WriteLine($"Main Refresh - connected: {connected}, locked: {_locked}");
        }
    }
}
