namespace Activator.Model.Advanced
{
    public interface IValidateModel
    {
        bool BaudRateInput(int index);
        bool BitRateInput(int index);
        bool BusAddressInput(int index);
        bool FrequencyInput(int index);
        bool IntervalInput(int index);
        bool NameInput(string value);
        bool PowerInput(int index);
        bool RssiInput(int index);
        bool SerialNumberInput(string value);
        bool TriggerTypeInput(int index);
        bool VerifyCodeInput(int index);
        bool WorkTypeInput(int index);
    }

    public class ValidateModel : IValidateModel
    {
        public bool NameInput(string value) => !Helper.IsStringEmpty(value) && Helper.IsStringLengthBetween(value, RFID.Api.GetNameMinLength(), RFID.Api.GetNameMaxLength());

        public bool SerialNumberInput(string value) => !Helper.IsStringEmpty(value) && Helper.IsStringLengthBetween(value, RFID.Api.GetSerialNumberMinLength(), RFID.Api.GetSerialNumberMaxLength());

        public bool BusAddressInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetBusAddressItems());

        public bool VerifyCodeInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetVerifyCodeItems());

        public bool WorkTypeInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetWorkTypeItems());

        public bool BitRateInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetBitRateItems());

        public bool TriggerTypeInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetTriggerTypeItems());

        public bool RssiInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetRssiItems());

        public bool FrequencyInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetFrequencyItems());

        public bool IntervalInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetIntervalItems());

        public bool PowerInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetPowerItems());

        public bool BaudRateInput(int index) => Helper.IsIndexInArray(index, RFID.Api.GetBaudRateItems());
    }
}
