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
                        games.Add(game);
                        if (!systems.Contains(game.ConsoleRegionIdentifier))
                        {
                            systems.Add(game.ConsoleRegionIdentifier);
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
            _textBoxConsole.Text = game.ConsoleRegionIdentifier;
        }

        private void PickRandomGame()
        {
            var random = new Random();
            List<Game> filteredGames = games;

            if (_listBoxConsoleFilter.SelectedItems.Count > 0)
            {
                var selectedConsoles = new List<string>();
                foreach (var item in _listBoxConsoleFilter.SelectedItems)
                {
                    selectedConsoles.Add(item.ToString());
                }
                var searchterms = _textBoxConsole.Text.Trim();
                filteredGames = filteredGames.Where(x => selectedConsoles.Contains(x.ConsoleRegionIdentifier)).ToList();
            }

            if (!String.IsNullOrEmpty(_textBoxSearchTerms.Text))
            {
                filteredGames = filteredGames.Where(x => x.Title.Contains(_textBoxSearchTerms.Text.Trim(), StringComparison.InvariantCultureIgnoreCase)).ToList();
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
            } else if (sender.Equals(_buttonClearSelection))
            {
                _listBoxConsoleFilter.ClearSelected();
            }
        }
    }
}
