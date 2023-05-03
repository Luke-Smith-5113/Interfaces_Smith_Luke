using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Smith_Luke
{
    //creates a Game class that uses the IGenre interface
    class Game : IGenre
    {
        //implements the strings from IGenre
        public string Genre { get; set; }
        public string ESRB { get; set; }
        public string Title { get; set; }
        //makes the constructor for Game and sets the three strings from earlier
        public Game(string genre, string esrb, string title)
        {
            Genre = genre;
            ESRB = esrb;
            Title = title;
        }
        //defines the Describe string method from the interface
        public string Describe()
        {
            return $"This is a {Genre} game called {Title} with a rating of {ESRB}";
        }
        //creates the PlayMovie function
        public void PlayGame()
        {
            Console.WriteLine("Game is Starting");
        }
    }
}
