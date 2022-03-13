using Cats.ApiClient.Model.Breed;
using RestSharp;

namespace Cats.ApiClient.Repository
{
    public interface ICatApiRepository
    {
        Task<RestResponse<List<Breed>>> GetBreedsAsync(int attachBreed, int page, int limit);
        Task<RestResponse<List<Image>>> GetImagesAsync(int categoryId, int limit, int page);
    }
}
