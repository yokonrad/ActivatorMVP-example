using Activator.Model.Advanced;
using Activator.View;

namespace Activator.Presenter.Advanced.Commands.TabControlPage2
{
    public class SetTriggerTypeCommand : SetCommandTemplate<int>
    {
        private readonly IValidateModel _validateModel;

        public SetTriggerTypeCommand(IMainForm mainForm, IAdvancedForm advancedForm, IViewController viewController, IValidateModel validateModel)
            : base(mainForm, advancedForm, viewController)
        {
            _validateModel = validateModel;
        }

        protected override Task<bool> CheckConnection() => RFID.Api.CheckHwConnection();
        protected override bool CheckValidation(int index) => _validateModel.TriggerTypeInput(index);
        protected override Task<bool> ExecuteCommand(int index) => RFID.Api.SetTriggerTypeKey(index);
        protected override string Success => Lang.Advanced.SetTriggerType_Success;
        protected override string Error => Lang.Advanced.SetTriggerType_Error;
    }
}
