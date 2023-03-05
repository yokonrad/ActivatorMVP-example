namespace RFID
{
    public class Api
    {
        // All methods here are async Tasks (wrapped in the Proxy.cs). They are cutted out due to the commercial usage.

        #region CheckHwConnection
        public static async Task<bool> CheckHwConnection()
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region CheckSwConnection
        public static async Task<bool> CheckSwConnection()
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region ClearConnection
        public static async Task<bool> ClearConnection()
        {
            return await Task.FromResult(true);
        }
        #endregion



        #region ConnectCom
        public static object[] ConnectComBusAddressItems() => Rfid.ConnectComBusAddressArray().GetValues();

        public static object[] ConnectComComNumberItems() => Rfid.ConnectComComNumberArray().GetValues();

        public static object[] ConnectComBaudRateItems() => Rfid.ConnectComBaudRateArray().GetValues();

        public static async Task<bool> ConnectCom(int busAddress, string comNumber, int baudRate)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region Disconnect
        public static async Task<bool> Disconnect()
        {
            return await Task.FromResult(true);
        }
        #endregion



        #region Reboot
        public static object[] RebootItems() => Rfid.RebootArray().GetValues();

        public static async Task<bool> Reboot()
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region Lang
        public static object[] LangItems() => Rfid.LangArray().GetValues();

        public static async Task<bool> Lang()
        {
            return await Task.FromResult(true);
        }
        #endregion



        #region Copyright
        public static async Task<string?> Copyright()
        {
            return await Task.FromResult<string?>(string.Empty);
        }
        #endregion

        #region ErrorMessage
        public static async Task<string?> ErrorMessage()
        {
            return await Task.FromResult<string?>(string.Empty);
        }
        #endregion

        #region ErrorCode
        public static async Task<int?> ErrorCode()
        {
            return await Task.FromResult<int?>(0);
        }
        #endregion



        #region Name
        public static int GetNameMinLength() => Rfid.SysInfName().GetMin();

        public static int GetNameMaxLength() => Rfid.SysInfName().GetMax();

        public static async Task<string?> GetName()
        {
            return await Task.FromResult<string?>(string.Empty);
        }

        public static async Task<bool> SetName(string value)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region SerialNumber
        public static int GetSerialNumberMinLength() => Rfid.SysInfSerialNumber().GetMin();

        public static int GetSerialNumberMaxLength() => Rfid.SysInfSerialNumber().GetMax();

        public static async Task<string?> GetSerialNumber()
        {
            return await Task.FromResult<string?>(string.Empty);
        }

        public static async Task<bool> SetSerialNumber(string value)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region BusAddress
        public static object[] GetBusAddressItems() => Rfid.SysInfBusAddress().GetValues();

        public static async Task<int?> GetBusAddressKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<bool> SetBusAddressKey(int key)
        {
            return await Task.FromResult(true);
        }
        #endregion



        #region VerifyCode
        public static object[] GetVerifyCodeItems() => Rfid.ParmOpVerifyCode().GetValues();

        public static async Task<int?> GetVerifyCodeKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<bool> SetVerifyCodeKey(int key)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region WorkType
        public static object[] GetWorkTypeItems() => Rfid.ParmOpWorkType().GetValues();

        public static async Task<int?> GetWorkTypeKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<bool> SetWorkTypeKey(int key)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region BitRate
        public static object[] GetBitRateItems() => Rfid.ParmOpBitRate().GetValues();

        public static async Task<int?> GetBitRateKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<bool> SetBitRateKey(int key)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region TriggerType
        public static object[] GetTriggerTypeItems() => Rfid.ParmOpTriggerType().GetValues();

        public static async Task<int?> GetTriggerTypeKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<bool> SetTriggerTypeKey(int key)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region Rssi
        public static object[] GetRssiItems() => Rfid.ParmOpRssi().GetValues();

        public static async Task<int?> GetRssiKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<bool> SetRssiKey(int key)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region Frequency
        public static object[] GetFrequencyItems() => Rfid.ParmOpFrequency().GetValues();

        public static async Task<int?> GetFrequencyKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<string?> GetFrequencyValue()
        {
            return await Task.FromResult<string?>(string.Empty);
        }

        public static async Task<bool> SetFrequencyKey(int key)
        {
            return await Task.FromResult(true);
        }

        public static async Task<bool> SetFrequencyValue(string value)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region Interval
        public static object[] GetIntervalItems() => Rfid.ParmOpInterval().GetValues();

        public static async Task<int?> GetIntervalKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<string?> GetIntervalValue()
        {
            return await Task.FromResult<string?>(string.Empty);
        }

        public static async Task<bool> SetIntervalKey(int key)
        {
            return await Task.FromResult(true);
        }

        public static async Task<bool> SetIntervalValue(string value)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region Power
        public static object[] GetPowerItems() => Rfid.ParmOpPower().GetValues();

        public static async Task<int?> GetPowerKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<bool> SetPowerKey(int key)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region BaudRate
        public static object[] GetBaudRateItems() => Rfid.ParmOpBaudRate().GetValues();

        public static async Task<int?> GetBaudRateKey()
        {
            return await Task.FromResult<int?>(0);
        }

        public static async Task<string?> GetBaudRateValue()
        {
            return await Task.FromResult<string?>(string.Empty);
        }

        public static async Task<bool> SetBaudRateKey(int key)
        {
            return await Task.FromResult(true);
        }

        public static async Task<bool> SetBaudRateValue(string value)
        {
            return await Task.FromResult(true);
        }
        #endregion

        #region RestoreDefaults
        public static async Task<bool> RestoreDefaults()
        {
            return await Task.FromResult(true);
        }
        #endregion
    }
}
