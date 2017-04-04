using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace LSLauncher
{
    public class Player : INotifyPropertyChanged
    {
        public static Collection<Map> Ribbons { get; set; } = new Collection<Map>(new Map[] {
            new Map() { Id = 0, Name = "None" },
            new Map() { Id = 1, Name = "Yellow" },
            new Map() { Id = 2, Name = "Blue" },
            new Map() { Id = 4, Name = "Green" },
            new Map() { Id = 8, Name = "Red" }
        });
        public static string[] Teams { get; set; } = new string[] { "BLUE", "PURPLE" };
        public static Collection<string> Ranks { get; private set; } = new Collection<string>(new string[] { "BRONZE", "SILVER", "GOLD", "PLATINUM", "DIAMOND", "MASTER", "CHALLENGER" });

        public static Collection<string> Champions { get; private set; } = new Collection<string>();
        public static Collection<string> SummonerSpells { get; private set; } = new Collection<string>();

        public event PropertyChangedEventHandler PropertyChanged;
        public void Changed(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }

        public string team { get; set; }
        public string rank { get; set; }
        public string name { get; set; }
        public string summoner1 { get; set; }
        public string summoner2 { get; set; }
        public string champion { get; set; }
        public int skin { get; set; }

        public int ribbon { get; set; }
        public int icon { get; set; }

        public Dictionary<int, int> runes { get; private set; }

        public string oppositeTeam => (team.Equals(Teams[0])) ? Teams[1] : Teams[0];
        public int teamIndex => (team.Equals(Teams[0])) ? 0 : 1;
        public int ribbonIndex => Ribbons.IndexOf(Ribbons.FirstOrDefault(s => s.Id == ribbon));
        public int rankIndex => Ranks.IndexOf(rank);
        public int summoner1Index => SummonerSpells.IndexOf(summoner1);
        public int summoner2Index => SummonerSpells.IndexOf(summoner2);
        public int champIndex { get; set; }

        public Player()
        {
            team = Teams[0];
            rank = Ranks[0];
            name = "";
            champion = "Aatrox";
            skin = 0;

            summoner1 = "SummonerHeal";
            summoner2 = "SummonerFlash";
            ribbon = 0;
            icon = 0;

            runes = new Dictionary<int, int>();
            for(int i = 1; i <= 9; i++)
                runes.Add(i, 5245);

            for (int i = 10; i <= 18; i++)
                runes.Add(i, 5317);

            for (int i = 19; i <= 27; i++)
                runes.Add(i, 5289);

            for (int i = 28; i <= 30; i++)
                runes.Add(i, 5335);
        }
    }
}
