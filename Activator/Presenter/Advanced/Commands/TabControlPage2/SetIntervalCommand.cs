using Activator.Model.Advanced;
using Activator.View;

namespace Activator.Presenter.Advanced.Commands.TabControlPage2
{
    public class SetIntervalCommand : SetCommandTemplate<int>
    {
        private readonly IMainForm _mainForm;
        private readonly IValidateModel _validateModel;

        public SetIntervalCommand(IMainForm mainForm, IAdvancedForm advancedForm, IViewController viewController, IValidateModel validateModel)
            : base(mainForm, advancedForm, viewController)
        {
            _mainForm = mainForm;
            _validateModel = validateModel;
        }

        protected override Task<bool> CheckConnection() => RFID.Api.CheckHwConnection();
        protected override bool CheckValidation(int index) => _validateModel.IntervalInput(index);
        protected override async Task<bool> ExecuteCommand(int index)
        {
            bool result = await RFID.Api.SetIntervalKey(index);

            if (result)
            {
                _mainForm.SettingHwIntervalIndex = index;
            }

            return result;
        }
        protected override string Success => Lang.Advanced.SetInterval_Success;
        protected override string Error => Lang.Advanced.SetInterval_Error;
    }
}
