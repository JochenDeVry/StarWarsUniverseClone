using NUnit.Framework;
using StarWarsUniverse.Data.Repositories.Api;

namespace StarWarsUniverse.Tests
{
    [TestFixture]
    public class MovieApiRepositoryTests
    {
        private MovieApiRepository _repo;

        [SetUp]
        public void Setup()
        {
            _repo = new MovieApiRepository();
        }

        [Test]
        public void GetAllMovies()
        {
            var result = _repo.GetAllMovies();
            Assert.AreEqual(6, result.Count);
        }
    }
}
