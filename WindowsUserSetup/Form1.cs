using System;
using System.Configuration;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsUserSetup
{
    public partial class Form1 : Form
    {
        private UnattendSettings _settings;

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            PopulateOptions();
        }

        private void LoadSettings()
        {
            string json = File.ReadAllText("Options.json");
            _settings = JsonConvert.DeserializeObject<UnattendSettings>(json);
        }

        private void PopulateOptions()
        {
            comboBoxUILanguage.DataSource = _settings.UILanguages;
            comboBoxInputLocale.DataSource = _settings.InputLocales;
            comboBoxTimeZone.DataSource = _settings.TimeZones;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var config = new ConfigurationManager
            {
                UILanguage = comboBoxUILanguage.SelectedItem.ToString(),
                InputLocale = comboBoxInputLocale.SelectedItem.ToString(),
                TimeZone = comboBoxTimeZone.SelectedItem.ToString(),
                AutoLogon = checkBoxAutoLogon.Checked
            };

            config.SaveConfiguration();
            MessageBox.Show("Configuração salva com sucesso!");
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            string jsonUrl = "https://github.com/ScryterX/WindowsUserSetup.git"; // Atualize esta URL para o local onde você hospedou o JSON
            await ConfigurationManager.UpdateOptionsJson(jsonUrl, "Options.json");
            LoadSettings();
            PopulateOptions();
        }
    }
}
