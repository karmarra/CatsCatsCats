using Cats.ApiClient.Model.Breed;
using RestSharp;

namespace Cats.ApiClient.Repository
{
    public class CatApiRepository : ICatApiRepository
    {
        private RestClient _client;

        public CatApiRepository()
        {
            _client = new RestClient(Config.API_URL);
        }

        public async Task<RestResponse<List<Breed>>> GetBreedsAsync(int attachBreed, int page, int limit)
        {
            var request = CreateRequestWithApiKey(Config.Requests.BREEDS_REQ, Method.Get);
            request.AddParameter("attach_breed", attachBreed);
            request.AddParameter("page", page);
            request.AddParameter("limit", limit);
            
            var queryResult = await _client.ExecuteAsync<List<Breed>>(request);
            return queryResult;
        }

        public async Task<RestResponse<List<Image>>> GetImagesAsync(int categoryId, int limit, int page)
        {
            var request = CreateRequestWithApiKey(Config.Requests.IMAGES_SEARCH_REQ, Method.Get);
            request.AddParameter("category_ids", categoryId);
            request.AddParameter("page", page);
            request.AddParameter("limit", limit);
            request.AddParameter("order", "Desc");
            var queryResult = await _client.ExecuteAsync<List<Image>>(request);

            return queryResult;
        }
        private RestRequest CreateRequestWithApiKey(string resource, Method method)
        {
            var request = new RestRequest(resource, method);
            request.AddHeader(Config.Headers.API_KEY_HEADER, Config.API_KEY);
            return request;
        }
    }
}
