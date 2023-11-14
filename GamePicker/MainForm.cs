using CsvHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GamePicker
{
    public partial class MainForm : Form
    {
        private readonly List<Game> games;
        private readonly List<string> systems;

        public MainForm()
        {
            InitializeComponent();
            _buttonPick.BackColor = Color.Black;
            _buttonResetFilters.BackColor = Color.Black;
            this.Text = $"Random Game Picker v{Application.ProductVersion}";
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
                GetGamesAndSystemsFromCsv();
                PopulateConsoleFilterListBox();
                ToggleControls(true);
            }
            catch (Exception e)
            {
                MessageBox.Show("The following error occurred: " + e.Message);
                throw;
            }

        }

        /// <summary>
        /// Populates the games and systems lists from the GAMES.csv file
        /// </summary>
        private void GetGamesAndSystemsFromCsv()
        {
            using var reader = new StreamReader("GAMES.csv");
            using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
            var records = csv.GetRecords<CsvGame>();
            foreach (var record in records)
            {
                var game = new Game
                {
                    Title = record.Game,
                    Console = record.Console,
                    ConsoleRegionIdentifier = $"{record.Console} - {record.Region}"
                };

                if (string.Equals(record.Region.Trim(), "usa", StringComparison.InvariantCultureIgnoreCase)
                    || string.Equals(record.Region.Trim(), "us", StringComparison.InvariantCultureIgnoreCase))
                {
                    game.Region = GamePicker.Region.USA;
                }
                else if (string.Equals(record.Region.Trim(), "europe", StringComparison.InvariantCultureIgnoreCase)
                    || string.Equals(record.Region.Trim(), "eu", StringComparison.InvariantCultureIgnoreCase))
                {
                    game.Region = GamePicker.Region.EUROPE;
                }
                else if (string.Equals(record.Region.Trim(), "japan", StringComparison.InvariantCultureIgnoreCase)
                    || string.Equals(record.Region.Trim(), "jp", StringComparison.InvariantCultureIgnoreCase))
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

        /// <summary>
        /// Toggles the enabled state of the controls
        /// </summary>
        /// <param name="toggle">The desired enabled state</param>
        private void ToggleControls(bool toggle)
        {
            _listBoxConsoleFilter.Enabled = toggle;
            _buttonPick.Enabled = toggle;
        }

        /// <summary>
        /// Clears the text boxes
        /// </summary>
        private void ClearTextBoxes()
        {
            _textBoxConsole.Clear();
            _textBoxGame.Clear();
            _textBoxRegion.Clear();
            _textBoxSearchTerms.Clear();
        }

        /// <summary>
        /// Populates the console filter list box
        /// </summary>
        private void PopulateConsoleFilterListBox()
        {
            _listBoxConsoleFilter.Items.Clear();
            systems.Sort();
            _listBoxConsoleFilter.Items.AddRange(systems.ToArray());
        }

        /// <summary>
        /// Populates the text boxes with the game information
        /// </summary>
        /// <param name="game">The Game object</param>
        private void PopulateTextBoxes(Game game)
        {
            _textBoxGame.Text = game.Title;
            _textBoxConsole.Text = game.Console;
            _textBoxRegion.Text = game.Region.ToString();
        }

        /// <summary>
        /// Pick a random game from the games list that meets the specified criteria
        /// </summary>
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

        /// <summary>
        /// Handles the button click events
        /// </summary>
        /// <param name="sender">The button object</param>
        /// <param name="e">Event args</param>
        private void OnButtonClick(object sender, EventArgs e)
        {
            if (sender.Equals(_buttonPick))
            {
                PickRandomGame();

            }
            else if (sender.Equals(_buttonResetFilters))
            {
                _listBoxConsoleFilter.ClearSelected();
            }
        }

        /// <summary>
        /// Handles hotkeys
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="keyData"></param>
        /// <returns></returns>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.E))
            {
                PickRandomGame();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
