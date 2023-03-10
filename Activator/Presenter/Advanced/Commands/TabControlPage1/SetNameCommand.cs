using Activator.Model.Advanced;
using Activator.View;

namespace Activator.Presenter.Advanced.Commands.TabControlPage1
{
    public class SetNameCommand : SetCommandTemplate<string>
    {
        private readonly IValidateModel _validateModel;

        public SetNameCommand(IMainForm mainForm, IAdvancedForm advancedForm, IViewController viewController, IValidateModel validateModel)
            : base(mainForm, advancedForm, viewController)
        {
            _validateModel = validateModel;
        }

        protected override Task<bool> CheckConnection() => RFID.Api.CheckHwConnection();
        protected override bool CheckValidation(string value) => _validateModel.NameInput(value);
        protected override Task<bool> ExecuteCommand(string value) => RFID.Api.SetName(value);
        protected override string Success => Lang.Advanced.SetName_Success;
        protected override string Error => Lang.Advanced.SetName_Error;
    }
}
