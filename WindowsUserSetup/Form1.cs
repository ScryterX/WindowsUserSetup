using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsUserSetup
{
    public partial class Form1 : Form
    {
        private UnattendSettings _settings;
        private string optionsFileUrl = "https://raw.githubusercontent.com/ScryterX/WindowsUserSetup/master/WindowsUserSetup/Options.json";

        public Form1()
        {
            InitializeComponent();
            LoadSettings();
            PopulateOptions();
        }

        private void LoadSettings()
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string json = client.DownloadString(optionsFileUrl);
                    _settings = JsonConvert.DeserializeObject<UnattendSettings>(json);
                }

                if (_settings == null)
                {
                    MessageBox.Show("Erro ao carregar as configura��es do arquivo Options.json.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Options.json: {ex.Message}");
            }
        }

        private void PopulateOptions()
        {
            if (_settings != null)
            {
                comboBoxUILanguage.DataSource = _settings.UILanguages;
                comboBoxInputLocale.DataSource = _settings.InputLocales;
                comboBoxTimeZone.DataSource = _settings.TimeZones;

                // Selecionar itens previamente configurados, se houver
                if (!string.IsNullOrEmpty(_settings.SelectedUILanguage))
                    comboBoxUILanguage.SelectedItem = _settings.SelectedUILanguage;

                if (!string.IsNullOrEmpty(_settings.SelectedInputLocale))
                    comboBoxInputLocale.SelectedItem = _settings.SelectedInputLocale;

                if (!string.IsNullOrEmpty(_settings.SelectedTimeZone))
                    comboBoxTimeZone.SelectedItem = _settings.SelectedTimeZone;
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (_settings != null)
            {
                _settings.SelectedUILanguage = comboBoxUILanguage.SelectedItem?.ToString();
                _settings.SelectedInputLocale = comboBoxInputLocale.SelectedItem?.ToString();
                _settings.SelectedTimeZone = comboBoxTimeZone.SelectedItem?.ToString();

                SaveSettings();

                MessageBox.Show("Configura��es salvas com sucesso!");
            }
            else
            {
                MessageBox.Show("Nenhuma configura��o dispon�vel para salvar.");
            }
        }

        private void SaveSettings()
        {
            try
            {
                string json = JsonConvert.SerializeObject(_settings, Formatting.Indented);
                // Aqui voc� pode salvar o JSON em um arquivo local se necess�rio
                // Exemplo de salvamento em arquivo local:
                // File.WriteAllText("settings.json", json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar configura��es: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Nenhuma a��o espec�fica necess�ria no carregamento do formul�rio al�m do que j� est� implementado
        }
    }
}
