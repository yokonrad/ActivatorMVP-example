using Activator.View;
using System.Diagnostics;

namespace Activator.Presenter.Advanced
{
    public interface IViewController
    {
        bool IsEditable { get; set; }
        bool IsLocked { get; }

        Task<bool> Data(int index);
        Task Refresh(int index, bool lockUI = false);
    }

    public class ViewController : IViewController
    {
        private readonly IAdvancedForm _advancedForm;
        private readonly CancellationToken _ct;

        private bool _locked = false;
        private bool _editable = false;

        public ViewController(IAdvancedForm advancedForm, CancellationToken ct)
        {
            _advancedForm = advancedForm;
            _ct = ct;
        }

        public bool IsLocked => _locked;
        public bool IsEditable
        {
            get { return _editable; }
            set { _editable = value; }
        }

        public async Task<bool> Data(int index)
        {
            var connected = await RFID.Api.CheckHwConnection();

            if (!connected)
            {
                _advancedForm.Close();
            }

            if (index == 0)
            {
                var tasksString = new List<Func<Task<string?>>>
                {
                    () => RFID.Api.GetName(),
                    () => RFID.Api.GetSerialNumber(),
                };
                var resultsString = new List<string?>();

                var tasksInt = new List<Func<Task<int?>>>
                {
                    () => RFID.Api.GetBusAddressKey(),
                };
                var resultsInt = new List<int?>();

                foreach (var task in tasksString)
                {
                    if (!_ct.IsCancellationRequested)
                    {
                        resultsString.Add(await task());
                    }
                }

                foreach (var task in tasksInt)
                {
                    if (!_ct.IsCancellationRequested)
                    {
                        resultsInt.Add(await task());
                    }
                }

                if (resultsString.Count == tasksString.Count && resultsInt.Count == tasksInt.Count)
                {
                    _advancedForm.NameInputText = resultsString.ElementAt(0) ?? string.Empty;
                    _advancedForm.SerialNumberInputText = resultsString.ElementAt(1) ?? string.Empty;
                    _advancedForm.BusAddressInputIndex = resultsInt.ElementAt(0) ?? -1;

                    return true;
                }
            }
            else if (index == 1)
            {
                var tasksInt = new List<Func<Task<int?>>>
                {
                    () => RFID.Api.GetVerifyCodeKey(),
                    () => RFID.Api.GetWorkTypeKey(),
                    () => RFID.Api.GetBitRateKey(),
                    () => RFID.Api.GetTriggerTypeKey(),
                    () => RFID.Api.GetRssiKey(),
                    () => RFID.Api.GetFrequencyKey(),
                    () => RFID.Api.GetIntervalKey(),
                    () => RFID.Api.GetPowerKey(),
                    () => RFID.Api.GetBaudRateKey(),
                };
                var resultsInt = new List<int?>();

                foreach (var task in tasksInt)
                {
                    if (!_ct.IsCancellationRequested)
                    {
                        resultsInt.Add(await task());
                    }
                }

                if (resultsInt.Count == tasksInt.Count)
                {
                    _advancedForm.VerifyCodeInputIndex = resultsInt.ElementAt(0) ?? -1;
                    _advancedForm.WorkTypeInputIndex = resultsInt.ElementAt(1) ?? -1;
                    _advancedForm.BitRateInputIndex = resultsInt.ElementAt(2) ?? -1;
                    _advancedForm.TriggerTypeInputIndex = resultsInt.ElementAt(3) ?? -1;
                    _advancedForm.RssiInputIndex = resultsInt.ElementAt(4) ?? -1;
                    _advancedForm.FrequencyInputIndex = resultsInt.ElementAt(5) ?? -1;
                    _advancedForm.IntervalInputIndex = resultsInt.ElementAt(6) ?? -1;
                    _advancedForm.PowerInputIndex = resultsInt.ElementAt(7) ?? -1;
                    _advancedForm.BaudRateInputIndex = resultsInt.ElementAt(8) ?? -1;

                    return true;
                }
            }
            else
            {
                throw new Exception("Not implemented index");
            }

            return false;
        }

        public async Task Refresh(int index, bool lockUI = false)
        {
            _locked = lockUI;

            var connected = await RFID.Api.CheckSwConnection();

            if (!connected)
            {
                _advancedForm.Close();
            }

            _advancedForm.TabControlEnabled = !_locked && connected;

            if (index == 0)
            {
                _advancedForm.NameInputEnabled = !_locked && _editable && connected;
                _advancedForm.NameButtonEnabled = !_locked && _editable && connected;

                _advancedForm.SerialNumberInputEnabled = !_locked && _editable && connected;
                _advancedForm.SerialNumberButtonEnabled = !_locked && _editable && connected;

                _advancedForm.BusAddressInputEnabled = !_locked && _editable && connected;
                _advancedForm.BusAddressButtonEnabled = !_locked && _editable && connected;

                _advancedForm.RebootButtonEnabled = !_locked && _editable && connected;
            }
            else if (index == 1)
            {
                _advancedForm.VerifyCodeInputEnabled = !_locked && _editable && connected;
                _advancedForm.VerifyCodeButtonEnabled = !_locked && _editable && connected;

                _advancedForm.WorkTypeInputEnabled = !_locked && _editable && connected;
                _advancedForm.WorkTypeButtonEnabled = !_locked && _editable && connected;

                _advancedForm.BitRateInputEnabled = !_locked && _editable && connected;
                _advancedForm.BitRateButtonEnabled = !_locked && _editable && connected;

                _advancedForm.TriggerTypeInputEnabled = !_locked && _editable && connected;
                _advancedForm.TriggerTypeButtonEnabled = !_locked && _editable && connected;

                _advancedForm.RssiInputEnabled = !_locked && _editable && connected;
                _advancedForm.RssiButtonEnabled = !_locked && _editable && connected;

                _advancedForm.FrequencyInputEnabled = !_locked && _editable && connected;
                _advancedForm.FrequencyButtonEnabled = !_locked && _editable && connected;

                _advancedForm.IntervalInputEnabled = !_locked && _editable && connected;
                _advancedForm.IntervalButtonEnabled = !_locked && _editable && connected;

                _advancedForm.PowerInputEnabled = !_locked && _editable && connected;
                _advancedForm.PowerButtonEnabled = !_locked && _editable && connected;

                _advancedForm.BaudRateInputEnabled = !_locked && _editable && connected;
                _advancedForm.BaudRateButtonEnabled = !_locked && _editable && connected;

                _advancedForm.RestoreDefaultsButtonEnabled = !_locked && _editable && connected;
            }

            Debug.WriteLine($"Advanced Refresh - connected: {connected}, locked: {_locked}, editable: {_editable}");
        }
    }
}
