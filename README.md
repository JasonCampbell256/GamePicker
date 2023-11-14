# GamePicker
An application created for the Twitch streamer [FuturemanGaming](https://www.twitch.tv/futuremangaming). Highly customized and stylized for a specific entertainment purpose. 

Picks a random video game based on console, region, and keyword selections. Games and consoles are maintained in a csv file.

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
 2. (Optional) Pick your consoles, regions, and/or type a keyword.
 3. Cick the "Encabulate" button to populate fields on the right with a randomly chosen game.

## Dependencies
 - .NET 5
 - WinForms
 - CsvHelper
