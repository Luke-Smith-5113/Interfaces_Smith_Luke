using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Smith_Luke
{
    //creates a Movie class that uses the IGenre interface
    class Movie : IGenre
    {
        //implements the strings from IGenre
        public string Genre { get; }
        public string ESRB { get; }
        public string Title { get; }
        //makes the constructor for Movie and sets the three strings from earlier
        public Movie(string genre, string esrb, string title)
        {
            Genre = genre;
            ESRB = esrb;
            Title = title;
        }
        //defines the Describe string method from the interface
        public string Describe()
        {
            return $"This is a {Genre} movie called {Title} with a rating of {ESRB}";
        }
        //creates the PlayMovie function
        public void PlayMovie()
        {
            Console.WriteLine("Movie is Starting. Shhhhhhh");
        }
    }
}
