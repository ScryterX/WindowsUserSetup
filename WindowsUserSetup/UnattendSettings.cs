using System.Collections.Generic;

namespace WindowsUserSetup
{
    public class UnattendSettings
    {
        public List<string> UILanguages { get; set; }
        public List<string> InputLocales { get; set; }
        public List<string> TimeZones { get; set; }

        // Propriedades adicionadas
        public string SelectedUILanguage { get; set; }
        public string SelectedInputLocale { get; set; }
        public string SelectedTimeZone { get; set; }

        public UnattendSettings()
        {
            UILanguages = new List<string>();
            InputLocales = new List<string>();
            TimeZones = new List<string>();
        }
    }
}
