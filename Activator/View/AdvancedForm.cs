namespace Activator.View
{
    public interface IAdvancedForm
    {
        bool BaudRateButtonEnabled { set; }
        bool BaudRateInputEnabled { set; }
        int BaudRateInputIndex { get; set; }
        bool BitRateButtonEnabled { set; }
        bool BitRateInputEnabled { set; }
        int BitRateInputIndex { get; set; }
        bool BusAddressButtonEnabled { set; }
        bool BusAddressInputEnabled { set; }
        int BusAddressInputIndex { get; set; }
        bool FrequencyButtonEnabled { set; }
        bool FrequencyInputEnabled { set; }
        int FrequencyInputIndex { get; set; }
        bool IntervalButtonEnabled { set; }
        bool IntervalInputEnabled { set; }
        int IntervalInputIndex { get; set; }
        bool NameButtonEnabled { set; }
        bool NameInputEnabled { set; }
        int NameInputMaxLength { set; }
        string NameInputText { get; set; }
        bool PowerButtonEnabled { set; }
        bool PowerInputEnabled { set; }
        int PowerInputIndex { get; set; }
        bool RebootButtonEnabled { set; }
        bool RestoreDefaultsButtonEnabled { set; }
        bool RssiButtonEnabled { set; }
        bool RssiInputEnabled { set; }
        int RssiInputIndex { get; set; }
        bool SerialNumberButtonEnabled { set; }
        bool SerialNumberInputEnabled { set; }
        int SerialNumberInputMaxLength { set; }
        string SerialNumberInputText { get; set; }
        bool TabControlEnabled { set; }
        int TabControlIndex { get; }
        bool TriggerTypeButtonEnabled { set; }
        bool TriggerTypeInputEnabled { set; }
        int TriggerTypeInputIndex { get; set; }
        bool VerifyCodeButtonEnabled { set; }
        bool VerifyCodeInputEnabled { set; }
        int VerifyCodeInputIndex { get; set; }
        bool WorkTypeButtonEnabled { set; }
        bool WorkTypeInputEnabled { set; }
        int WorkTypeInputIndex { get; set; }

        event EventHandler? Load;
        event FormClosedEventHandler? FormClosed;
        event KeyEventHandler? KeyDown;
        event EventHandler? BaudRateButton_Click;
        event EventHandler? BitRateButton_Click;
        event EventHandler? BusAddressButton_Click;
        event EventHandler? FrequencyButton_Click;
        event EventHandler? IntervalButton_Click;
        event EventHandler? NameButton_Click;
        event KeyPressEventHandler? NameInput_KeyPress;
        event EventHandler? PowerButton_Click;
        event EventHandler? RebootButton_Click;
        event EventHandler? RestoreDefaultsButton_Click;
        event EventHandler? RssiButton_Click;
        event EventHandler? SerialNumberButton_Click;
        event KeyPressEventHandler? SerialNumberInput_KeyPress;
        event EventHandler? TabControl_IndexChanged;
        event EventHandler? TriggerTypeButton_Click;
        event EventHandler? VerifyCodeButton_Click;
        event EventHandler? WorkTypeButton_Click;

        void Close();
        bool OpenRebootMessageBox();
        bool OpenRestoreDefaultsMessageBox();
        void SetBaudRateInputItems(object[] items);
        void SetBitRateInputItems(object[] items);
        void SetBusAddressInputItems(object[] items);
        void SetFrequencyInputItems(object[] items);
        void SetIntervalInputItems(object[] items);
        void SetPowerInputItems(object[] items);
        void SetRssiInputItems(object[] items);
        void SetTriggerTypeInputItems(object[] items);
        void SetVerifyCodeInputItems(object[] items);
        void SetWorkTypeInputItems(object[] items);
    }

    public partial class AdvancedForm : Form, IAdvancedForm
    {
        private readonly MainForm _mainForm;

        public AdvancedForm(MainForm mainForm)
        {
            InitializeComponent();

            _mainForm = mainForm;

            SetAdvancedFormUI();
            SetTabControlUI();
            SetTabControlPage1UI();
            SetTabControlPage2UI();
        }

        private void SetAdvancedFormUI()
        {
            Text = Lang.Advanced.FormName;
        }

        private void AdvancedForm_Move(object sender, EventArgs e)
        {
            _mainForm.Left = Left - _mainForm.Width;
            _mainForm.Top = Top;
        }
    }
}
