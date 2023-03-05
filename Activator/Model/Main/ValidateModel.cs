namespace Activator.Model.Main
{
    public interface IValidateModel
    {
        bool ConnectCom(string busAddress, string comNumber, string baudRate);
        bool SettingHwInterval(int index);
        bool SettingHwPower(int index);
        bool SettingHwRssi(int index);
    }

    public class ValidateModel : IValidateModel
    {
        public bool ConnectCom(string busAddress, string comNumber, string baudRate)
        {
            if (Helper.IsStringEmpty(busAddress) || !Helper.IsObjectInArray(busAddress, RFID.Api.ConnectComBusAddressItems(), typeof(int))) return false;
            if (Helper.IsStringEmpty(comNumber) || !Helper.IsObjectInArray(comNumber, RFID.Api.ConnectComComNumberItems(), typeof(string))) return false;
            if (Helper.IsStringEmpty(baudRate) || !Helper.IsObjectInArray(baudRate, RFID.Api.ConnectComBaudRateItems(), typeof(int))) return false;

            return true;
        }

        public bool SettingHwRssi(int index) => Helper.IsIndexInArray(index, RFID.Api.GetRssiItems());

        public bool SettingHwInterval(int index) => Helper.IsIndexInArray(index, RFID.Api.GetIntervalItems());

        public bool SettingHwPower(int index) => Helper.IsIndexInArray(index, RFID.Api.GetPowerItems());
    }
}
