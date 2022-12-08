using System.Collections.Generic;

namespace GamePicker
{
    public enum Region
    {
        USA,
        JAPAN,
        EUROPE
    }

    public class Game
    {
        public string Title { get; set; }
        public string Console { get; set; }
        public Region Region { get; set; }
        public string ConsoleRegionIdentifier { get; set; }
        public List<string> Playlists { get; set; }
    }
}
