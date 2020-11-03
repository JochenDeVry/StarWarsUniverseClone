using System;
using System.Runtime.CompilerServices;
using StarWarsUniverse.Data;
using StarWarsUniverse.Data.Repositories.Db;

namespace StarWarsUniverseClone
{
    class Program
    {
        private static MovieDbRepository _movieDbRepository;
        static void Main(string[] args)
        {
            Console.WriteLine("app running");
            var context = new StarWarsContext();
            _movieDbRepository = new MovieDbRepository(context);
            PrintAllMovies();

        }

        private static void PrintAllMovies()
        {
            Console.WriteLine("=== Star Wars Movies ===");
            var movies = _movieDbRepository.GetAllMovies();
            foreach (var movie in movies)
            {
                Console.WriteLine("Episode " + movie.EpisodeId + " - "  + movie.Title);
                Console.WriteLine("\tReleased: " + movie.ReleaseDate.ToString("dd/MM/yyyy"));
            }
            Console.WriteLine("========================");
        }


    }
}
