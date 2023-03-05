using Activator.Model.Advanced;
using Activator.Presenter.Advanced;
using Activator.Presenter.Advanced.Commands.Form;
using Activator.Presenter.Advanced.Commands.TabControl;
using Activator.Presenter.Advanced.Commands.TabControlPage1;
using Activator.Presenter.Advanced.Commands.TabControlPage2;
using Activator.View;

namespace Activator.Presenter
{
    public class AdvancedPresenter
    {
        private readonly CancellationToken _ct;
        private readonly CancellationTokenSource _cts;

        private readonly IMainForm _mainForm;
        private readonly IAdvancedForm _advancedForm;
        private readonly IValidateModel _validateModel;

        private readonly IViewController _viewController;

        private readonly LoadCommand _loadCommand;
        private readonly FormClosedCommand _formClosedCommand;
        private readonly KeyDownCommand _keyDownCommand;

        private readonly IndexChangedCommand _indexChangedCommand;

        private readonly SetNameCommand _setNameCommand;
        private readonly SetSerialNumberCommand _setSerialNumberCommand;
        private readonly SetBusAddressCommand _setBusAddressCommand;
        private readonly OpenRebootCommand _openRebootCommand;

        private readonly SetVerifyCodeCommand _setVerifyCodeCommand;
        private readonly SetWorkTypeCommand _setWorkTypeCommand;
        private readonly SetBitRateCommand _setBitRateCommand;
        private readonly SetTriggerTypeCommand _setTriggerTypeCommand;
        private readonly SetRssiCommand _setRssiCommand;
        private readonly SetFrequencyCommand _setFrequencyCommand;
        private readonly SetIntervalCommand _setIntervalCommand;
        private readonly SetPowerCommand _setPowerCommand;
        private readonly SetBaudRateCommand _setBaudRateCommand;
        private readonly OpenRestoreDefaultsCommand _openRestoreDefaultsCommand;

        public AdvancedPresenter(IMainForm mainForm, IAdvancedForm advancedForm, IValidateModel validateModel)
        {
            _ct = new CancellationToken();
            _cts = new CancellationTokenSource();
            _ct = _cts.Token;

            _mainForm = mainForm;
            _advancedForm = advancedForm;
            _validateModel = validateModel;

            _viewController = new ViewController(_advancedForm, _ct);

            _loadCommand = new(_mainForm, _viewController);
            _formClosedCommand = new(_cts);
            _keyDownCommand = new(_mainForm, _viewController);

            _indexChangedCommand = new(_mainForm, _advancedForm, _viewController);

            _setNameCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setSerialNumberCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setBusAddressCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _openRebootCommand = new(_mainForm, _advancedForm, _viewController);

            _setVerifyCodeCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setWorkTypeCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setBitRateCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setTriggerTypeCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setRssiCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setFrequencyCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setIntervalCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setPowerCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _setBaudRateCommand = new(_mainForm, _advancedForm, _viewController, _validateModel);
            _openRestoreDefaultsCommand = new(_mainForm, _advancedForm, _viewController);

            FormEventsBind();
            TabControlEventsBind();
            TabControlPage1ControlsSet();
            TabControlPage1EventsBind();
            TabControlPage2ControlsSet();
            TabControlPage2EventsBind();
        }

        #region Form functions
        private void FormEventsBind()
        {
            _advancedForm.Load += FormViewOnLoad;
            _advancedForm.FormClosed += FormViewOnFormClosed;
            _advancedForm.KeyDown += FormViewOnKeyDown;
        }
        #endregion
        #region Form handlers
        private async void FormViewOnLoad(object? sender, EventArgs e)
        {
            await _loadCommand.Execute(_advancedForm.TabControlIndex);
        }

        private void FormViewOnFormClosed(object? sender, FormClosedEventArgs e)
        {
            _formClosedCommand.Execute();
        }

        private async void FormViewOnKeyDown(object? sender, KeyEventArgs e)
        {
            await _keyDownCommand.Execute(_advancedForm.TabControlIndex, e);
        }
        #endregion

        #region TabControl functions
        private void TabControlEventsBind()
        {
            _advancedForm.TabControl_IndexChanged += TabControlOnIndexChanged;
        }
        #endregion
        #region TabControl handlers
        private async void TabControlOnIndexChanged(object? sender, EventArgs e)
        {
            await _indexChangedCommand.Execute(_advancedForm.TabControlIndex);
        }
        #endregion

        #region TabControlPage1 functions
        private void TabControlPage1ControlsSet()
        {
            _advancedForm.NameInputMaxLength = RFID.Api.GetNameMaxLength();
            _advancedForm.SerialNumberInputMaxLength = RFID.Api.GetSerialNumberMaxLength();
            _advancedForm.SetBusAddressInputItems(RFID.Api.GetBusAddressItems());
        }

        private void TabControlPage1EventsBind()
        {
            _advancedForm.NameButton_Click += NameButtonOnClick;
            _advancedForm.SerialNumberButton_Click += SerialNumberButtonOnClick;
            _advancedForm.BusAddressButton_Click += BusAddressButtonOnClick;
            _advancedForm.RebootButton_Click += RebootButtonOnClick;
        }
        #endregion
        #region TabControlPage1 handlers
        private async void NameButtonOnClick(object? sender, EventArgs e)
        {
            await _setNameCommand.Execute(_advancedForm.NameInputText);
        }

        private async void SerialNumberButtonOnClick(object? sender, EventArgs e)
        {
            await _setSerialNumberCommand.Execute(_advancedForm.SerialNumberInputText);
        }

        private async void BusAddressButtonOnClick(object? sender, EventArgs e)
        {
            await _setBusAddressCommand.Execute(_advancedForm.BusAddressInputIndex);
        }

        private async void RebootButtonOnClick(object? sender, EventArgs e)
        {
            await _openRebootCommand.Execute();
        }
        #endregion

        #region TabControlPage2 functions
        private void TabControlPage2ControlsSet()
        {
            _advancedForm.SetVerifyCodeInputItems(RFID.Api.GetVerifyCodeItems());
            _advancedForm.SetWorkTypeInputItems(RFID.Api.GetWorkTypeItems());
            _advancedForm.SetBitRateInputItems(RFID.Api.GetBitRateItems());
            _advancedForm.SetTriggerTypeInputItems(RFID.Api.GetTriggerTypeItems());
            _advancedForm.SetRssiInputItems(RFID.Api.GetRssiItems());
            _advancedForm.SetFrequencyInputItems(RFID.Api.GetFrequencyItems());
            _advancedForm.SetIntervalInputItems(RFID.Api.GetIntervalItems());
            _advancedForm.SetPowerInputItems(RFID.Api.GetPowerItems());
            _advancedForm.SetBaudRateInputItems(RFID.Api.GetBaudRateItems());
        }

        private void TabControlPage2EventsBind()
        {
            _advancedForm.VerifyCodeButton_Click += VerifyCodeButtonOnClick;
            _advancedForm.WorkTypeButton_Click += WorkTypeButtonOnClick;
            _advancedForm.BitRateButton_Click += BitRateButtonOnClick;
            _advancedForm.TriggerTypeButton_Click += TriggerTypeButtonOnClick;
            _advancedForm.RssiButton_Click += RssiButtonOnClick;
            _advancedForm.FrequencyButton_Click += FrequencyButtonOnClick;
            _advancedForm.IntervalButton_Click += IntervalButtonOnClick;
            _advancedForm.PowerButton_Click += PowerButtonOnClick;
            _advancedForm.BaudRateButton_Click += BaudRateButtonOnClick;
            _advancedForm.RestoreDefaultsButton_Click += RestoreDefaultsButtonOnClick;
        }
        #endregion
        #region TabControlPage2 handlers
        private async void VerifyCodeButtonOnClick(object? sender, EventArgs e)
        {
            await _setVerifyCodeCommand.Execute(_advancedForm.VerifyCodeInputIndex);
        }

        private async void WorkTypeButtonOnClick(object? sender, EventArgs e)
        {
            await _setWorkTypeCommand.Execute(_advancedForm.WorkTypeInputIndex);
        }

        private async void BitRateButtonOnClick(object? sender, EventArgs e)
        {
            await _setBitRateCommand.Execute(_advancedForm.BitRateInputIndex);
        }

        private async void TriggerTypeButtonOnClick(object? sender, EventArgs e)
        {
            await _setTriggerTypeCommand.Execute(_advancedForm.TriggerTypeInputIndex);
        }

        private async void RssiButtonOnClick(object? sender, EventArgs e)
        {
            await _setRssiCommand.Execute(_advancedForm.RssiInputIndex);
        }

        private async void FrequencyButtonOnClick(object? sender, EventArgs e)
        {
            await _setFrequencyCommand.Execute(_advancedForm.FrequencyInputIndex);
        }

        private async void IntervalButtonOnClick(object? sender, EventArgs e)
        {
            await _setIntervalCommand.Execute(_advancedForm.IntervalInputIndex);
        }

        private async void PowerButtonOnClick(object? sender, EventArgs e)
        {
            await _setPowerCommand.Execute(_advancedForm.PowerInputIndex);
        }

        private async void BaudRateButtonOnClick(object? sender, EventArgs e)
        {
            await _setBaudRateCommand.Execute(_advancedForm.BaudRateInputIndex);
        }

        private async void RestoreDefaultsButtonOnClick(object? sender, EventArgs e)
        {
            await _openRestoreDefaultsCommand.Execute();
        }
        #endregion
    }
}
