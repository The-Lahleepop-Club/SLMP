using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLMPHealthCheck {
    public class TestRunner {
        private readonly Dictionary<string, Action[]> _testGroups;

        public TestRunner() {
            _testGroups = new();
        }

        public void AddTestGroup(string groupName, Action[] actions) {
            _testGroups.Add(groupName, actions);
        }

        public void RunTests() {
            foreach (KeyValuePair<string, Action[]> entry in _testGroups) {
                string groupName = entry.Key;
                Action[] tests = entry.Value;
                Console.WriteLine($"Test Group: {groupName}\n");

                foreach (Action test in tests) {
                    Console.WriteLine($"Running Test `{test.Method.Name}`...");

                    try {
                        test();
                        Console.WriteLine("Passed");
                    } catch (Exception ex) {
                        Console.WriteLine(ex.ToString());
                        Console.WriteLine("Failed");
                    }
                }

                Console.WriteLine(new string('-', 30));
            }
        }
    }
}
