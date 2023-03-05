using Activator.View;

namespace Activator.Presenter.Advanced.Commands.TabControl
{
    public class IndexChangedCommand
    {
        private readonly IMainForm _mainForm;
        private readonly IAdvancedForm _advancedForm;
        private readonly IViewController _viewController;

        public IndexChangedCommand(IMainForm mainForm, IAdvancedForm advancedForm, IViewController viewController)
        {
            _mainForm = mainForm;
            _advancedForm = advancedForm;
            _viewController = viewController;
        }

        public async Task Execute(int index)
        {
            if (_viewController.IsLocked) return;

            try
            {
                await _viewController.Refresh(index, true);

                if (index == 0)
                {
                    _advancedForm.NameInputText = string.Empty;
                    _advancedForm.SerialNumberInputText = string.Empty;
                    _advancedForm.BusAddressInputIndex = -1;
                }
                else if (index == 1)
                {
                    _advancedForm.VerifyCodeInputIndex = -1;
                    _advancedForm.WorkTypeInputIndex = -1;
                    _advancedForm.BitRateInputIndex = -1;
                    _advancedForm.TriggerTypeInputIndex = -1;
                    _advancedForm.RssiInputIndex = -1;
                    _advancedForm.FrequencyInputIndex = -1;
                    _advancedForm.IntervalInputIndex = -1;
                    _advancedForm.PowerInputIndex = -1;
                    _advancedForm.BaudRateInputIndex = -1;
                }
                else
                {
                    throw new Exception("Not implemented index");
                }

                if (await _viewController.Data(index))
                {
                    _mainForm.LogDevice_Add(Lang.Advanced.DataUI_Success);
                }
                else
                {
                    _mainForm.LogDevice_Add(Lang.Advanced.DataUI_Error);
                }
            }
            catch (Exception exception)
            {
                _mainForm.LogDevice_Add(exception.Message, true);
            }
            finally
            {
                await _viewController.Refresh(index, false);
            }
        }
    }
}
