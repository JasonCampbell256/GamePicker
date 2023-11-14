using System.Collections.Generic;

namespace GamePicker
{
    /// <summary>
    /// Represents a game from the GAMES.csv file
    /// </summary>
    public class CsvGame
    {
        public string Game { get; set; }
        public string Console { get; set; }
        public string Region { get; set; }
        public List<string> Playlists { get; set; }
    }
}
