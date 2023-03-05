using Activator.Model.Main;
using Activator.View;

namespace Activator.Presenter.Main.Commands.SettingHw
{
    public class SetRssiCommand : SetCommandTemplate<int>
    {
        private readonly IMainForm _mainForm;
        private readonly IValidateModel _validateModel;

        public SetRssiCommand(IMainForm mainForm, IViewController viewController, IValidateModel validateModel)
            : base(mainForm, viewController)
        {
            _mainForm = mainForm;
            _validateModel = validateModel;
        }

        protected override Task<bool> CheckConnection() => RFID.Api.CheckHwConnection();
        protected override bool CheckValidation(int index) => _validateModel.SettingHwRssi(index);
        protected override async Task<bool> ExecuteCommand(int index)
        {
            bool result = await RFID.Api.SetRssiKey(index);

            if (result)
            {
                _mainForm.SettingHwRssiPrevIndex = index;
            }
            else
            {
                _mainForm.SettingHwRssiIndex = _mainForm.SettingHwRssiPrevIndex;
            }

            return result;
        }
        protected override string Success => Lang.Main.SetRssi_Success;
        protected override string Error => Lang.Main.SetRssi_Error;
    }
}
