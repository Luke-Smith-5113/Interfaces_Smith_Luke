using System;

namespace Interfaces_Smith_Luke
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates a new object of the Game class named game
            Game game = new Game("adventure", "E", "Legend of Zelda: Breath of the Wild");
            //activates the movie function PlayGame
            game.PlayGame();
            //rights the return for game.Describe
            Console.WriteLine(game.Describe());
            //creates a new object of the Movie class named movie
            Movie movie = new Movie("comedy", "E", "Megamind");
            //activates the movie function PlayMovie
            movie.PlayMovie();
            //rights the return for movie.Describe
            Console.WriteLine(movie.Describe());
        }
    }
}
