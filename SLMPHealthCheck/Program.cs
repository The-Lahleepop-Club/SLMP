using SLMPUnitTests;

namespace SLMPHealthCheck {
    internal static class Program {
        static readonly ReadWordDeviceUnitTests _readWordDeviceTests = new();
        static readonly ReadBitDeviceUnitTests _readBitDeviceUnitTests = new();

        static readonly Action[] _readWordDeviceActions = new Action[] {
            _readWordDeviceTests.DDevice, _readWordDeviceTests.WDevice,
            _readWordDeviceTests.ZDevice, _readWordDeviceTests.RDevice,
            _readWordDeviceTests.ZRDevice, _readWordDeviceTests.SDDevice
        };
        static readonly Action[] _readBitDeviceActions = new Action[] {
            _readBitDeviceUnitTests.XDevice, _readBitDeviceUnitTests.YDevice,
            _readBitDeviceUnitTests.MDevice, _readBitDeviceUnitTests.LDevice,
            _readBitDeviceUnitTests.FDevice, _readBitDeviceUnitTests.VDevice,
            _readBitDeviceUnitTests.BDevice, _readBitDeviceUnitTests.SMDevice
        };

        static void Main(string[] args) {
            if (args.Length < 2) {
                Console.WriteLine("Usage: program <slmp_ip:string> <slmp_port:int>");
                return;
            }
            Utils.SlmpAddress = args[0];
            Utils.SlmpPort = int.Parse(args[1]);

            TestRunner testRunner = new();
            testRunner.AddTestGroup("Read Word Device Tests", _readWordDeviceActions);
            testRunner.AddTestGroup("Read Bit Device Tests", _readBitDeviceActions);

            Console.WriteLine($"SLMP ADDR: {Utils.SlmpAddress}");
            Console.WriteLine($"SLMP PORT: {Utils.SlmpPort}");
            testRunner.RunTests();
        }
    }
}