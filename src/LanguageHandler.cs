using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenta {
    internal class LanguageHandler {
        private static LanguageHandler? _instance;
        public static LanguageHandler Instance {
            get {
                _instance ??= new LanguageHandler();
                return _instance;
            }
        }

        private bool loaded = false;
        public string? currentLanguage = null;
        private Dictionary<string, string> languageList = new Dictionary<string, string>();
        private Dictionary<string, string> languageData = new Dictionary<string, string>();

        public Dictionary<string, string> LanguageList => languageList;

        private LanguageHandler() {
            LoadLanguageList();
            LoadLanguageFromConfig();
        }

        private void LoadLanguageList() {
            var langDir = Path.Combine("lang");
            if (!Directory.Exists(langDir)) {
                Directory.CreateDirectory(langDir);
                return;
            }
            var langFiles = Directory.GetFiles(langDir, "*.ini");
            foreach (var langFile in langFiles) {
                var langName = Path.GetFileNameWithoutExtension(langFile);
                foreach (var line in File.ReadAllLines(langFile)) {
                    if (line.StartsWith("LanguageName=")) {
                        languageList[line.Substring(13)] = langName;
                        break;
                    }
                }
            }
        }

        public void LoadLanguageFromConfig() {
            var configLanguage = ConfigHandler.Instance.GetString("Language", null);
            LoadLanguage(configLanguage ??= CultureInfo.CurrentUICulture.Name);
        }

        public void LoadLanguage(string? locale) {
            if (currentLanguage == locale) return;
            var langFile = Path.Combine("lang", $"{locale}.ini");
            if (!File.Exists(langFile)) {
                langFile = Path.Combine("lang", "en-US.ini");
                if (!File.Exists(langFile)) {
                    // default language file is missing, switch to failsafe mode
                    loaded = false;
                    currentLanguage = null;
                    return;
                }
            }
            languageData.Clear();
            bool isOnLanguageSection = false;
            foreach (var line in File.ReadAllLines(langFile)) {
                if (line == "[Language]") {
                    isOnLanguageSection = true;
                    continue;
                }
                if (!isOnLanguageSection) continue;

                if (!line.Contains('=') || line.StartsWith(';')) continue;
                var split = line.Split('=', 2, StringSplitOptions.None);
                languageData.Add(split[0], split[1]);
            }
            loaded = true;
            currentLanguage = locale;
        }

        public bool GetTranslatedString(string key, ref string? target) {
            if (!loaded) return false;
            if (languageData.TryGetValue(key, out var value)) {
                target = value;
                return true;
            }
            return false;
        }

        // for normal controls
        public void TranslateControls(Control[] controls) {
            foreach (var control in controls) {
                if (control.Tag is null || control.Tag is not string) continue;
                if (languageData.ContainsKey(control.Tag.ToString()!)) {
                    string? translatedText = null; 
                    if (GetTranslatedString(control.Tag.ToString()!, ref translatedText)) control.Text = translatedText;
                }
            }
        }

        // for ToolStripItems
        public void TranslateControls(ToolStripItem[] controls) {
            foreach (var control in controls) {
                if (control.Tag is null || control.Tag is not string) continue;
                if (languageData.ContainsKey(control.Tag.ToString()!)) {
                    string? translatedText = null;
                    if (GetTranslatedString(control.Tag.ToString()!, ref translatedText)) control.Text = translatedText;
                }
            }
        }
    }
}
