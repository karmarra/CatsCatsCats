namespace Cats.ApiClient
{
    internal static class Config
    {
        public const string API_URL = "https://api.thecatapi.com/v1";
        public const string API_KEY = "0b6113cc-55a7-463c-933e-a47913ca2c31";
        public static class Headers
        {
            public const string API_KEY_HEADER = "x-api-key";
            public const string PAGINATION_COUNT_HEADER = "pagination-count";
        }
        public static class Requests
        {
            public const string BREEDS_REQ = "breeds";
            public const string IMAGES_SEARCH_REQ = "images/search";
        }
    }
}
