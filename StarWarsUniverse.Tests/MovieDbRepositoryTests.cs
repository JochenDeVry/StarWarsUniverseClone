using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using StarWarsUniverse.Data.Repositories.Db;

namespace StarWarsUniverse.Tests
{
    [TestFixture]
    public class MovieDbRepositoryTests : StarWarsDbTestBase
    {
        [Test]
        public void GetAllMoviesShouldReturnEveryMovie()
        {
            var repo = new MovieDbRepository(Context);

            var returnedMovies = repo.GetAllMovies();

            Assert.AreEqual(6, returnedMovies.Count);
        }
    }
}
