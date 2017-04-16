using Newtonsoft.Json;

namespace LSLauncher
{
    public class GameInfo
    {
        [JsonProperty("MANACOSTS_ENABLED")]
        public bool? IsManacosts { get; set; }
        [JsonProperty("COOLDOWNS_ENABLED")]
        public bool? IsCooldowns { get; set; }
        [JsonProperty("CHEATS_ENABLED")]
        public bool? IsCheats { get; set; }
        [JsonProperty("MINION_SPAWNS_ENABLED")]
        public bool? IsMinionSpawns { get; set; }
        [JsonProperty("IS_WAIT_PLAYERS")]
        public bool? IsWaitPlayers { get; set; }

        public GameInfo()
        {
            IsManacosts = true;
            IsCooldowns = true;
            IsCheats = false;
            IsMinionSpawns = true;
            IsWaitPlayers = false;
        }
    }
}
