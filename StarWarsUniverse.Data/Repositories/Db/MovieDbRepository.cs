using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using StarWarsUniverse.Domain;

namespace StarWarsUniverse.Data.Repositories.Db
{
    public class MovieDbRepository : IMovieRepository
    {
        private readonly StarWarsContext _starWarsContext;
        public MovieDbRepository(StarWarsContext starWarsContext)
        {
            this._starWarsContext = starWarsContext;
        }
        public IList<Movie> GetAllMovies()
        {
            return _starWarsContext.Movies.OrderBy(m => m.EpisodeId).ToList();
        }
    }
}
