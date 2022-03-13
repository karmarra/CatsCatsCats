using Cats.ApiClient.Model.Breed;
using Cats.ApiClient.Repository;
using NUnit.Framework;
using RestSharp;
using System.Collections.Generic;

namespace Cats.Tests
{
    public class ApiTests
    {
        private CatApiRepository _rep;
        [SetUp]
        public void Setup()
        {
            _rep = new CatApiRepository();
        }

        [Test]
        public void BreedsTest()

        {
            var res = new RestResponse<List<Breed>>();
            Assert.DoesNotThrowAsync(async () =>
            {
                res = await _rep.GetBreedsAsync(0, 1, 1);

            });
            Assert.IsTrue(res.IsSuccessful);
        }
    }
}