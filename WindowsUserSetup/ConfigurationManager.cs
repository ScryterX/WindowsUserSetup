using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WindowsUserSetup
{
    public class ConfigurationManager
    {
        private static readonly HttpClient _client = new HttpClient();

        public string UILanguage { get; set; }
        public string InputLocale { get; set; }
        public string TimeZone { get; set; }
        public bool AutoLogon { get; set; }

        public void SaveConfiguration()
        {
            var config = new
            {
                UILanguage = this.UILanguage,
                InputLocale = this.InputLocale,
                TimeZone = this.TimeZone,
                AutoLogon = this.AutoLogon
            };

            string json = JsonConvert.SerializeObject(config, Formatting.Indented);
            File.WriteAllText("user_config.json", json);
        }

        public static async Task UpdateOptionsJson(string url, string localPath)
        {
            var response = await _client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                File.WriteAllText(localPath, content);
            }
        }
    }
}
