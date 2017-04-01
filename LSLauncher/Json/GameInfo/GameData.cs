using Newtonsoft.Json;
using System.Collections.ObjectModel;
using System.IO;

namespace LSLauncher
{
    public class GameData
    {
        public ObservableCollection<Player> players { get; private set; }
        public Game game { get; set; }
        public GameInfo gameInfo { get; set; }

        public GameData()
        {
            players = new ObservableCollection<Player>();
            game = new Game();
            gameInfo = new GameInfo();
        }

        public static GameData Load(string path)
        {
            if (File.Exists(path))
                return JsonConvert.DeserializeObject<GameData>(File.ReadAllText(path));

            return null;
        }

        public void Save(string path)
        {
            File.WriteAllText(path, JsonConvert.SerializeObject(this, Formatting.Indented));
        }
    }
}
