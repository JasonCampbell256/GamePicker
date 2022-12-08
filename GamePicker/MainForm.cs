using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GamePicker
{
    public partial class MainForm : Form
    {
        private List<Game> games;
        private List<string> systems;
        public MainForm()
        {
            InitializeComponent();
            this.Text = $"Random Game Picker v{System.Windows.Forms.Application.ProductVersion}";
            ToggleControls(false);
            games = new List<Game>();
            systems = new List<string>();
            _textBoxGame.Enabled = true;
            _listBoxConsoleFilter.Items.Clear();
            _checkBoxRegionUSA.Checked = true;

            if (!File.Exists("GAMES.csv"))
            {
                MessageBox.Show("Could not find GAMES.csv, closing application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            try
            {
                GetGamesFromCsv();
                PopulateFilterListBox();
                ToggleControls(true);
            }
            catch (Exception e)
            {
                MessageBox.Show("The following error occurred: " + e.Message);
                throw;
            }

        }

        private void GetGamesFromCsv()
        {
            using (var reader = new StreamReader("GAMES.csv"))
            {
                using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                {
                    var records = csv.GetRecords<CsvGame>();
                    foreach (var record in records)
                    {
                        var game = new Game {
                            Title = record.Game,
                            Console = record.Console,
                            ConsoleRegionIdentifier = $"{record.Console} - {record.Region}"
                        };
                        if (String.Equals(record.Region.Trim(), "usa", StringComparison.InvariantCultureIgnoreCase)
                            || String.Equals(record.Region.Trim(), "us", StringComparison.InvariantCultureIgnoreCase))
                        {
                            game.Region = GamePicker.Region.USA;
                        } else if (String.Equals(record.Region.Trim(), "europe", StringComparison.InvariantCultureIgnoreCase)
                            || String.Equals(record.Region.Trim(), "eu", StringComparison.InvariantCultureIgnoreCase))
                        {
                            game.Region = GamePicker.Region.EUROPE;
                        } else if (String.Equals(record.Region.Trim(), "japan", StringComparison.InvariantCultureIgnoreCase)
                            || String.Equals(record.Region.Trim(), "jp", StringComparison.InvariantCultureIgnoreCase))
                        {
                            game.Region = GamePicker.Region.JAPAN;
                        }
                        games.Add(game);
                        if (!systems.Contains(game.Console))
                        {
                            systems.Add(game.Console);
                        }
                    }
                }
            }

        }

        private void ToggleControls(bool toggle)
        {
            _listBoxConsoleFilter.Enabled = toggle;
            _buttonPick.Enabled = toggle;
        }

        private void ClearTextBoxes()
        {
            _textBoxConsole.Clear();
            _textBoxGame.Clear();
            _textBoxRegion.Clear();
        }

        private void PopulateFilterListBox()
        {
            _listBoxConsoleFilter.Items.Clear();
            systems.Sort();
            _listBoxConsoleFilter.Items.AddRange(systems.ToArray());
        }

        private void PopulateTextBoxes(Game game)
        {
            _textBoxGame.Text = game.Title;
            _textBoxConsole.Text = game.Console;
            _textBoxRegion.Text = game.Region.ToString();
        }

        private void PickRandomGame()
        {
            var random = new Random();
            List<Game> filteredGames = games;

            if (!_checkBoxRegionUSA.Checked && !_checkBoxRegionEurope.Checked && !_checkBoxRegionJapan.Checked)
            {
                MessageBox.Show("You need to check a region", "Idiot.", MessageBoxButtons.OK);
                return;
            }

            var regions = new List<Region>();

            if (_checkBoxRegionUSA.Checked)
            {
                regions.Add(GamePicker.Region.USA);
            }

            if (_checkBoxRegionEurope.Checked)
            {
                regions.Add(GamePicker.Region.EUROPE);
            }

            if (_checkBoxRegionJapan.Checked)
            {
                regions.Add(GamePicker.Region.JAPAN);
            }

            var selectedConsoles = new List<string>();

            foreach (var item in _listBoxConsoleFilter.SelectedItems)
            {
                selectedConsoles.Add(item.ToString());
            }

            var searchTerms = _textBoxSearchTerms.Text.Trim();

            filteredGames = filteredGames.Where(x =>
                regions.Contains(x.Region) &&
                (selectedConsoles.Count == 0 || selectedConsoles.Contains(x.Console)) &&
                x.Title.Contains(searchTerms, StringComparison.InvariantCultureIgnoreCase)
            ).ToList();

            if (filteredGames.Count != 0)
            {
                int index = random.Next(filteredGames.Count);
                var randomGame = filteredGames[index];

                ClearTextBoxes();
                PopulateTextBoxes(randomGame);
            }
            else
            {
                MessageBox.Show("No game found with specified parameters. Re-encabulate and try again!");
            }
        }



        private void onButtonClick(object sender, EventArgs e)
        {
            if (sender.Equals(_buttonPick))
            {
                PickRandomGame();
                
            } else if (sender.Equals(_buttonResetFilters))
            {
                _listBoxConsoleFilter.ClearSelected();
            }
        }

        private void _checkBoxRegionEurope_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
