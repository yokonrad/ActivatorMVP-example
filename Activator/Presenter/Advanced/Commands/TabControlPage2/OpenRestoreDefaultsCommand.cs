using Activator.View;

namespace Activator.Presenter.Advanced.Commands.TabControlPage2
{
    public class OpenRestoreDefaultsCommand : OpenCommandTemplate
    {
        private readonly IAdvancedForm _advancedForm;

        public OpenRestoreDefaultsCommand(IMainForm mainForm, IAdvancedForm advancedForm, IViewController viewController)
            : base(mainForm, advancedForm, viewController)
        {
            _advancedForm = advancedForm;
        }

        protected override Task<bool> CheckConnection() => RFID.Api.CheckHwConnection();
        protected override bool OpenMessageBox() => _advancedForm.OpenRestoreDefaultsMessageBox();
        protected override Task<bool> ExecuteCommand() => RFID.Api.RestoreDefaults();
        protected override string Success => Lang.Advanced.RestoreDefaults_Success;
        protected override string Error => Lang.Advanced.RestoreDefaults_Error;
    }
}
