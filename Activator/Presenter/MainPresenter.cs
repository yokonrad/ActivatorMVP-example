using Activator.Model.Main;
using Activator.Presenter.Main;
using Activator.Presenter.Main.Commands.Connection;
using Activator.Presenter.Main.Commands.Form;
using Activator.Presenter.Main.Commands.SettingHw;
using Activator.View;

namespace Activator.Presenter
{
    public class MainPresenter
    {
        private readonly CancellationToken _ct;
        private readonly CancellationTokenSource _cts;

        private readonly IMainForm _mainForm;
        private readonly IConnectionComModel _connectionComModel;
        private readonly IValidateModel _validateModel;

        private readonly IViewController _viewController;

        private readonly LoadCommand _loadCommand;
        private readonly FormClosedCommand _formClosedCommand;

        private readonly IdComIndexChangedCommand _idComIndexChangedCommand;
        private readonly ConnectComCommand _connectComCommand;
        private readonly DisconnectCommand _disconnectCommand;

        private readonly SetIntervalCommand _setIntervalCommand;
        private readonly SetPowerCommand _setPowerCommand;
        private readonly SetRssiCommand _setRssiCommand;
        private readonly OpenAdvancedCommand _openAdvancedCommand;

        public MainPresenter(IMainForm mainForm, IConnectionComModel connectionComModel, IValidateModel validateModel)
        {
            _ct = new CancellationToken();
            _cts = new CancellationTokenSource();
            _ct = _cts.Token;

            _mainForm = mainForm;
            _connectionComModel = connectionComModel;
            _validateModel = validateModel;

            _viewController = new ViewController(_mainForm);

            _loadCommand = new(_viewController);
            _formClosedCommand = new(_cts);

            _idComIndexChangedCommand = new(_mainForm, _viewController, _connectionComModel);
            _connectComCommand = new(_mainForm, _viewController, _validateModel, _ct);
            _disconnectCommand = new(_mainForm, _viewController);

            _setIntervalCommand = new(_mainForm, _viewController, _validateModel);
            _setPowerCommand = new(_mainForm, _viewController, _validateModel);
            _setRssiCommand = new(_mainForm, _viewController, _validateModel);
            _openAdvancedCommand = new(_mainForm, _viewController);

            FormEventsBind();
            ConnectionComControlsSet();
            ConnectionComEventsBind();
            SettingHwControlsSet();
            SettingHwEventsBind();
        }

        #region Form functions
        private void FormEventsBind()
        {
            _mainForm.Load += FormViewOnLoad;
            _mainForm.FormClosed += FormViewOnFormClosed;
        }
        #endregion
        #region Form handlers
        private async void FormViewOnLoad(object? sender, EventArgs e)
        {
            await _loadCommand.Execute();
        }

        private void FormViewOnFormClosed(object? sender, FormClosedEventArgs e)
        {
            _formClosedCommand.Execute();
        }
        #endregion

        #region ConnectionCom functions
        private void ConnectionComControlsSet()
        {
            _connectionComModel.Add(1, "COM3", 9600);

            _mainForm.SetConnectionComIdItems(_connectionComModel.GetItems());
            _mainForm.SetConnectionComBusAddressItems(RFID.Api.ConnectComBusAddressItems());
            _mainForm.SetConnectionComComNumberItems(RFID.Api.ConnectComComNumberItems());
            _mainForm.SetConnectionComBaudRateItems(RFID.Api.ConnectComBaudRateItems());
        }

        private void ConnectionComEventsBind()
        {
            _mainForm.ConnectionComId_SelectedIndexChanged += ConnectionComIdOnSelectedIndexChanged;
            _mainForm.ConnectionComConnect_Click += ConnectionComConnectOnClick;
            _mainForm.ConnectionComDisconnect_Click += ConnectionComDisconnectOnClick;
        }
        #endregion
        #region ConnectionCom handlers
        private void ConnectionComIdOnSelectedIndexChanged(object? sender, EventArgs e)
        {
            _idComIndexChangedCommand.Execute(_mainForm.ConnectionComIdIndex);
        }

        private async void ConnectionComConnectOnClick(object? sender, EventArgs e)
        {
            await _connectComCommand.Execute(_mainForm.ConnectionComBusAddressText, _mainForm.ConnectionComComNumberText, _mainForm.ConnectionComBaudRateText);
        }

        private async void ConnectionComDisconnectOnClick(object? sender, EventArgs e)
        {
            await _disconnectCommand.Execute();
        }
        #endregion

        #region SettingHw functions
        private void SettingHwControlsSet()
        {
            _mainForm.SetSettingHwRssiItems(RFID.Api.GetRssiItems());
            _mainForm.SetSettingHwIntervalItems(RFID.Api.GetIntervalItems());
            _mainForm.SetSettingHwPowerItems(RFID.Api.GetPowerItems());
        }

        private void SettingHwEventsBind()
        {
            _mainForm.SettingHwRssi_SelectedIndexChanged += SettingHwRssiOnSelectedIndexChanged;
            _mainForm.SettingHwInterval_SelectedIndexChanged += SettingHwIntervalOnSelectedIndexChanged;
            _mainForm.SettingHwPower_SelectedIndexChanged += SettingHwPowerOnSelectedIndexChanged;
            _mainForm.SettingHwAdvanced_Click += SettingHwAdvancedOnClick;
        }
        #endregion
        #region SettingHw handlers
        private async void SettingHwRssiOnSelectedIndexChanged(object? sender, EventArgs e)
        {
            await _setRssiCommand.Execute(_mainForm.SettingHwRssiIndex);
        }

        private async void SettingHwIntervalOnSelectedIndexChanged(object? sender, EventArgs e)
        {
            await _setIntervalCommand.Execute(_mainForm.SettingHwIntervalIndex);
        }

        private async void SettingHwPowerOnSelectedIndexChanged(object? sender, EventArgs e)
        {
            await _setPowerCommand.Execute(_mainForm.SettingHwPowerIndex);
        }

        private async void SettingHwAdvancedOnClick(object? sender, EventArgs e)
        {
            await _openAdvancedCommand.Execute();
        }
        #endregion
    }
}
