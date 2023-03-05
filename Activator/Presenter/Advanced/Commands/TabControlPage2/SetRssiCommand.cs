using Activator.Model.Advanced;
using Activator.View;

namespace Activator.Presenter.Advanced.Commands.TabControlPage2
{
    public class SetRssiCommand : SetCommandTemplate<int>
    {
        private readonly IMainForm _mainForm;
        private readonly IValidateModel _validateModel;

        public SetRssiCommand(IMainForm mainForm, IAdvancedForm advancedForm, IViewController viewController, IValidateModel validateModel)
            : base(mainForm, advancedForm, viewController)
        {
            _mainForm = mainForm;
            _validateModel = validateModel;
        }

        protected override Task<bool> CheckConnection() => RFID.Api.CheckHwConnection();
        protected override bool CheckValidation(int index) => _validateModel.RssiInput(index);
        protected override async Task<bool> ExecuteCommand(int index)
        {
            bool result = await RFID.Api.SetRssiKey(index);

            if (result)
            {
                _mainForm.SettingHwRssiIndex = index;
            }

            return result;
        }
        protected override string Success => Lang.Advanced.SetRssi_Success;
        protected override string Error => Lang.Advanced.SetRssi_Error;
    }
}
