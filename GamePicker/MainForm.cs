using System;
using System.Collections.Generic;
using System.Data;
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

            if (!File.Exists("GAMES.txt"))
            {
                MessageBox.Show("Could not find GAMES.txt, closing application", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }
            try
            {
                GetGamesFromTxt();
                PopulateFilterListBox();
                ToggleControls(true);
            }
            catch (Exception e)
            {
                MessageBox.Show("The following error occurred: " + e.Message);
                throw;
            }
            
        }

        private void GetGamesFromTxt()
        {
            var txt = File.ReadLines("GAMES.txt");
            var currentSystem = "";
            foreach(var line in txt)
            {
                if (line.Length == 0)
                {
                    continue;
                }
                if (String.Equals(line[0].ToString(), "*", StringComparison.CurrentCultureIgnoreCase))
                {
                    var system = line.Remove(0, 1);
                    systems.Add(system);
                    currentSystem = system;
                } else
                {
                    var game = new Game();
                    game.Title = line;
                    game.Console = currentSystem;
                    games.Add(game);
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
            _textBoxConsole.Text = game.Console;
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

                filteredGames = filteredGames.Where(x => selectedConsoles.Contains(x.Console)).ToList();
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
