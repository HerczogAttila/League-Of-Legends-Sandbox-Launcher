using System.IO;

namespace LSLauncher
{
    public class ProfileIcon
    {
        public static int Size { get; set; } = 48;
        public static string Path { get; private set; } = Directory.GetCurrentDirectory() + @"data\profileicon0.png";
        public string Rect { get; set; }

        public ProfileIcon(int index)
        {
            Rect = index % 10 * Size + " " + index / 10 * Size + " " + Size + " " + Size;
        }
    }
}
