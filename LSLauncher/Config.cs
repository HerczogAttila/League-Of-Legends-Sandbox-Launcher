using System.IO;
using Newtonsoft.Json;
using System.ComponentModel;

namespace LSLauncher
{
    public class Config : INotifyPropertyChanged
    {
        public static string ServerExe { get; private set; } = "GameServerApp.exe";
        public static string ClientExtern { get; private set; } = @"\RADS\solutions\lol_game_client_sln\releases\0.0.1.68\deploy\";
        public static string ClientExe { get; private set; } = "League of Legends.exe";

        public event PropertyChangedEventHandler PropertyChanged;

        public string ServerPath { get; set; }
        public string ClientPath { get; set; }
        public string Server { get; set; }
        public string Port { get; set; }
        public string Key { get; set; }
        public int Index { get; set; }

        [JsonIgnore]
        public string GameInfoPath => ServerPath + @"\settings\GameInfo.json";
        [JsonIgnore]
        public string ChampionsPath => ServerPath + @"\Content\Data\LeagueSandbox-Default\Champions";
        [JsonIgnore]
        public string SummonerSpellsPath => ServerPath + @"\Content\Data\LeagueSandbox-Default\Champions\Global\";

        [JsonIgnore]
        public bool IsValidServerPath => File.Exists(ServerPath + "\\" + ServerExe) && File.Exists(GameInfoPath) && Directory.Exists(ChampionsPath) &&
            Directory.Exists(SummonerSpellsPath);
        [JsonIgnore]
        public bool IsValidClientPath => File.Exists(ClientPath + ClientExtern + ClientExe);

        public Config()
        {
            ServerPath = "";
            ClientPath = "";
            Server = "127.0.0.1";
            Port = "5119";
            Key = "17BLOhi6KZsTtldTsizvHg==";
            Index = 1;
        }

        public void Changed(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public static Config Load(string path)
        {
            if (File.Exists(path))
                return JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));

            return null;
        }

        public void Save(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this));
        }
    }
}
