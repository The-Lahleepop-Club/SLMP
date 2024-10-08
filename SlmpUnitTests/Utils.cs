using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMPUnitTests {
    public static class Utils {

        public static string SlmpAddress { get; set; } = "192.168.3.39";
        public static int SlmpPort { get; set; } = 1200;

        public static SlmpClient CreateSlmpConnection() {
            SlmpConfig cfg = new(SlmpAddress, SlmpPort);
            SlmpClient plc = new(cfg);
            plc.Connect();

            return plc;
        }

        public static void ReadBitDeviceFromAddr(string addr, ushort count) {
            SlmpClient plc = CreateSlmpConnection();

            try {
                if (count > 0) {
                    Assert.AreEqual(count, plc.ReadBitDevice(addr, count).Length);
                } else {
                    plc.ReadBitDevice(addr);
                }
            } finally {
                plc.Disconnect();
            }
        }

        public static void ReadWordDeviceFromAddr(string addr, ushort count) {
            SlmpClient plc = CreateSlmpConnection();

            try {
                if (count > 0) {
                    Assert.AreEqual(count, plc.ReadWordDevice(addr, count).Length);
                } else {
                    plc.ReadWordDevice(addr);
                }
            } finally {
                plc.Disconnect();
            }
        }
    }
}
