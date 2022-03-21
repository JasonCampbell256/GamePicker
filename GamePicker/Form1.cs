using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GamePicker
{
    public partial class Form1 : Form
    {
        private List<Game> games;
        private List<string> systems;
        private List<int> years;
        private List<string> regions;

        public Form1()
        {
            InitializeComponent();
            ToggleControls(false);
            games = new List<Game>();
            systems = new List<string>();
            years = new List<int>();
            regions = new List<string>();

            if (!File.Exists("database.json"))
            {
                MessageBox.Show("Could not find database.json, closing application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            try
            {
                var json = File.ReadAllText("database.json");
                var foo = JObject.Parse(json);

                var defaultNode = foo["_default"];
                var firstGameNode = defaultNode.First;
                foreach (var node in defaultNode.Children())
                {
                    var game = Game.FromJToken(node);
                    games.Add(game);
                    if (!systems.Contains(game.Console, StringComparer.OrdinalIgnoreCase))
                    {
                        systems.Add(game.Console);
                    }
                    if (!regions.Contains(game.Region, StringComparer.OrdinalIgnoreCase))
                    {
                        regions.Add(game.Region);
                    }
                    if (!years.Contains(game.Year))
                    {
                        years.Add(game.Year);
                    }
                }
                PopulateFilterComboboxes();
                ToggleControls(true);
            }
            catch (Exception e)
            {
                MessageBox.Show("The following error occurred: " + e.Message);
                throw;
            }
            
        }

        private void ToggleControls(bool toggle)
        {
            _comboBoxConsoleFilter.Enabled = toggle;
            _comboBoxRegion.Enabled = toggle;
            //_comboBoxYearFilter.Enabled = toggle;
            _buttonPick.Enabled = toggle;
        }

        private void ClearTextBoxes()
        {
            _textBoxConsole.Clear();
            _textBoxGame.Clear();
            _textBoxYear.Clear();
            _textBoxDescription.Clear();
            _textBoxRegion.Clear();
        }

        private void PopulateFilterComboboxes()
        {
            _comboBoxConsoleFilter.Items.Clear();
            _comboBoxConsoleFilter.Items.Add("");
            systems.Sort();
            _comboBoxConsoleFilter.Items.AddRange(systems.ToArray());

            _comboBoxRegion.Items.Clear();
            _comboBoxRegion.Items.Add("");
            regions.Sort();
            _comboBoxRegion.Items.AddRange(regions.ToArray());

            _comboBoxYearFilter.Items.Clear();
            _comboBoxYearFilter.Items.Add("");
            years.Sort();
            foreach (var year in years)
            {
                _comboBoxYearFilter.Items.Add(year);
            }
        }

        private void PopulateTextBoxes(Game game)
        {
            _textBoxGame.Text = game.Title;
            _textBoxConsole.Text = game.Console;
            _textBoxYear.Text = game.Year.ToString();
            _textBoxDescription.Text = game.Description;
            _textBoxRegion.Text = game.Region;
        }

        private void PickRandomGame()
        {
            var random = new Random();
            List<Game> filteredGames = games;
            String consoleFilter;
            int yearFilter;
            String regionFilter;

            if (!String.IsNullOrWhiteSpace(_comboBoxConsoleFilter.Text))
            {
                consoleFilter = _comboBoxConsoleFilter.Text;

                filteredGames = filteredGames.Where(x => String.Equals(x.Console, consoleFilter)).ToList();
            }

            if (!String.IsNullOrWhiteSpace(_comboBoxYearFilter.Text))
            {
                Int32.TryParse(_comboBoxYearFilter.Text, out yearFilter);

                filteredGames = filteredGames.Where(x => x.Year == yearFilter).ToList();
            }

            if (!String.IsNullOrWhiteSpace(_comboBoxRegion.Text))
            {
                regionFilter = _comboBoxRegion.Text;

                filteredGames = filteredGames.Where(x => String.Equals(x.Region, regionFilter)).ToList();
            }

            if (filteredGames.Count != 0)
            {
                int index = random.Next(filteredGames.Count);
                var randomGame = filteredGames[index];

                ClearTextBoxes();
                PopulateTextBoxes(randomGame);
            } else
            {
                MessageBox.Show("No game found with specified parameters");
            }

            
        }

        private void onButtonClick(object sender, EventArgs e)
        {
            if (sender.Equals(_buttonPick))
            {
                PickRandomGame();
            }
        }
    }
}
