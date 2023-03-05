using Activator.Model.Advanced;
using Activator.View;

namespace Activator.Presenter.Advanced.Commands.TabControlPage2
{
    public class SetBaudRateCommand : SetCommandTemplate<int>
    {
        private readonly IValidateModel _validateModel;

        public SetBaudRateCommand(IMainForm mainForm, IAdvancedForm advancedForm, IViewController viewController, IValidateModel validateModel)
            : base(mainForm, advancedForm, viewController)
        {
            _validateModel = validateModel;
        }

        protected override Task<bool> CheckConnection() => RFID.Api.CheckHwConnection();
        protected override bool CheckValidation(int index) => _validateModel.BaudRateInput(index);
        protected override Task<bool> ExecuteCommand(int index) => RFID.Api.SetBaudRateKey(index);
        protected override string Success => Lang.Advanced.SetBaudRate_Success;
        protected override string Error => Lang.Advanced.SetBaudRate_Error;
    }
}
