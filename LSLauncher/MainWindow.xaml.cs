using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Linq;
using System.Windows.Controls;
using System.ComponentModel;

namespace LSLauncher
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public Config Config { get; set; }
        public GameData GameData { get; set; }

        public Visibility SelectServerPath => Config.IsValidServerPath ? Visibility.Collapsed : Visibility.Visible;
        public Visibility SelectClientPath => (!Config.IsValidClientPath && Config.IsValidServerPath) ? Visibility.Visible : Visibility.Collapsed;
        public Visibility Launcher => Config.IsValidClientPath ? Visibility.Visible : Visibility.Collapsed;

        private string workingDir;
        private string configPath;
        private string startBatPath;
        private string championsPath;
        private string lastPath;

        public void Changed()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectServerPath"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SelectClientPath"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Launcher"));

            if (Config.IsValidServerPath)
                LoadGameData();
        }

        public MainWindow()
        {
            InitializeComponent();
            workingDir = "data";
            configPath = workingDir + "\\config.json";
            startBatPath = workingDir + "\\start.bat";
            championsPath = workingDir + "\\champions.json";
        }

        private void LoadGameData()
        {
            GameData = GameData.Load(Config.GameInfoPath);
            if (GameData == null)
            {
                GameData = new GameData();
                GameData.Save(Config.GameInfoPath);
            }
            var champs = Directory.GetDirectories(Config.ChampionsPath);
            Player.Champions.Clear();
            foreach (var v in champs)
                Player.Champions.Add(v.Substring(v.LastIndexOf("\\") + 1));

            GameData.game.MapIndex = Game.Maps.IndexOf(Game.Maps.FirstOrDefault(s => s.Id == GameData.game.map));
            foreach (var v in GameData.players)
            {
                v.champIndex = Player.Champions.IndexOf(v.champion);
            }
            DataContext = this;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            GameData.Save(Config.GameInfoPath);
            Config.CreateStartBatFile(startBatPath, true);
            Process.Start(startBatPath);
        }
        private void StartOnlyClient_Click(object sender, RoutedEventArgs e)
        {
            GameData.Save(Config.GameInfoPath);
            Config.CreateStartBatFile(startBatPath, false);
            Process.Start(startBatPath);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(!Directory.Exists(workingDir))
                Directory.CreateDirectory(workingDir);

            Config = Config.Load(configPath);
            if(Config == null)
                Config = new Config();
            else if (Config.IsValidServerPath)
                LoadGameData();

            DataContext = this;
        }

        private void Map_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GameData.game.map = Game.Maps.ElementAt(GameData.game.MapIndex).Id;
        }

        private void AddPlayer_Click(object sender, RoutedEventArgs e)
        {
            if (GameData.players.Count >= 10)
                return;

            var team = Player.Teams[0];
            if (GameData.players.Count(s => s.team == team) == 5)
                team = Player.Teams[1];

            GameData.players.Add(new Player() { name = "Player " + (GameData.players.Count + 1), team = team });
        }
        private void RemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            GameData.players.Remove((sender as Button).Tag as Player);
        }

        private void Team_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = (sender as ComboBox);
            var player = box.Tag as Player;
            player.team = Player.Teams[box.SelectedIndex];
            if (GameData.players.Count(s => s.team == player.team) > 5)
            {
                var p = GameData.players.FirstOrDefault(s => s.team.Equals(player.team) && !s.Equals(player));
                if (p != null)
                {
                    p.team = p.oppositeTeam;
                    p.Changed("teamIndex");
                }
            }

            GameData.Save(Config.GameInfoPath);
        }
        private void Ribbon_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = (sender as ComboBox);
            var player = box.Tag as Player;
            player.ribbon = Player.Ribbons[box.SelectedIndex].Id;
            GameData.Save(Config.GameInfoPath);
        }
        private void Champion_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var box = (sender as ComboBox);
            var player = box.Tag as Player;
            player.champion = Player.Champions[box.SelectedIndex];
        }

        private void SelectServerPath_Click(object sender, RoutedEventArgs e)
        {
            using (var fbd = new System.Windows.Forms.FolderBrowserDialog())
            {
                fbd.SelectedPath = lastPath;
                System.Windows.Forms.DialogResult result = fbd.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lastPath = fbd.SelectedPath;
                    Config.ServerPath = fbd.SelectedPath;
                    if (Config.IsValidServerPath)
                    {
                        Config.CreateStartBatFile(startBatPath);
                        Config.Changed("ServerPath");
                        Config.Save(configPath);
                        Changed();
                    }
                }
            }
        }
        private void SelectClientPath_Click(object sender, RoutedEventArgs e)
        {
            using (var fbd = new System.Windows.Forms.FolderBrowserDialog())
            {
                fbd.SelectedPath = lastPath;
                System.Windows.Forms.DialogResult result = fbd.ShowDialog();

                if (result == System.Windows.Forms.DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    lastPath = fbd.SelectedPath;
                    Config.ClientPath = fbd.SelectedPath;
                    if (Config.IsValidClientPath)
                    {
                        Config.CreateStartBatFile(startBatPath);
                        Config.Changed("ClientPath");
                        Config.Save(configPath);
                        Changed();
                    }
                }
            }
        }
    }
}
