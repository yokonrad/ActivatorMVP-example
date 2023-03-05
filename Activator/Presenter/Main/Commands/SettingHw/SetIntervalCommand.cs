using Activator.Model.Main;
using Activator.View;

namespace Activator.Presenter.Main.Commands.SettingHw
{
    public class SetIntervalCommand : SetCommandTemplate<int>
    {
        private readonly IMainForm _mainForm;
        private readonly IValidateModel _validateModel;

        public SetIntervalCommand(IMainForm mainForm, IViewController viewController, IValidateModel validateModel)
            : base(mainForm, viewController)
        {
            _mainForm = mainForm;
            _validateModel = validateModel;
        }

        protected override Task<bool> CheckConnection() => RFID.Api.CheckHwConnection();
        protected override bool CheckValidation(int index) => _validateModel.SettingHwInterval(index);
        protected override async Task<bool> ExecuteCommand(int index)
        {
            bool result = await RFID.Api.SetIntervalKey(index);

            if (result)
            {
                _mainForm.SettingHwIntervalPrevIndex = index;
            }
            else
            {
                _mainForm.SettingHwIntervalIndex = _mainForm.SettingHwIntervalPrevIndex;
            }

            return result;
        }
        protected override string Success => Lang.Main.SetInterval_Success;
        protected override string Error => Lang.Main.SetInterval_Error;
    }
}
