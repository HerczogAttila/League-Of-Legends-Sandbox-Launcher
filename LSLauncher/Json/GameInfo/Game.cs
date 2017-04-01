using System.Collections.ObjectModel;
using Newtonsoft.Json;

namespace LSLauncher
{
    public class Game
    {
        public static Collection<Map> Maps { get; private set; } = new Collection<Map>(new Map[] {
            new Map() {Id = 1, Name = "Summoner's Rift original" },
            //new Map() {Id = 4, Name = "Twisted Treeline original" },  //bugsplat
            //new Map() {Id = 8, Name = "The Crystal Scar" },           //nincs scriptelve
            new Map() {Id = 10, Name = "Twisted Treeline" },
            new Map() {Id = 11, Name = "Summoner's Rift" },
            new Map() {Id = 12, Name = "Howling Abyss" }
        });

        public string gameMode { get; set; }
        public int map { get; set; }

        [JsonIgnore]
        public int MapIndex { get; set; }

        public Game()
        {
            map = 1;
            gameMode = "LeagueSandbox-Default";
        }
    }
}
