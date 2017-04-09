using System.Collections.ObjectModel;

namespace LSLauncher
{
    public class Skins
    {
        public Collection<Skin> Get { get; private set; }

        public Skins(Skin[] skins)
        {
            Get = new Collection<Skin>(skins);
        }
    }
}
