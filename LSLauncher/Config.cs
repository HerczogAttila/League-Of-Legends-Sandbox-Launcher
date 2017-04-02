using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.ComponentModel;

namespace LSLauncher
{
    public class Config : INotifyPropertyChanged
    {
        private static string ServerExe = "GameServerApp.exe";
        private static string ClientExtern = @"\RADS\solutions\lol_game_client_sln\releases\0.0.1.68\deploy\";
        private static string ClientExe = "League of Legends.exe";

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
            if(File.Exists(path))
                return JsonConvert.DeserializeObject<Config>(File.ReadAllText(path));

            return null;
        }

        public void Save(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this));
        }

        public void CreateStartBatFile(string path, bool server = true)
        {
            File.WriteAllText(path, CreateStartCommand(server));
        }

        private string CreateStartCommand(bool server)
        {
            var sb = new StringBuilder();
            //start server
            if(server)
            {
                sb.Append("cd ");
                sb.AppendLine(ServerPath);
                sb.Append("start ");
                sb.AppendLine(ServerExe);
            }

            //start client
            sb.Append("cd ");
            sb.Append(ClientPath);
            sb.AppendLine(ClientExtern);
            sb.Append("start \"\" \"");
            sb.Append(ClientExe);
            sb.Append("\" \"8394\" \"LoLLauncher.exe\" \"\" \"");
            sb.Append(Server);
            sb.Append(" ");
            sb.Append(Port);
            sb.Append(" ");
            sb.Append(Key);
            sb.Append(" ");
            sb.Append(Index);
            sb.Append(" \"");

            return sb.ToString();
        }
    }
}
