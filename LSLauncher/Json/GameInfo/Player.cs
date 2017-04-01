using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace LSLauncher
{
    public enum Team { BLUE, PURPLE }
    public enum Rank { BRONZE, SILVER, GOLD, PLATINA, DIAMOND, CHALLENGER }

    public class Player
    {
        public static string[] Teams = new string[] { "BLUE", "PURPLE" };
        public static string[] Ranks = new string[] { "BRONZE", "SILVER", "GOLD", "PLATINA", "DIAMOND", "CHALLENGER" };
        public static Collection<string> Champions { get; private set; } = new Collection<string>();

        public string team { get; set; }
        public string rank { get; set; }
        public string name { get; set; }
        public string champion { get; set; }
        public int skin { get; set; }
        
        public string summoner1 { get; set; }
        public string summoner2 { get; set; }

        public int ribbon { get; set; }
        public int icon { get; set; }

        public Dictionary<int, int> runes { get; private set; }

        public int teamIndex => (team.Equals("BLUE")) ? 0 : 1;
        public int champIndex { get; set; }

        public Player()
        {
            team = Teams[0];
            rank = Ranks[0];
            name = "test";
            champion = "Ezreal";
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
