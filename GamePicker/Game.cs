using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePicker
{
    public class Game
    {
        public string Title { get; set; }
        public string Id { get; set; }
        public int Year { get; set; }
        public string Region { get; set; }
        public string Console { get; set; }
        public string Description { get; set; }

        public static Game FromJToken(JToken token)
        {
            var result = new Game();
            result.Title = token.First()["release_name"].ToString();
            result.Id = token.First()["uuid"].ToString();
            if (int.TryParse(token.First()["date"].ToString(), out int year))
            {
                result.Year = year;
            } else
            {
                result.Year = 0;
            }

            var region = token.First()["region"].ToString();

            if (String.Equals("US", region, StringComparison.OrdinalIgnoreCase)
                || String.Equals("USA, Brazil", region, StringComparison.OrdinalIgnoreCase))
            {
                region = "USA";
            }

            result.Region = region;
            result.Console = token.First()["system"].ToString();
            result.Description = token.First()["description"].ToString();
            return result;
        }
    }
}
