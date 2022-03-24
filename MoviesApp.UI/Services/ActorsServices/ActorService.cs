using System.Net.Http.Json;

namespace MoviesApp.UI.Services
{
    public class ActorService: IActorService
    {
        public List<Actor> actors { get; set; } = new List<Actor>();

        private readonly HttpClient _httpClient;
        private readonly MovieApiClient moviesApiClient;

        public ActorService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            moviesApiClient = new MovieApiClient("https://localhost:7039/", _httpClient);
        }

        public async Task GetActors()
        {
            var apiResponse = await moviesApiClient.GetAllAsync();
            if (apiResponse != null)
                actors = apiResponse.ToList();
        }
    }
}
