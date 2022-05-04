# GamePicker
 Pick a random game based on console selection. Games and consoles are easily managed in a text file.

## Requirements
 1. A CSV file called GAMES.csv in the root application directory.

 Example CSV file:
 ```
 Console,Region,Game,
 PS1,USA,3D Lemmings
 PS1,USA,3Xtreme
 PS1,USA,007 - The World Is Not Enough
 ```

## Usage
 1. Run `GamePicker.exe`
 2. (Optional) Pick your consoles.
 3. Cick the "Pick Randon Game" button to populate fields on the right with a randomly chosen game.

## Dependencies
 - .NET 5
 - WinForms
 - CsvHelper