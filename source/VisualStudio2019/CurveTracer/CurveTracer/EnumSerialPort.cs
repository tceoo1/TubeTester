using System;
using System.Management;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;

namespace CurveTracer
{
    static class EnumSerialPort
    {
        public static Dictionary<string, string> DeviceNames
        {
            get
            {
                const string pattern = @"\(COM[1-9][0-9]?[0-9]?\)";
                const string pattern2 = @"COM[1-9][0-9]?[0-9]?";
                var mcPnPEntity = new ManagementClass("Win32_PnPEntity");
                var manageObjCol = mcPnPEntity.GetInstances();

                var deviceNames = new Dictionary<string, string>();
                foreach (var manageObj in manageObjCol)
                {
                    if (manageObj is null) continue;
                    var propName = manageObj.GetPropertyValue("Name");
                    if (propName is null) continue;
                    var name = propName.ToString();
                    if (string.IsNullOrWhiteSpace(name)) continue;

                    if (Regex.IsMatch(name, pattern))
                    {
                        var match = Regex.Match(name, pattern2).Value.Trim();
                        var devname = Regex.Replace(name, pattern, "").Trim();
                        deviceNames.Add(match, $"[{match}] {devname}");
                    }
                }

                return deviceNames;
            }
        }
    }

}
