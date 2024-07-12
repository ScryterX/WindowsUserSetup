using System.Collections.Generic;

namespace WindowsUserSetup
{
    public class UnattendSettings
    {
        public List<string> UILanguages { get; set; }
        public List<string> InputLocales { get; set; }
        public List<string> TimeZones { get; set; }
    }
}
