using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenta {
    internal class ConfigHandler {
        private static ConfigHandler? _instance;
        public static ConfigHandler Instance {
            get {
                _instance ??= new ConfigHandler();
                return _instance;
            }
        }

        Dictionary<string, string> config = new Dictionary<string, string>();

        private ConfigHandler() {
            if (!File.Exists("config.ini")) using (var _ = File.Create("config.ini")) { }
            foreach (var line in File.ReadAllLines("config.ini")) {
                if (!line.Contains('=') || line.StartsWith(';') || line.StartsWith('[')) continue;
                var split = line.Split('=', 2, StringSplitOptions.None);
                config.Add(split[0], split[1]);
            }
        }

        public string? GetString(string key, string? defaultValue) {
            return config.TryGetValue(key, out var value) ? value : defaultValue;
        }

        public void SetString(string key, string value) {
            config[key] = value;
            Save();
        }

        public bool GetBool(string key, bool defaultValue) {
            return config.TryGetValue(key, out var value) ? value == "true" : defaultValue;
        }

        public void SetBool(string key, bool value) {
            config[key] = value ? "true" : "false";
            Save();
        }

        public void ClearValue(string key) {
            config.Remove(key);
            Save();
        }

        private void Save() {
            var sb = new StringBuilder();
            sb.AppendLine($"[Config]");
            foreach (var (key, value) in config) {
                sb.AppendLine($"{key}={value}");
            }
            File.WriteAllText("config.ini", sb.ToString());
        }
    }
}
