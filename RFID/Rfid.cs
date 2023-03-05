namespace RFID
{
    #region structs
    internal readonly struct StructMinMax
    {
        private readonly int _min;
        private readonly int _max;

        internal StructMinMax(int min, int max)
        {
            _min = min;
            _max = max;
        }

        internal bool CheckKey(int key) => GetKeys().Length > key && key >= 0;

        internal bool CheckKey(int key, int[] except) => CheckKey(key) && !except.Contains(key);

        internal bool CheckValue(object value) => GetValues().Contains(value);

        internal bool CheckValue(object value, object[] except) => CheckValue(value) && !except.Contains(value);

        internal int GetMin() => _min;

        internal int GetMax() => _max;

        internal int GetKey(object value) => Array.IndexOf(GetValues(), value);

        internal int[] GetKeys() => Enumerable.Range(0, GetValues().Length).ToArray();

        internal object GetValue(int key) => GetValues().ElementAt(key);

        internal object[] GetValues() => Enumerable.Range(_min, _max - _min + 1).Cast<object>().ToArray();
    }

    internal readonly struct StructArray
    {
        private readonly object[] _array;

        internal StructArray(object[] array)
        {
            _array = array;
        }

        internal bool CheckKey(int key) => _array.Length > key && key >= 0;

        internal bool CheckKey(int key, int[] except) => CheckKey(key) && !except.Contains(key);

        internal bool CheckValue(object value) => _array.Contains(value);

        internal bool CheckValue(object value, object[] except) => CheckValue(value) && !except.Contains(value);

        internal int GetKey(object value) => Array.IndexOf(_array, value);

        internal int[] GetKeys() => Enumerable.Range(0, _array.Length).ToArray();

        internal object GetValue(int key) => _array.ElementAt(key);

        internal object[] GetValues() => _array;
    }
    #endregion

    internal class Rfid
    {
        // All methods here are cutted out due to the commercial usage.

        internal static StructMinMax ConnectComBusAddressArray() => new(0, 255);

        internal static StructArray ConnectComComNumberArray() => new(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
        });

        internal static StructArray ConnectComBaudRateArray() => new(new object[] {
            1200,
            2400,
            4800,
            9600,
            19200,
            115200,
        });

        internal static StructArray RebootArray() => new(new object[] {
            "Normal mode",
            "Boot mode",
        });
        
        internal static StructArray LangArray() => new(new object[] {
            "Simplified Chinese (ZH_CN)",
            "Chinese Traditional (ZH_TW)",
            "English (EN_US)",
        });

        internal static StructMinMax SysInfName() => new(1, 8);

        internal static StructMinMax SysInfSerialNumber() => new(1, 8);

        internal static StructMinMax SysInfBusAddress() => new(0, 255);

        internal static StructMinMax ParmOpVerifyCode() => new(0, 255);

        internal static StructMinMax ParmOpWorkType() => new(0, 7);

        internal static StructMinMax ParmOpBitRate() => new(0, 28);

        internal static StructMinMax ParmOpTriggerType() => new(0, 7);

        internal static StructMinMax ParmOpRssi() => new(0, 31);

        internal static StructArray ParmOpFrequency() => new(new object[] {
            "2405 MHz",
            "2410 MHz",
            "2415 MHz",
            "2420 MHz",
            "2425 MHz",
            "2430 MHz",
            "2435 MHz",
            "2440 MHz",
            "2445 MHz",
            "2450 MHz",
            "2455 MHz",
            "2460 MHz",
            "2465 MHz",
            "2470 MHz",
            "2475 MHz",
            "2480 MHz",
            "2485 MHz",
            "2490 MHz",
            "2495 MHz",
            "2500 MHz",
            "2505 MHz",
            "2510 MHz",
            "2515 MHz",
            "2520 MHz",
        });

        internal static StructArray ParmOpInterval() => new(new object[] {
            25,
            50,
            75,
            100,
            150,
            200,
            250,
            300,
            400,
            500,
            750,
            1000,
            1250,
            1500,
            2000,
            2500,
            3000,
            4000,
            5000,
        });

        internal static StructMinMax ParmOpPower() => new(0, 3);

        internal static StructArray ParmOpBaudRate() => new(new object[] {
            1200,
            2400,
            4800,
            9600,
            19200,
            115200,
        });
    }
}
